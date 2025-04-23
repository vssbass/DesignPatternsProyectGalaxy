using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTipoEnvio.Services
{
    public class EnvioLocal : IEnvioStrategy
    {
        public string MetodoEnvio => "Local";
        public string CalcularTipoEnvio(decimal peso, string destino)
        {
            return $"El costo de envío del paquete local es : S/. {peso * 0.5m}";
        }
    }
}
