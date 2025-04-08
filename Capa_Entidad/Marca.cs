using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
   public  class Marca
    {
        public int IdMarca { get; set; }
        public  required string Descripcion { get; set; }
        public required bool Activo { get; set; }
        public required string Fecha_Registro { get; set; }
    }
}
