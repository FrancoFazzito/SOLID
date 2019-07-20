using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_de_Inversión_de_Dependencia
{
    //SIN REFACTOR
    //class Auditor
    //{
    //    private Almacen almacen;

    //    //AUDITOR SOLO VA A PODER TRABAJAR CON ALMACENES
    //    //EN EL DIA DEL MAÑANA NECESITAMOS CONTENEDORES O BODEGAS 

    //    //CLASE DE ALTO NIVEL DEPENDE DE CLASE DE BAJO NIVEL
    //    public Auditor(Almacen almacen)
    //    {
    //        this.almacen = almacen ?? throw new ArgumentNullException(nameof(almacen));
    //    }

    //    public double GetTotal()
    //    {
    //        double total = 0;
    //        foreach (Producto producto in almacen.Productos)
    //        {
    //            Console.ForegroundColor = ConsoleColor.Yellow;
    //            Console.WriteLine(producto.ToString());
    //            total += producto.Costo;
    //        }
    //        return total;
    //    }
    //}
    class Auditor
    {
        private Iauditable almacen;
        public Auditor(Iauditable almacen) //AUDITARA TODO LO QUE SE DEBE AUDITAR
        {
            this.almacen = almacen;
        }

        public double GetTotal()
        {
            double total = 0;
            //ALMACEN DEBE EXPONER LA LISTA
            foreach (Producto auditado in almacen.GetProductos())
            {
                Console.WriteLine(auditado.ToString());
                total += auditado.Costo;
            }
            return total;
        }
    }
}
