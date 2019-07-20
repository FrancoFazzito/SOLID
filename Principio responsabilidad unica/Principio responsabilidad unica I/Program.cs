using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_responsabilidad_unica_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("juan", "programador java", 19, 100000);
            //empleado.PagarImpuesto(); //SIN REFACTOR

            Console.WriteLine(empleado);
            Hacienda.PagarImpuesto(empleado);

            Console.ReadLine();
            //mayor facilidad de extensibilidad
        }
    }
}
