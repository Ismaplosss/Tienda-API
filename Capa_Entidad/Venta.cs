using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public required Cliente Ocliente { get; set; }
        public int Total_Producto { get; set; }
        public decimal Monto_Total { get; set; }
        public required string Contacto { get; set; }
        public required string IdDistrito { get; set; }
        public required string Telefono { get; set; }
        public required string Direccion { get; set; }
        public required string Id_Transaccion { get; set; }
        public required string Fecha_Registro { get; set;  }


    }
}
