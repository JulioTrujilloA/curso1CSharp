using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa6
{
    class Program
    {
        static void Main(string[] args)
        {
            clsEmpleados empleado;
            empleado = new clsEmpleados();

            empleado.Edad = 34;
            empleado.Nombre = "Daniel Rentería";
            empleado.SueldoDiario = 12.5m;
            decimal total;
            total = empleado.CalculaSalario(30);
            Console.WriteLine("El salario mensual de: " + empleado.Nombre);
            Console.WriteLine(" es: " + total.ToString("C"));
            Console.ReadKey();
        }
    }
}
