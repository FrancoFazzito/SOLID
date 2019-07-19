using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_abierto_cerrado
{
    abstract class BaseInventario
    {
         protected Producto producto;

        public BaseInventario(Producto producto)
        {
            this.producto = producto ?? throw new ArgumentNullException(nameof(producto));
        }

        public override string ToString()
        {
            return producto.ToString();
        }

        public abstract double CalcularProducto();
    }
}
