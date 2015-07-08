using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa11
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesConContacto cliente = new clsClientesConContacto(0, "Matias Perez", "003", "MLH97SD9", 1, "Flores Torres", "555-473-541", "555-565-988", "jojo@gmail.com",
                                               "Concha Toro", "#455", "#4", "Col. LindaVista", "Ocotlán", "Veracruz", "48877");
            intSalidas Impresion;
            string cadena = Console.ReadLine();
            if (cadena == "1")
            {
                Impresion = new clsImpresion();
            }
            else
            {
                Impresion = new clsArchivos();
            }
            try
            {
                Console.WriteLine("Revisa tu directorio de archivos");
                Impresion.imprimeCliente(cliente);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrió un error: " + e.Message);
                Console.ReadKey();
            }
            
        }
    }
}
