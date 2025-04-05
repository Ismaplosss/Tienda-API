using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Capa_Controlador.Controlladores
{
    [ApiController]
    [Route("api/[controller]")]
    public class Productos : ControllerBase
    {
        private readonly IlistadoProducto _listadoProductos;

        // Este constructor debe ser PÚBLICO
        public Productos(IlistadoProducto listadoProductos)
        {
            _listadoProductos = listadoProductos;
        }

        [HttpGet("Listado")]
        public async Task<ActionResult<List<Producto>>> Get()
        {
            try
            {
                var productos = await _listadoProductos.GetProductos();
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet ("cantidad")]
        public  async Task<ActionResult> Cantidad()
        {
            try
            {
                var cantidad = await _listadoProductos.Listada_Canidad();
                return Ok(cantidad);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

       
}

}
