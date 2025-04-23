using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterImpresora.Services
{
    public class ImpresoranikonAdapter : IImpresora
    {
        private readonly ImpresoraNikon _impresoraNikon;
        public ImpresoranikonAdapter(ImpresoraNikon impresoraNikon)
        {
            _impresoraNikon = impresoraNikon;
        }
        public string Imprimir(string mensaje)
        {
            return _impresoraNikon.ImprimirTextos(mensaje);
        }
    }
}
