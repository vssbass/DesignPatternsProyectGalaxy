using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Services
{
    public class SaludoBase : ISaludo
    {
        public string ObtenerSaludo(string nombre)
        {
            return $"Hola {nombre}";
        }
    }
}
