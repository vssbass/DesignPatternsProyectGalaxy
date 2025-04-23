using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Services
{
    public class Invoker
    {
        private readonly Stack<ICommand> _historial = new();

        public string Ejecutar(ICommand comando)
        {
            var resultado = comando.Execute();
            _historial.Push(comando);
            return resultado;
        }

        public string Deshacer()
        {
            if (_historial.Count == 0)
                return "No hay acciones para deshacer.";

            var comando = _historial.Pop();
            return comando.Undo();
        }
    }
}
