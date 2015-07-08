using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa7
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesVentas Cliente;
            Cliente = new clsClientesVentas();
            Cliente.IdCliente = 123;
            Cliente.Apellidos = "Flores Segura";
            Cliente.Nombres = "Marco Luis";
            Cliente.RFC = "HDFS98SFH";
            Cliente.Direccion = "Las Lomas #44";
            Cliente.Colonia = "Col. Jaguar";
            Cliente.Municipio = "Guanatos";
            Cliente.EsCredito = true;
            Console.WriteLine(Cliente.Apellidos + " " + Cliente.Nombres);
            Console.WriteLine(Cliente.Direccion + " " + Cliente.Colonia + " "+ Cliente.Municipio);
            Console.WriteLine(Cliente.RFC);
            if (Cliente.EsCredito)
            {
                Console.WriteLine("El cliente tiene un crédito");
            }
            else
            {
                Console.WriteLine("El cliente NO tiene un crédito");    
            }
            Console.ReadKey();
        }
    }
}

