using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[4];
            string cadena;
            for (int i = 0; i < arreglo.Length; i++)
            {
                cadena = Console.ReadLine();
                arreglo[i] = Convert.ToInt32(cadena);
            }
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("{0}", arreglo[i]);
            }
            Console.ReadKey();
        }
    }
}
