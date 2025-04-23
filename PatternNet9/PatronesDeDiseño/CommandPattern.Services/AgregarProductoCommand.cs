using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Services
{
    public class AgregarProductoCommand : ICommand
    {
        private readonly CarritoCompras _carritoCompras;
        private readonly Producto _producto;
        public AgregarProductoCommand(CarritoCompras carritoCompras, Producto producto)
        {
            _carritoCompras = carritoCompras;
            _producto = producto;
        }
        public string Execute()
        {
            return _carritoCompras.Agregar(_producto);
        }
        public string Undo()
        {
            return _carritoCompras.Eliminar(_producto);
        }
    }

}
