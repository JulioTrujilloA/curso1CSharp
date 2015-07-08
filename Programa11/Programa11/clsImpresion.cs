using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa11
{
    public class clsImpresion : intSalidas
    {
        public void imprimeCliente(clsAbsClientes cliente)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            if (cliente.TipoRegimen==1)
            {
                Console.WriteLine("Tipo: PERSONA FÍSICA");
            }else
                Console.WriteLine("Tipo: PERSONA MORAL");
            Console.WriteLine("RFC: "+cliente.RFC);
            Console.ReadKey();
        }

        public void imprimeDireccion(clsDirecciones Direccion)
        {
            Console.WriteLine(Direccion.Calle + "No."+Direccion.NumeroExterior);
            Console.WriteLine(Direccion.Colonia);
            Console.WriteLine(Direccion.CP);
            Console.WriteLine(Direccion.Estado);
        }

    }
}
