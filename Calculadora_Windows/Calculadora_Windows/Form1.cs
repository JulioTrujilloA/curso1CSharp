using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Windows
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation= string.Empty;
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((resultado.Text == "0") || (operation_pressed))
            {
                resultado.Clear();
            }
            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!resultado.Text.Contains("."))
                {
                      resultado.Text = resultado.Text + b.Text;
                }
            }
            else
            {
                resultado.Text = resultado.Text + b.Text;
            }
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                ecuacion.Text = value + " " + operation;
            }
            else
            {         
            operation = b.Text;
            value = Double.Parse(resultado.Text);
            operation_pressed = true;
            ecuacion.Text = value + " " + operation;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ecuacion.Text = string.Empty;
            switch (operation)
            {
                case "+":
                    resultado.Text = (value + Double.Parse(resultado.Text)).ToString();
                    break;
                case "-":
                    resultado.Text = (value - Double.Parse(resultado.Text)).ToString();
                    break;
                case "*":
                    resultado.Text = (value * Double.Parse(resultado.Text)).ToString();
                    break;
                case "/":
                    resultado.Text = (value / Double.Parse(resultado.Text)).ToString();
                    break;
                default:
                    break;
            }
            value = Int32.Parse(resultado.Text);
            operation = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            resultado.Text = "0";
            value = 0;
            ecuacion.Text = string.Empty;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
            switch (e.KeyChar.ToString())
            {
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                case "0":
                    zero.PerformClick();
                    break;
                case ".":
                    dec.PerformClick();
                    break;
                case "ENTER":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
