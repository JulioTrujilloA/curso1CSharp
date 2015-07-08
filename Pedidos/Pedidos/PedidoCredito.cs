﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos
{
    class PedidoCredito : Pedido
    {
        public PedidoCredito(double importe) : base(importe) { }

        public override void paga()
        {
            Console.WriteLine("El pago del pedido a crédito de: "+
                        importe + " se ha realizado.");
        }

        public override bool valida()
        {
            return (importe >= 1000.0) && (importe <= 5000.0);
        }
    }
}
