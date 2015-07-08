using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy
{
    public class ArchivoProxy : Archivo
    {
        private ArchivoOriginal archivo;

        public void guardarArchivo(string str)
        {
            // Example #2: Write one string to a text file. 
            // WriteAllText creates a file, writes the specified string to the file, 
            // and then closes the file.
            System.IO.File.WriteAllText(@"C:\wamp\www\Dropbox\curso1CSharp\PatronProxy\text.txt", str);
        }

        public string cadenaTexto()
        {
            if (archivo == null)
            {
                archivo = new ArchivoOriginal();
            }
            return archivo.cadenaTexto();
        }
    }
}
