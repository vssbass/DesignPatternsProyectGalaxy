using Microsoft.AspNetCore.Mvc;
using TemplateMethod.Services;

namespace PatronesDeComportamiento.Controllers
{
    [ApiController]
    [Route("apiTemplateMethod/[controller]")]
    public class PedidosController : Controller
    {
        [HttpPost]
        [Route("template")]
        public IActionResult Index([FromBody] PedidoRequest pedidoRequest)
        {
            PedidoTemplate pedido;

            if (pedidoRequest.Tipo.ToUpper().Equals("LOCAL", StringComparison.OrdinalIgnoreCase))
            {
                pedido = new PedidoLocal();
            }
            else if (pedidoRequest.Tipo.ToUpper().Equals("PROVINCIA", StringComparison.OrdinalIgnoreCase))
            {
                pedido = new PedidoProvincial();
            }
            else
            {
                return BadRequest("Tipo de pedido no válido.");
            }
            try
            {
                var resultado = pedido.RealizarPedido(pedidoRequest.Destino.ToUpper(), pedidoRequest.Peso);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
    }

    public class PedidoRequest
    {
        public string Tipo { get; set; }
        public string Destino { get; set; }
        public decimal Peso { get; set; }
    }
}
