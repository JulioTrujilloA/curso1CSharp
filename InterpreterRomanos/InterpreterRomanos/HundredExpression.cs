using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterRomanos
{
    public class HundredExpression : Expression
    {
        public override string one()
        {
            return "C";
        }
        public override string four()
        {
            return "CD";
        }
        public override string five()
        {
            return "D";
        }
        public override string nine()
        {
            return "CM";
        }
        public override int multiplier()
        {
            return 100;
        }
    }
}
