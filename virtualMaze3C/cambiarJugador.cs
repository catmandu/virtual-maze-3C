using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace virtualMaze3C
{
    public partial class cambiarJugador : Form
    {
        public Bitmap jugador;
        EfectosSonido efecto = new EfectosSonido();

        public cambiarJugador()
        {
            InitializeComponent();
           
        }

        private void cambiarJugador_Load(object sender, EventArgs e)
        {
            button1.BackgroundImage = new Bitmap("./seleccion avatar/jugadores/nino1.png");
            button2.BackgroundImage = new Bitmap("./seleccion avatar/jugadores/nino2.png");
            button3.BackgroundImage = new Bitmap("./seleccion avatar/jugadores/nino3.png");

            button4.BackgroundImage = new Bitmap("./seleccion avatar/jugadores/nina1.png");
            button5.BackgroundImage = new Bitmap("./seleccion avatar/jugadores/nina2.png");
            button6.BackgroundImage = new Bitmap("./seleccion avatar/jugadores/nina3.png");

            bCambiarCancelar.BackgroundImage = new Bitmap("./seleccion avatar/cancelar.jpg");

            this.BackgroundImage = new Bitmap("./seleccion avatar/monitos.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button comodin = (Button)sender;
            efecto.clickBoton();
            jugador = new Bitmap(comodin.BackgroundImage);
            this.Close();
        }

      

        private void button6_MouseHover(object sender, EventArgs e)
        {
            Button comodin=sender as Button;
            efecto.sobreBoton();
            comodin.Cursor = Cursors.Hand;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            efecto.clickBoton();
            this.Close();
           
        }
    }
}
