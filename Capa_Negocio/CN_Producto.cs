using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Interfaces;

namespace Capa_Negocio
{
    public class CN_Producto : IlistadoProducto
    {
        public Task<IEnumerable<Producto>> GetProductos()
        {
            throw new NotImplementedException();
        }
    }
    
        
    
}