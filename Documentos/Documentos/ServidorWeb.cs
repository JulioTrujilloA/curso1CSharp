using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documentos
{
    public class ServidorWeb
    {
        static void Main(string[] args)
        {
            Documento documento1, documento2;
            documento1 = new DocumentoHTML();
            documento1.contenido = "Hola querubines";
            documento1.dibuja();
            Console.WriteLine();
            documento2 = new DocumentoPdf();
            documento2.contenido = "Hello cherubim";
            documento2.dibuja();
            Console.ReadKey();
        }
    }
}
