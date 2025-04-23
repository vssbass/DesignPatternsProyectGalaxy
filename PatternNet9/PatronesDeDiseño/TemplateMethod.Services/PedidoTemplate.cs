namespace TemplateMethod.Services
{
    public abstract class PedidoTemplate
    {
        //public string NombreCliente { get; set; }
        //public string DireccionEnvio { get; set; }
        //public string MetodoPago { get; set; }
        public string RealizarPedido(string destino, decimal peso)
        {
            ValidarDatos(destino, peso);
            var costo = ProcesarPago(destino, peso);
            var guia = EnviarPedido(destino);
            return $"Costo Envío Pedido: S/. {costo} | {guia}";
           
        }
        protected abstract void ValidarDatos(string destino, decimal peso);
        protected abstract decimal ProcesarPago(string destino, decimal peso);
        protected abstract string EnviarPedido(string destino);
    }
 
}
