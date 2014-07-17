using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace virtualMaze3C
{
    public partial class perdedor : Form
    {
        public String eleccion = "";
        public perdedor()
        {
            InitializeComponent();
        }

        private void perdedor_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap("./perdedor/perdedor.jpg");
            bInicio.BackgroundImage = new Bitmap("./botones/inicio.png");
            bIntentarDeNuevo.BackgroundImage = new Bitmap("./botones/IntentarNuevo.png");
            bNuevoLaberinto.BackgroundImage = new Bitmap("./botones/NuevoLaberinto.png");
            bCambiarModo.BackgroundImage = new Bitmap("./botones/ModoJuego.png");
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
