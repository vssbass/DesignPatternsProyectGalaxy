using Microsoft.AspNetCore.Mvc;
using StrategyTipoEnvio.Services;

namespace PatronesDeComportamiento.Controllers
{
    [ApiController]
    [Route("apiStrategy/[controller]")]
    public class EnvioController : Controller
    {
      
        private readonly CostoEnvioService costoEnvioService;
        public EnvioController(CostoEnvioService costoEnvioService)
        {
            this.costoEnvioService = costoEnvioService;
        }

        [HttpPost]
        [Route("Envios")]
        public IActionResult Index([FromBody] decimal peso, string destino)
        {
            List<string> resultado = new List<string>();
            var tipoenvio = new CostoEnvioService(new EnvioAereo()); //costoEnvioService.SetEnvioStrategy(_envioStrategy);
            resultado.Add(tipoenvio.EjecutarEnvio(peso, destino.ToUpper()));

            tipoenvio.SetEnvioStrategy(new EnvioTerrestre());
            resultado.Add(tipoenvio.EjecutarEnvio(peso, destino.ToUpper()));

            tipoenvio.SetEnvioStrategy(new EnvioLocal());
            resultado.Add(tipoenvio.EjecutarEnvio(peso, destino.ToUpper()));


            return Ok(resultado);
        }
    }
}
