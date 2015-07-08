using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtroMemento
{
    class Program
    {
        static void Main(string[] args)
        {
            Caretaker caretaker = new Caretaker();

            Persona p = new Persona();
            p.setNombre("Maxi");
            p.setNombre("Juan");

            caretaker.addMemento(p.saveToMemento());
            p.setNombre("Pedro");

            caretaker.addMemento(p.saveToMemento());
            p.setNombre("Diego");

            Memento m1 = caretaker.getMemento(0);
            Memento m2 = caretaker.getMemento(1);

            Console.WriteLine(m1.getSavedState());
            Console.WriteLine(m2.getSavedState());

            Console.ReadKey();
        }
    }
}
