using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Interfaces
{
    public interface IlistadoProducto
    {
        Task<IEnumerable<Producto>> GetProductos();
    }
}