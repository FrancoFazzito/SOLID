using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_responsabilidad_unica_I
{
    class Empleado
    {
        //debe tener solo una razon para cambiar 
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }

        public Empleado(string nombre, string puesto, int edad, double sueldo)
        {
            this.nombre = nombre;
            this.puesto = puesto;
            this.edad = edad;
            this.sueldo = sueldo;
        }

        public override string ToString()
        {
            return $"{nombre} con puesto {puesto} y edad de {edad} con sueldo {sueldo}";
        }

        //RESPONSABILIDAD EMPLEADO
        public string ProyectoActual()
        {
            return "curso solid";
        }

        //RESPONSABILIDAD IMPUESTO
        //CLASE CON DOS RESPONSABILIDADES responsablidad impuestos y de emplead
        //private double CalcularImpuesto()
        //{
        //    return sueldo * 0.30;
        //}
        //public void PagarImpuesto()
        //{
        //    double imp = CalcularImpuesto();
        //    Console.WriteLine("se pago {0} de impuestos", imp);
        //}
    }
}
