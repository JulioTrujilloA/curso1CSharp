using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BaseComputer : Computer
    {
        public override decimal CalculateCost()
        {
            return 0M;
        }
    }
}
