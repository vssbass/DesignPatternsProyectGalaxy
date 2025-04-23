namespace StrategyTipoEnvio.Services
{
    public interface IEnvioStrategy
    {
        string MetodoEnvio { get; }
        string CalcularTipoEnvio(decimal peso, string destino);
    }
}
