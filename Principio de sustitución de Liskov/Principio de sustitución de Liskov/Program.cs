using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_de_sustitución_de_Liskov
{
    class Program
    {
        private const string MENSAJE_A_MOSTRAR = "HOLA A TODOS";

        static void Main(string[] args)
        {
            //objetos de clases hijas pueden reemplazar a las clases padres sin problemas
            //garantiza el uso correcto del polimorfismo

            //Noticiero noticiero = new Noticiero(MENSAJE_A_MOSTRAR);
            //noticiero.muestra();

            //Radio radio = new Radio(MENSAJE_A_MOSTRAR);
            //radio.muestra();

            //Noticiero sustitucion = new Radio(MENSAJE_A_MOSTRAR); //ACA SE MUESTRA EL COMPORTAMIENTO ERRONEO LOGICO
            //sustitucion.muestra();

            //PODREMOS UTILIZAR -> VIRTUAL PADRE Y OVERRIDE EN HIJA (UTILIZA COMPORTAMIENTO DE LA HIJA)
            //PROBLEMA DE DISEÑO -> CUANDO HACEMOS OVERRIDE ESTAMOS PERDIENDO EL COMPORTAMIENTO DE LA CLASE PADRE

            //PARA ESTO ENTRA LA SUSTITUCION DE LISKOV

            Principal noticiero = new Noticiero(MENSAJE_A_MOSTRAR);
            noticiero.muestra();

            Principal radio = new Radio(MENSAJE_A_MOSTRAR);
            radio.muestra();


            Console.ReadLine();
        }
    }
}
