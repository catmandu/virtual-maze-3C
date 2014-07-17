using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace virtualMaze3C
{
    public partial class principal : Form 
    {
        
        EfectosSonido efecto = new EfectosSonido();
        Form fondo = new Form();
        Ayudas ayuda = new Ayudas();
        
        public principal()
        {         
            InitializeComponent();
        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            efecto.clickBoton();
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             efecto.clickBoton(); 
             elegirJugador lab = new elegirJugador();
             this.Hide();
             this.TopMost = false;
             lab.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            efecto.clickBoton();
            labManual man = new labManual();
            this.Hide();
            this.TopMost = false;
            man.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            efecto.clickBoton();
            Guardado guar = new Guardado();
            this.Hide();
            this.TopMost = false;
            guar.Show(this);
        }

        public void principal_Load(object sender, EventArgs e)
        {
            fondo.WindowState = FormWindowState.Maximized;
            fondo.FormBorderStyle = FormBorderStyle.None;
            fondo.BackColor = Color.Black;
            
            fondo.Show();
            fondo.BringToFront();
            this.BringToFront();
            
            this.BackgroundImage = new Bitmap("./principal/principal.jpg");
            bPrincipalGenerar.BackgroundImage = new Bitmap("./principal/auto.jpg");
            bPrincipalCrear.BackgroundImage = new Bitmap("./principal/manual.jpg");
            bPrincipalAbrir.BackgroundImage = new Bitmap("./principal/guardado.jpg");
            bPrincipalSalir.BackgroundImage = new Bitmap("./principal/salir.jpg");

            reproductor.URL=("./Sonidos/cancion.wav");
            reproductor.Ctlcontrols.play();
           // reproductor.Ctlcontrols.stop();
            reproductor.settings.volume = 70;
            reproductor.settings.setMode("loop", true);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            Button comodin = (Button)sender;
            ayuda.escogerBoton(comodin);
            efecto.sobreBoton();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            Button comodin = sender as Button;
            comodin.FlatAppearance.BorderSize = 3;
            comodin.FlatAppearance.BorderColor = Color.FromArgb(80, 51, 153, 255);
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            Button comodin = sender as Button;
            comodin.FlatAppearance.BorderSize = 0;
        }

        private void principal_Layout(object sender, LayoutEventArgs e)
        {
            this.TopMost = true;
            fondo.BringToFront();
            this.BringToFront();
        }

        private void reproductor_Enter(object sender, EventArgs e)
        {

        }
    }
}
