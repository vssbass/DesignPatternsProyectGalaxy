using Microsoft.AspNetCore.Mvc;
using PrototypeContratosPattern;


namespace PatronesDeDiseño.Web.Controllers
{
    [ApiController]
    [Route("apiPrototype/[controller]")]
    public class PrototypeContrato : Controller
    {
        public readonly IContratoServices ContratoServices;

        public PrototypeContrato(IContratoServices contratoServices)
        {
            ContratoServices = contratoServices;
        }

        [HttpPost]
        [Route("Contrato")]
        public IActionResult Index([FromBody] int TipoDocumento, string NumeroDocumento, string NombresApellidos, string Direccion, string Telefono)
        {
            
            var resultado = ContratoServices.EjecutarPatron(TipoDocumento,NumeroDocumento, NombresApellidos, Direccion, Telefono);


            return Ok(resultado);
        }
    }
}
