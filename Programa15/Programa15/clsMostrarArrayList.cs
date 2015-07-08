using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa15
{
    public class clsMostrarArrayList
    {
        ArrayList lista;

        public clsMostrarArrayList()
        {
            lista = new ArrayList();
        }

        public void capturaDatos()
        {
            string cadena;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Escribe el dato {0}: ", i + 1);
                cadena = Console.ReadLine();
                lista.Add(cadena);
            }
            lista.Add(1);
            lista.Add(2);
        }

        public void imprimeDatos()
        {
            Console.WriteLine("Aquí están los datos: ");
            foreach (string elemento in lista)
            {
                Console.WriteLine(elemento);
            }
            Console.ReadKey();
        }
    }
}
