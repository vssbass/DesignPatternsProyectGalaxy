using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Services
{
    public class PedidoLocal : PedidoTemplate
    {
        protected override string EnviarPedido(string destino)
        {
            Console.WriteLine("Enviando pedido local...");
            return $"GUIA-LOCAL-{destino}-{Guid.NewGuid().ToString().Substring(0, 8)}";
        }
        protected override decimal ProcesarPago(string destino, decimal peso)
        {
            Console.WriteLine("Procesando pago del pedido local...");
            return peso * 0.5m;
        }
        protected override void ValidarDatos(string destino, decimal peso)
        {
            Console.WriteLine("Validando datos del pedido local...");
            if (string.IsNullOrWhiteSpace(destino))
                throw new ArgumentException("Debe ingresar el destino de envio!!!");
            if (destino != "LIMA")
                throw new ArgumentException("Destino no permitido para provincia");
            if (peso <= 0)
                throw new ArgumentException("El Peso debe ser mayor a cero");

        }
    }
}
