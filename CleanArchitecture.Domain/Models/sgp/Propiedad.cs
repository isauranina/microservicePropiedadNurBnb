using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Models.sgp
{
     public class Propiedad : BaseDomainModel
     {
         
          public string? Descripcion { get; set; }
          public string Direccion { get; set; }= string.Empty;
          public Boolean esverificado { get; set; } = false;
          public long? TipoproPiedadId { get; set; }
          public virtual TipoPropiedad? TipoPropiedad { get; set; }
          public long? CiudadId { get; set; }
          public virtual Ciudad? Ciudad { get; set; }
          public string? Estado { get; set; }


     }
}
