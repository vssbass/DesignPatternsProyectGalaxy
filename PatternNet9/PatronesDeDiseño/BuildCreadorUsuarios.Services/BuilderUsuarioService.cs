using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildCreadorUsuarios.Services
{
    public class BuilderUsuarioService
    {
        private int _edad;
        private string _nombres;
        private string? _apellidos;
        private string _rol = "Demo";
        private bool _estado = false;

        public BuilderUsuarioService WithAge(int edad)
        {
            _edad = edad > 18 ? edad : throw new ArgumentException("La edad debe ser mayor a 18");
            return this;
        }

        public BuilderUsuarioService WithNames(string nombres)
        {
            if(string.IsNullOrEmpty(nombres)) throw new ArgumentException("El nombre no puede estar vacío");
            _nombres = nombres;
            return this;
        }

        public BuilderUsuarioService WithLastName(string apellidos)
        {
            _apellidos = apellidos;
            return this;
        }
        public BuilderUsuarioService WithRole(string rol)
        {
            _rol = rol;
            return this;
        }
        public BuilderUsuarioService WithEstate()
        {
            _estado = true;
            return this;
        }

        public CreadorUsuariosService Build()
        {
            return new CreadorUsuariosService
            (
                _edad,
                _nombres,
                _apellidos,
                _rol,
                _estado
            );
        }

    }
}
