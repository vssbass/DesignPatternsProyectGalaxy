using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Services
{
    public class GeneradorReporteProxy : IGeneradorReporte
    {
        private readonly IGeneradorReporte _report;
        private readonly Dictionary<int, byte[]> _cache = new();

        public GeneradorReporteProxy(IGeneradorReporte report)
        {
            _report = report;
        }
        public byte[] GenerarReporte(int reporteId)
        {
            if (_cache.ContainsKey(reporteId))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Obteniendo reporte #{reporteId} desde caché...");
                Console.ResetColor();
                return _cache[reporteId];
            }

            var pdf = _report.GenerarReporte(reporteId);
            _cache[reporteId] = pdf;
            return pdf;
        }
    }
}
