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
         // Se declara una variable privada de tipo IProducto
        private readonly IProducto _producto;
       
       
       // Constructor que recibe una instancia de IProducto
        // para inyectar la dependencia
        // y permitir la implementación de la interfaz IlistadoProducto
        // en la clase CN_Producto.
        public CN_Producto(IProducto producto)
        {
            _producto = producto;
        }



    // ########Clases de la capa de negocio########
    // Aqui van todos los métodos de la capa de negocio la cual cargara las instancias de productos

        // Método que obtiene una lista de productos
        public Task<IEnumerable<Producto>> GetProductos()
        {
            
            return _producto.ObtenerProductos();
        }
    }
    
        
    
}