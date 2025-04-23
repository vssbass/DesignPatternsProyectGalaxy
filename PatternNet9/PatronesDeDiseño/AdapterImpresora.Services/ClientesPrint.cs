using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterImpresora.Services
{
    public class ClientesPrint
    {
        private readonly IImpresora _impresora;
        public ClientesPrint(IImpresora impresora)
        {
            _impresora = impresora;
        }
        public string Imprimir(string mensaje)
        {
            return _impresora.Imprimir(mensaje);
        }
    }
}
