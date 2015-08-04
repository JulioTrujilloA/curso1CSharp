using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            string romano = "II";
            Context context = new Context(romano);

            // Construimos el árbol
            ArrayList tree = new ArrayList();
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Lo interpretamos

            foreach (Expression arbol in tree)
            {
                arbol.interpreter(context);
            }

            Console.WriteLine(context.output);
            Console.ReadKey();
            
        3}
    }
}
