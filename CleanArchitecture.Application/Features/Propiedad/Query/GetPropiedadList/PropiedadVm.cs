

namespace CleanArchitecture.Application.Features.Propiedad.Query.GetPropiedadList
{
     public class PropiedadVm
     {
          public string? Descripcion { get; set; }
          public string Direccion { get; set; } = string.Empty;
          public Boolean esverificado { get; set; } = false;
          public long? TipoproPiedadId { get; set; }        
          public long? CiudadId { get; set; }       
          public string? Estado { get; set; }
     }
}
