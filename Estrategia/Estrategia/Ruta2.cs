using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    public class Ruta2: EstrategiaTransporte
    {
        private string tiempo;

        public Ruta2(String tiempo)
        {
            this.tiempo = tiempo;
        }

        public void Ruta()
        {
            Console.WriteLine("El tiempo estimado para ruta 2 es de: "+tiempo);
        }
    }
}
