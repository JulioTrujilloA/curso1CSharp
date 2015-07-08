using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Cómo usar Break o Continue
 * **/
namespace Programa18
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = "";
            string pass = "";

            while ((user != "Administrador") && pass != "admin")
            {
                Console.WriteLine("Introduce tu nombre de usuario");
                user = Console.ReadLine();
                if (user == "Administrador")
                {
                    Console.WriteLine("Introduce tu contraseña");
                    pass = Console.ReadLine();
                    continue;
                }
                if (user=="Invitado")
                {
                    break;
                }
            }

            Console.WriteLine("Bienvenido {0}",user);
            Console.ReadKey();
        }
    }
}
