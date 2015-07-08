using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Estructura Switch
 * **/

namespace Programa17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teclee su usuario");
            string usuario = Console.ReadLine();

            switch (usuario)
            {
                case "Administrador":
                    Console.WriteLine("Bienvenido {0}",usuario);
                    break;
                case "Invitado":
                    Console.WriteLine("Bienvenido {0} recuerda que no tienes todos los permisos", usuario);
                    break;
                case "Cristo":
                    Console.WriteLine("Bienvenido {0}, gracias por visitar nuestra aplicación", usuario);
                    break;
                default:
                    Console.WriteLine("No existe el usuario...");
                    break;
            }
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
