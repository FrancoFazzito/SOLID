using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_de_segregacion_de_interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            //ningun cliente debe ser forzado a depender de metodos que no usa
            //reduccion de codigo a la implementacion mas pequeña

            //problema -> exageracion de interfaces

            //interfaz de los objetos tendra los metodos que tiene que usar
            Console.WriteLine("IMPRESORA PROCESANDO");

            Impresora impresora = new Impresora();
            impresora.Imprimir();
            impresora.Escanear();

            Console.WriteLine("FAX PROCESANDO");

            Fax fax = new Fax();
            fax.Faxear();
            fax.Llamar();

            Console.WriteLine("MULTIFUNCION PROCESANDO");
            ImpresoraConFax impresoraConFax = new ImpresoraConFax();
            //uso interfaz de impresora
            impresoraConFax.Imprimir();
            impresoraConFax.Escanear();

            //uso interfaz de fax
            impresoraConFax.Faxear();
            impresoraConFax.Llamar();

            Console.ReadLine();
        }
    }
}
