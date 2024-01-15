using MediatR;


namespace CleanArchitecture.Application.Features.Propiedad.Commands.DeletePropiedad
{
     public class DeletePropiedadCommand : IRequest
     {        
          public int Id { get; set; }
          
     }
}
