using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Services
{
    public class CarritoCompras
    {
        public List<Producto> Productos { get; } = new();

        public string Agregar(Producto producto)
        {
            Productos.Add(producto);
            return $"Producto '{producto.Nombre}' agregado.";
        }

        public string Eliminar(Producto producto)
        {
            Productos.Remove(producto);
            return $"Producto '{producto.Nombre}' eliminado.";
        }

        public List<Producto> ObtenerTodosProductos() => Productos;
    }
}
