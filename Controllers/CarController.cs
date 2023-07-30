using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using legocarapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace legocarapi.Controllers
{
    [ApiController]
    [Route("api/car")]
    public class CarController : ControllerBase
    {
        [HttpGet()]
        [Produces( MediaTypeNames.Application.Json )]
        [ProducesResponseType(typeof(CarStateResponse), 200)]
        [ProducesResponseType(typeof(ErrorResponse), 404)]
        public IActionResult GetById([FromQuery, BindRequired] string id)
        {
            if (id == "0") {
                return Ok(new CarStateResponse());
            } else {
                return NotFound(new ErrorResponse (new Error{ Message = "Car not found", Code = 404 }));
            }
        }

        [HttpPost("speed")]
        [Produces( MediaTypeNames.Application.Json )]
        [ProducesResponseType(typeof(SuccessResponse), 200)]
        [ProducesResponseType(typeof(ErrorResponse), 400)]
        [ProducesResponseType(typeof(ErrorResponse), 404)]
        public IActionResult PostById([FromQuery, BindRequired] string id, [FromBody, BindRequired] CarSpeedRequest speed)
        {
            if (speed.Speed != null && speed.Speed >= 0 && speed.Speed <= 100) {
                if (id == "0") {
                    return Ok(new SuccessResponse());
                } else {
                    return NotFound(new ErrorResponse (new Error{ Message = "Car not found", Code = 404 }));
                }
            } else {
                return BadRequest(new ErrorResponse (new Error{ Message = "Bad request", Code = 400 }));
            }
        }

        [HttpPost("direction")]
        [Produces( MediaTypeNames.Application.Json )]
        [ProducesResponseType(typeof(SuccessResponse), 200)]
        [ProducesResponseType(typeof(ErrorResponse), 400)]
        [ProducesResponseType(typeof(ErrorResponse), 404)]
        public IActionResult PostById([FromQuery, BindRequired] string id, [FromBody, BindRequired] CarDirectionRequest direction)
        {
            if (direction.Direction != 0) {
                if (id == "0") {
                    return Ok(new SuccessResponse());
                } else {
                    return NotFound(new ErrorResponse (new Error{ Message = "Car not found", Code = 404 }));
                }
            } else {
                return BadRequest(new ErrorResponse (new Error{ Message = "Bad request", Code = 400 }));
            }
        }
    }
}