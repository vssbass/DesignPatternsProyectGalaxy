using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTipoEnvio.Services
{
    public class EnvioTerrestre : IEnvioStrategy
    {
        public string MetodoEnvio => "Terrestre";
        public string CalcularTipoEnvio(decimal peso, string destino)
        {
            return $"El costo de envío del paquete via terreste es : S/. {peso * 0.8m}";
        }
    }
}
