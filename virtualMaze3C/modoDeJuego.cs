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
    public partial class modoDeJuego : Form
    {
        EfectosSonido efecto = new EfectosSonido();
        public bool tiempo = false;

        public modoDeJuego()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            efecto.clickBoton();
           
                this.Close();
        }

        private void modoDeJuego_Load(object sender, EventArgs e)
        {
           
            this.BackgroundImage = new Bitmap("./modo de juego/modo de juego.jpg");
            bModoLibre.BackgroundImage = new Bitmap("./modo de juego/libre.jpg");
            bModoTiempo.BackgroundImage = new Bitmap("./modo de juego/tiempo.jpg");
            bModoAceptar.BackgroundImage = new Bitmap("./modo de juego/aceptar.jpg");
            bModoCancelar.BackgroundImage = new Bitmap("./modo de juego/cancelar.jpg");
            bModoLibre.FlatAppearance.BorderColor = Color.LimeGreen;
            bModoTiempo.FlatAppearance.BorderColor = Color.LimeGreen;
            bModoLibre.FlatAppearance.BorderSize = 5;
            bModoTiempo.FlatAppearance.BorderSize = 0;
            rb1.Visible = rb3.Visible = rb5.Visible = false;
        }

        private void bModoCancelar_Click(object sender, EventArgs e)
        {
            tiempo = false;
            this.Close();
        }

        private void bModoLibre_Click(object sender, EventArgs e)
        {
            efecto.clickBoton();
            bModoLibre.FlatAppearance.BorderSize = 5;
            bModoTiempo.FlatAppearance.BorderSize = 0;
            tiempo = false;
            rb1.Visible = rb3.Visible = rb5.Visible = false;
        }

        private void bModoTiempo_Click(object sender, EventArgs e)
        {
            efecto.clickBoton();
            bModoLibre.FlatAppearance.BorderSize = 0;
            bModoTiempo.FlatAppearance.BorderSize = 5;
            tiempo = true;
            rb1.Visible = rb3.Visible = rb5.Visible = true;
        }

        private void bModoCancelar_MouseHover(object sender, EventArgs e)
        {
            efecto.sobreBoton();
        }
    }
}
