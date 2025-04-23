using AdapterImpresora.Services;
using Microsoft.AspNetCore.Mvc;

namespace PatronesEstructurales.Controllers
{
    [ApiController]
    [Route("apiAdapter/[controller]")]
    public class ImpresoraController : Controller
    {

        [HttpPost("imprimir")]
        public IActionResult ImprimirMensaje([FromBody] string mensaje)
        {
            var impresoranikon = new ImpresoraNikon();
            IImpresora impresoraAdaptada = new ImpresoranikonAdapter(impresoranikon);

            var result = impresoraAdaptada.Imprimir(mensaje);

            return Ok(result);
        }
    }
}
