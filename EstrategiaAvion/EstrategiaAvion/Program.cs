using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrategiaAvion
{
    class Program
    {
        static void Main(string[] args)
        {
            AvionComercial avionComercial = new AvionComercial();
            AvionRapido avionRapido = new AvionRapido();

            Console.WriteLine("Primero el avión comercial:");
            avionComercial.setAlgorimo(new EnTierra());
            avionComercial.mover();
            avionComercial.setAlgorimo(new EnAire());
            avionComercial.mover();
            Console.WriteLine();

            Console.WriteLine("Ahora el avión rápido:");
            avionRapido.setAlgorimo(new EnTierra());
            avionRapido.mover();
            avionRapido.setAlgorimo(new EnAireVeloz());
            avionRapido.mover();
            Console.WriteLine();

            Console.WriteLine("El avión comercial veloz...");
            avionComercial.setAlgorimo(new EnAireVeloz());
            avionComercial.mover();

            Console.ReadKey();

        }
    }
}
