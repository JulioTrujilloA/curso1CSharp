using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa10
{
    public class clsArchivos : intSalidas
    {
        public void imprimeCliente(clsAbsClientes cliente)
        {
            StreamWriter ar = new StreamWriter(@"C:\wamp\www\Dropbox\curso1CSharp\Programa10\ArchBitacora.log", true);
            ar.WriteLine(cliente.Clave + " " + cliente.Nombre);
            if (cliente.TipoRegimen == 1)
            {
                ar.WriteLine("Tipo: PERSONA FÍSICA");
            }
            else
            {
                ar.WriteLine("Tipo: PERSONA MORAL");
            }
            ar.WriteLine("RFC: " + cliente.RFC);
            ar.Close();
        }

        public void imprimeDireccion(clsDirecciones direccion)
        {

        }
    }
}
