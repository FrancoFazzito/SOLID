using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_de_Inversión_de_Dependencia
{
    //SIN REFACTOR
    //class Almacen
    //{
    //    private List<Producto> productos;
    //    public Almacen(List<Producto> productos)
    //    {
    //        this.productos = productos ?? throw new ArgumentNullException(nameof(productos));
    //    }
    //    public List<Producto> Productos { get => productos;}
    //    public void addProducto(Producto producto)
    //    {
    //        productos.Add(producto);
    //    }
    //}

    class Almacen : Iauditable
    {
        private List<Producto> productos;

        public Almacen()
        {
            this.productos = new List<Producto>();
        }

        public void addProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public IEnumerable<Producto> GetProductos()
        {
            return this.productos;
        }
    }
}
