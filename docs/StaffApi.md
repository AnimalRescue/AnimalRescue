# IO.Swagger.Api.StaffApi

All URIs are relative to *https://virtserver.swaggerhub.com/jgartee/AnimalRescue/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBuildingToLocation**](StaffApi.md#addbuildingtolocation) | **POST** /locations/{locationId}/buildings | adds a Building at the specified Location
[**AddInventory**](StaffApi.md#addinventory) | **POST** /inventory | adds an inventory item
[**AddKennel**](StaffApi.md#addkennel) | **POST** /kennels | adds a Kennel to the rescue
[**AddKennelToRoom**](StaffApi.md#addkenneltoroom) | **POST** /locations/{locationId}/buildings/{buildingId}/room/{roomId}/kennels | creates a Kennel in the specified Room
[**AddRoomToBuilding**](StaffApi.md#addroomtobuilding) | **POST** /locations/{locationId}/buildings/{buildingId}/rooms | creates a Room in the specified Building
[**CreateCat**](StaffApi.md#createcat) | **POST** /cats | creates a new Cat
[**CreateContact**](StaffApi.md#createcontact) | **POST** /contacts | creates a new Contact
[**CreateDog**](StaffApi.md#createdog) | **POST** /dogs | creates a new Dog
[**CreateDonor**](StaffApi.md#createdonor) | **POST** /donors | creates new Donor with a unique id
[**CreateFoster**](StaffApi.md#createfoster) | **POST** /fosters | creates new Foster with a unique id
[**CreateOrganization**](StaffApi.md#createorganization) | **POST** /organizations | creates a new Organization
[**CreateVolunteer**](StaffApi.md#createvolunteer) | **POST** /volunteers | creates new Volunteer with a unique id
[**DeleteBuildingAtLocationById**](StaffApi.md#deletebuildingatlocationbyid) | **DELETE** /locations/{locationId}/buildings/{buildingId} | deletes a Building from a Location by id
[**DeleteCatById**](StaffApi.md#deletecatbyid) | **DELETE** /cats/{id} | deletes a Cat by id
[**DeleteContactById**](StaffApi.md#deletecontactbyid) | **DELETE** /contacts/{id} | deletes a Contact by id
[**DeleteDogById**](StaffApi.md#deletedogbyid) | **DELETE** /dogs/{id} | deletes a Dog by id
[**DeleteDonorById**](StaffApi.md#deletedonorbyid) | **DELETE** /donors/{id} | deletes a Donor by id
[**DeleteFosterById**](StaffApi.md#deletefosterbyid) | **DELETE** /fosters/{id} | deletes a Foster by id
[**DeleteKennelById**](StaffApi.md#deletekennelbyid) | **DELETE** /kennels/{id} | deletes a Kennel by id
[**DeleteKennelFromRoomById**](StaffApi.md#deletekennelfromroombyid) | **DELETE** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId}/kennels/{kennelId} | deletes a Kennel by id
[**DeleteOrganizationById**](StaffApi.md#deleteorganizationbyid) | **DELETE** /organizations/{id} | deletes a Organization by id
[**DeleteRoomFromBuildingById**](StaffApi.md#deleteroomfrombuildingbyid) | **DELETE** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId} | deletes a Room by id
[**DeleteVolunteerById**](StaffApi.md#deletevolunteerbyid) | **DELETE** /volunteers/{id} | deletes a Volunteer by id
[**GetApiHealth**](StaffApi.md#getapihealth) | **GET** /health | reports whether the API is up and running
[**GetBuildingAtLocationById**](StaffApi.md#getbuildingatlocationbyid) | **GET** /locations/{locationId}/buildings/{buildingId} | returns a specific location for the Rescue
[**GetBuildingById**](StaffApi.md#getbuildingbyid) | **GET** /buildings/{id} | returns a specific Building for the Rescue
[**GetBuildings**](StaffApi.md#getbuildings) | **GET** /buildings | Returns a (filtered) collection of buildings affiliated withthe Rescue
[**GetBuildingsAtLocation**](StaffApi.md#getbuildingsatlocation) | **GET** /locations/{locationId}/buildings | returns all buildings at a Location
[**GetCatById**](StaffApi.md#getcatbyid) | **GET** /cats/{id} | retrieves a Cat by id
[**GetContactById**](StaffApi.md#getcontactbyid) | **GET** /contacts/{id} | retrieves a Contact by id
[**GetCountiesByState**](StaffApi.md#getcountiesbystate) | **GET** /counties | retrieves counties for the provided state
[**GetDogById**](StaffApi.md#getdogbyid) | **GET** /dogs/{id} | retrieves a Dog by id
[**GetDonorById**](StaffApi.md#getdonorbyid) | **GET** /donors/{id} | retrieves a Donor by id
[**GetDonors**](StaffApi.md#getdonors) | **GET** /donors | searches animal rescue doners
[**GetEnclosureById**](StaffApi.md#getenclosurebyid) | **GET** /enclosures/{id} | returns a specific Enclosure for the Rescue
[**GetEnclosures**](StaffApi.md#getenclosures) | **GET** /enclosures | searches all Enclosures for the Rescue
[**GetFosterById**](StaffApi.md#getfosterbyid) | **GET** /fosters/{id} | retrieves a Foster by id
[**GetKennelById**](StaffApi.md#getkennelbyid) | **GET** /kennels/{id} | returns a specific location for the Rescue
[**GetKennelFromRoomById**](StaffApi.md#getkennelfromroombyid) | **GET** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId}/kennels/{kennelId} | returns a specific location for the Rescue
[**GetKennels**](StaffApi.md#getkennels) | **GET** /kennels | searches all Kennels for the Rescue
[**GetKennelsInRoom**](StaffApi.md#getkennelsinroom) | **GET** /locations/{locationId}/buildings/{buildingId}/room/{roomId}/kennels | returns all kennels in a Room
[**GetLocationById**](StaffApi.md#getlocationbyid) | **GET** /locations/{id} | returns a specific location for the Rescue
[**GetLocations**](StaffApi.md#getlocations) | **GET** /locations | searches all locations for the Rescue
[**GetOrganizationById**](StaffApi.md#getorganizationbyid) | **GET** /organizations/{id} | retrieves a Organization by id
[**GetRoomInBuildingById**](StaffApi.md#getroominbuildingbyid) | **GET** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId} | returns a specific location for the Rescue
[**GetRoomsInBuilding**](StaffApi.md#getroomsinbuilding) | **GET** /locations/{locationId}/buildings/{buildingId}/rooms | gets all Rooms in a Building at a Location
[**GetVolunteerById**](StaffApi.md#getvolunteerbyid) | **GET** /volunteers/{id} | retrieves a Volunteer by id
[**IntakeInformation**](StaffApi.md#intakeinformation) | **GET** /intakes | support for animal intake process
[**PatchBuildingAtLocationById**](StaffApi.md#patchbuildingatlocationbyid) | **PATCH** /locations/{locationId}/buildings/{buildingId} | updates a Location by id
[**PatchBuildingById**](StaffApi.md#patchbuildingbyid) | **PATCH** /buildings/{id} | updates a Building by id
[**PatchCatById**](StaffApi.md#patchcatbyid) | **PATCH** /cats/{id} | updates a Cat by id
[**PatchContactById**](StaffApi.md#patchcontactbyid) | **PATCH** /contacts/{id} | updates a Contact by id
[**PatchDogById**](StaffApi.md#patchdogbyid) | **PATCH** /dogs/{id} | updates a Dog by id
[**PatchDonorById**](StaffApi.md#patchdonorbyid) | **PATCH** /donors/{id} | updates a Donor by id
[**PatchFosterById**](StaffApi.md#patchfosterbyid) | **PATCH** /fosters/{id} | updates a Foster by id
[**PatchKennelById**](StaffApi.md#patchkennelbyid) | **PATCH** /kennels/{id} | updates a Kennel by id
[**PatchKennelInRoomById**](StaffApi.md#patchkennelinroombyid) | **PATCH** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId}/kennels/{kennelId} | updates a Kennel by id
[**PatchLocationById**](StaffApi.md#patchlocationbyid) | **PATCH** /locations/{id} | updates a Location by id
[**PatchOrganizationById**](StaffApi.md#patchorganizationbyid) | **PATCH** /organizations/{id} | updates a Organization by id
[**PatchRoomInBuildingById**](StaffApi.md#patchroominbuildingbyid) | **PATCH** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId} | updates a Room by id
[**PatchVolunteerById**](StaffApi.md#patchvolunteerbyid) | **PATCH** /volunteers/{id} | updates a Volunteer by id
[**SearchAdoptions**](StaffApi.md#searchadoptions) | **GET** /adoptions | searches all Adoptions at the Rescue
[**SearchCats**](StaffApi.md#searchcats) | **GET** /cats | searches cats
[**SearchContact**](StaffApi.md#searchcontact) | **GET** /contacts | searches Contact
[**SearchDog**](StaffApi.md#searchdog) | **GET** /dogs | searches dogs
[**SearchFosters**](StaffApi.md#searchfosters) | **GET** /fosters | searches animal fosters
[**SearchInventory**](StaffApi.md#searchinventory) | **GET** /inventory | searches inventory
[**SearchOrganization**](StaffApi.md#searchorganization) | **GET** /organizations | searches Organization
[**SearchVolunteers**](StaffApi.md#searchvolunteers) | **GET** /volunteers | searches volunteers
[**UpdateCatById**](StaffApi.md#updatecatbyid) | **PUT** /cats/{id} | updates a Cat by id
[**UpdateDogById**](StaffApi.md#updatedogbyid) | **PUT** /dogs/{id} | updates a Dog by id
[**UpdateDonorById**](StaffApi.md#updatedonorbyid) | **PUT** /donors/{id} | updates a Donor by id
[**UpdateFosterById**](StaffApi.md#updatefosterbyid) | **PUT** /fosters/{id} | updates a Foster by id
[**UpdateKennelById**](StaffApi.md#updatekennelbyid) | **PUT** /kennels/{id} | updates a Kennel by id
[**UpdateKennelInRoomById**](StaffApi.md#updatekennelinroombyid) | **PUT** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId}/kennels/{kennelId} | updates a Kennel by id
[**UpdateLocationById**](StaffApi.md#updatelocationbyid) | **PUT** /locations/{id} | updates a Location by id
[**UpdateOrganizationById**](StaffApi.md#updateorganizationbyid) | **PUT** /organizations/{id} | updates a Organization by id
[**UpdateRoomInBuildingById**](StaffApi.md#updateroominbuildingbyid) | **PUT** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId} | updates a Room by id
[**UpdateVolunteerById**](StaffApi.md#updatevolunteerbyid) | **PUT** /volunteers/{id} | updates a Volunteer by id

<a name="addbuildingtolocation"></a>
# **AddBuildingToLocation**
> void AddBuildingToLocation (Building body, Guid? locationId)

adds a Building at the specified Location

Adds a new Building to the specified Location

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddBuildingToLocationExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Building(); // Building | unique id of Building to update
            var locationId = new Guid?(); // Guid? | 

            try
            {
                // adds a Building at the specified Location
                apiInstance.AddBuildingToLocation(body, locationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.AddBuildingToLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Building**](Building.md)| unique id of Building to update | 
 **locationId** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addinventory"></a>
# **AddInventory**
> void AddInventory (InventoryItem body = null)

adds an inventory item

Adds an item to the system

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddInventoryExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new InventoryItem(); // InventoryItem | Inventory item to add (optional) 

            try
            {
                // adds an inventory item
                apiInstance.AddInventory(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.AddInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InventoryItem**](InventoryItem.md)| Inventory item to add | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addkennel"></a>
# **AddKennel**
> void AddKennel (Kennel body)

adds a Kennel to the rescue

Adds a new Kennel to the Rescue

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddKennelExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Kennel(); // Kennel | Kennel to add to the Rescue

            try
            {
                // adds a Kennel to the rescue
                apiInstance.AddKennel(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.AddKennel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Kennel**](Kennel.md)| Kennel to add to the Rescue | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addkenneltoroom"></a>
# **AddKennelToRoom**
> void AddKennelToRoom (Kennel body, Guid? locationId, Guid? buildingId, Guid? roomId)

creates a Kennel in the specified Room

Adds a new Kennel to the specified Room

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddKennelToRoomExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Kennel(); // Kennel | Room to create
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 
            var roomId = new Guid?(); // Guid? | 

            try
            {
                // creates a Kennel in the specified Room
                apiInstance.AddKennelToRoom(body, locationId, buildingId, roomId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.AddKennelToRoom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Kennel**](Kennel.md)| Room to create | 
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 
 **roomId** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="addroomtobuilding"></a>
# **AddRoomToBuilding**
> void AddRoomToBuilding (Room body, Guid? locationId, Guid? buildingId)

creates a Room in the specified Building

Adds a new Room to the specified Location

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddRoomToBuildingExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Room(); // Room | Room to create
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 

            try
            {
                // creates a Room in the specified Building
                apiInstance.AddRoomToBuilding(body, locationId, buildingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.AddRoomToBuilding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Room**](Room.md)| Room to create | 
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createcat"></a>
# **CreateCat**
> void CreateCat (Cat body = null)

creates a new Cat

adds a Cat with a unique id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateCatExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Cat(); // Cat | full Cat object with new id (optional) 

            try
            {
                // creates a new Cat
                apiInstance.CreateCat(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.CreateCat: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Cat**](Cat.md)| full Cat object with new id | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createcontact"></a>
# **CreateContact**
> void CreateContact (Contact body = null)

creates a new Contact

adds a Contact with a unique id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateContactExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Contact(); // Contact | full Contact object with new id (optional) 

            try
            {
                // creates a new Contact
                apiInstance.CreateContact(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.CreateContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Contact**](Contact.md)| full Contact object with new id | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createdog"></a>
# **CreateDog**
> void CreateDog (Dog body = null)

creates a new Dog

adds a Dog with a unique id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateDogExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Dog(); // Dog | full Dog object with new id (optional) 

            try
            {
                // creates a new Dog
                apiInstance.CreateDog(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.CreateDog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dog**](Dog.md)| full Dog object with new id | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createdonor"></a>
# **CreateDonor**
> void CreateDonor (Donor body)

creates new Donor with a unique id

creates a new, unique Donor

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateDonorExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Donor(); // Donor | new Donor object

            try
            {
                // creates new Donor with a unique id
                apiInstance.CreateDonor(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.CreateDonor: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Donor**](Donor.md)| new Donor object | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createfoster"></a>
# **CreateFoster**
> void CreateFoster (Foster body)

creates new Foster with a unique id

creates a new, unique Foster

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateFosterExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Foster(); // Foster | new Foster object

            try
            {
                // creates new Foster with a unique id
                apiInstance.CreateFoster(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.CreateFoster: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Foster**](Foster.md)| new Foster object | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createorganization"></a>
# **CreateOrganization**
> void CreateOrganization (Organization body = null)

creates a new Organization

adds a Organization with a unique id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateOrganizationExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Organization(); // Organization | full Organization object with new id (optional) 

            try
            {
                // creates a new Organization
                apiInstance.CreateOrganization(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.CreateOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Organization**](Organization.md)| full Organization object with new id | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createvolunteer"></a>
# **CreateVolunteer**
> void CreateVolunteer (Volunteer body)

creates new Volunteer with a unique id

creates a new, unique Volunteer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreateVolunteerExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Volunteer(); // Volunteer | new Volunteer object

            try
            {
                // creates new Volunteer with a unique id
                apiInstance.CreateVolunteer(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.CreateVolunteer: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Volunteer**](Volunteer.md)| new Volunteer object | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletebuildingatlocationbyid"></a>
# **DeleteBuildingAtLocationById**
> void DeleteBuildingAtLocationById (Guid? locationId, Guid? buildingId)

deletes a Building from a Location by id

Deletes an existing Building at a Location by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteBuildingAtLocationByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 

            try
            {
                // deletes a Building from a Location by id
                apiInstance.DeleteBuildingAtLocationById(locationId, buildingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.DeleteBuildingAtLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecatbyid"></a>
# **DeleteCatById**
> void DeleteCatById (Guid? id)

deletes a Cat by id

Deletes an existing Cat by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteCatByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Cat by id
                apiInstance.DeleteCatById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.DeleteCatById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecontactbyid"></a>
# **DeleteContactById**
> void DeleteContactById (Guid? id)

deletes a Contact by id

Deletes an existing Contact by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteContactByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Contact by id
                apiInstance.DeleteContactById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.DeleteContactById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletedogbyid"></a>
# **DeleteDogById**
> void DeleteDogById (Guid? id)

deletes a Dog by id

Deletes an existing Dog by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDogByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Dog by id
                apiInstance.DeleteDogById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.DeleteDogById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletedonorbyid"></a>
# **DeleteDonorById**
> void DeleteDonorById (Guid? id)

deletes a Donor by id

Deletes an existing Donor by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteDonorByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Donor by id
                apiInstance.DeleteDonorById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.DeleteDonorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletefosterbyid"></a>
# **DeleteFosterById**
> void DeleteFosterById (Guid? id)

deletes a Foster by id

Deletes an existing Foster by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteFosterByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Foster by id
                apiInstance.DeleteFosterById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.DeleteFosterById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletekennelbyid"></a>
# **DeleteKennelById**
> void DeleteKennelById (Guid? id)

deletes a Kennel by id

Deletes an existing Kennel by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteKennelByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Kennel by id
                apiInstance.DeleteKennelById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.DeleteKennelById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletekennelfromroombyid"></a>
# **DeleteKennelFromRoomById**
> void DeleteKennelFromRoomById (Guid? locationId, Guid? buildingId, Guid? roomId, Guid? kennelId)

deletes a Kennel by id

Deletes an existing Kennel from a Room by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteKennelFromRoomByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 
            var roomId = new Guid?(); // Guid? | 
            var kennelId = new Guid?(); // Guid? | 

            try
            {
                // deletes a Kennel by id
                apiInstance.DeleteKennelFromRoomById(locationId, buildingId, roomId, kennelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.DeleteKennelFromRoomById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 
 **roomId** | [**Guid?**](Guid?.md)|  | 
 **kennelId** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteorganizationbyid"></a>
# **DeleteOrganizationById**
> void DeleteOrganizationById (Guid? id)

deletes a Organization by id

Deletes an existing Organization by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteOrganizationByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Organization by id
                apiInstance.DeleteOrganizationById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.DeleteOrganizationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteroomfrombuildingbyid"></a>
# **DeleteRoomFromBuildingById**
> void DeleteRoomFromBuildingById (Guid? locationId, Guid? buildingId, Guid? roomId)

deletes a Room by id

Deletes an existing Building at a Room by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteRoomFromBuildingByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 
            var roomId = new Guid?(); // Guid? | 

            try
            {
                // deletes a Room by id
                apiInstance.DeleteRoomFromBuildingById(locationId, buildingId, roomId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.DeleteRoomFromBuildingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 
 **roomId** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletevolunteerbyid"></a>
# **DeleteVolunteerById**
> void DeleteVolunteerById (Guid? id)

deletes a Volunteer by id

Deletes an existing Volunteer by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteVolunteerByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Volunteer by id
                apiInstance.DeleteVolunteerById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.DeleteVolunteerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getapihealth"></a>
# **GetApiHealth**
> void GetApiHealth ()

reports whether the API is up and running

used to check on the api status, but returns no content

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetApiHealthExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();

            try
            {
                // reports whether the API is up and running
                apiInstance.GetApiHealth();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetApiHealth: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbuildingatlocationbyid"></a>
# **GetBuildingAtLocationById**
> Location GetBuildingAtLocationById (Guid? locationId, Guid? buildingId, int? limit = null, int? offset = null)

returns a specific location for the Rescue

Returns details about a specific Location 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBuildingAtLocationByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // returns a specific location for the Rescue
                Location result = apiInstance.GetBuildingAtLocationById(locationId, buildingId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetBuildingAtLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**Location**](Location.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbuildingbyid"></a>
# **GetBuildingById**
> Building GetBuildingById (Guid? id, int? limit = null, int? offset = null)

returns a specific Building for the Rescue

Returns details about a specific Building 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBuildingByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // returns a specific Building for the Rescue
                Building result = apiInstance.GetBuildingById(id, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetBuildingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**Building**](Building.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbuildings"></a>
# **GetBuildings**
> List<Building> GetBuildings (int? limit = null, int? offset = null, DateTime? fromDate = null, DateTime? toDate = null)

Returns a (filtered) collection of buildings affiliated withthe Rescue

With no parameters, returns all Buildings affiliated with the Rescue 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBuildingsExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 
            var fromDate = 2013-10-20;  // DateTime? | Specifies the first date to return in a query (optional) 
            var toDate = 2013-10-20;  // DateTime? | Specifies the last date to include in a query (optional) 

            try
            {
                // Returns a (filtered) collection of buildings affiliated withthe Rescue
                List&lt;Building&gt; result = apiInstance.GetBuildings(limit, offset, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetBuildings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 
 **fromDate** | **DateTime?**| Specifies the first date to return in a query | [optional] 
 **toDate** | **DateTime?**| Specifies the last date to include in a query | [optional] 

### Return type

[**List<Building>**](Building.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbuildingsatlocation"></a>
# **GetBuildingsAtLocation**
> List<Building> GetBuildingsAtLocation (Guid? locationId, int? limit = null, int? offset = null)

returns all buildings at a Location

With no parameters, returns all Buildings at the specified Location 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetBuildingsAtLocationExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var locationId = new Guid?(); // Guid? | 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // returns all buildings at a Location
                List&lt;Building&gt; result = apiInstance.GetBuildingsAtLocation(locationId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetBuildingsAtLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**List<Building>**](Building.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcatbyid"></a>
# **GetCatById**
> Cat GetCatById (Guid? id)

retrieves a Cat by id

Gets an existing Cat by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCatByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Cat by id
                Cat result = apiInstance.GetCatById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetCatById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

[**Cat**](Cat.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcontactbyid"></a>
# **GetContactById**
> Contact GetContactById (Guid? id)

retrieves a Contact by id

Gets an existing Contact by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetContactByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Contact by id
                Contact result = apiInstance.GetContactById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetContactById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

[**Contact**](Contact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcountiesbystate"></a>
# **GetCountiesByState**
> List<string> GetCountiesByState (string state, int? limit = null, int? offset = null)

retrieves counties for the provided state

Given a state, return an alpha list of counties in that state

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetCountiesByStateExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var state = state_example;  // string | state to retrieve counties for
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // retrieves counties for the provided state
                List&lt;string&gt; result = apiInstance.GetCountiesByState(state, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetCountiesByState: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **state** | **string**| state to retrieve counties for | 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

**List<string>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdogbyid"></a>
# **GetDogById**
> Dog GetDogById (Guid? id)

retrieves a Dog by id

Gets an existing Dog by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDogByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Dog by id
                Dog result = apiInstance.GetDogById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetDogById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

[**Dog**](Dog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdonorbyid"></a>
# **GetDonorById**
> Donor GetDonorById (Guid? id)

retrieves a Donor by id

Gets an existing Donor by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDonorByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Donor by id
                Donor result = apiInstance.GetDonorById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetDonorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

[**Donor**](Donor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getdonors"></a>
# **GetDonors**
> List<Donor> GetDonors (string state, string searchString = null, int? limit = null, int? offset = null, DateTime? fromDate = null, DateTime? toDate = null)

searches animal rescue doners

With no parameters, returns all Donors. Allows filters. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDonorsExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var state = state_example;  // string | state to retrieve counties for
            var searchString = searchString_example;  // string | pass an optional search string for looking up Fosters (optional) 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 
            var fromDate = 2013-10-20;  // DateTime? | Specifies the first date to return in a query (optional) 
            var toDate = 2013-10-20;  // DateTime? | Specifies the last date to include in a query (optional) 

            try
            {
                // searches animal rescue doners
                List&lt;Donor&gt; result = apiInstance.GetDonors(state, searchString, limit, offset, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetDonors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **state** | **string**| state to retrieve counties for | 
 **searchString** | **string**| pass an optional search string for looking up Fosters | [optional] 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 
 **fromDate** | **DateTime?**| Specifies the first date to return in a query | [optional] 
 **toDate** | **DateTime?**| Specifies the last date to include in a query | [optional] 

### Return type

[**List<Donor>**](Donor.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getenclosurebyid"></a>
# **GetEnclosureById**
> Enclosure GetEnclosureById (Guid? id, int? limit = null, int? offset = null)

returns a specific Enclosure for the Rescue

Returns details about a specific Enclosure 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEnclosureByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // returns a specific Enclosure for the Rescue
                Enclosure result = apiInstance.GetEnclosureById(id, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetEnclosureById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**Enclosure**](Enclosure.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getenclosures"></a>
# **GetEnclosures**
> List<Enclosure> GetEnclosures (int? limit = null, int? offset = null)

searches all Enclosures for the Rescue

With no parameters, returns all Enclosures for the Rescue 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetEnclosuresExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // searches all Enclosures for the Rescue
                List&lt;Enclosure&gt; result = apiInstance.GetEnclosures(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetEnclosures: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**List<Enclosure>**](Enclosure.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getfosterbyid"></a>
# **GetFosterById**
> Foster GetFosterById (Guid? id)

retrieves a Foster by id

Gets an existing Foster by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetFosterByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Foster by id
                Foster result = apiInstance.GetFosterById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetFosterById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

[**Foster**](Foster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getkennelbyid"></a>
# **GetKennelById**
> Kennel GetKennelById (Guid? id, int? limit = null, int? offset = null)

returns a specific location for the Rescue

Returns details about a specific Kennel 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetKennelByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // returns a specific location for the Rescue
                Kennel result = apiInstance.GetKennelById(id, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetKennelById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**Kennel**](Kennel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getkennelfromroombyid"></a>
# **GetKennelFromRoomById**
> Kennel GetKennelFromRoomById (Guid? locationId, Guid? buildingId, Guid? roomId, Guid? kennelId, int? limit = null, int? offset = null)

returns a specific location for the Rescue

Returns details about a specific Room 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetKennelFromRoomByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 
            var roomId = new Guid?(); // Guid? | 
            var kennelId = new Guid?(); // Guid? | 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // returns a specific location for the Rescue
                Kennel result = apiInstance.GetKennelFromRoomById(locationId, buildingId, roomId, kennelId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetKennelFromRoomById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 
 **roomId** | [**Guid?**](Guid?.md)|  | 
 **kennelId** | [**Guid?**](Guid?.md)|  | 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**Kennel**](Kennel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getkennels"></a>
# **GetKennels**
> List<Kennel> GetKennels (int? limit = null, int? offset = null)

searches all Kennels for the Rescue

With no parameters, returns all Kennels for the Rescue 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetKennelsExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // searches all Kennels for the Rescue
                List&lt;Kennel&gt; result = apiInstance.GetKennels(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetKennels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**List<Kennel>**](Kennel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getkennelsinroom"></a>
# **GetKennelsInRoom**
> List<Kennel> GetKennelsInRoom (Guid? locationId, Guid? buildingId, Guid? roomId, int? limit = null, int? offset = null)

returns all kennels in a Room

With no parameters, returns all kennels in a Room

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetKennelsInRoomExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 
            var roomId = new Guid?(); // Guid? | 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // returns all kennels in a Room
                List&lt;Kennel&gt; result = apiInstance.GetKennelsInRoom(locationId, buildingId, roomId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetKennelsInRoom: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 
 **roomId** | [**Guid?**](Guid?.md)|  | 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**List<Kennel>**](Kennel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlocationbyid"></a>
# **GetLocationById**
> Location GetLocationById (Guid? id, int? limit = null, int? offset = null)

returns a specific location for the Rescue

Returns details about a specific Location 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLocationByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // returns a specific location for the Rescue
                Location result = apiInstance.GetLocationById(id, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**Location**](Location.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlocations"></a>
# **GetLocations**
> List<Location> GetLocations (int? limit = null, int? offset = null)

searches all locations for the Rescue

With no parameters, returns all Locations for the Rescue 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetLocationsExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // searches all locations for the Rescue
                List&lt;Location&gt; result = apiInstance.GetLocations(limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**List<Location>**](Location.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getorganizationbyid"></a>
# **GetOrganizationById**
> Organization GetOrganizationById (Guid? id)

retrieves a Organization by id

Gets an existing Organization by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetOrganizationByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Organization by id
                Organization result = apiInstance.GetOrganizationById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetOrganizationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

[**Organization**](Organization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getroominbuildingbyid"></a>
# **GetRoomInBuildingById**
> Room GetRoomInBuildingById (Guid? locationId, Guid? buildingId, Guid? roomId, int? limit = null, int? offset = null)

returns a specific location for the Rescue

Returns details about a specific Room 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRoomInBuildingByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 
            var roomId = new Guid?(); // Guid? | 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // returns a specific location for the Rescue
                Room result = apiInstance.GetRoomInBuildingById(locationId, buildingId, roomId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetRoomInBuildingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 
 **roomId** | [**Guid?**](Guid?.md)|  | 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**Room**](Room.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getroomsinbuilding"></a>
# **GetRoomsInBuilding**
> List<Room> GetRoomsInBuilding (Guid? locationId, Guid? buildingId, int? limit = null, int? offset = null)

gets all Rooms in a Building at a Location

With no parameters, returns all Rooms in a Building

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetRoomsInBuildingExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 

            try
            {
                // gets all Rooms in a Building at a Location
                List&lt;Room&gt; result = apiInstance.GetRoomsInBuilding(locationId, buildingId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetRoomsInBuilding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 

### Return type

[**List<Room>**](Room.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getvolunteerbyid"></a>
# **GetVolunteerById**
> Volunteer GetVolunteerById (Guid? id)

retrieves a Volunteer by id

Gets an existing Volunteer by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetVolunteerByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Volunteer by id
                Volunteer result = apiInstance.GetVolunteerById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.GetVolunteerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

[**Volunteer**](Volunteer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="intakeinformation"></a>
# **IntakeInformation**
> List<Intake> IntakeInformation (int? limit = null, int? offset = null, DateTime? fromDate = null, DateTime? toDate = null)

support for animal intake process

Base endopoints returns and empty Intake array

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IntakeInformationExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 
            var fromDate = 2013-10-20;  // DateTime? | Specifies the first date to return in a query (optional) 
            var toDate = 2013-10-20;  // DateTime? | Specifies the last date to include in a query (optional) 

            try
            {
                // support for animal intake process
                List&lt;Intake&gt; result = apiInstance.IntakeInformation(limit, offset, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.IntakeInformation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 
 **fromDate** | **DateTime?**| Specifies the first date to return in a query | [optional] 
 **toDate** | **DateTime?**| Specifies the last date to include in a query | [optional] 

### Return type

[**List<Intake>**](Intake.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchbuildingatlocationbyid"></a>
# **PatchBuildingAtLocationById**
> void PatchBuildingAtLocationById (Building body, Guid? locationId, Guid? buildingId)

updates a Location by id

Updates an existing Location by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchBuildingAtLocationByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Building(); // Building | partial json object of Location with fields to patch
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 

            try
            {
                // updates a Location by id
                apiInstance.PatchBuildingAtLocationById(body, locationId, buildingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchBuildingAtLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Building**](Building.md)| partial json object of Location with fields to patch | 
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchbuildingbyid"></a>
# **PatchBuildingById**
> void PatchBuildingById (Building body, Guid? id)

updates a Building by id

Updates an existing Building by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchBuildingByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Building(); // Building | partial json object of Building with fields to patch
            var id = new Guid?(); // Guid? | unique id of Building to patch

            try
            {
                // updates a Building by id
                apiInstance.PatchBuildingById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchBuildingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Building**](Building.md)| partial json object of Building with fields to patch | 
 **id** | [**Guid?**](Guid?.md)| unique id of Building to patch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchcatbyid"></a>
# **PatchCatById**
> void PatchCatById (Cat body, Guid? id)

updates a Cat by id

Updates an existing Cat by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchCatByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Cat(); // Cat | partial json object of Cat with fields to patch
            var id = new Guid?(); // Guid? | unique id of Cat to patch

            try
            {
                // updates a Cat by id
                apiInstance.PatchCatById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchCatById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Cat**](Cat.md)| partial json object of Cat with fields to patch | 
 **id** | [**Guid?**](Guid?.md)| unique id of Cat to patch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchcontactbyid"></a>
# **PatchContactById**
> void PatchContactById (Contact body, Guid? id)

updates a Contact by id

Updates an existing Contact by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchContactByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Contact(); // Contact | partial json object of Contact with fields to patch
            var id = new Guid?(); // Guid? | unique id of Contact to patch

            try
            {
                // updates a Contact by id
                apiInstance.PatchContactById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchContactById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Contact**](Contact.md)| partial json object of Contact with fields to patch | 
 **id** | [**Guid?**](Guid?.md)| unique id of Contact to patch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchdogbyid"></a>
# **PatchDogById**
> void PatchDogById (Dog body, Guid? id)

updates a Dog by id

Updates an existing Dog by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchDogByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Dog(); // Dog | partial json object of Dog with fields to patch
            var id = new Guid?(); // Guid? | unique id of Dog to patch

            try
            {
                // updates a Dog by id
                apiInstance.PatchDogById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchDogById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dog**](Dog.md)| partial json object of Dog with fields to patch | 
 **id** | [**Guid?**](Guid?.md)| unique id of Dog to patch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchdonorbyid"></a>
# **PatchDonorById**
> void PatchDonorById (Donor body, Guid? id)

updates a Donor by id

Updates an existing Donor by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchDonorByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Donor(); // Donor | partial json object of Donor with fields to patch
            var id = new Guid?(); // Guid? | unique id of Donor to patch

            try
            {
                // updates a Donor by id
                apiInstance.PatchDonorById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchDonorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Donor**](Donor.md)| partial json object of Donor with fields to patch | 
 **id** | [**Guid?**](Guid?.md)| unique id of Donor to patch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchfosterbyid"></a>
# **PatchFosterById**
> void PatchFosterById (Foster body, Guid? id)

updates a Foster by id

Updates an existing Foster by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchFosterByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Foster(); // Foster | partial json object of Foster with fields to patch
            var id = new Guid?(); // Guid? | unique id of Foster to patch

            try
            {
                // updates a Foster by id
                apiInstance.PatchFosterById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchFosterById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Foster**](Foster.md)| partial json object of Foster with fields to patch | 
 **id** | [**Guid?**](Guid?.md)| unique id of Foster to patch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchkennelbyid"></a>
# **PatchKennelById**
> void PatchKennelById (Kennel body, Guid? id)

updates a Kennel by id

Updates an existing Kennel by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchKennelByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Kennel(); // Kennel | partial json object of Kennel with fields to patch
            var id = new Guid?(); // Guid? | unique id of Kennel to patch

            try
            {
                // updates a Kennel by id
                apiInstance.PatchKennelById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchKennelById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Kennel**](Kennel.md)| partial json object of Kennel with fields to patch | 
 **id** | [**Guid?**](Guid?.md)| unique id of Kennel to patch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchkennelinroombyid"></a>
# **PatchKennelInRoomById**
> void PatchKennelInRoomById (Kennel body, Guid? locationId, Guid? buildingId, Guid? roomId, Guid? kennelId)

updates a Kennel by id

Updates an existing Kennel by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchKennelInRoomByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Kennel(); // Kennel | partial json object of Kennel with fields to patch
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 
            var roomId = new Guid?(); // Guid? | 
            var kennelId = new Guid?(); // Guid? | 

            try
            {
                // updates a Kennel by id
                apiInstance.PatchKennelInRoomById(body, locationId, buildingId, roomId, kennelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchKennelInRoomById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Kennel**](Kennel.md)| partial json object of Kennel with fields to patch | 
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 
 **roomId** | [**Guid?**](Guid?.md)|  | 
 **kennelId** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchlocationbyid"></a>
# **PatchLocationById**
> void PatchLocationById (Location body, Guid? id)

updates a Location by id

Updates an existing Location by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchLocationByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Location(); // Location | partial json object of Location with fields to patch
            var id = new Guid?(); // Guid? | unique id of Location to patch

            try
            {
                // updates a Location by id
                apiInstance.PatchLocationById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Location**](Location.md)| partial json object of Location with fields to patch | 
 **id** | [**Guid?**](Guid?.md)| unique id of Location to patch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchorganizationbyid"></a>
# **PatchOrganizationById**
> void PatchOrganizationById (Organization body, Guid? id)

updates a Organization by id

Updates an existing Organization by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchOrganizationByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Organization(); // Organization | partial json object of Organization with fields to patch
            var id = new Guid?(); // Guid? | unique id of Organization to patch

            try
            {
                // updates a Organization by id
                apiInstance.PatchOrganizationById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchOrganizationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Organization**](Organization.md)| partial json object of Organization with fields to patch | 
 **id** | [**Guid?**](Guid?.md)| unique id of Organization to patch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchroominbuildingbyid"></a>
# **PatchRoomInBuildingById**
> void PatchRoomInBuildingById (Room body, Guid? locationId, Guid? buildingId, Guid? roomId)

updates a Room by id

Updates an existing Room by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchRoomInBuildingByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Room(); // Room | partial json object of Room with fields to patch
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 
            var roomId = new Guid?(); // Guid? | 

            try
            {
                // updates a Room by id
                apiInstance.PatchRoomInBuildingById(body, locationId, buildingId, roomId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchRoomInBuildingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Room**](Room.md)| partial json object of Room with fields to patch | 
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 
 **roomId** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="patchvolunteerbyid"></a>
# **PatchVolunteerById**
> void PatchVolunteerById (Volunteer body, Guid? id)

updates a Volunteer by id

Updates an existing Volunteer by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchVolunteerByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Volunteer(); // Volunteer | partial json object of Volunteer with fields to patch
            var id = new Guid?(); // Guid? | unique id of Volunteer to patch

            try
            {
                // updates a Volunteer by id
                apiInstance.PatchVolunteerById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.PatchVolunteerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Volunteer**](Volunteer.md)| partial json object of Volunteer with fields to patch | 
 **id** | [**Guid?**](Guid?.md)| unique id of Volunteer to patch | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchadoptions"></a>
# **SearchAdoptions**
> List<Adoption> SearchAdoptions (int? limit = null, int? offset = null, DateTime? fromDate = null, DateTime? toDate = null)

searches all Adoptions at the Rescue

With no parameters, returns all Adoptions at the Rescue 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchAdoptionsExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 
            var fromDate = 2013-10-20;  // DateTime? | Specifies the first date to return in a query (optional) 
            var toDate = 2013-10-20;  // DateTime? | Specifies the last date to include in a query (optional) 

            try
            {
                // searches all Adoptions at the Rescue
                List&lt;Adoption&gt; result = apiInstance.SearchAdoptions(limit, offset, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.SearchAdoptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 
 **fromDate** | **DateTime?**| Specifies the first date to return in a query | [optional] 
 **toDate** | **DateTime?**| Specifies the last date to include in a query | [optional] 

### Return type

[**List<Adoption>**](Adoption.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchcats"></a>
# **SearchCats**
> List<Cat> SearchCats (int? limit = null, int? offset = null, DateTime? fromDate = null, DateTime? toDate = null, DateTime? name = null, string adoptionStatus = null, string breed = null, string color = null, string gender = null)

searches cats

With no parameters, returns all cats currently in the shelter. Allows filters. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchCatsExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 
            var fromDate = 2013-10-20;  // DateTime? | Specifies the first date to return in a query (optional) 
            var toDate = 2013-10-20;  // DateTime? | Specifies the last date to include in a query (optional) 
            var name = 2013-10-20;  // DateTime? | Specifies a matching pattern for the name (optional) 
            var adoptionStatus = adoptionStatus_example;  // string | Specifies one of the valid AdoptionStatus values (optional) 
            var breed = breed_example;  // string | breed of cat to retrieve (optional) 
            var color = color_example;  // string | Specifies one of the valid CatColors (optional) 
            var gender = gender_example;  // string | Specifies on of the valid Gender (optional) 

            try
            {
                // searches cats
                List&lt;Cat&gt; result = apiInstance.SearchCats(limit, offset, fromDate, toDate, name, adoptionStatus, breed, color, gender);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.SearchCats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 
 **fromDate** | **DateTime?**| Specifies the first date to return in a query | [optional] 
 **toDate** | **DateTime?**| Specifies the last date to include in a query | [optional] 
 **name** | **DateTime?**| Specifies a matching pattern for the name | [optional] 
 **adoptionStatus** | **string**| Specifies one of the valid AdoptionStatus values | [optional] 
 **breed** | **string**| breed of cat to retrieve | [optional] 
 **color** | **string**| Specifies one of the valid CatColors | [optional] 
 **gender** | **string**| Specifies on of the valid Gender | [optional] 

### Return type

[**List<Cat>**](Cat.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchcontact"></a>
# **SearchContact**
> List<Contact> SearchContact (int? limit = null, int? offset = null, DateTime? fromDate = null, DateTime? toDate = null, string searchString = null, Gender gender = null)

searches Contact

With no parameters, returns all contacts associated with the Rescue. Allows filters. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchContactExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 
            var fromDate = 2013-10-20;  // DateTime? | Specifies the first date to return in a query (optional) 
            var toDate = 2013-10-20;  // DateTime? | Specifies the last date to include in a query (optional) 
            var searchString = searchString_example;  // string | pass an optional search string for looking up Fosters (optional) 
            var gender = new Gender(); // Gender | One of the valid Gender enumeration values (optional) 

            try
            {
                // searches Contact
                List&lt;Contact&gt; result = apiInstance.SearchContact(limit, offset, fromDate, toDate, searchString, gender);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.SearchContact: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 
 **fromDate** | **DateTime?**| Specifies the first date to return in a query | [optional] 
 **toDate** | **DateTime?**| Specifies the last date to include in a query | [optional] 
 **searchString** | **string**| pass an optional search string for looking up Fosters | [optional] 
 **gender** | [**Gender**](Gender.md)| One of the valid Gender enumeration values | [optional] 

### Return type

[**List<Contact>**](Contact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchdog"></a>
# **SearchDog**
> List<Dog> SearchDog (int? limit = null, int? offset = null, DateTime? fromDate = null, DateTime? toDate = null, DateTime? name = null, string adoptionStatus = null, string breed = null, string color = null, string gender = null)

searches dogs

With no parameters, returns all dogss currently in the shelter. Allows filters. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchDogExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 
            var fromDate = 2013-10-20;  // DateTime? | Specifies the first date to return in a query (optional) 
            var toDate = 2013-10-20;  // DateTime? | Specifies the last date to include in a query (optional) 
            var name = 2013-10-20;  // DateTime? | Specifies a matching pattern for the name (optional) 
            var adoptionStatus = adoptionStatus_example;  // string | Specifies one of the valid AdoptionStatus values (optional) 
            var breed = breed_example;  // string | breed of dog to retrieve (optional) 
            var color = color_example;  // string | Specifies one of the valid DogColors (optional) 
            var gender = gender_example;  // string | Specifies on of the valid Gender (optional) 

            try
            {
                // searches dogs
                List&lt;Dog&gt; result = apiInstance.SearchDog(limit, offset, fromDate, toDate, name, adoptionStatus, breed, color, gender);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.SearchDog: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 
 **fromDate** | **DateTime?**| Specifies the first date to return in a query | [optional] 
 **toDate** | **DateTime?**| Specifies the last date to include in a query | [optional] 
 **name** | **DateTime?**| Specifies a matching pattern for the name | [optional] 
 **adoptionStatus** | **string**| Specifies one of the valid AdoptionStatus values | [optional] 
 **breed** | **string**| breed of dog to retrieve | [optional] 
 **color** | **string**| Specifies one of the valid DogColors | [optional] 
 **gender** | **string**| Specifies on of the valid Gender | [optional] 

### Return type

[**List<Dog>**](Dog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchfosters"></a>
# **SearchFosters**
> List<Foster> SearchFosters (string searchString = null, int? limit = null, int? offset = null, DateTime? fromDate = null, DateTime? toDate = null)

searches animal fosters

With no parameters, returns all registered Fosters. Allows filters. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchFostersExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var searchString = searchString_example;  // string | pass an optional search string for looking up Fosters (optional) 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 
            var fromDate = 2013-10-20;  // DateTime? | Specifies the first date to return in a query (optional) 
            var toDate = 2013-10-20;  // DateTime? | Specifies the last date to include in a query (optional) 

            try
            {
                // searches animal fosters
                List&lt;Foster&gt; result = apiInstance.SearchFosters(searchString, limit, offset, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.SearchFosters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchString** | **string**| pass an optional search string for looking up Fosters | [optional] 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 
 **fromDate** | **DateTime?**| Specifies the first date to return in a query | [optional] 
 **toDate** | **DateTime?**| Specifies the last date to include in a query | [optional] 

### Return type

[**List<Foster>**](Foster.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchinventory"></a>
# **SearchInventory**
> List<InventoryItem> SearchInventory (int? limit = null, int? offset = null, string searchString = null)

searches inventory

By passing in the appropriate options, you can search for available inventory in the system 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchInventoryExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 
            var searchString = searchString_example;  // string | pass an optional search string for looking up inventory (optional) 

            try
            {
                // searches inventory
                List&lt;InventoryItem&gt; result = apiInstance.SearchInventory(limit, offset, searchString);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.SearchInventory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 
 **searchString** | **string**| pass an optional search string for looking up inventory | [optional] 

### Return type

[**List<InventoryItem>**](InventoryItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchorganization"></a>
# **SearchOrganization**
> List<Organization> SearchOrganization (int? limit = null, int? offset = null, DateTime? fromDate = null, DateTime? toDate = null, DateTime? name = null, string gender = null)

searches Organization

With no parameters, returns all Organizations associated with the Rescue. Allows filters. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchOrganizationExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 
            var fromDate = 2013-10-20;  // DateTime? | Specifies the first date to return in a query (optional) 
            var toDate = 2013-10-20;  // DateTime? | Specifies the last date to include in a query (optional) 
            var name = 2013-10-20;  // DateTime? | Specifies a matching pattern for the name (optional) 
            var gender = gender_example;  // string | Specifies on of the valid Gender (optional) 

            try
            {
                // searches Organization
                List&lt;Organization&gt; result = apiInstance.SearchOrganization(limit, offset, fromDate, toDate, name, gender);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.SearchOrganization: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 
 **fromDate** | **DateTime?**| Specifies the first date to return in a query | [optional] 
 **toDate** | **DateTime?**| Specifies the last date to include in a query | [optional] 
 **name** | **DateTime?**| Specifies a matching pattern for the name | [optional] 
 **gender** | **string**| Specifies on of the valid Gender | [optional] 

### Return type

[**List<Organization>**](Organization.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchvolunteers"></a>
# **SearchVolunteers**
> List<Volunteer> SearchVolunteers (string searchString = null, int? limit = null, int? offset = null, DateTime? fromDate = null, DateTime? toDate = null)

searches volunteers

With no parameters, returns all registered Volunteers. Allows filters. 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SearchVolunteersExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var searchString = searchString_example;  // string | pass an optional search string for looking up Fosters (optional) 
            var limit = 56;  // int? | Limits the number of items on a page (optional) 
            var offset = 56;  // int? | Specifies the page number of the artists to be displayed (optional) 
            var fromDate = 2013-10-20;  // DateTime? | Specifies the first date to return in a query (optional) 
            var toDate = 2013-10-20;  // DateTime? | Specifies the last date to include in a query (optional) 

            try
            {
                // searches volunteers
                List&lt;Volunteer&gt; result = apiInstance.SearchVolunteers(searchString, limit, offset, fromDate, toDate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.SearchVolunteers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchString** | **string**| pass an optional search string for looking up Fosters | [optional] 
 **limit** | **int?**| Limits the number of items on a page | [optional] 
 **offset** | **int?**| Specifies the page number of the artists to be displayed | [optional] 
 **fromDate** | **DateTime?**| Specifies the first date to return in a query | [optional] 
 **toDate** | **DateTime?**| Specifies the last date to include in a query | [optional] 

### Return type

[**List<Volunteer>**](Volunteer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecatbyid"></a>
# **UpdateCatById**
> void UpdateCatById (Cat body, Guid? id)

updates a Cat by id

Updates an existing Cat by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCatByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Cat(); // Cat | unique id of Cat to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Cat by id
                apiInstance.UpdateCatById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.UpdateCatById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Cat**](Cat.md)| unique id of Cat to update | 
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatedogbyid"></a>
# **UpdateDogById**
> void UpdateDogById (Dog body, Guid? id)

updates a Dog by id

Updates an existing Dog by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateDogByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Dog(); // Dog | unique id of Dog to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Dog by id
                apiInstance.UpdateDogById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.UpdateDogById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dog**](Dog.md)| unique id of Dog to update | 
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatedonorbyid"></a>
# **UpdateDonorById**
> void UpdateDonorById (Donor body, Guid? id)

updates a Donor by id

Updates an existing Donor by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateDonorByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Donor(); // Donor | unique id of Donor to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Donor by id
                apiInstance.UpdateDonorById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.UpdateDonorById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Donor**](Donor.md)| unique id of Donor to update | 
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatefosterbyid"></a>
# **UpdateFosterById**
> void UpdateFosterById (Foster body, Guid? id)

updates a Foster by id

Updates an existing Foster by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateFosterByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Foster(); // Foster | unique id of Foster to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Foster by id
                apiInstance.UpdateFosterById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.UpdateFosterById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Foster**](Foster.md)| unique id of Foster to update | 
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatekennelbyid"></a>
# **UpdateKennelById**
> void UpdateKennelById (Kennel body, Guid? id)

updates a Kennel by id

Updates an existing Kennel by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateKennelByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Kennel(); // Kennel | partial json object of Kennel with fields to patch
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Kennel by id
                apiInstance.UpdateKennelById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.UpdateKennelById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Kennel**](Kennel.md)| partial json object of Kennel with fields to patch | 
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatekennelinroombyid"></a>
# **UpdateKennelInRoomById**
> void UpdateKennelInRoomById (Kennel body, Guid? locationId, Guid? buildingId, Guid? roomId, Guid? kennelId)

updates a Kennel by id

Updates an existing Kennel in a Room by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateKennelInRoomByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Kennel(); // Kennel | partial json object of Kennel with fields to patch
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 
            var roomId = new Guid?(); // Guid? | 
            var kennelId = new Guid?(); // Guid? | 

            try
            {
                // updates a Kennel by id
                apiInstance.UpdateKennelInRoomById(body, locationId, buildingId, roomId, kennelId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.UpdateKennelInRoomById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Kennel**](Kennel.md)| partial json object of Kennel with fields to patch | 
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 
 **roomId** | [**Guid?**](Guid?.md)|  | 
 **kennelId** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatelocationbyid"></a>
# **UpdateLocationById**
> void UpdateLocationById (Location body, Guid? id)

updates a Location by id

Updates an existing Location by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateLocationByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Location(); // Location | unique id of Location to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Location by id
                apiInstance.UpdateLocationById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.UpdateLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Location**](Location.md)| unique id of Location to update | 
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateorganizationbyid"></a>
# **UpdateOrganizationById**
> void UpdateOrganizationById (Organization body, Guid? id)

updates a Organization by id

Updates an existing Organization by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateOrganizationByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Organization(); // Organization | unique id of Organization to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Organization by id
                apiInstance.UpdateOrganizationById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.UpdateOrganizationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Organization**](Organization.md)| unique id of Organization to update | 
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateroominbuildingbyid"></a>
# **UpdateRoomInBuildingById**
> void UpdateRoomInBuildingById (Room body, Guid? locationId, Guid? buildingId, Guid? roomId)

updates a Room by id

Updates an existing Room by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRoomInBuildingByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Room(); // Room | unique id of Room to update
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 
            var roomId = new Guid?(); // Guid? | 

            try
            {
                // updates a Room by id
                apiInstance.UpdateRoomInBuildingById(body, locationId, buildingId, roomId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.UpdateRoomInBuildingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Room**](Room.md)| unique id of Room to update | 
 **locationId** | [**Guid?**](Guid?.md)|  | 
 **buildingId** | [**Guid?**](Guid?.md)|  | 
 **roomId** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatevolunteerbyid"></a>
# **UpdateVolunteerById**
> void UpdateVolunteerById (Volunteer body, Guid? id)

updates a Volunteer by id

Updates an existing Volunteer by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateVolunteerByIdExample
    {
        public void main()
        {
            var apiInstance = new StaffApi();
            var body = new Volunteer(); // Volunteer | unique id of Volunteer to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Volunteer by id
                apiInstance.UpdateVolunteerById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StaffApi.UpdateVolunteerById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Volunteer**](Volunteer.md)| unique id of Volunteer to update | 
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
