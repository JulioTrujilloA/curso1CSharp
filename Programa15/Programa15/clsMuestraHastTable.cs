using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa15
{
    public class clsMuestraHastTable
    {
        Hashtable tabla;
        public clsMuestraHastTable()
        {
            tabla = new Hashtable();
        }

        public void AgregarDatos()
        {
            tabla.Add("C001", "Producto 1");
            tabla.Add("C002", "Producto 2");
            tabla.Add("C003", "Producto 3");
            tabla.Add("C004", "Producto 4");
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("Existen {0} elementos, dame la clave del producto:",tabla.Count);
            string cadena = Console.ReadLine();
            if (tabla[cadena] == null)
            {
                Console.WriteLine("El elemento no existe");
            }
            else
            {
                Console.WriteLine("El elemento encontrado es:");
                Console.WriteLine(tabla[cadena]);
            }            
            Console.ReadKey();
        }

        public void EliminarElemento(string key)
        {
            tabla.Remove(key);
        }
    }
}
