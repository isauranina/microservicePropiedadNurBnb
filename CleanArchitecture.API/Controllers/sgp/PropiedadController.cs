using CleanArchitecture.Application.Features.Propiedad.Commands.CreatePropiedad;
using CleanArchitecture.Application.Features.Streamers.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanArchitecture.API.Controllers.sgp
{
     [ApiController]
     [Route("api/v1/[controller]")]     
     public class PropiedadController:ControllerBase
     {
          private IMediator _mediator;

          public PropiedadController(IMediator mediator)
          {
               _mediator = mediator;
          }
          [HttpPost(Name = "CreatePropiedad")]
          [Authorize(Roles = "Administrator")]
          [ProducesResponseType((int)HttpStatusCode.OK)]
          public async Task<ActionResult<long>> CreatePropiedad([FromBody] CreatePropiedadCommand command)
          {
               return await _mediator.Send(command);
          }

     }
}
