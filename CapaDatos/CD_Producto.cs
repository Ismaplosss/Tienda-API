
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Interfaces;

namespace Capa_Datos
{
    public class CD_Producto : IProducto
    {
        public Task<IEnumerable<Producto>> ObtenerProductos()
        {
            throw new NotImplementedException();
        }
    }
}
