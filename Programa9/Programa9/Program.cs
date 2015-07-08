using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa9
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesConContacto cliente = new clsClientesConContacto(0, "Matias Perez", "003", "MLH97SD9", 1, "Flores Torres", "555-473-541","555-565-988","jojo@gmail.com",
                                               "Concha Toro","#455","#4","Col. LindaVista","Ocotlán","Veracruz","48877");
            clsImpresion Impresion;
            Impresion = new clsImpresion();

            Impresion.ImprimeCliente(cliente);
        }
    }
}
