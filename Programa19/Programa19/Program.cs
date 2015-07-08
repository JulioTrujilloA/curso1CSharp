using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Realice un programa que lea 5 números ingresados por el teclado, calcule el factorial
 * de cada número y lo muestre en pantalla, además debe mostrar la suma de los
 * factoriales de los 5 números ingresados.
 * **/
namespace Programa19
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, numero4, numero5, fac1, fac2, fac3, fac4, fac5;

            Console.Write("Ingresa el número 1: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el número 2: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el número 3: ");
            numero3 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el número 4: ");
            numero4 = int.Parse(Console.ReadLine());
            Console.Write("Ingresa el número 5: ");
            numero5 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            fac1 = factorial(numero1);
            fac2 = factorial(numero2);
            fac3 = factorial(numero3);
            fac4 = factorial(numero4);
            fac5 = factorial(numero5);

            int sumaFac = fac1 + fac2 + fac3 + fac4 + fac5;

            Console.WriteLine("Factorial de {0} es {1}", numero1, factorial(numero1));
            Console.WriteLine("Factorial de {0} es {1}", numero2, factorial(numero2));
            Console.WriteLine("Factorial de {0} es {1}", numero3, factorial(numero3));
            Console.WriteLine("Factorial de {0} es {1}", numero4, factorial(numero4));
            Console.WriteLine("Factorial de {0} es {1}", numero5, factorial(numero5));
            Console.WriteLine();
            Console.WriteLine("La suma de los factoriales es: {0}", sumaFac);
            Console.ReadKey();
        }

        public static int factorial(int num)
        {
            int aux = 1;
            if (num == 1 || num == 0)
            {
                return 1;
            }
            else
            {
                while (num > 0)
                {
                    aux = aux * num;
                    num--;
                }
            }
            return aux;
        }
    }
}
