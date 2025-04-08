using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
   public  class Reportes
    {
        public required string Fecha_venta { get; set; }
   
        public required string Cliente { get; set; }
        public required string Producto { get; set; }

        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public required string Id_Transaccion { get; set; }
    }
}
