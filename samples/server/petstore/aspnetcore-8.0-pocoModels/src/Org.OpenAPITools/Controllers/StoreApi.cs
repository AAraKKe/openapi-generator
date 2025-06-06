/*
 * OpenAPI Petstore
 *
 * This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using Org.OpenAPITools.Attributes;
using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class StoreApiController : ControllerBase
    { 
        /// <summary>
        /// Delete purchase order by ID
        /// </summary>
        /// <remarks>For valid response try integer IDs with value &lt; 1000. Anything above 1000 or nonintegers will generate API errors</remarks>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Order not found</response>
        [HttpDelete]
        [Route("/v2/store/order/{orderId}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteOrder")]
        public virtual IActionResult DeleteOrder([FromRoute (Name = "orderId")][Required]string orderId)
        {

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns pet inventories by status
        /// </summary>
        /// <remarks>Returns a map of status codes to quantities</remarks>
        /// <response code="200">successful operation</response>
        [HttpGet]
        [Route("/v2/store/inventory")]
        [Authorize(Policy = "api_key")]
        [ValidateModelState]
        [SwaggerOperation("GetInventory")]
        [SwaggerResponse(statusCode: 200, type: typeof(Dictionary<string, int>), description: "successful operation")]
        public virtual IActionResult GetInventory()
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default);
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Dictionary<string, int>>(exampleJson)
            : new Dictionary<string, int>();
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Find purchase order by ID
        /// </summary>
        /// <remarks>For valid response try integer IDs with value &lt;&#x3D; 5 or &gt; 10. Other values will generate exceptions</remarks>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Order not found</response>
        [HttpGet]
        [Route("/v2/store/order/{orderId}")]
        [ValidateModelState]
        [SwaggerOperation("GetOrderById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Order), description: "successful operation")]
        public virtual IActionResult GetOrderById([FromRoute (Name = "orderId")][Required][Range(1, 5)]long orderId)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default);
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\n  \"petId\" : 6,\n  \"quantity\" : 1,\n  \"id\" : 0,\n  \"shipDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"complete\" : false,\n  \"status\" : \"placed\"\n}";
            exampleJson = "<Order>\n  <id>123456789</id>\n  <petId>123456789</petId>\n  <quantity>123</quantity>\n  <shipDate>2000-01-23T04:56:07.000Z</shipDate>\n  <status>aeiou</status>\n  <complete>true</complete>\n</Order>";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Order>(exampleJson)
            : default;
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Place an order for a pet
        /// </summary>
        /// <param name="order">order placed for purchasing the pet</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid Order</response>
        [HttpPost]
        [Route("/v2/store/order")]
        [Consumes("application/json")]
        [ValidateModelState]
        [SwaggerOperation("PlaceOrder")]
        [SwaggerResponse(statusCode: 200, type: typeof(Order), description: "successful operation")]
        public virtual IActionResult PlaceOrder([FromBody]Order order)
        {

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default);
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "{\n  \"petId\" : 6,\n  \"quantity\" : 1,\n  \"id\" : 0,\n  \"shipDate\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"complete\" : false,\n  \"status\" : \"placed\"\n}";
            exampleJson = "<Order>\n  <id>123456789</id>\n  <petId>123456789</petId>\n  <quantity>123</quantity>\n  <shipDate>2000-01-23T04:56:07.000Z</shipDate>\n  <status>aeiou</status>\n  <complete>true</complete>\n</Order>";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Order>(exampleJson)
            : default;
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
