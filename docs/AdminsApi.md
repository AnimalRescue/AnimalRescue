# IO.Swagger.Api.AdminsApi

All URIs are relative to *https://virtserver.swaggerhub.com/jgartee/AnimalRescue/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddBuilding**](AdminsApi.md#addbuilding) | **POST** /buildings | adds a Building to the rescue
[**AddBuildingToLocation**](AdminsApi.md#addbuildingtolocation) | **POST** /locations/{locationId}/buildings | adds a Building at the specified Location
[**AddEnclosure**](AdminsApi.md#addenclosure) | **POST** /enclosures | adds a Enclosure to the rescue
[**AddInventory**](AdminsApi.md#addinventory) | **POST** /inventory | adds an inventory item
[**AddKennel**](AdminsApi.md#addkennel) | **POST** /kennels | adds a Kennel to the rescue
[**AddKennelToRoom**](AdminsApi.md#addkenneltoroom) | **POST** /locations/{locationId}/buildings/{buildingId}/room/{roomId}/kennels | creates a Kennel in the specified Room
[**AddLocation**](AdminsApi.md#addlocation) | **POST** /locations | adds a Location to the rescue
[**AddRoomToBuilding**](AdminsApi.md#addroomtobuilding) | **POST** /locations/{locationId}/buildings/{buildingId}/rooms | creates a Room in the specified Building
[**CreateContact**](AdminsApi.md#createcontact) | **POST** /contacts | creates a new Contact
[**CreateFoster**](AdminsApi.md#createfoster) | **POST** /fosters | creates new Foster with a unique id
[**CreateOrganization**](AdminsApi.md#createorganization) | **POST** /organizations | creates a new Organization
[**CreateVolunteer**](AdminsApi.md#createvolunteer) | **POST** /volunteers | creates new Volunteer with a unique id
[**DeleteBuildingAtLocationById**](AdminsApi.md#deletebuildingatlocationbyid) | **DELETE** /locations/{locationId}/buildings/{buildingId} | deletes a Building from a Location by id
[**DeleteBuildingById**](AdminsApi.md#deletebuildingbyid) | **DELETE** /buildings/{id} | deletes a Building by id
[**DeleteCatById**](AdminsApi.md#deletecatbyid) | **DELETE** /cats/{id} | deletes a Cat by id
[**DeleteContactById**](AdminsApi.md#deletecontactbyid) | **DELETE** /contacts/{id} | deletes a Contact by id
[**DeleteDogById**](AdminsApi.md#deletedogbyid) | **DELETE** /dogs/{id} | deletes a Dog by id
[**DeleteDonorById**](AdminsApi.md#deletedonorbyid) | **DELETE** /donors/{id} | deletes a Donor by id
[**DeleteEnclosureById**](AdminsApi.md#deleteenclosurebyid) | **DELETE** /enclosures/{id} | deletes a Enclosure by id
[**DeleteFosterById**](AdminsApi.md#deletefosterbyid) | **DELETE** /fosters/{id} | deletes a Foster by id
[**DeleteKennelById**](AdminsApi.md#deletekennelbyid) | **DELETE** /kennels/{id} | deletes a Kennel by id
[**DeleteKennelFromRoomById**](AdminsApi.md#deletekennelfromroombyid) | **DELETE** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId}/kennels/{kennelId} | deletes a Kennel by id
[**DeleteLocationById**](AdminsApi.md#deletelocationbyid) | **DELETE** /locations/{id} | deletes a Location by id
[**DeleteOrganizationById**](AdminsApi.md#deleteorganizationbyid) | **DELETE** /organizations/{id} | deletes a Organization by id
[**DeleteRoomFromBuildingById**](AdminsApi.md#deleteroomfrombuildingbyid) | **DELETE** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId} | deletes a Room by id
[**DeleteVolunteerById**](AdminsApi.md#deletevolunteerbyid) | **DELETE** /volunteers/{id} | deletes a Volunteer by id
[**GetApiHealth**](AdminsApi.md#getapihealth) | **GET** /health | reports whether the API is up and running
[**GetBuildingAtLocationById**](AdminsApi.md#getbuildingatlocationbyid) | **GET** /locations/{locationId}/buildings/{buildingId} | returns a specific location for the Rescue
[**GetBuildingById**](AdminsApi.md#getbuildingbyid) | **GET** /buildings/{id} | returns a specific Building for the Rescue
[**GetBuildings**](AdminsApi.md#getbuildings) | **GET** /buildings | Returns a (filtered) collection of buildings affiliated withthe Rescue
[**GetBuildingsAtLocation**](AdminsApi.md#getbuildingsatlocation) | **GET** /locations/{locationId}/buildings | returns all buildings at a Location
[**GetCatById**](AdminsApi.md#getcatbyid) | **GET** /cats/{id} | retrieves a Cat by id
[**GetContactById**](AdminsApi.md#getcontactbyid) | **GET** /contacts/{id} | retrieves a Contact by id
[**GetCountiesByState**](AdminsApi.md#getcountiesbystate) | **GET** /counties | retrieves counties for the provided state
[**GetDogById**](AdminsApi.md#getdogbyid) | **GET** /dogs/{id} | retrieves a Dog by id
[**GetDonorById**](AdminsApi.md#getdonorbyid) | **GET** /donors/{id} | retrieves a Donor by id
[**GetDonors**](AdminsApi.md#getdonors) | **GET** /donors | searches animal rescue doners
[**GetEnclosureById**](AdminsApi.md#getenclosurebyid) | **GET** /enclosures/{id} | returns a specific Enclosure for the Rescue
[**GetEnclosures**](AdminsApi.md#getenclosures) | **GET** /enclosures | searches all Enclosures for the Rescue
[**GetFosterById**](AdminsApi.md#getfosterbyid) | **GET** /fosters/{id} | retrieves a Foster by id
[**GetKennelById**](AdminsApi.md#getkennelbyid) | **GET** /kennels/{id} | returns a specific location for the Rescue
[**GetKennelFromRoomById**](AdminsApi.md#getkennelfromroombyid) | **GET** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId}/kennels/{kennelId} | returns a specific location for the Rescue
[**GetKennels**](AdminsApi.md#getkennels) | **GET** /kennels | searches all Kennels for the Rescue
[**GetKennelsInRoom**](AdminsApi.md#getkennelsinroom) | **GET** /locations/{locationId}/buildings/{buildingId}/room/{roomId}/kennels | returns all kennels in a Room
[**GetLocationById**](AdminsApi.md#getlocationbyid) | **GET** /locations/{id} | returns a specific location for the Rescue
[**GetLocations**](AdminsApi.md#getlocations) | **GET** /locations | searches all locations for the Rescue
[**GetOrganizationById**](AdminsApi.md#getorganizationbyid) | **GET** /organizations/{id} | retrieves a Organization by id
[**GetRoomInBuildingById**](AdminsApi.md#getroominbuildingbyid) | **GET** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId} | returns a specific location for the Rescue
[**GetRoomsInBuilding**](AdminsApi.md#getroomsinbuilding) | **GET** /locations/{locationId}/buildings/{buildingId}/rooms | gets all Rooms in a Building at a Location
[**GetVolunteerById**](AdminsApi.md#getvolunteerbyid) | **GET** /volunteers/{id} | retrieves a Volunteer by id
[**IntakeInformation**](AdminsApi.md#intakeinformation) | **GET** /intakes | support for animal intake process
[**PatchBuildingAtLocationById**](AdminsApi.md#patchbuildingatlocationbyid) | **PATCH** /locations/{locationId}/buildings/{buildingId} | updates a Location by id
[**PatchBuildingById**](AdminsApi.md#patchbuildingbyid) | **PATCH** /buildings/{id} | updates a Building by id
[**PatchContactById**](AdminsApi.md#patchcontactbyid) | **PATCH** /contacts/{id} | updates a Contact by id
[**PatchDonorById**](AdminsApi.md#patchdonorbyid) | **PATCH** /donors/{id} | updates a Donor by id
[**PatchEnclosureById**](AdminsApi.md#patchenclosurebyid) | **PATCH** /enclosures/{id} | updates a Enclosure by id
[**PatchFosterById**](AdminsApi.md#patchfosterbyid) | **PATCH** /fosters/{id} | updates a Foster by id
[**PatchKennelById**](AdminsApi.md#patchkennelbyid) | **PATCH** /kennels/{id} | updates a Kennel by id
[**PatchKennelInRoomById**](AdminsApi.md#patchkennelinroombyid) | **PATCH** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId}/kennels/{kennelId} | updates a Kennel by id
[**PatchLocationById**](AdminsApi.md#patchlocationbyid) | **PATCH** /locations/{id} | updates a Location by id
[**PatchOrganizationById**](AdminsApi.md#patchorganizationbyid) | **PATCH** /organizations/{id} | updates a Organization by id
[**PatchRoomInBuildingById**](AdminsApi.md#patchroominbuildingbyid) | **PATCH** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId} | updates a Room by id
[**PatchVolunteerById**](AdminsApi.md#patchvolunteerbyid) | **PATCH** /volunteers/{id} | updates a Volunteer by id
[**SearchAdoptions**](AdminsApi.md#searchadoptions) | **GET** /adoptions | searches all Adoptions at the Rescue
[**SearchCats**](AdminsApi.md#searchcats) | **GET** /cats | searches cats
[**SearchContact**](AdminsApi.md#searchcontact) | **GET** /contacts | searches Contact
[**SearchDog**](AdminsApi.md#searchdog) | **GET** /dogs | searches dogs
[**SearchFosters**](AdminsApi.md#searchfosters) | **GET** /fosters | searches animal fosters
[**SearchInventory**](AdminsApi.md#searchinventory) | **GET** /inventory | searches inventory
[**SearchOrganization**](AdminsApi.md#searchorganization) | **GET** /organizations | searches Organization
[**SearchVolunteers**](AdminsApi.md#searchvolunteers) | **GET** /volunteers | searches volunteers
[**UpdateBuildingAtLocationById**](AdminsApi.md#updatebuildingatlocationbyid) | **PUT** /locations/{locationId}/buildings/{buildingId} | updates a Location by id
[**UpdateBuildingById**](AdminsApi.md#updatebuildingbyid) | **PUT** /buildings/{id} | updates a Building by id
[**UpdateDonorById**](AdminsApi.md#updatedonorbyid) | **PUT** /donors/{id} | updates a Donor by id
[**UpdateEnclosureById**](AdminsApi.md#updateenclosurebyid) | **PUT** /enclosures/{id} | updates a Enclosure by id
[**UpdateFosterById**](AdminsApi.md#updatefosterbyid) | **PUT** /fosters/{id} | updates a Foster by id
[**UpdateKennelById**](AdminsApi.md#updatekennelbyid) | **PUT** /kennels/{id} | updates a Kennel by id
[**UpdateKennelInRoomById**](AdminsApi.md#updatekennelinroombyid) | **PUT** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId}/kennels/{kennelId} | updates a Kennel by id
[**UpdateLocationById**](AdminsApi.md#updatelocationbyid) | **PUT** /locations/{id} | updates a Location by id
[**UpdateOrganizationById**](AdminsApi.md#updateorganizationbyid) | **PUT** /organizations/{id} | updates a Organization by id
[**UpdateRoomInBuildingById**](AdminsApi.md#updateroominbuildingbyid) | **PUT** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId} | updates a Room by id
[**UpdateVolunteerById**](AdminsApi.md#updatevolunteerbyid) | **PUT** /volunteers/{id} | updates a Volunteer by id

<a name="addbuilding"></a>
# **AddBuilding**
> void AddBuilding (Building body)

adds a Building to the rescue

Adds a new Building to the Rescue

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddBuildingExample
    {
        public void main()
        {
            var apiInstance = new AdminsApi();
            var body = new Building(); // Building | Building to add to the Rescue

            try
            {
                // adds a Building to the rescue
                apiInstance.AddBuilding(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.AddBuilding: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Building**](Building.md)| Building to add to the Rescue | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
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
            var apiInstance = new AdminsApi();
            var body = new Building(); // Building | unique id of Building to update
            var locationId = new Guid?(); // Guid? | 

            try
            {
                // adds a Building at the specified Location
                apiInstance.AddBuildingToLocation(body, locationId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.AddBuildingToLocation: " + e.Message );
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
<a name="addenclosure"></a>
# **AddEnclosure**
> void AddEnclosure (Enclosure body)

adds a Enclosure to the rescue

Adds a new Enclosure to the Rescue

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddEnclosureExample
    {
        public void main()
        {
            var apiInstance = new AdminsApi();
            var body = new Enclosure(); // Enclosure | Enclosure to add to the Rescue

            try
            {
                // adds a Enclosure to the rescue
                apiInstance.AddEnclosure(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.AddEnclosure: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Enclosure**](Enclosure.md)| Enclosure to add to the Rescue | 

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
            var apiInstance = new AdminsApi();
            var body = new InventoryItem(); // InventoryItem | Inventory item to add (optional) 

            try
            {
                // adds an inventory item
                apiInstance.AddInventory(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.AddInventory: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Kennel(); // Kennel | Kennel to add to the Rescue

            try
            {
                // adds a Kennel to the rescue
                apiInstance.AddKennel(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.AddKennel: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.AddKennelToRoom: " + e.Message );
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
<a name="addlocation"></a>
# **AddLocation**
> void AddLocation (Location body)

adds a Location to the rescue

Adds a new Location to the Rescue

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddLocationExample
    {
        public void main()
        {
            var apiInstance = new AdminsApi();
            var body = new Location(); // Location | Location to add to the Rescue

            try
            {
                // adds a Location to the rescue
                apiInstance.AddLocation(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.AddLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Location**](Location.md)| Location to add to the Rescue | 

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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.AddRoomToBuilding: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Contact(); // Contact | full Contact object with new id (optional) 

            try
            {
                // creates a new Contact
                apiInstance.CreateContact(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.CreateContact: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Foster(); // Foster | new Foster object

            try
            {
                // creates new Foster with a unique id
                apiInstance.CreateFoster(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.CreateFoster: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Organization(); // Organization | full Organization object with new id (optional) 

            try
            {
                // creates a new Organization
                apiInstance.CreateOrganization(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.CreateOrganization: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Volunteer(); // Volunteer | new Volunteer object

            try
            {
                // creates new Volunteer with a unique id
                apiInstance.CreateVolunteer(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.CreateVolunteer: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 

            try
            {
                // deletes a Building from a Location by id
                apiInstance.DeleteBuildingAtLocationById(locationId, buildingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.DeleteBuildingAtLocationById: " + e.Message );
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
<a name="deletebuildingbyid"></a>
# **DeleteBuildingById**
> void DeleteBuildingById (Guid? id)

deletes a Building by id

Deletes an existing Building by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteBuildingByIdExample
    {
        public void main()
        {
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Building by id
                apiInstance.DeleteBuildingById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.DeleteBuildingById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Cat by id
                apiInstance.DeleteCatById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.DeleteCatById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Contact by id
                apiInstance.DeleteContactById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.DeleteContactById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Dog by id
                apiInstance.DeleteDogById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.DeleteDogById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Donor by id
                apiInstance.DeleteDonorById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.DeleteDonorById: " + e.Message );
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
<a name="deleteenclosurebyid"></a>
# **DeleteEnclosureById**
> void DeleteEnclosureById (Guid? id)

deletes a Enclosure by id

Deletes an existing Enclosure by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteEnclosureByIdExample
    {
        public void main()
        {
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Enclosure by id
                apiInstance.DeleteEnclosureById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.DeleteEnclosureById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Foster by id
                apiInstance.DeleteFosterById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.DeleteFosterById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Kennel by id
                apiInstance.DeleteKennelById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.DeleteKennelById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.DeleteKennelFromRoomById: " + e.Message );
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
<a name="deletelocationbyid"></a>
# **DeleteLocationById**
> void DeleteLocationById (Guid? id)

deletes a Location by id

Deletes an existing Location by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteLocationByIdExample
    {
        public void main()
        {
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Location by id
                apiInstance.DeleteLocationById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.DeleteLocationById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Organization by id
                apiInstance.DeleteOrganizationById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.DeleteOrganizationById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.DeleteRoomFromBuildingById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Volunteer by id
                apiInstance.DeleteVolunteerById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.DeleteVolunteerById: " + e.Message );
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
            var apiInstance = new AdminsApi();

            try
            {
                // reports whether the API is up and running
                apiInstance.GetApiHealth();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.GetApiHealth: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetBuildingAtLocationById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetBuildingById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetBuildings: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetBuildingsAtLocation: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Cat by id
                Cat result = apiInstance.GetCatById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.GetCatById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Contact by id
                Contact result = apiInstance.GetContactById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.GetContactById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetCountiesByState: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Dog by id
                Dog result = apiInstance.GetDogById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.GetDogById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Donor by id
                Donor result = apiInstance.GetDonorById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.GetDonorById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetDonors: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetEnclosureById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetEnclosures: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Foster by id
                Foster result = apiInstance.GetFosterById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.GetFosterById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetKennelById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetKennelFromRoomById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetKennels: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetKennelsInRoom: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetLocationById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetLocations: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Organization by id
                Organization result = apiInstance.GetOrganizationById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.GetOrganizationById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetRoomInBuildingById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.GetRoomsInBuilding: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Volunteer by id
                Volunteer result = apiInstance.GetVolunteerById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.GetVolunteerById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.IntakeInformation: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.PatchBuildingAtLocationById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Building(); // Building | partial json object of Building with fields to patch
            var id = new Guid?(); // Guid? | unique id of Building to patch

            try
            {
                // updates a Building by id
                apiInstance.PatchBuildingById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.PatchBuildingById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Contact(); // Contact | partial json object of Contact with fields to patch
            var id = new Guid?(); // Guid? | unique id of Contact to patch

            try
            {
                // updates a Contact by id
                apiInstance.PatchContactById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.PatchContactById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Donor(); // Donor | partial json object of Donor with fields to patch
            var id = new Guid?(); // Guid? | unique id of Donor to patch

            try
            {
                // updates a Donor by id
                apiInstance.PatchDonorById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.PatchDonorById: " + e.Message );
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
<a name="patchenclosurebyid"></a>
# **PatchEnclosureById**
> void PatchEnclosureById (Enclosure body, Guid? id)

updates a Enclosure by id

Updates an existing Enclosure by id with only elements that are changing

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PatchEnclosureByIdExample
    {
        public void main()
        {
            var apiInstance = new AdminsApi();
            var body = new Enclosure(); // Enclosure | partial json object of Enclosure with fields to patch
            var id = new Guid?(); // Guid? | unique id of Enclosure to patch

            try
            {
                // updates a Enclosure by id
                apiInstance.PatchEnclosureById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.PatchEnclosureById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Enclosure**](Enclosure.md)| partial json object of Enclosure with fields to patch | 
 **id** | [**Guid?**](Guid?.md)| unique id of Enclosure to patch | 

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
            var apiInstance = new AdminsApi();
            var body = new Foster(); // Foster | partial json object of Foster with fields to patch
            var id = new Guid?(); // Guid? | unique id of Foster to patch

            try
            {
                // updates a Foster by id
                apiInstance.PatchFosterById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.PatchFosterById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Kennel(); // Kennel | partial json object of Kennel with fields to patch
            var id = new Guid?(); // Guid? | unique id of Kennel to patch

            try
            {
                // updates a Kennel by id
                apiInstance.PatchKennelById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.PatchKennelById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.PatchKennelInRoomById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Location(); // Location | partial json object of Location with fields to patch
            var id = new Guid?(); // Guid? | unique id of Location to patch

            try
            {
                // updates a Location by id
                apiInstance.PatchLocationById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.PatchLocationById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Organization(); // Organization | partial json object of Organization with fields to patch
            var id = new Guid?(); // Guid? | unique id of Organization to patch

            try
            {
                // updates a Organization by id
                apiInstance.PatchOrganizationById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.PatchOrganizationById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.PatchRoomInBuildingById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Volunteer(); // Volunteer | partial json object of Volunteer with fields to patch
            var id = new Guid?(); // Guid? | unique id of Volunteer to patch

            try
            {
                // updates a Volunteer by id
                apiInstance.PatchVolunteerById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.PatchVolunteerById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.SearchAdoptions: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.SearchCats: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.SearchContact: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.SearchDog: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.SearchFosters: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.SearchInventory: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.SearchOrganization: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.SearchVolunteers: " + e.Message );
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
<a name="updatebuildingatlocationbyid"></a>
# **UpdateBuildingAtLocationById**
> void UpdateBuildingAtLocationById (Building body, Guid? locationId, Guid? buildingId)

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
    public class UpdateBuildingAtLocationByIdExample
    {
        public void main()
        {
            var apiInstance = new AdminsApi();
            var body = new Building(); // Building | unique id of Location to update
            var locationId = new Guid?(); // Guid? | 
            var buildingId = new Guid?(); // Guid? | 

            try
            {
                // updates a Location by id
                apiInstance.UpdateBuildingAtLocationById(body, locationId, buildingId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.UpdateBuildingAtLocationById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Building**](Building.md)| unique id of Location to update | 
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
<a name="updatebuildingbyid"></a>
# **UpdateBuildingById**
> void UpdateBuildingById (Building body, Guid? id)

updates a Building by id

Updates an existing Building by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateBuildingByIdExample
    {
        public void main()
        {
            var apiInstance = new AdminsApi();
            var body = new Building(); // Building | unique id of Building to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Building by id
                apiInstance.UpdateBuildingById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.UpdateBuildingById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Building**](Building.md)| unique id of Building to update | 
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
            var apiInstance = new AdminsApi();
            var body = new Donor(); // Donor | unique id of Donor to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Donor by id
                apiInstance.UpdateDonorById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.UpdateDonorById: " + e.Message );
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
<a name="updateenclosurebyid"></a>
# **UpdateEnclosureById**
> void UpdateEnclosureById (Enclosure body, Guid? id)

updates a Enclosure by id

Updates an existing Enclosure by id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateEnclosureByIdExample
    {
        public void main()
        {
            var apiInstance = new AdminsApi();
            var body = new Enclosure(); // Enclosure | unique id of Enclosure to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Enclosure by id
                apiInstance.UpdateEnclosureById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.UpdateEnclosureById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Enclosure**](Enclosure.md)| unique id of Enclosure to update | 
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
            var apiInstance = new AdminsApi();
            var body = new Foster(); // Foster | unique id of Foster to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Foster by id
                apiInstance.UpdateFosterById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.UpdateFosterById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Kennel(); // Kennel | partial json object of Kennel with fields to patch
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Kennel by id
                apiInstance.UpdateKennelById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.UpdateKennelById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.UpdateKennelInRoomById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Location(); // Location | unique id of Location to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Location by id
                apiInstance.UpdateLocationById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.UpdateLocationById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Organization(); // Organization | unique id of Organization to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Organization by id
                apiInstance.UpdateOrganizationById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.UpdateOrganizationById: " + e.Message );
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
            var apiInstance = new AdminsApi();
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
                Debug.Print("Exception when calling AdminsApi.UpdateRoomInBuildingById: " + e.Message );
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
            var apiInstance = new AdminsApi();
            var body = new Volunteer(); // Volunteer | unique id of Volunteer to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Volunteer by id
                apiInstance.UpdateVolunteerById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdminsApi.UpdateVolunteerById: " + e.Message );
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
