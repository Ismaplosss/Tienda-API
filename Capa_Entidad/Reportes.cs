﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
   public  class Reportes
    {
        public string Fecha_venta { get; set; }
   
        public string Cliente { get; set; }
        public string Producto { get; set; }

        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public string Id_Transaccion { get; set; }
    }
}
