using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_abierto_cerrado
{
    class Program
    {
        static void Main(string[] args)
        {
            //clases y metodos deben estar 
            //abiertos para extension
            //cerrados para modificacion

            //las clases tiene que extender comportamiento y el codigo ya hecho no se debe tocar 
            //List<Producto> productos = new List<Producto>
            //{
            //    new Producto("papas",2,100),
            //    new Producto("tomate",1,300),
            //    new Producto("lechuga",2,1100),
            //    new Producto("milanesa",1,500),
            //    new Producto("fideos",2,1000)
            //};
            //Tienda tienda = new Tienda(productos);

            List<BaseInventario> inventario = new List<BaseInventario>
            {
                new CategoriaDosInventario(new Producto("papas",2,100)),
                new CategoriaUnoInventario(new Producto("tomate",1,110)),
                new CategoriaDosInventario(new Producto("lechuga",2,120)),
                new CategoriaUnoInventario(new Producto("milanesa",1,130)),
                new CategoriaDosInventario(new Producto("fideos",2,140))
            };
            Tienda tienda = new Tienda(inventario);
            Console.WriteLine(tienda.GetTotal());
            Console.ReadLine();

            //puedo agregar extension de forma sencilla 
            //agregar una nueva clase heredando del baseinventario

        }
    }
}
