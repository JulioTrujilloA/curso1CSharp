using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public abstract  class OperadorBinario : Expresion
    {
        protected Expresion operandoIzquierdo, operandoDerecho;

        public OperadorBinario(Expresion operandoIzquierdo, Expresion operandoDerecho)
        {
            this.operandoIzquierdo = operandoIzquierdo;
            this.operandoDerecho = operandoDerecho;
        }
    }
}
