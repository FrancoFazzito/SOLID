using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_de_Inversión_de_Dependencia
{
    class Producto
    {
        private string nombre;
        private int tipo;
        private double costo;

        public Producto(string nombre, int tipo, double costo)
        {
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.tipo = tipo;
            this.costo = costo;
        }

        public string Nombre { get => nombre;}
        public int Tipo { get => tipo;}
        public double Costo { get => costo; }

        public override string ToString()
        {
            return $"{nombre} de tipo {tipo} y costo de {costo}";
        }
    }
}
