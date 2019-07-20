using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_de_Inversión_de_Dependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //ELIMINAR DEPENDENCIA ENTRE CLASES DE ALTO NIVEL CON CLASES DE BAJO NIVEL
            Almacen almacen = new Almacen();

            almacen.addProducto(new Producto("banana", 0, 123));
            almacen.addProducto(new Producto("manzana", 0, 150));
            almacen.addProducto (new Producto("mouse", 0, 300));

            Auditor auditor = new Auditor(almacen);
            Console.WriteLine( $"el total es {auditor.GetTotal()}");
            Console.ReadLine();
        }
    }
}
