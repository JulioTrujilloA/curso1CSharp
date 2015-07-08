using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy
{
    public class ArchivoOriginal : Archivo
    {
        private string contenido = "";
        private string temp = "";

        public ArchivoOriginal()
        {
            this.cargarArchivo();
        }

        public void cargarArchivo()
        {
            contenido = "";
            temp = "";

            // Lee el archivo y lo muestra línea por línea
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\wamp\www\Dropbox\curso1CSharp\PatronProxy\text.txt");
            while ((temp = file.ReadLine()) != null)
            {
                contenido = contenido + temp + "\n";
            }

            file.Close();
        }

        public string cadenaTexto()
        {
            this.cargarArchivo();
            return contenido;
        }
    }
}
