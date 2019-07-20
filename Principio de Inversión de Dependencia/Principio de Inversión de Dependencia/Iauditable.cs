using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_de_Inversión_de_Dependencia
{
    interface Iauditable
    {
        IEnumerable<Producto> GetProductos();
    }
}
