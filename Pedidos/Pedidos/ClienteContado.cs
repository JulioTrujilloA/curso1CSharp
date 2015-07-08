using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    public class ClienteContado : Cliente
    {
        protected override Pedido creaPedido(double importe)
        {
            return new PedidoContado(importe);
        }
    }
}
