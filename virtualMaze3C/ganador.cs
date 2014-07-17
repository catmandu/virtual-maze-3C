using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace virtualMaze3C
{
    public partial class ganador : Form
    {
        public String eleccion = "";
        public ganador()
        {
            InitializeComponent();
        }

        private void ganador_Load(object sender, EventArgs e)
        {
            bInicio.BackgroundImage = new Bitmap("./botones/inicio.png");
            bIntentarDeNuevo.BackgroundImage = new Bitmap("./botones/IntentarNuevo.png");
            bNuevoLaberinto.BackgroundImage = new Bitmap("./botones/NuevoLaberinto.png");
            bCambiarModo.BackgroundImage = new Bitmap("./botones/ModoJuego.png");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
          
            this.Close();
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            eleccion = "inicio";
            this.Close();
        }

        private void bIntentarDeNuevo_Click(object sender, EventArgs e)
        {
            eleccion = "intentar de nuevo";
            this.Close();
        }

        private void bNuevoLaberinto_Click(object sender, EventArgs e)
        {
            eleccion = "nuevo laberinto";
            this.Close();
        }

        private void bCambiarModo_Click(object sender, EventArgs e)
        {
            eleccion = "cambiar modo";
            this.Close();
        }     
    }
}
