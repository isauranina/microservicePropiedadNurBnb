using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Models.sgp
{
     public class Agenda : BaseDomainModel
     {
         
          public long PropiedadId {get;set;}
          public virtual Propiedad? Propiedad { get; set; }
          public long TipoEstadoId { get; set; }
          public virtual TipoEstado? TipoEstado { get; set; }
          public DateTime fecha_inicio { get; set; }   
          public DateTime fecha_fin { get; set; }
          public DateTime fecha_registro { get; set; }
          public string? Estado { get; set; }

     }
}
