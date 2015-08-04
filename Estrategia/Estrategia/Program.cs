using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiempo = "45 minutos";

            RutaTransporte rt = new RutaTransporte(tiempo);
            rt.SetEstrategia(new Ruta1(tiempo));
            rt.Ejecutar();

            rt.SetEstrategia(new Ruta2(tiempo));
            rt.Ejecutar();
        }
    }
}
