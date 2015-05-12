using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables y tipos de datos

            int i = 0;
            decimal d = 0.0m;
            float f = 0.0f;
            double db = 0.0d;
            string s = "Julio";
            bool bl = true;
            DateTime fecha = DateTime.MinValue;

            Console.WriteLine("Valor de i: {0}", i);
            Console.WriteLine("Valor de d: {0:C}", d);
            Console.WriteLine("Valor de f: {0:F3}", f);
            Console.WriteLine("Valor de db: {0:F2}", db);
            Console.WriteLine("Valor de c: " + s);
            Console.WriteLine("Valor de bl: "+ bl.ToString());
            Console.WriteLine("Valor de fecha: " + fecha.ToShortDateString());
            Console.ReadKey();
        }
    }
}
