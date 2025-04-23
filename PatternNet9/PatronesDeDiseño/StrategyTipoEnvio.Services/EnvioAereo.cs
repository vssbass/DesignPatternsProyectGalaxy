using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTipoEnvio.Services
{
    public class EnvioAereo : IEnvioStrategy
    {

        public string MetodoEnvio => "Aereo";
        public string CalcularTipoEnvio(decimal peso, string destino)
        {
            //costo por pais
            decimal valorfinal = 0; 

            switch (destino)
            {
                case "USA":
                    valorfinal = peso * 10m;
                    break;
                case "EUROPA":
                    valorfinal = peso * 20m;
                    break;
                case "ASIA":
                    valorfinal = peso * 30m;
                    break;
                        
                default:
                    valorfinal = peso;
                    break;
            }
            
            return $"El costo de envío del paquete via aerea para {destino} es : {valorfinal} USD";
        }
    }
}
