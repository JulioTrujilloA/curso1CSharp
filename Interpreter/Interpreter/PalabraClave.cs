using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class PalabraClave : Expresion
    {
        protected string palabraClave;

        public PalabraClave(string palabraClave)
        {
            this.palabraClave = palabraClave;
        }

        public override bool evalua(string descripcion)
        {
            return descripcion.IndexOf(palabraClave) != -1;
        }

        // parte del análisis sintáctico
        public static new Expresion parsea()
        {
            Expresion resultado;
            resultado = new PalabraClave(pieza);
            siguientePieza();
            return resultado;
        }
    }
}
