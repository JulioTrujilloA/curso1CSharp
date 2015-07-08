using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public abstract class Pedido
    {
        protected double importe;

        public Pedido(double importe)
        {
            this.importe = importe;
        }

        public abstract bool valida();
        
        public abstract void paga();
    }
}
