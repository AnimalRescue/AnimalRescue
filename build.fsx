#r "System.Data.Entity"
#r "System.Xml.Linq.dll"
#r "packages/FAKE/tools/FakeLib.dll"
#r "packages/FAKE/tools/Fake.SQL.dll"
#r "packages/FSharp.Data/lib/net40/FSharp.Data.dll"

open System.Data.EntityClient
open System.Linq
open Fake
open Fake.SQL.SqlServer
open Fake.AssemblyInfoFile
open Fake.Testing
open FSharp.Data

// Directories
let projectDir = "./src/Web/"
let buildDir  = "./build/"
let testDir   = "./test/"
let deployDir = "./deploy/"

// Database
let appDatabaseEnvar = "voatEntities"

// Filesets
let appReferences  = !! (projectDir + "*.csproj")
let unitTestReferences = !! "./UnitTests/*.csproj"
let integrationTestReferences = !! "./IntegrationTests/*.csproj"

// version info
let version = if buildServer = BuildServer.AppVeyor then AppVeyor.AppVeyorEnvironment.BuildNumber else "1.0.0.0"

// Setup AppVeyor
let private sendToAppVeyor args =
    ExecProcess (fun info -> 
                info.FileName <- "appveyor"
                info.Arguments <- args) (System.TimeSpan.MaxValue)
    |> ignore

let private add msg category =
    sprintf "AddMessage %s -Category %s" (quoteIfNeeded msg) (quoteIfNeeded category)
    |> sendToAppVeyor
let private addWithDetails msg category details =
    sprintf "AddMessage %s -Category %s -Details %s" (quoteIfNeeded msg) (quoteIfNeeded category) (quoteIfNeeded details)
    |> sendToAppVeyor
let private addNoCategory msg =
    sprintf "AddMessage %s" (quoteIfNeeded msg)
    |> sendToAppVeyor

// Add trace listener to track messages
if buildServer = BuildServer.AppVeyor then
    listeners.Add({new ITraceListener with
        member this.Write msg =
            match msg with
            | ErrorMessage x -> add x "Error"
            | ImportantMessage x -> add x "Warning"
            | LogMessage (x, _) -> add x "Information"
            | TraceMessage (x, _) -> if not enableProcessTracing then addNoCategory x
            | StartMessage | FinishedMessage
            | OpenTag (_, _) | CloseTag _ -> ()})

// Generate Web.config
let webConfigExists = fileExists (projectDir @@ "Web.config")
if not webConfigExists then
    FileUtils.cp "./config/Web.config" projectDir
    FileUtils.cp "./config/Web.config" (projectDir @@ "Web.Base.config")
    FileUtils.cp "./config/Web.Transform.config" (projectDir @@ "Web.Debug.config")
    FileUtils.cp "./config/Web.Transform.config" (projectDir @@ "Web.Azure.config")
    FileUtils.cp "./config/Web.Transform.config" (projectDir @@ "Web.Release.config")

// Restore packages
RestorePackages ()

if buildServer = BuildServer.AppVeyor then
    MSBuildLoggers <- @"""C:\Program Files\AppVeyor\BuildAgent\Appveyor.MSBuildLogger.dll""" :: MSBuildLoggers

// Targets
Target "Clean" (fun _ ->
    CleanDirs [buildDir; testDir; deployDir]
)

Target "BuildApp" (fun _ ->
    CreateCSharpAssemblyInfo (projectDir + "Properties/AssemblyInfo.cs")
        [Attribute.Title "Animal Rescue"
         Attribute.Description "Software to save critters"
         Attribute.Company "Animal Rescue Foundation"
         Attribute.Product "ACnimalRescue"
         Attribute.Copyright "Copyright © Animal Rescue Foundation 2015"
         Attribute.Trademark "Animal Rescue Foundation"
         Attribute.Guid "822D4F9F-A3AE-4257-B986-534189E6FEE7"
         Attribute.ComVisible false
         Attribute.Version version
         Attribute.FileVersion version]

    MSBuild buildDir "Build" [("BuildServer","True");("Configuration","Debug")] appReferences
        |> Log "BuildApp-Output: "
)

Target "BuildTest" (fun _ ->
    MSBuild (testDir @@ "UnitTests") "Build" [("BuildServer","True");("Configuration","Debug")] unitTestReferences
        |> Log "BuildTest-Output: "

    MSBuild (testDir @@ "IntegrationTests") "Build" [("BuildServer","True");("Configuration","Debug")] integrationTestReferences
        |> Log "BuildTest-Output: "
)

Target "UnitTest" (fun _ ->
    !! (testDir @@ "UnitTests/UnitTests.dll")
        |> xUnit (fun p ->
            {p with
                ToolPath = "packages/xunit.runner.console/tools/xunit.console.exe"})
)

Target "IntegrationTest" (fun _ ->
    !! (testDir @@ "IntegrationTests/IntegrationTests.dll")
        |> xUnit (fun p ->
            {p with
                ToolPath = "packages/xunit.runner.console/tools/xunit.console.exe"})
)

let private fromEntityConnectionString name =
    let builder = new EntityConnectionStringBuilder(name)
    builder.ProviderConnectionString

let private readWebConfigConnectionString name =
    let webConfig = readConfig (projectDir + "Web.config")
    (webConfig.SelectSingleNode ("/configuration/connectionStrings/add[@name='" + name + "']/@connectionString")).Value

let private getConnectionStrings () =
    if buildServer = BuildServer.AppVeyor then
        [(userDatabaseEnvar, environVar userDatabaseEnvar, userDatabaseMigrationScript);
        (appDatabaseEnvar, fromEntityConnectionString (environVar appDatabaseEnvar), appDatabaseMigrationScript)]
    else
        [(userDatabaseEnvar, readWebConfigConnectionString userDatabaseEnvar, userDatabaseMigrationScript);
        (appDatabaseEnvar, fromEntityConnectionString (readWebConfigConnectionString appDatabaseEnvar), appDatabaseMigrationScript)]

Target "MigrateDatabase" (fun _ ->
    let connectionStrings = getConnectionStrings ()

    for (database, connectionString, scriptPath) in connectionStrings do
        trace ("Migrating database " + database)
        runScript (getServerInfo connectionString) scriptPath
        trace ("Done migrating " + database)
)

Target "Package" (fun _ ->
    MSBuild deployDir "Build,Package" [("VisualStudioVersion","12.0");("PackageLocation",("../" @@ deployDir @@ "voat.zip"));("PackageAsSingleFile","True");("BuildServer","True");("Configuration", "Azure")] appReferences
            |> Log "Package-Output: "
)

Target "SendPackageToAppVeyor" (fun _ ->
    sendToAppVeyor (sprintf "PushArtifact %svoat.zip -Type WebDeployPackage" deployDir)
)

Target "Default" (fun _ ->
    trace "Done"
)

let deploy = hasBuildParam "Deploy"
let localBuild = buildServer = BuildServer.LocalBuild
let package = not localBuild
let appVeyorBuild = buildServer = BuildServer.AppVeyor

// Build order
"Clean"
  ==> "BuildApp"
//  ==> "BuildTest"
//  =?> ("MigrateDatabase", hasBuildParam "MigrateDatabase")
//  ==> "UnitTest"
//  ==> "IntegrationTest"
  =?> ("Package", package)
  =?> ("SendPackageToAppVeyor", appVeyorBuild && deploy)
  ==> "Default"

// start build
RunTargetOrDefault "Default"