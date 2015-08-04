using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstrategiaAvion
{
    public abstract class Avion
    {
        private Algoritmo miAlgoritmo;

        public void setAlgorimo(Algoritmo a)
        {
            this.miAlgoritmo = a;
        }

        public void mover()
        {
            this.miAlgoritmo.moverse();
        }
    }
}
