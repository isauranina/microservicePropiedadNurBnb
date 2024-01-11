using MediatR;


namespace CleanArchitecture.Application.Features.Propiedad.Commands.CreatePropiedad
{
     public class CreatePropiedadCommand: IRequest<long>
     {
          public string Descripcion { get; set; } = string.Empty;
          public string Direccion { get; set; } = string.Empty;
          public Boolean esverificado { get; set; } = false;
          public long? TipoproPiedadId { get; set; }
          public long? CiudadId { get; set; }
          public string? Estado { get; set; }
     }
}
