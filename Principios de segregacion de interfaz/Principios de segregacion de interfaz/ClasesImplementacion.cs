using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_de_segregacion_de_interfaz
{
    class Impresora : Iimpresora //IMPLEMENTARA SOLO LOS METODOS DE IMPRESORA
    {
        public void Escanear()
        {
            Console.WriteLine("SCAN");
        }

        public void Imprimir()
        {
            Console.WriteLine("IMPRIMIR");
        }
    }

    class Fax : Ifax //IMPLEMENTARA SOLO LOS METODOS DE FAX
    {
        public void Faxear()
        {
            Console.WriteLine("FAXEAR");
        }

        public void Llamar()
        {
            Console.WriteLine("LLAMAR");
        }
    }

    class ImpresoraConFax : Imultifuncion  //INTERFAZ MULTIFUNCION IMPLEMENTACION IFAX E IIMPRESORA OBTENIENDO LAS DOS FUNCIONALIDADES
    {
        public void Escanear()
        {
            Console.WriteLine("SCAN");
        }

        public void Faxear()
        {
            Console.WriteLine("FAXEAR");
        }

        public void Imprimir()
        {
            Console.WriteLine("IMPRIMIR");
        }

        public void Llamar()
        {
            Console.WriteLine("LLAMAR");
        }
    }
}
