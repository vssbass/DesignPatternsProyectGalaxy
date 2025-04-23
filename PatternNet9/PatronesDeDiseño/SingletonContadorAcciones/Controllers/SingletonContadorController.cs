using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SingletonContadorAcciones.Services;

namespace SingletonContadorAcciones.Controllers
{
    [ApiController]
    [Route("apiThreadSingleton/[controller]")]
    public class SingletonContadorController : Controller
    {
        private readonly ContadorAccionesService _contadorAccionesService;

        public SingletonContadorController(ContadorAccionesService contadorAccionesService)
        {
            _contadorAccionesService = contadorAccionesService;
        }
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            
            ContadorAccionesService.GetInstance();
            _contadorAccionesService.IncrementarContador();
            return Ok("Bienvenido a mi Página!!!");

        }

        [HttpGet]
        [Route("VisitasCount")]
        public IActionResult Obtener()
        {
            ContadorAccionesService.GetInstance();
            int valor = _contadorAccionesService.ContadorVisitas;
            List<String> valorAcciones = _contadorAccionesService.Acciones;
            return Ok(
                new 
                {
                    CantidadVisitas = valor,
                    Instancias = valorAcciones,
                }
            );
        }
    }
}
