using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa15
{
    class Program
    {
        static void Main(string[] args)
        {
            clsMostrarArrayList mostrarA = new clsMostrarArrayList();
            mostrarA.capturaDatos();
            mostrarA.imprimeDatos();

            //clsMuestraHastTable mostrarH = new clsMuestraHastTable();
            //mostrarH.AgregarDatos();
            //mostrarH.ImprimirDatos();

            //mostrarH.EliminarElemento("C001");
            //mostrarH.ImprimirDatos();
        }
    }
}
