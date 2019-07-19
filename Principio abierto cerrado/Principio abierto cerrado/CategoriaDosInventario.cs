using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_abierto_cerrado
{
    class CategoriaDosInventario : BaseInventario
    {
        public CategoriaDosInventario(Producto producto) : base(producto)
        {
        }

        public override double CalcularProducto()
        {
            producto.Precio *= 0.8;
            return producto.Precio;
        }
    }
}
