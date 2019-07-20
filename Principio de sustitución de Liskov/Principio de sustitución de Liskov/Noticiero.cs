using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_de_sustitución_de_Liskov
{
    abstract class Principal
    {
       protected string mensaje;

        public Principal(string mensaje)
        {
            this.mensaje = mensaje ?? throw new ArgumentNullException(nameof(mensaje));
        }

        public abstract void muestra();
        //public void muestra()
        //{
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine($"noticiero: {mensaje}");
        //}
        //public virtual void muestra()
        //{
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine($"noticiero: {mensaje}");
        //}
    }
    class Noticiero : Principal
    {
        public Noticiero(string mensaje) : base(mensaje)
        {
        }

        public override void muestra()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"noticiero: {mensaje}");
        }
    }
    class Radio : Principal
    {
        public Radio(string mensaje) : base(mensaje)
        {
        }

        public override void muestra()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"radio: {mensaje}");
        }

        //reemplazo de muestra de clase padre
        //public new void muestra()
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine($"radio: {mensaje}");
        //}
        //public override void muestra()
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine($"radio: {mensaje}");
        //}
    }
}
