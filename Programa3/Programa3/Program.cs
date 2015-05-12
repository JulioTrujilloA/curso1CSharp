using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversiones implicitas. Conversiones de tipo. Casting.

            int i = 10;
            decimal flotante = 12.2m;
            bool bandera = true;
            string cadena = "45223";
            DateTime fecha = DateTime.MinValue;
            i = Convert.ToInt32(cadena);

            Console.WriteLine("Valor de i es: {0}",i);
            Console.WriteLine("Valor de flotante es: {0:C}",flotante);
            Console.WriteLine("Valor de bandera es: "+bandera.ToString());
            Console.WriteLine("Valor de cadena es: "+cadena);
            Console.WriteLine("Valor de fecha es: "+fecha.ToShortDateString());
            Console.ReadKey();
        }
    }
}
