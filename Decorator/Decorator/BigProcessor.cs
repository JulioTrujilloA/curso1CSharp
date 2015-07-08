using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BigProcessor : ComponentDecorator
    {
        private Computer currentComputer;

        public BigProcessor(Computer computer)
        {
            this.currentComputer = computer;
        }

        public override decimal CalculateCost()
        {
            return this.currentComputer.CalculateCost() + 120.00M;
        }
    }
}
