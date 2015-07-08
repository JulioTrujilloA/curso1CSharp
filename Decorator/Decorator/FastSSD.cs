using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class FastSSD : ComponentDecorator 
    {
        private Computer currentComputer;

        public FastSSD(Computer computer)
        {
            this.currentComputer = computer;
        }

        public override decimal CalculateCost()
        {
            return this.currentComputer.CalculateCost() + 255.20M;
        }
    }
}
