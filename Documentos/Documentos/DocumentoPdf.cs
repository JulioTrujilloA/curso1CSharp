using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentos
{
    public class DocumentoPdf : Documento
    {
        protected ComponentePdf herramientaPdf = new ComponentePdf();

        public string contenido
        {
            set
            {
                herramientaPdf.pdfFijaContenido(value);
            }
        }

        public void dibuja()
        {
            herramientaPdf.pdfPreparaVisualizacion();
            herramientaPdf.pdfRefresca();
            herramientaPdf.pdfFinalizaVisualizacion();
        }

        public void imprime()
        {
            herramientaPdf.pdfEnviaImpresora();
        }
    }
}
