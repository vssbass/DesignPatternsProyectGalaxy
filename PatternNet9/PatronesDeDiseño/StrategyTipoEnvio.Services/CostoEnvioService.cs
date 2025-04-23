using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTipoEnvio.Services
{
    public class CostoEnvioService
    {
        private IEnvioStrategy _envioStrategy;

        public CostoEnvioService(IEnvioStrategy envioStrategy)
        {
            _envioStrategy = envioStrategy;
        }

        public void SetEnvioStrategy(IEnvioStrategy envioStrategy)
        {
            _envioStrategy = envioStrategy;
            //return $"El costo de envío del paquete via {_envioStrategy.MetodoEnvio} es : {_envioStrategy.CalcularTipoEnvio(10)}";
        }

        public string EjecutarEnvio(decimal peso, string destino)
        {
            return _envioStrategy.CalcularTipoEnvio(peso, destino);
        }
    }
}
