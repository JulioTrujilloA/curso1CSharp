using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtroMemento
{
    public class Memento
    {
        private string estado;

        public Memento(string estado)
        {
            this.estado = estado;
        }

        public string getSavedState()
        {
            return estado;
        }
    }
}
