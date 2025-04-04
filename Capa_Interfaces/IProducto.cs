using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
 

namespace Capa_Interfaces
{
    public  interface IProducto
    {
        Task<IEnumerable<Producto>> ObtenerProductos();
    }
}
