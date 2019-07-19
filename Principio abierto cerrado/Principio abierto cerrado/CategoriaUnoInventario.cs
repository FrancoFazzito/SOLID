using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_abierto_cerrado
{
    class CategoriaUnoInventario : BaseInventario
    {
        public CategoriaUnoInventario(Producto producto) : base(producto)
        {
        }
        public override double CalcularProducto()
        {
            return producto.Precio;
        }
    }
}
