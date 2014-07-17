using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;



namespace virtualMaze3C
{
    
    public partial class Auto : Form
    {
       // bool guardar = true;
        modoDeJuego modo = new modoDeJuego();
        ganador win = new ganador();
        Ayudas ayuda = new Ayudas();
        Point[,] matriz = new Point[10, 25];
        EfectosSonido efecto = new EfectosSonido();
        public Bitmap jugador;
        Point[] recorrido = new Point[1024];
        Bitmap choque;
        public bool generar = true;
        public bool elegirJugador = false;
        int x, y, posicion, casilla,segundos;
        

        public Auto()
        {
            InitializeComponent();
            casilla = 0;
            posicion = 1;
        }

        //Al iniciarse el form padre que contiene a los demas controles, redimensiona al picturebox con respecto al form
        private void labAuto_Load(object sender, EventArgs e)
        {  
                pictureBox1.Height = this.Height - 110;
                pictureBox1.Width = this.Width;
                groupBox1.Width = this.Width;
                groupBox1.BackgroundImage = new Bitmap("./cabeceras/automatico.jpg");
                casilla = (pictureBox1.Width) / 24;
                bGenerarLaberinto.Focus();
                jugador = new Bitmap(jugador, new Size(casilla - 8, casilla - 5));
                bGenerarLaberinto.BackgroundImage = new Bitmap("./botones/nuevo.png");
                bGuardar.BackgroundImage=new Bitmap("./botones/guardar.png");
                bCambiarAvatar.BackgroundImage=new Bitmap("./botones/personaje.png");
                bInicio.BackgroundImage = new Bitmap("./botones/inicio.png");
                bModoDeJuego.BackgroundImage = new Bitmap("./botones/ModoJuego.png");
                bEnviarDatos.BackgroundImage = new Bitmap("./botones/EnviarDatos.png");
                progreso.Location =(new Point((pictureBox1.Width / 2) - 50, pictureBox1.Height / 2));
        }

        private void determinarPuntos()
        {
            for (int i = 0; i < 9; i++)
            {
                x = 30;
                for (int j = 0; j < 24; j++)
                {
                    matriz[(i), (j)] = new Point(x + 3, y + 3);
                    x += casilla;
                    progreso.PerformStep();
                }
                y += casilla;
                progreso.PerformStep();
            }
        }

        private void convertirBM()
        {
           
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            
            // Saves the Image via a FileStream created by the OpenFile method.

            System.IO.FileStream fs = new System.IO.FileStream("./temp/temp.vm3", System.IO.FileMode.Create, System.IO.FileAccess.Write);
            
            // Saves the Image in the appropriate ImageFormat based upon the

            // File type selected in the dialog box.    
            choque = bm;
            
            bm.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            

            fs.Close();
            
            pictureBox1.Image = bm;

            progreso.PerformStep();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (generar)
            {
                
                GC.Collect();
                progreso.Visible = true;
                Random fondo = new Random();
                Image bosque=new Bitmap(Image.FromFile("./fondosBosque/" + fondo.Next(1, 11).ToString() + ".jpg"),pictureBox1.Width,pictureBox1.Height);
                pictureBox1.Image = bosque;
                y = (pictureBox1.Height/2)-(casilla*4);

                Pen negro = new Pen(new TextureBrush(new Bitmap("./caramelo.png")));
                Pen gris = new Pen(Color.Gray);
                gris.Width = 4;
                negro.Width = 8;
                progreso.PerformStep();
              

                determinarPuntos();
               
                
                for (int i = 0; i < 9; i++)
                {

                    for (int j = 0; j < 24; j++)
                    {
                        if (matriz[i, j + 1] != new Point(0, 0))
                        {
                            e.Graphics.DrawLine(gris, matriz[(i), (j)], matriz[(i), (j + 1)]);
                        }
                        if (matriz[i + 1, j] != new Point(0, 0))
                        {
                            e.Graphics.DrawLine(gris, matriz[(i), (j)], matriz[(i + 1), (j)]);
                        }
                        progreso.PerformStep();
                    }
                    progreso.PerformStep();

                }
                

                //Muros delimitadores



                e.Graphics.DrawLine(negro, matriz[(0), (0)], matriz[(0), (23)]);
                e.Graphics.DrawLine(negro, matriz[(8), (0)], matriz[(8), (23)]);
                //entrada
                e.Graphics.DrawLine(negro, matriz[(0), (0)], matriz[(7), (0)]);
                e.Graphics.DrawLine(negro, matriz[(8), (0)], matriz[(8), (23)]);
                e.Graphics.DrawLine(negro, matriz[(1), (23)], matriz[(8), (23)]);
                



                Random direccion = new Random();
                progreso.PerformStep();
                
                
                    for (int i = 1; i < 8; i++)
                    {
                        for (int j = 1; j < 23; j++)
                        {

                            switch (direccion.Next(1, 4))
                            {
                                //arriba
                                case 1:
                                    e.Graphics.DrawLine(negro, matriz[i, j], matriz[i - 1, j]);
                                    break;
                                //derecha
                                case 2:
                                    e.Graphics.DrawLine(negro, matriz[i, j], matriz[i, j + 1]);
                                    break;
                                //abajo
                                case 3:
                                    e.Graphics.DrawLine(negro, matriz[i, j], matriz[i + 1, j]);
                                    break;
                                //Izquierda
                                case 4:
                                    e.Graphics.DrawLine(negro, matriz[i, j], matriz[i, j - 1]);
                                    break;
                            }
                            progreso.PerformStep();
                        }
                        progreso.PerformStep();
                    }
                
                
                x = matriz[7, 0].X;
                y = matriz[7, 0].Y;
                

                convertirBM();
                generar = false;
                pictureBox1.Image=choque;

                recorrido[0] = matriz[7, 0];
                progreso.PerformStep();

                progreso.Visible = false;
                progreso.Value = 0;
                
               
            }
            else
            {
                
                for(int i=0;i<posicion;i++)
                {
                    if(recorrido[i]!=new Point(0,0))
                        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 252, 231, 9)), recorrido[i].X + 2, recorrido[i].Y + 2, casilla - 5, casilla - 5);
                }
                e.Graphics.DrawImage(jugador, x, y, casilla - 5, casilla - 5);

            }
        }
        
        private void teclaPresionada(object sender,KeyEventArgs e)
        {
            switch (e.KeyData.ToString())
            {
                case "Up":
                    recorrerLaberinto(1);
                    break;
                case "Down":
                    recorrerLaberinto(2);
                    break;
                case "Right":
                    recorrerLaberinto(3);
                    break;
                case "Left":
                    recorrerLaberinto(4);
                    break;
            }
        }

        private void recorrerLaberinto(int movimiento)
        {
            if (movimiento==4&&x-casilla < matriz[0, 0].X)
            {
                MessageBox.Show("¡Debes de entrar al laberinto!", "Camino equivocado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                switch (movimiento)
                {

                    case 1:
                        if (choque.GetPixel(x + casilla / 2, y).Name.ToString() == "ff808080")
                        {

                            y -= casilla;

                            for (int i = 0; i < posicion; i++)
                            {
                                if (recorrido[i].Equals(new Point(x, y)))
                                {
                                    posicion = i;


                                    break;
                                }

                            }
                            pictureBox1.Invalidate();
                            recorrido[posicion] = new Point(x, y);
                            posicion++;

                        }
                        else
                        {
                            efecto.choque();

                        }

                        break;
                    case 2:
                        if (choque.GetPixel(x + casilla / 2, (y + (casilla))).Name.ToString() == "ff808080")
                        {
                            y += casilla;
                            for (int i = 0; i < posicion; i++)
                            {
                                if (recorrido[i].Equals(new Point(x, y)))
                                {
                                    posicion = i;


                                    break;
                                }

                            }
                            pictureBox1.Invalidate();
                            recorrido[posicion] = new Point(x, y);

                            posicion++;
                        }
                        else
                        {
                            efecto.choque();

                        }
                        break;


                    case 3:
                        if (choque.GetPixel((x + casilla), y + (casilla / 2)).Name.ToString() == "ff808080")
                        {
                            x += casilla;

                            for (int i = 0; i < posicion; i++)
                            {
                                if (recorrido[i].Equals(new Point(x, y)))
                                {
                                    posicion = i;


                                    break;
                                }

                            }
                            pictureBox1.Invalidate();
                            recorrido[posicion] = new Point(x, y);

                            posicion++;
                        }
                        else
                        {
                            efecto.choque();

                        }
                        break;
                    case 4:
                        if (choque.GetPixel(x, y + (casilla / 2)).Name.ToString() == "ff808080")
                        {
                            x -= casilla;
                            for (int i = 0; i < posicion; i++)
                            {
                                if (recorrido[i].Equals(new Point(x, y)))
                                {
                                    posicion = i;
                                    break;
                                }

                            }

                            pictureBox1.Invalidate();
                            recorrido[posicion] = new Point(x, y);
                            posicion++;
                        }
                        else
                        {
                            efecto.choque();
                        }
                        break;



                }

                GC.Collect();


                if (x == matriz[0, 23].X && y == matriz[0, 23].Y)
                {

                    timer1.Stop();
                    timer1.Enabled = false;
                   
                    win.BackgroundImage = new Bitmap("./ganador/felicidades.jpg");
                    win.BackgroundImageLayout = ImageLayout.Stretch;
                    win.StartPosition = FormStartPosition.CenterScreen;
                    win.ShowDialog();
                    switch (win.eleccion)
                    {
                        case "inicio":
                            this.Owner.Show();
                            this.Close();
                            this.Dispose();
                            break;
                        case "intentar de nuevo":
                            timer1.Enabled = true;
                            lTiempo.Visible = true;
                            if (modo.rb1.Checked)
                            {

                                segundos = 60;
                            }
                            if (modo.rb3.Checked)
                            {

                                segundos = 180;
                            }
                            if (modo.rb5.Checked)
                            {

                                segundos = 300;
                            }
                            lTiempo.Text = segundos.ToString();
                            timer1.Start();
                            x = matriz[7, 0].X;
                            y = matriz[7, 0].Y;
                            posicion = 1;
                            pictureBox1.Invalidate();
                            break;
                        case "nuevo laberinto":
                            generar = true;
                            x = matriz[7, 0].X;
                            y = matriz[7, 0].Y;
                            posicion = 1;
                            pictureBox1.Invalidate();
                            break;
                        case "cambiar modo":
                            bModoDeJuego.PerformClick();
                            x = matriz[7, 0].X;
                            y = matriz[7, 0].Y;
                            posicion = 1;
                            pictureBox1.Invalidate();
                            break;
                    }
                  
                }
            }
        
         }
            
        

        private void teclaPrevia(object sender, PreviewKeyDownEventArgs e)
        {
            
                e.IsInputKey = true;
            
        }

        private void button6_Leave(object sender, EventArgs e)
        {
            bGenerarLaberinto.Focus();
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bGenerarLaberinto.BackgroundImage = new Bitmap("./botones/nuevo.png");
            }
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bGenerarLaberinto.BackgroundImage = new Bitmap("./botones/nuevo2.png");
                generar = true;
              
                pictureBox1.Invalidate();
                for (int i = 1; i <= posicion; i++)
                {
                    recorrido[i].X = 0;
                    recorrido[i].Y = 0;
                }


            }
            efecto.clickBoton();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
             SaveFileDialog guardar = new SaveFileDialog();
                guardar.AddExtension = true;
                guardar.Filter = "Laberinto Virtual Maze vm3|*.vm3";
                efecto.clickBoton();
                guardar.ShowDialog();
                if (guardar.FileName != "")
                {
                    
                    System.IO.FileStream fs = (System.IO.FileStream)guardar.OpenFile();
                    pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                    fs.Close();
                }
                guardar.Dispose();
                
            GC.Collect();
        }

        

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            bInicio.BackgroundImage = new Bitmap("./botones/inicio2.png");
            efecto.clickBoton();
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            bInicio.BackgroundImage = new Bitmap("./botones/inicio.png");
            Form principal=this.Owner;
            principal.Show();
            this.Close();
            this.Dispose();
            GC.Collect();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            bCambiarAvatar.BackgroundImage = new Bitmap("./botones/personaje2.png");
            efecto.clickBoton();
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            bCambiarAvatar.BackgroundImage = new Bitmap("./botones/personaje.png");
            cambiarJugador camb = new cambiarJugador();
            camb.ShowDialog();
            if (camb.jugador != null)
            {
                jugador = camb.jugador;

            }
            camb.Dispose();
         
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            efecto.sobreBoton();
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            analizarMuros ana = new analizarMuros(choque, casilla);
            String[] matrizBinaria = new String[25];
            matrizBinaria[0]="FILAS";
            matrizBinaria[1] = "";
            for(int i=0;i<9;i++)
            {
                for (int j = 0; j < 23;j++)
                {
                    matrizBinaria[i+2] += ana.analizarFilas(matriz[0, 0])[j, i]+" ";
                }
            }
                       matrizBinaria[12] = "COLUMNAS";
                       matrizBinaria[13] = "";

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 24; j++)
                {matrizBinaria[i+14]+= ana.analizarColumnas(matriz[0, 0])[j, i] + " ";
                }
               
            }
            System.IO.File.WriteAllLines((Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory))+"/matrizBinaria.txt", matrizBinaria);
            System.Windows.MessageBox.Show("¡Datos guardados en el escritorio bajo el nombre de 'matrizBinaria.txt' correctamente!");

        }

        private void bModoDeJuego_MouseDown(object sender, MouseEventArgs e)
        {
            bModoDeJuego.BackgroundImage = new Bitmap("./botones/ModoJuego1.png");
            efecto.clickBoton();
        }

        private void bModoDeJuego_MouseUp(object sender, MouseEventArgs e)
        {
            bModoDeJuego.BackgroundImage = new Bitmap("./botones/ModoJuego.png");
        }

        private void bEnviarDatos_MouseDown(object sender, MouseEventArgs e)
        {
            bEnviarDatos.BackgroundImage = new Bitmap("./botones/EnviarDatos1.png");
            efecto.clickBoton();
        }

        private void bEnviarDatos_MouseUp(object sender, MouseEventArgs e)
        {
            bEnviarDatos.BackgroundImage = new Bitmap("./botones/EnviarDatos.png");
        }

        private void bEnviarDatos_MouseHover(object sender, EventArgs e)
        {
            Button comodin = (Button)sender;
            ayuda.escogerBoton(comodin);
            efecto.sobreBoton();
        }

        private void bModoDeJuego_Click(object sender, EventArgs e)
        {
            timer1.Stop();
           
            modo.ShowDialog(this);
            if (modo.tiempo)
            {
                timer1.Enabled = true;
                lTiempo.Visible = true;
                if (modo.rb1.Checked)
                {

                    segundos = 60;
                }
                if (modo.rb3.Checked)
                {

                    segundos = 180;
                }
                if (modo.rb5.Checked)
                {

                    segundos = 300;
                }
                lTiempo.Text = segundos.ToString();
                timer1.Start();
            }
            else
            {
                timer1.Enabled = false;
                lTiempo.Visible = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (segundos > 0)
            {
                segundos--;
                lTiempo.Text = segundos.ToString();
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                lTiempo.Visible = false;
                perdedor perder=new perdedor();
                perder.ShowDialog();
                switch (perder.eleccion)
                {
                    case "inicio":
                        this.Owner.Show();
                        this.Close();
                        this.Dispose();
                        break;
                    case "intentar de nuevo":
                         timer1.Enabled = true;
                lTiempo.Visible = true;
                if (modo.rb1.Checked)
                {

                    segundos = 60;
                }
                if (modo.rb3.Checked)
                {

                    segundos = 180;
                }
                if (modo.rb5.Checked)
                {

                    segundos = 300;
                }
                lTiempo.Text = segundos.ToString();
                timer1.Start();
                         x = matriz[7, 0].X;
                         y = matriz[7, 0].Y;
                         posicion = 1;
                         pictureBox1.Invalidate();
                        break;
                    case "nuevo laberinto":
                        generar = true;
                         x = matriz[7, 0].X;
                         y = matriz[7, 0].Y;
                         posicion = 1;
                        pictureBox1.Invalidate();
                        break;
                    case "cambiar modo":
                        bModoDeJuego.PerformClick();
                         x = matriz[7, 0].X;
                         y = matriz[7, 0].Y;
                         posicion = 1;
                         pictureBox1.Invalidate();
                        break;
                }
            }
        }
    }

    
}
