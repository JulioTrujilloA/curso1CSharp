using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa13
{
    class Program
    {
        static void Main(string[] args)
        {
            clsMatrices Matriz;
            Matriz = new clsMatrices();

            Matriz.inicializaMatriz();
            Matriz.imprimeMatriz();
        }
    }
}
