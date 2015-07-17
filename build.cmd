@echo off
IF NOT EXIST "packages\FAKE\tools\FakeLib.dll" (
  "tools\NuGet.exe" "Install" "FAKE" "-OutputDirectory" "packages" "-ExcludeVersion"
)
IF NOT EXIST "packages\xunit.runner.console\tools\xunit.console.exe" (
  "tools\NuGet.exe" "Install" "xunit.runner.console" "-OutputDirectory" "packages" "-ExcludeVersion"
)
IF NOT EXIST "packages\FSharp.Data\lib\net40\FSharp.Data.dll" (
  "tools\NuGet.exe" "Install" "FSharp.Data" "-OutputDirectory" "packages" "-ExcludeVersion"
)
"packages\FAKE\tools\Fake.exe" build.fsx %*
