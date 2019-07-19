using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_abierto_cerrado
{
    class Tienda
    {
        private List<BaseInventario> productos = new List<BaseInventario>();

        public Tienda(List<BaseInventario> productos)
        {
            this.productos = productos;
        }

        //ejemplo: en el caso de que tengamos un cambio en los requerimientos de como se contabiliza el total de productos 
        //haremos uso de ABIERTO-CERRADO
        public double GetTotal()
        {
            double total = 0;
            foreach (var item in this.productos)
            {
                total += item.CalcularProducto();
            }
            return total;
        }
        //adicion de clases un abstract para implementar el calculo uno para categoria 1 y otra pra categoria 2
    }
}
