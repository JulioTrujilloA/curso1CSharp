using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa11
{
    public class clsArchivos : intSalidas
    {
        public void imprimeCliente(clsAbsClientes cliente)
        {
            int i = 0;
            bool bandera = true;
            while (bandera)
            {
                try
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
                    bandera = false;
                }
                catch (Exception e)
                {
                    i++;
                    if (i >= 500)
                    {
                        throw e;
                    }
                }
            }

        }

        public void imprimeDireccion(clsDirecciones direccion)
        {

        }
    }
}
