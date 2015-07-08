using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DummyComputer : Computer
    {
        private decimal processor = 56.00M;
        private decimal hdd = 30.00M;
        private decimal graphics = 41.99M;
        private decimal ram = 23.50M;

        public override decimal CalculateCost()
        {
            var cost = this.processor + this.hdd + this.graphics + this.ram;
            return cost;
        }
    }
}
