using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Services
{
    public class SaludoGerenteDecorator : ISaludo
    {
        private readonly ISaludo _saludoBase;
        public SaludoGerenteDecorator(ISaludo saludoBase)
        {
            _saludoBase = saludoBase;
        }
        public string ObtenerSaludo(string nombre)
        {
            return $"{_saludoBase.ObtenerSaludo(nombre)}. Gracias por liderar la Gerencia de TI.";
        }
    }
 
}
