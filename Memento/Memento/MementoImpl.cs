using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class MementoImpl : Memento
    {
        protected IList<OpcionVehiculo> opciones = new List<OpcionVehiculo>();

        public IList<OpcionVehiculo> estado
        {
            get
            {
                return opciones;
            }
            set
            {
                this.opciones.Clear();
                foreach (OpcionVehiculo opcion in value)
                {
                    this.opciones.Add(opcion);
                }
            }
        }
    }
}
