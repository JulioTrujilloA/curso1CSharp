using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatronProxy
{
    public partial class Formulario : Form
    {

        private ArchivoProxy proxy;
        private string texto = "";
        public Formulario()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proxy = new ArchivoProxy();
            textBOriginal.Text = proxy.cadenaTexto();
            textBProxy.Text = proxy.cadenaTexto();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            texto = textBProxy.Text;
            proxy.guardarArchivo(texto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBOriginal.Text = proxy.cadenaTexto();
        }
    }
}
