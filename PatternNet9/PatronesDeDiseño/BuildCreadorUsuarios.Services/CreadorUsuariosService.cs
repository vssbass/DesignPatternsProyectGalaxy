using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildCreadorUsuarios.Services
{
    public class CreadorUsuariosService
    {
        public int Edad { get; set; }
        public string Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string Rol { get; set; }
        public bool Estado { get; set; }
        public CreadorUsuariosService(int edad, string nombres, string? apellidos, string rol, bool estado)
        {
            Edad = edad;
            Nombres = nombres;
            Apellidos = apellidos;
            Rol = rol;
            Estado = estado;
        }
        public void CreateUser()
        {
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Rol: {Rol}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"Usuario creado con éxito");
        }
    }
}
