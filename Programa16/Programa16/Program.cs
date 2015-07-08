using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Realice una aplicación que permita introducir el nombre y salario de 3 trabajadores
 * y muestre el promedio salarial de estos.
 * */

namespace Programa16
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre1, nombre2, nombre3;
            double salario1, salario2, salario3, promedio;

            Console.WriteLine("***Promedio salarial***");

            // Pedimos nombre de trabajador y su salario
            Console.Write("Teclea el nombre de tu trabajador: ");
            nombre1 = Console.ReadLine();
            Console.Write("Teclea el salario del trabajador {0}: ", nombre1);
            salario1 = double.Parse(Console.ReadLine());
            Console.Write("Teclea el nombre de tu trabajador: ");
            nombre2 = Console.ReadLine();
            Console.Write("Teclea el salario del trabajador {0}: ", nombre2);
            salario2 = double.Parse(Console.ReadLine());
            Console.Write("Teclea el nombre de tu trabajador: ");
            nombre3 = Console.ReadLine();
            Console.Write("Teclea el salario del trabajador {0}: ", nombre3);
            salario3 = double.Parse(Console.ReadLine());

            // Hacemos el promedio del salario de los trabajadores
            promedio = (salario1 + salario2 + salario3)/3;

            Console.WriteLine("El promedio salarial de los tres trabajadores es: ${0}",promedio);
            Console.ReadKey();
        }
    }
}
