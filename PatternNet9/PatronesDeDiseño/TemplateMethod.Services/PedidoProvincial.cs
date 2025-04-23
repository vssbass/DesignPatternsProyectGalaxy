using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Services
{
    public class PedidoProvincial : PedidoTemplate
    {
        protected override string EnviarPedido(string destino)
        {
            Console.WriteLine("Enviando pedido provincial...");
            return $"GUIA-PROV-{destino}-{Guid.NewGuid().ToString().Substring(0, 8)}";
        }
        protected override decimal ProcesarPago(string destino, decimal peso)
        {
            Console.WriteLine("Procesando pago del pedido provincial...");
            return peso * 0.8m;
        }
        protected override void ValidarDatos(string destino, decimal peso)
        {
            Console.WriteLine("Validando datos del pedido provincial...");
            if (string.IsNullOrWhiteSpace(destino))
                throw new ArgumentException("Debe ingresar el destino de envio!!!");
            if (destino == "LIMA")
                throw new ArgumentException("Destino no permitido para provincia");
            if (peso <= 0)
                throw new ArgumentException("Peso debe ser mayor a cero");
        }
    }
}
