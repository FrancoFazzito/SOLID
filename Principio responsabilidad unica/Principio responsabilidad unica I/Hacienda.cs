using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_responsabilidad_unica_I
{
    class Hacienda //SE USARA HACIENDA PARA LA RESPONSABILIDAD DE IMPUESTOS 
    {
        private static double CalcularImpuesto(Empleado empleado)
        {
            return empleado.Sueldo * 0.30;
        }
        public static void PagarImpuesto(Empleado empleado)
        {
            double imp = CalcularImpuesto(empleado);
            Console.WriteLine("se pago {0} de impuestos", imp);
        }
    }
}
