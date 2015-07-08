using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        //firstClicked apunta al primer control Label que el jugador clickó, pero
        // será nulo si el jugador no ha clickado una etiqueta todavía.
        Label firstClicked = null;

        //secondClicked apunta al segundo control Label que el jugador clickó.
        Label secondClicked = null;

        // Usa este objeto Random para elejir al azar íconos para los cuadros
        Random random = new Random();

        // Cada una de estas letras es un ícono interesante en la fuente Webdings, 
        // y cada ícono aparece dos veces en esta lista.
        List<string> icons = new List<string>(){ 
        "!", "!", "P", "P", ",", ",", "k", "k",
        "h", "h", "v", "v", "o", "o", "z", "z"
        };

        /// <summary>
        /// Asigna cada ícono de la lista de íconos a un cuadrado al azar
        /// </summary>
        private void AssignIconsToSquares()
        {
            //El TableLayoutPanel tiene 16 etiquetas y la lista de íconos
            // 16 íconos, así un ícono es tirado al azar desde la lista y agregado a cada etiqueta.
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        /// <summary>
        /// Cada evento de la etiqueta Click es manejado por este manejador de eventos
        /// </summary>
        /// <param name="sender">La etiqueta a la que se le da click</param>
        /// <param name="e"></param>
        private void etiqueta_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                return;
            }
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                //Si la etiqueta clickeada es negra, el jugador hizo click en un ícono que ya
                //está revelado -- ignora el click.
                if (clickedLabel.ForeColor == Color.Black)
                {
                    return;
                }

                //Si firstClicked es null, éste es el primer ícono en el par que el jugador clickó,
                //entonces establece firstClicked a la etiqueta que el jugador clickó, cambia su color a negro, y regresa.
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                // If the player gets this far, the timer isn't 
                // running and firstClicked isn't null, 
                // so this must be the second icon the player clicked 
                // Set its color to black
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                // Check to see if the player won
                CheckForWinner();

                //Si el jugador descubrió dos íconos iguales, los mantiene negros y hace reset en firstClicked y secondClicked
                //así el jugador puede dar click en otro ícono.
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                // If the player gets this far, the player  
                // clicked two different icons, so start the  
                // timer (which will wait three quarters of  
                // a second, and then hide the icons)
                timer1.Start();
            }
        }
        /// <summary> 
        /// This timer is started when the player clicks  
        /// two icons that don't match, 
        /// so it counts three quarters of a second  
        /// and then turns itself off and hides both icons 
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked  
            // so the next time a label is 
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }

        /// <summary> 
        /// Check every icon to see if it is matched, by  
        /// comparing its foreground color to its background color.  
        /// If all of the icons are matched, the player wins 
        /// </summary> 
        private void CheckForWinner()
        {
            // Revisa cada una de las etiquetas en el TableLayoutPanel,
            //para ver si su ícono coincide
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                    {
                        return;
                    }
                }
            }
            //Si el foreach no retorna, quiere decir que no encontró coincidencias en los íconos
            // por lo tanto el jugador ganó
            MessageBox.Show("¡Has encontrado los pares!", "Felicidades");
            Close();
        }
    }
}
