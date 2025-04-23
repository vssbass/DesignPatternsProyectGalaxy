using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Services
{
    public class GeneradorReportes : IGeneradorReporte
    {
        public byte[] GenerarReporte(int reporteId)
        {
            
            Console.WriteLine($"Generando reporte con ID: {reporteId} En ejecución..........");
            Thread.Sleep(3000);
            return Encoding.UTF8.GetBytes($"Contenido del reporte {reporteId}");
        }
    }
}
