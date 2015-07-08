using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class ClienteCredito : Cliente
    {
        protected override Pedido creaPedido(double importe)
        {
            return new PedidoCredito(importe);
        }
    }
}
