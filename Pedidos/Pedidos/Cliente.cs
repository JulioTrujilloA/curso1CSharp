using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public abstract class Cliente
    {
        protected IList<Pedido> pedidos = new List<Pedido>();

        protected abstract Pedido creaPedido(double importe);

        public void nuevoPedido(double importe)
        {
            Pedido pedido = this.creaPedido(importe);
            if (pedido.valida())
            {
                pedido.paga();
                pedidos.Add(pedido);
            }
        }
    }
}


