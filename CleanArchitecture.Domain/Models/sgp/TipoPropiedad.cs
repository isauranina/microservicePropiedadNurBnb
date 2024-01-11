using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Models.sgp
{
     public class TipoPropiedad : BaseDomainModel
     {         
          public string? Descripcion { get; set; } 

          public string? Estado { get; set; }
     }
}
