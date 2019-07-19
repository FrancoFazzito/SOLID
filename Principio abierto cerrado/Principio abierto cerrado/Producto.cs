using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_abierto_cerrado
{
    class Producto
    {
        private string nombre;
        private int categoria;
        private double precio;

        public Producto(string nombre, int categoria, double precio)
        {
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.categoria = categoria;
            this.Precio = precio;
        }

        public double Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return $"{nombre} de categoria {categoria} con precio {Precio}";
        }
    }
}
