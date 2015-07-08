using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa8
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClienteBase cliente = new clsClienteBase(0,"Matias Perez",
                                                        "003",
                                                        "MLH97SD9",
                                                        1,"Flores Torres");
            Console.WriteLine(cliente.Clave +" "+cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();

        }
    }
}
