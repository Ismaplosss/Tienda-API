using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
     public class Provincia
    {
        public required string IdProvincia { get; set; }
        public required string Descripcion { get; set; }
        public required string IdCanton { get; set;  }
    }
}
