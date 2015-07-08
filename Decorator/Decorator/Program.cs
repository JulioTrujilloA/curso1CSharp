using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer gammerPC = new BaseComputer();
            gammerPC = new FastSSD(gammerPC);
            gammerPC = new BigProcessor(gammerPC);

            var cost = gammerPC.CalculateCost();

            Console.WriteLine(string.Format("El costo del Gammer PC es de {0} euros.",cost));
            Console.ReadKey();
        }
    }
}
