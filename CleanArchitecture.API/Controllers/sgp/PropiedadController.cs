using CleanArchitecture.Application.Features.Propiedad.Commands.CreatePropiedad;
using CleanArchitecture.Application.Features.Propiedad.Commands.DeletePropiedad;
using CleanArchitecture.Application.Features.Propiedad.Commands.UpdatePropiedad;
using CleanArchitecture.Application.Features.Streamers.Commands;
using CleanArchitecture.Application.Features.Streamers.Commands.DeleteStreamer;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanArchitecture.API.Controllers.sgp
{
     [ApiController]
     [Route("api/v1/[controller]")]
     public class PropiedadController : ControllerBase
     {
          private IMediator _mediator;

          public PropiedadController(IMediator mediator)
          {
               _mediator = mediator;
          }
          [HttpPost(Name = "CreatePropiedad")]
         // [Authorize(Roles = "Administrator")]
          [ProducesResponseType((int)HttpStatusCode.OK)]
          public async Task<ActionResult<long>> CreatePropiedad([FromBody] CreatePropiedadCommand command)
          {
               return await _mediator.Send(command);
          }

          [HttpPut(Name = "UpdateStreamer")]
          [ProducesResponseType(StatusCodes.Status204NoContent)]
          [ProducesResponseType(StatusCodes.Status404NotFound)]
          [ProducesDefaultResponseType]
          public async Task<ActionResult> UpdatePropiedad([FromBody] UpdatePropiedadCommand command)
          {
               await _mediator.Send(command);

               return NoContent();
          }

          [HttpDelete("{id}", Name = "PropiedadStreamer")]
          [ProducesResponseType(StatusCodes.Status204NoContent)]
          [ProducesResponseType(StatusCodes.Status404NotFound)]
          [ProducesDefaultResponseType]
          public async Task<ActionResult> DeletePropiedad(int id)
          {
               var command = new DeletePropiedadCommand
               {
                    Id = id
               };

               await _mediator.Send(command);

               return NoContent();
          }


     }
}
