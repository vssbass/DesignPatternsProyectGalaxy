using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SingletonContadorAcciones.Services
{
    public sealed class ContadorAccionesService
    {
        private int contadorVisitas = 0;
        private static ContadorAccionesService _instance;
        private static List<string> _acciones = [];
        private static readonly object _lockInstance = new();

        public ContadorAccionesService()
        {
        }

        public static ContadorAccionesService GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockInstance)
                {
                    if (_instance == null)
                    {
                        _instance = new ContadorAccionesService();
                        _acciones.Add($"Creando una nueva instancia de ContadorAccionesService: {DateTime.UtcNow}");
                        Console.WriteLine($"Creando una nueva instancia de ContadorAccionesService: {DateTime.UtcNow}");
                    }
                }
            }
            Console.WriteLine($"Retornando la instancia de ContadorAccionesService: {DateTime.UtcNow}");
            _acciones.Add($"Retornando la instancia de ContadorAccionesService: {DateTime.UtcNow}");
            return _instance;
        }
        public int ContadorVisitas
        {
            get
            {
                lock (_lockInstance)
                {
                    return contadorVisitas;
                }
            }
        }

        public List<string> Acciones
        {
            get
            {
                lock (_lockInstance)
                {
                    return _acciones;
                }
            }
        }
        public void IncrementarContador()
        {
            lock (_lockInstance)
            {
                contadorVisitas++;
            }
        }
    }
}
