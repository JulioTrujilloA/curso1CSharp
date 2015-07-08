using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentos
{
    public interface Documento
    {
        string contenido { set; }
        void dibuja();
        void imprime();
    }
}
