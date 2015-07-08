using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtroMemento
{
     public class Caretaker
    {
         private ArrayList estados = new ArrayList();

         public void addMemento(Memento m)
         {
             estados.Add(m);
         }

         public Memento getMemento(int index)
         {
             return (Memento)estados[index];
         }
    }
}
