# IO.Swagger.Api.VetsApi

All URIs are relative to *https://virtserver.swaggerhub.com/jgartee/AnimalRescue/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInventory**](VetsApi.md#addinventory) | **POST** /inventory | adds an inventory item
[**CreateContact**](VetsApi.md#createcontact) | **POST** /contacts | creates a new Contact
[**CreateOrganization**](VetsApi.md#createorganization) | **POST** /organizations | creates a new Organization
[**DeleteOrganizationById**](VetsApi.md#deleteorganizationbyid) | **DELETE** /organizations/{id} | deletes a Organization by id
[**GetApiHealth**](VetsApi.md#getapihealth) | **GET** /health | reports whether the API is up and running
[**GetBuildingAtLocationById**](VetsApi.md#getbuildingatlocationbyid) | **GET** /locations/{locationId}/buildings/{buildingId} | returns a specific location for the Rescue
[**GetBuildingById**](VetsApi.md#getbuildingbyid) | **GET** /buildings/{id} | returns a specific Building for the Rescue
[**GetBuildings**](VetsApi.md#getbuildings) | **GET** /buildings | Returns a (filtered) collection of buildings affiliated withthe Rescue
[**GetBuildingsAtLocation**](VetsApi.md#getbuildingsatlocation) | **GET** /locations/{locationId}/buildings | returns all buildings at a Location
[**GetCatById**](VetsApi.md#getcatbyid) | **GET** /cats/{id} | retrieves a Cat by id
[**GetContactById**](VetsApi.md#getcontactbyid) | **GET** /contacts/{id} | retrieves a Contact by id
[**GetCountiesByState**](VetsApi.md#getcountiesbystate) | **GET** /counties | retrieves counties for the provided state
[**GetDogById**](VetsApi.md#getdogbyid) | **GET** /dogs/{id} | retrieves a Dog by id
[**GetEnclosureById**](VetsApi.md#getenclosurebyid) | **GET** /enclosures/{id} | returns a specific Enclosure for the Rescue
[**GetEnclosures**](VetsApi.md#getenclosures) | **GET** /enclosures | searches all Enclosures for the Rescue
[**GetFosterById**](VetsApi.md#getfosterbyid) | **GET** /fosters/{id} | retrieves a Foster by id
[**GetKennelById**](VetsApi.md#getkennelbyid) | **GET** /kennels/{id} | returns a specific location for the Rescue
[**GetKennelFromRoomById**](VetsApi.md#getkennelfromroombyid) | **GET** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId}/kennels/{kennelId} | returns a specific location for the Rescue
[**GetKennels**](VetsApi.md#getkennels) | **GET** /kennels | searches all Kennels for the Rescue
[**GetKennelsInRoom**](VetsApi.md#getkennelsinroom) | **GET** /locations/{locationId}/buildings/{buildingId}/room/{roomId}/kennels | returns all kennels in a Room
[**GetLocationById**](VetsApi.md#getlocationbyid) | **GET** /locations/{id} | returns a specific location for the Rescue
[**GetLocations**](VetsApi.md#getlocations) | **GET** /locations | searches all locations for the Rescue
[**GetOrganizationById**](VetsApi.md#getorganizationbyid) | **GET** /organizations/{id} | retrieves a Organization by id
[**GetRoomInBuildingById**](VetsApi.md#getroominbuildingbyid) | **GET** /locations/{locationId}/buildings/{buildingId}/rooms/{roomId} | returns a specific location for the Rescue
[**GetVolunteerById**](VetsApi.md#getvolunteerbyid) | **GET** /volunteers/{id} | retrieves a Volunteer by id
[**IntakeInformation**](VetsApi.md#intakeinformation) | **GET** /intakes | support for animal intake process
[**PatchContactById**](VetsApi.md#patchcontactbyid) | **PATCH** /contacts/{id} | updates a Contact by id
[**PatchOrganizationById**](VetsApi.md#patchorganizationbyid) | **PATCH** /organizations/{id} | updates a Organization by id
[**SearchAdoptions**](VetsApi.md#searchadoptions) | **GET** /adoptions | searches all Adoptions at the Rescue
[**SearchCats**](VetsApi.md#searchcats) | **GET** /cats | searches cats
[**SearchContact**](VetsApi.md#searchcontact) | **GET** /contacts | searches Contact
[**SearchDog**](VetsApi.md#searchdog) | **GET** /dogs | searches dogs
[**SearchFosters**](VetsApi.md#searchfosters) | **GET** /fosters | searches animal fosters
[**SearchInventory**](VetsApi.md#searchinventory) | **GET** /inventory | searches inventory
[**SearchOrganization**](VetsApi.md#searchorganization) | **GET** /organizations | searches Organization
[**SearchVolunteers**](VetsApi.md#searchvolunteers) | **GET** /volunteers | searches volunteers
[**UpdateOrganizationById**](VetsApi.md#updateorganizationbyid) | **PUT** /organizations/{id} | updates a Organization by id

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
            var apiInstance = new VetsApi();
            var body = new InventoryItem(); // InventoryItem | Inventory item to add (optional) 

            try
            {
                // adds an inventory item
                apiInstance.AddInventory(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.AddInventory: " + e.Message );
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
            var apiInstance = new VetsApi();
            var body = new Contact(); // Contact | full Contact object with new id (optional) 

            try
            {
                // creates a new Contact
                apiInstance.CreateContact(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.CreateContact: " + e.Message );
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
            var apiInstance = new VetsApi();
            var body = new Organization(); // Organization | full Organization object with new id (optional) 

            try
            {
                // creates a new Organization
                apiInstance.CreateOrganization(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.CreateOrganization: " + e.Message );
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
            var apiInstance = new VetsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // deletes a Organization by id
                apiInstance.DeleteOrganizationById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.DeleteOrganizationById: " + e.Message );
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
            var apiInstance = new VetsApi();

            try
            {
                // reports whether the API is up and running
                apiInstance.GetApiHealth();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.GetApiHealth: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetBuildingAtLocationById: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetBuildingById: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetBuildings: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetBuildingsAtLocation: " + e.Message );
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
            var apiInstance = new VetsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Cat by id
                Cat result = apiInstance.GetCatById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.GetCatById: " + e.Message );
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
            var apiInstance = new VetsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Contact by id
                Contact result = apiInstance.GetContactById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.GetContactById: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetCountiesByState: " + e.Message );
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
            var apiInstance = new VetsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Dog by id
                Dog result = apiInstance.GetDogById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.GetDogById: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetEnclosureById: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetEnclosures: " + e.Message );
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
            var apiInstance = new VetsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Foster by id
                Foster result = apiInstance.GetFosterById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.GetFosterById: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetKennelById: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetKennelFromRoomById: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetKennels: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetKennelsInRoom: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetLocationById: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetLocations: " + e.Message );
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
            var apiInstance = new VetsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Organization by id
                Organization result = apiInstance.GetOrganizationById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.GetOrganizationById: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.GetRoomInBuildingById: " + e.Message );
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
            var apiInstance = new VetsApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // retrieves a Volunteer by id
                Volunteer result = apiInstance.GetVolunteerById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.GetVolunteerById: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.IntakeInformation: " + e.Message );
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
            var apiInstance = new VetsApi();
            var body = new Contact(); // Contact | partial json object of Contact with fields to patch
            var id = new Guid?(); // Guid? | unique id of Contact to patch

            try
            {
                // updates a Contact by id
                apiInstance.PatchContactById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.PatchContactById: " + e.Message );
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
            var apiInstance = new VetsApi();
            var body = new Organization(); // Organization | partial json object of Organization with fields to patch
            var id = new Guid?(); // Guid? | unique id of Organization to patch

            try
            {
                // updates a Organization by id
                apiInstance.PatchOrganizationById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.PatchOrganizationById: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.SearchAdoptions: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.SearchCats: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.SearchContact: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.SearchDog: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.SearchFosters: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.SearchInventory: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.SearchOrganization: " + e.Message );
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
            var apiInstance = new VetsApi();
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
                Debug.Print("Exception when calling VetsApi.SearchVolunteers: " + e.Message );
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
            var apiInstance = new VetsApi();
            var body = new Organization(); // Organization | unique id of Organization to update
            var id = new Guid?(); // Guid? | 

            try
            {
                // updates a Organization by id
                apiInstance.UpdateOrganizationById(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VetsApi.UpdateOrganizationById: " + e.Message );
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
