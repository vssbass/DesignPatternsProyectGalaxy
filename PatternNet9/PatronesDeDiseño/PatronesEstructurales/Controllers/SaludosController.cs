using DecoratorPattern.Services;
using Microsoft.AspNetCore.Mvc;

namespace PatronesEstructurales.Controllers
{
    [ApiController]
    [Route("apiDecorator/[controller]")]
    public class SaludosController : Controller
    {
        [HttpGet("{nombre}")]
        public IActionResult Saludar(string nombre, [FromQuery] string rol)
        {
            ISaludo saludo = new SaludoBase();

            // Aplicar decorador según el rol
            switch (rol?.ToLower())
            {
                case "gerente":
                    saludo = new SaludoGerenteDecorator(saludo);
                    break;
                case "cliente":
                    saludo = new SaludoClienteDecorator(saludo);
                    break;
                
                default:
                    break; // Saludo básico
            }

            var mensaje = saludo.ObtenerSaludo(nombre);
            return Ok(mensaje);
        }
    }
}
