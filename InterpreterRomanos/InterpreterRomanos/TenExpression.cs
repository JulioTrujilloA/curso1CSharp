using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterRomanos
{
    public class TenExpression : Expression
    {
        public override string one()
        {
            return "X";
        }
        public override string four()
        {
            return "XL";
        }
        public override string five()
        {
            return "L";
        }
        public override string nine()
        {
            return "XC";
        }
        public override int multiplier()
        {
            return 10;
        }
    }
}
