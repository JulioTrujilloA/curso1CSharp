using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    public class Ruta1 : EstrategiaTransporte
    {
        private string tiempo;
        public Ruta1(string tiempo)
        {
            this.tiempo = tiempo;
        }

        public void Ruta()
        {
            Console.WriteLine("El tiempo de la ruta 1 es de: " + tiempo);
        }
    }
}
