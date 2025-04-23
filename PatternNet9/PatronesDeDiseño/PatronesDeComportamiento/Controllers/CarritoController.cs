using CommandPattern.Services;
using Microsoft.AspNetCore.Mvc;

namespace PatronesDeComportamiento.Controllers
{
    [ApiController]
    [Route("apiCommand/[controller]")]
    public class CarritoController : Controller
    {
        private static readonly CarritoCompras _carrito = new();
        private static readonly Invoker _invoker = new();

        [HttpPost("agregar")]
        public IActionResult AgregarProducto([FromBody] Producto producto)
        {
            var command = new AgregarProductoCommand(_carrito, producto);
            var resultado = _invoker.Ejecutar(command);
            return Ok(resultado);
        }

        [HttpPost("deshacer")]
        public IActionResult Deshacer()
        {
            var resultado = _invoker.Deshacer();
            return Ok(resultado);
        }

        [HttpGet("productos")]
        public IActionResult ObtenerProductos()
        {
            return Ok(_carrito.ObtenerTodosProductos());
        }
    }
}
