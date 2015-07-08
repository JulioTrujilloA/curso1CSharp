using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtroMemento
{
    public class Persona
    {
        private string nombre;

        public Memento saveToMemento()
        {
            Console.WriteLine("Originator: Guardando Memento... "+getNombre());
            return new Memento(nombre);
        }

        public void restoreFromMemento(Memento m)
        {
            nombre = m.getSavedState();
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
    }
}
