using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterRomanos
{
    public class Context
    {
        public string input;
        public int output;

        public Context(string s)
        {
            input = s;
        }
    }
}
