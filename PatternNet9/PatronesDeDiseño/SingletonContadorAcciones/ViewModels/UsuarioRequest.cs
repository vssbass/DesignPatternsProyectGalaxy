namespace PatronesDeDiseño.Web.ViewModels
{
    public class UsuarioRequest
    {
        public int Edad { get; set; }
        public string Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Rol { get; set; }
        public bool Estado { get; set; }
    }
}
