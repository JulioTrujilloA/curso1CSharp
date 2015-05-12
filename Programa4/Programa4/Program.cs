using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa4
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0, valor2 = 0;
            string cadena;
            Console.WriteLine("Dame el primer valor: ");
            cadena = Console.ReadLine();
            valor1 = Convert.ToInt32(cadena);
            Console.WriteLine("Dame el segundo valor: ");
            cadena = Console.ReadLine();
            valor2 = Convert.ToInt32(cadena);

            if (valor1 <= valor2)
            {
                if (valor1 == valor2)
                {
                    Console.WriteLine("El primer valor es igual al segundo");
                }
                else
                {
                    Console.WriteLine("El segundo valor es mayor al primero");
                }
                
            }
            else
            {
                Console.WriteLine("El primer valor es mayor que el segundo valor");
            }
            Console.ReadKey();
        }
    }
}
