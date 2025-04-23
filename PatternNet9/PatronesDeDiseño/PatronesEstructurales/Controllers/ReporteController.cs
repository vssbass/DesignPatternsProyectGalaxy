using Microsoft.AspNetCore.Mvc;
using ProxyPattern.Services;

namespace PatronesEstructurales.Controllers
{
    [ApiController]
    [Route("apiReporte/[controller]")]
    public class ReporteController : Controller
    {
        private readonly IGeneradorReporte _generador;

        public ReporteController()
        {
            _generador = new GeneradorReporteProxy(new GeneradorReportes());
        }

        [HttpGet("{id}")]
        public IActionResult GenerarReporte(int id)
        {
            var reporteBytes = _generador.GenerarReporte(id);
            return File(reporteBytes, "application/pdf", $"reporte_{id}.txt");
        }
    }
}
