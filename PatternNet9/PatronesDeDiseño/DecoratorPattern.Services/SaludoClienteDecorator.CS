using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Services
{
    public class SaludoClienteDecorator : ISaludo
    {
        private readonly ISaludo _saludoBase;
        public SaludoClienteDecorator(ISaludo saludoBase)
        {
            _saludoBase = saludoBase;
        }
        public string ObtenerSaludo(string nombre)
        {
            return $"{_saludoBase.ObtenerSaludo(nombre)}. Gracias por su preferencia.";
        }
    }
  
}
