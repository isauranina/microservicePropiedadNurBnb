using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Models.sgp
{
     public class TipoEstado : BaseDomainModel
     {
         
          public string? Descripcion { get; set; } 

          public string? Estado { get; set; }
     }
}
