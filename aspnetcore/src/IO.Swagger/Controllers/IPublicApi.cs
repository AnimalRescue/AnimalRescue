/*
 * AnimalRescue API
 *
 * API for OSS AnimalRescue
 *
 * OpenAPI spec version: 1.0.0-oas3
 * Contact: jlgartee@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public interface IPublicApiController
    { 
        /// <summary>
        /// creates a new Contact
        /// </summary>
        /// <remarks>adds a Contact with a unique id</remarks>
        /// <param name="body">full Contact object with new id</param>
        /// <response code="200">ok</response>
        /// <response code="201">create successful</response>
        /// <response code="400">bad request</response>
        /// <response code="409">unable to apply valid change to a valid Contact</response>
        IActionResult CreateContact([FromBody]Contact body);

        /// <summary>
        /// reports whether the API is up and running
        /// </summary>
        /// <remarks>used to check on the api status</remarks>
        /// <response code="200">OK</response>
        IActionResult GetApiHealth();

        /// <summary>
        /// returns a specific location for the Rescue
        /// </summary>
        /// <remarks>Returns details about a specific Location </remarks>
        /// <param name="locationId"></param>
        /// <param name="buildingId"></param>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetBuildingAtLocationById([FromRoute][Required]Guid? locationId, [FromRoute][Required]Guid? buildingId, [FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// returns a specific Building for the Rescue
        /// </summary>
        /// <remarks>Returns details about a specific Building </remarks>
        /// <param name="id"></param>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetBuildingById([FromRoute][Required]Guid? id, [FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// searches all Buildings for the Rescue
        /// </summary>
        /// <remarks>With no parameters, returns all Buildings for the Rescue </remarks>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetBuildings([FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// returns all buildings at a Location
        /// </summary>
        /// <remarks>With no parameters, returns all Buildings at the specified Location </remarks>
        /// <param name="locationId"></param>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetBuildingsAtLocation([FromRoute][Required]Guid? locationId, [FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// retrieves a Cat by id
        /// </summary>
        /// <remarks>Gets an existing Cat by id</remarks>
        /// <param name="id"></param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized request</response>
        IActionResult GetCatById([FromRoute][Required]Guid? id);

        /// <summary>
        /// retrieves a Contact by id
        /// </summary>
        /// <remarks>Gets an existing Contact by id</remarks>
        /// <param name="id"></param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized request</response>
        IActionResult GetContactById([FromRoute][Required]Guid? id);

        /// <summary>
        /// retrieves counties for the provided state
        /// </summary>
        /// <remarks>Given a state, return an alpha list of counties in that state</remarks>
        /// <param name="state">state to retrieve counties for</param>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">OK</response>
        IActionResult GetCountiesByState([FromQuery][Required()]string state, [FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// retrieves a Dog by id
        /// </summary>
        /// <remarks>Gets an existing Dog by id</remarks>
        /// <param name="id"></param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized request</response>
        IActionResult GetDogById([FromRoute][Required]Guid? id);

        /// <summary>
        /// returns a specific Enclosure for the Rescue
        /// </summary>
        /// <remarks>Returns details about a specific Enclosure </remarks>
        /// <param name="id"></param>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetEnclosureById([FromRoute][Required]Guid? id, [FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// searches all Enclosures for the Rescue
        /// </summary>
        /// <remarks>With no parameters, returns all Enclosures for the Rescue </remarks>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetEnclosures([FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// returns a specific location for the Rescue
        /// </summary>
        /// <remarks>Returns details about a specific Kennel </remarks>
        /// <param name="id"></param>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetKennelById([FromRoute][Required]Guid? id, [FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// returns a specific location for the Rescue
        /// </summary>
        /// <remarks>Returns details about a specific Room </remarks>
        /// <param name="locationId"></param>
        /// <param name="buildingId"></param>
        /// <param name="roomId"></param>
        /// <param name="kennelId"></param>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetKennelFromRoomById([FromRoute][Required]Guid? locationId, [FromRoute][Required]Guid? buildingId, [FromRoute][Required]Guid? roomId, [FromRoute][Required]Guid? kennelId, [FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// searches all Kennels for the Rescue
        /// </summary>
        /// <remarks>With no parameters, returns all Kennels for the Rescue </remarks>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetKennels([FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// returns all kennels in a Room
        /// </summary>
        /// <remarks>With no parameters, returns all kennels in a Room</remarks>
        /// <param name="locationId"></param>
        /// <param name="buildingId"></param>
        /// <param name="roomId"></param>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetKennelsInRoom([FromRoute][Required]Guid? locationId, [FromRoute][Required]Guid? buildingId, [FromRoute][Required]Guid? roomId, [FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// returns a specific location for the Rescue
        /// </summary>
        /// <remarks>Returns details about a specific Location </remarks>
        /// <param name="id"></param>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetLocationById([FromRoute][Required]Guid? id, [FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// searches all locations for the Rescue
        /// </summary>
        /// <remarks>With no parameters, returns all Locations for the Rescue </remarks>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetLocations([FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// retrieves a Organization by id
        /// </summary>
        /// <remarks>Gets an existing Organization by id</remarks>
        /// <param name="id"></param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized request</response>
        IActionResult GetOrganizationById([FromRoute][Required]Guid? id);

        /// <summary>
        /// returns a specific location for the Rescue
        /// </summary>
        /// <remarks>Returns details about a specific Room </remarks>
        /// <param name="locationId"></param>
        /// <param name="buildingId"></param>
        /// <param name="roomId"></param>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult GetRoomInBuildingById([FromRoute][Required]Guid? locationId, [FromRoute][Required]Guid? buildingId, [FromRoute][Required]Guid? roomId, [FromQuery]int? limit, [FromQuery]int? offset);

        /// <summary>
        /// retrieves a Volunteer by id
        /// </summary>
        /// <remarks>Gets an existing Volunteer by id</remarks>
        /// <param name="id"></param>
        /// <response code="200">ok</response>
        /// <response code="400">bad request</response>
        /// <response code="401">unauthorized request</response>
        IActionResult GetVolunteerById([FromRoute][Required]Guid? id);

        /// <summary>
        /// support for animal intake process
        /// </summary>
        /// <remarks>Base endopoints returns and empty Intake array</remarks>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <param name="fromDate">Specifies the first to return</param>
        /// <param name="toDate">Specifies the last date to return</param>
        /// <response code="200">OK</response>
        IActionResult IntakeInformation([FromQuery]int? limit, [FromQuery]int? offset, [FromQuery]DateTime? fromDate, [FromQuery]DateTime? toDate);

        /// <summary>
        /// updates a Contact by id
        /// </summary>
        /// <remarks>Updates an existing Contact by id with only elements that are changing</remarks>
        /// <param name="body">partial json object of Contact with fields to patch</param>
        /// <param name="id">unique id of Contact to patch</param>
        /// <response code="200">ok</response>
        IActionResult PatchContactById([FromBody]Contact body, [FromRoute][Required]Guid? id);

        /// <summary>
        /// searches all Adoptions at the Rescue
        /// </summary>
        /// <remarks>With no parameters, returns all Adoptions at the Rescue </remarks>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <param name="fromDate">Specifies the first to return</param>
        /// <param name="toDate">Specifies the last date to return</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult SearchAdoptions([FromQuery]int? limit, [FromQuery]int? offset, [FromQuery]DateTime? fromDate, [FromQuery]DateTime? toDate);

        /// <summary>
        /// searches cats
        /// </summary>
        /// <remarks>With no parameters, returns all cats currently in the shelter. Allows filters. </remarks>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <param name="fromDate">Specifies the first to return</param>
        /// <param name="toDate">Specifies the last date to return</param>
        /// <param name="name">Specifies a matching pattern for the name</param>
        /// <param name="adoptionStatus">Specifies one of the valid AdoptionStatus values</param>
        /// <param name="breed">breed of cat to retrieve</param>
        /// <param name="color">Specifies one of the valid CatColors</param>
        /// <param name="gender">Specifies on of the valid Gender</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult SearchCats([FromQuery]int? limit, [FromQuery]int? offset, [FromQuery]DateTime? fromDate, [FromQuery]DateTime? toDate, [FromQuery]DateTime? name, [FromQuery]string adoptionStatus, [FromQuery]string breed, [FromQuery]string color, [FromQuery]string gender);

        /// <summary>
        /// searches Contact
        /// </summary>
        /// <remarks>With no parameters, returns all contacts associated with the Rescue. Allows filters. </remarks>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <param name="fromDate">Specifies the first to return</param>
        /// <param name="toDate">Specifies the last date to return</param>
        /// <param name="searchString">pass an optional search string for looking up Fosters</param>
        /// <param name="gender">One of the valid Gender enumeration values</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult SearchContact([FromQuery]int? limit, [FromQuery]int? offset, [FromQuery]DateTime? fromDate, [FromQuery]DateTime? toDate, [FromQuery]string searchString, [FromQuery]Gender gender);

        /// <summary>
        /// searches dogs
        /// </summary>
        /// <remarks>With no parameters, returns all dogss currently in the shelter. Allows filters. </remarks>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <param name="fromDate">Specifies the first to return</param>
        /// <param name="toDate">Specifies the last date to return</param>
        /// <param name="name">Specifies a matching pattern for the name</param>
        /// <param name="adoptionStatus">Specifies one of the valid AdoptionStatus values</param>
        /// <param name="breed">breed of dog to retrieve</param>
        /// <param name="color">Specifies one of the valid DogColors</param>
        /// <param name="gender">Specifies on of the valid Gender</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult SearchDog([FromQuery]int? limit, [FromQuery]int? offset, [FromQuery]DateTime? fromDate, [FromQuery]DateTime? toDate, [FromQuery]DateTime? name, [FromQuery]string adoptionStatus, [FromQuery]string breed, [FromQuery]string color, [FromQuery]string gender);

        /// <summary>
        /// searches inventory
        /// </summary>
        /// <remarks>By passing in the appropriate options, you can search for available inventory in the system </remarks>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <param name="searchString">pass an optional search string for looking up inventory</param>
        /// <response code="200">search results matching criteria</response>
        /// <response code="400">bad input parameter</response>
        IActionResult SearchInventory([FromQuery]int? limit, [FromQuery]int? offset, [FromQuery]string searchString);

        /// <summary>
        /// searches Organization
        /// </summary>
        /// <remarks>With no parameters, returns all Organizations associated with the Rescue. Allows filters. </remarks>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <param name="fromDate">Specifies the first to return</param>
        /// <param name="toDate">Specifies the last date to return</param>
        /// <param name="name">Specifies a matching pattern for the name</param>
        /// <param name="gender">Specifies on of the valid Gender</param>
        /// <response code="200">ok</response>
        /// <response code="204">no results found</response>
        /// <response code="400">bad request - check parameter format</response>
        /// <response code="401">unauthorized request for this user</response>
        IActionResult SearchOrganization([FromQuery]int? limit, [FromQuery]int? offset, [FromQuery]DateTime? fromDate, [FromQuery]DateTime? toDate, [FromQuery]DateTime? name, [FromQuery]string gender);

        /// <summary>
        /// searches volunteers
        /// </summary>
        /// <remarks>With no parameters, returns all registered Volunteers. Allows filters. </remarks>
        /// <param name="searchString">pass an optional search string for looking up Fosters</param>
        /// <param name="limit">Limits the number of items on a page</param>
        /// <param name="offset">Specifies the page number of the artists to be displayed</param>
        /// <param name="fromDate">Specifies the first to return</param>
        /// <param name="toDate">Specifies the last date to return</param>
        /// <response code="200">search results matching specified criteria</response>
        /// <response code="400">bad input parameter</response>
        IActionResult SearchVolunteers([FromQuery]string searchString, [FromQuery]int? limit, [FromQuery]int? offset, [FromQuery]DateTime? fromDate, [FromQuery]DateTime? toDate);

        /// <summary>
        /// updates a Contact by id
        /// </summary>
        /// <remarks>Updates an existing Contact by id</remarks>
        /// <param name="body">unique id of Contact to update</param>
        /// <param name="id"></param>
        /// <response code="200">ok</response>
        /// <response code="401">unauthorized request</response>
        IActionResult UpdateContactById([FromBody]Contact body, [FromRoute][Required]Guid? id);
    }
}
