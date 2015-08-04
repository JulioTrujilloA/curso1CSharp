using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterRomanos
{
    public class OneExpression : Expression
    {
        public override string one()
        {
            return "I";
        }

        public override string four()
        {
            return "IV";
        }

        public override string five()
        {
            return "V";
        }

        public override string nine()
        {
            return "IX";
        }

        public override int multiplier()
        {
            return 1;
        }
    }
}
