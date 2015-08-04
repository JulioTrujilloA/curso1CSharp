using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string miString = string.Format("{2} - ({3})", "3", "4", "5");

            Console.WriteLine(miString);
            Console.ReadKey();
        }
    }
}
