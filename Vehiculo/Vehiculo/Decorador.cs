using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public abstract class Decorador : ComponenteGraficoVehiculo
    {
        protected ComponenteGraficoVehiculo componente;

        public Decorador(ComponenteGraficoVehiculo componente)
        {
            this.componente = componente;
        }

        public virtual void visualiza()
        {
            componente.visualiza();
        }
    }
}
