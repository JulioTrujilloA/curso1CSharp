using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterRomanos
{
    public abstract class Expression
    {
        public abstract string one();
        public abstract string four();
        public abstract string five();
        public abstract string nine();
        public abstract int multiplier();

        public void interpreter(Context context)
        {
            if (context.input.StartsWith(nine()))
            {
                context.output += (9 * multiplier());
                context.input = context.input.Substring(2);
            }
            else
            {
                if (context.input.StartsWith(four()))
                {
                    context.output += (4 * multiplier());
                    context.input = context.input.Substring(2);
                }
                else
                {
                    if (context.input.StartsWith(five()))
                    {
                        context.output += (5 * multiplier());
                        context.input = context.input.Substring(1);
                    }
                }
            }

            while (context.input.StartsWith(one()))
            {
                context.output += (1 * multiplier());
                context.input = context.input.Substring(1);
            }
        }
    }
}