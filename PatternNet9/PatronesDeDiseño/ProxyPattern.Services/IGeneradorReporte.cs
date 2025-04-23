namespace ProxyPattern.Services
{
    public interface IGeneradorReporte
    {
        byte[] GenerarReporte(int reporteId);
    }
}
