using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterImpresora.Services
{
    public class ImpresoraNikon
    {
        public string ImprimirTextos(string text)
        {
            return $"[Impresora Nikon 990]: {text}";
        }
    }
}
