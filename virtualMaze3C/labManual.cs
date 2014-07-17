using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Microsoft.VisualBasic.PowerPacks;


namespace virtualMaze3C
{
    public partial class labManual : Form
    {
        modoDeJuego modo = new modoDeJuego();
        EfectosSonido efecto = new EfectosSonido();
        Ayudas ayuda = new Ayudas();
        Point[,] matriz = new Point[10, 25];
        Point[] recorrido = new Point[1024];
        //Variable del tipo random para determinar la direccion hacia la cual se pintaran los muros aleatorios posteriormente
        Random direccion = new Random();
        //variable de estado que sirve para detener el ciclo de generacion de muros hasta que el usuario quiera generar un diseño aleatorio nuevo
        ShapeContainer contenedor = new ShapeContainer();
        Bitmap choque,jugador;
        bool generar = true;
        bool empezar = false;
        int x, y, posicion, casilla,segundos;
        bool paredes = true;

        public labManual()
        {
            InitializeComponent();
            casilla = 0;
            posicion = 1;
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

        private void labManual_Load(object sender, EventArgs e)
        {
            pictureBox1.Height = this.Height - 110;
            pictureBox1.Width = this.Width;
            groupBox1.Width = this.Width;
            groupBox1.BackgroundImage = new Bitmap("./cabeceras/manual.jpg");
            casilla = (pictureBox1.Width) / 24;
            progreso.Location = (new Point((pictureBox1.Width / 2) - 50, pictureBox1.Height / 2));
            bCrearLaberinto.BackgroundImage = new Bitmap("./botones/crear.png");
            bInvertir.BackgroundImage = new Bitmap("./botones/invertir.png");
            bInicio.BackgroundImage = new Bitmap("./botones/inicio.png");
            bGuardar.BackgroundImage = new Bitmap("./botones/guardar.png");
            bCambiarAvatar.BackgroundImage = new Bitmap("./botones/personaje.png");
            bComenzar.BackgroundImage = new Bitmap("./botones/iniciar.png");
            bModoDeJuego.BackgroundImage = new Bitmap("./botones/ModoJuego.png");
            bEnviarDatos.BackgroundImage = new Bitmap("./botones/EnviarDatos.png");
            progreso.Value = 0;
           
  
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
            progreso.PerformStep();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (generar)
            {
                
                GC.Collect();
                Random fondo = new Random();
                Image bosque = new Bitmap(Image.FromFile("./fondosBosque/" + fondo.Next(1, 11).ToString() + ".jpg"), pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bosque;
                y = (pictureBox1.Height / 2) - (casilla * 4);
                Pen negro = new Pen(new TextureBrush(new Bitmap("./caramelo.png")));
                Pen gris = new Pen(Color.Gray);
                negro.Width = 8;
                gris.Width = 4;
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

                recorrido[0].X = matriz[7, 0].X;
                recorrido[0].Y = matriz[7, 0].Y;
                x = matriz[7, 0].X;
                y = matriz[7, 0].Y;
                convertirBM();
                generar = false;
                progreso.PerformStep();
                progreso.Visible = false;
               
            }
            else
            {
                if (paredes)
                {
                    bCrearLaberinto.PerformClick();
                    paredes = false;
                }
                if (empezar)
                {
                    for (int i = 0; i < posicion; i++)
                    {
                        if (recorrido[i] != new Point(0, 0))
                            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(100, 252, 231, 9)), recorrido[i].X + 2, recorrido[i].Y + 2, casilla - 5, casilla - 5);
                    }
                    e.Graphics.DrawImage(jugador, x, y, casilla - 5, casilla - 5);
                }
            }
            
        }

        private void teclaPrevia(object sender, PreviewKeyDownEventArgs e)
        {

            e.IsInputKey = true;

        }

        private void teclaPresionada(object sender, KeyEventArgs e)
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
            if(empezar)
            {

                if (movimiento == 4 && x - casilla < matriz[0, 0].X)
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


                        ganador win = new ganador();
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
                                bCrearLaberinto.PerformClick();
                                x = matriz[7, 0].X;
                                y = matriz[7, 0].Y;
                                posicion = 1;
                                pictureBox1.Invalidate();
                                lTiempo.Visible = false;
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

        private void borrarMuro_mouseDown(object sender, MouseEventArgs e)
        {
            RectangleShape muro=(RectangleShape)sender;
            switch(e.Button)
            {
                case MouseButtons.Left:
                    muro.BackgroundImage = null;
                    break;
                case MouseButtons.Right:
                    muro.BackgroundImage = new Bitmap("./caramelo.png");
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            progreso.Value = 0;
            progreso.Visible = true;
            progreso.Maximum = 193;
            contenedor.Parent = pictureBox1;
            contenedor.Shapes.Clear();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 23; j++)
                {
                    if (j > 0)
                    {
                        RectangleShape columnas = new RectangleShape(contenedor);

                        columnas.Location = new Point(matriz[i, j].X - 2, matriz[i, j].Y);
                        columnas.Width = 8;
                        columnas.Height = casilla;
                        columnas.BackgroundImage = new Bitmap("./caramelo.png");
                        columnas.BorderColor = columnas.SelectionColor = Color.Transparent;
                        columnas.MouseDown += new MouseEventHandler(borrarMuro_mouseDown);
                    }


                    if (i > 0)
                    {
                        RectangleShape filas = new RectangleShape(contenedor);

                        filas.Location = new Point(matriz[i, j].X, matriz[i, j].Y - 2);
                        filas.Width = casilla;
                        filas.Height = 8;
                        filas.BackgroundImage = new Bitmap("./caramelo.png");
                        filas.BorderColor = filas.SelectionColor = Color.Transparent;
                        filas.MouseDown += new MouseEventHandler(borrarMuro_mouseDown);

                    }
                    progreso.PerformStep();
                }
                progreso.PerformStep();
            }

            progreso.PerformStep();
            progreso.Visible = false;
            efecto.clickBoton();

            GC.Collect();
           
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (empezar)
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.AddExtension = true;
                guardar.Filter = "Laberinto Virtual Maze 3C|*.vm3";
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
            else
            {
                MessageBox.Show("Debes hacer click en el boton 'Comenzar' para empezar a resolver el laberinto, poder guardarlo, cambiar de avatar, cambiar el modo de juego y enviar datos al laberinto fisico", "No haz comenzado a recorrer el laberinto", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
        }

        private void button6_Leave(object sender, EventArgs e)
        {
            bCrearLaberinto.Focus();
        }

      
        private void button4_Enter(object sender, EventArgs e)
        {
            bCrearLaberinto.Focus();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            Button comodin=(Button)sender;
            ayuda.escogerBoton(comodin);
            efecto.sobreBoton();
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            bInicio.BackgroundImage = new Bitmap("./botones/inicio2.png");
            efecto.clickBoton();
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            Form principal = (Form)this.Owner;
            principal.Show();
            this.Close();
            this.Dispose();
            
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            bCrearLaberinto.BackgroundImage = new Bitmap("./botones/crear2.png");
            efecto.clickBoton();
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            progreso.Value = 0;
            progreso.Visible = true;
            progreso.Maximum = 193;
            contenedor.Parent = pictureBox1;
            contenedor.Shapes.Clear();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 23; j++)
                {
                    if (j > 0)
                    {
                        RectangleShape columnas = new RectangleShape(contenedor);

                        columnas.Location = new Point(matriz[i, j].X - 2, matriz[i, j].Y);
                        columnas.Width = 8;
                        columnas.Height = casilla;
                        columnas.BackgroundImage = new Bitmap("./caramelo.png");
                        columnas.BorderColor = columnas.SelectionColor = Color.Transparent;
                        columnas.MouseDown += new MouseEventHandler(borrarMuro_mouseDown);
                    }


                    if (i > 0)
                    {
                        RectangleShape filas = new RectangleShape(contenedor);

                        filas.Location = new Point(matriz[i, j].X, matriz[i, j].Y - 2);
                        filas.Width = casilla;
                        filas.Height = 8;
                        filas.BackgroundImage = new Bitmap("./caramelo.png");
                        filas.BorderColor = filas.SelectionColor = Color.Transparent;
                        filas.MouseDown += new MouseEventHandler(borrarMuro_mouseDown);

                    }
                    progreso.PerformStep();
                }
                progreso.PerformStep();
            }

            progreso.PerformStep();
            progreso.Visible = false;
            bCrearLaberinto.BackgroundImage = new Bitmap("./botones/crear.png");
            GC.Collect();
        }

        private void iniciar_MouseDown(object sender, MouseEventArgs e)
        {
            bComenzar.BackgroundImage = new Bitmap("./botones/iniciar2.png");

            efecto.clickBoton();
        }

        private void iniciar_MouseUp(object sender, MouseEventArgs e)
        {   var desicion = MessageBox.Show("¿Estas seguro que deseas empezar a resolver el laberinto tal y como esta?", "¿Comenzar a resolver laberinto?", MessageBoxButtons.OKCancel);
      
            if (desicion.ToString() == "OK")
          {
            cambiarJugador camb = new cambiarJugador();
            camb.ShowDialog();
            if (camb.jugador != null)
            {
                jugador = camb.jugador;
                jugador = new Bitmap(jugador, new Size(casilla - 8, casilla - 5));
                convertirBM();
                pictureBox1.Invalidate();
                contenedor.Shapes.Clear();
                empezar = true;
                efecto.clickBoton();
                
            }
            camb.Dispose();
            GC.Collect();
          }
          bComenzar.BackgroundImage = new Bitmap("./botones/iniciar.png");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            bInvertir.BackgroundImage = new Bitmap("./botones/invertir2.png");
            efecto.clickBoton();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            bCambiarAvatar.BackgroundImage = new Bitmap("./botones/personaje2.png");
            efecto.clickBoton();
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            if (empezar)
            {
                cambiarJugador camb = new cambiarJugador();
                camb.ShowDialog();
                if (camb.jugador != null)
                {
                    jugador = camb.jugador;
                    pictureBox1.Invalidate();
                }
                camb.Dispose();
            }
            else
            {
                MessageBox.Show("Debes hacer click en el boton 'Comenzar' para empezar a resolver el laberinto, poder guardarlo, cambiar de avatar, cambiar el modo de juego y enviar datos al laberinto fisico", "No haz comenzado a recorrer el laberinto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            bCambiarAvatar.BackgroundImage = new Bitmap("./botones/personaje.png");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            RectangleShape comodin;

            for (int i = 0; i < contenedor.Shapes.Count; i++)
            {
                comodin = (RectangleShape)contenedor.Shapes.get_Item(i);

                if (comodin.BackgroundImage == null)
                    comodin.BackgroundImage = new Bitmap("./caramelo.png");
                else
                    comodin.BackgroundImage = null;
            }
            bInvertir.BackgroundImage = new Bitmap("./botones/invertir.png");
        }

        private void bModoDeJuego_MouseDown(object sender, MouseEventArgs e)
        {
            bModoDeJuego.BackgroundImage = new Bitmap("./botones/ModoJuego1.png");
            efecto.clickBoton();
            
        }

      

        private void bEnviarDatos_MouseDown(object sender, MouseEventArgs e)
        {
            if (empezar)
            {
                bEnviarDatos.BackgroundImage = new Bitmap("./botones/EnviarDatos1.png");
                efecto.clickBoton();
                analizarMuros ana = new analizarMuros(choque, casilla);
                String[] matrizBinaria = new String[25];
                matrizBinaria[0] = "FILAS";
                matrizBinaria[1] = "";
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 23; j++)
                    {
                        matrizBinaria[i + 2] += ana.analizarFilas(matriz[0, 0])[j, i] + " ";
                    }
                }
                matrizBinaria[12] = "COLUMNAS";
                matrizBinaria[13] = "";

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 24; j++)
                    {
                        matrizBinaria[i + 14] += ana.analizarColumnas(matriz[0, 0])[j, i] + " ";
                    }

                }
                System.IO.File.WriteAllLines((Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)) + "/matrizBinaria.txt", matrizBinaria);
                System.Windows.MessageBox.Show("¡Datos guardados en el escritorio bajo el nombre de 'matrizBinaria.txt' correctamente!");
            }
            else
            {
                MessageBox.Show("Debes hacer click en el boton 'Comenzar' para empezar a resolver el laberinto, poder guardarlo, cambiar de avatar, cambiar el modo de juego y enviar datos al laberinto fisico", "No haz comenzado a recorrer el laberinto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bEnviarDatos_MouseUp(object sender, MouseEventArgs e)
        {
            bEnviarDatos.BackgroundImage = new Bitmap("./botones/EnviarDatos.png");
        }

        private void bModoDeJuego_Click(object sender, EventArgs e)
        {
            if (empezar)
            {
                timer1.Stop();

                modo.ShowDialog(this);
                bModoDeJuego.BackgroundImage = new Bitmap("./botones/ModoJuego.png");
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
            else
            {
                MessageBox.Show("Debes hacer click en el boton 'Comenzar' para empezar a resolver el laberinto, poder guardarlo, cambiar de avatar, cambiar el modo de juego y enviar datos al laberinto fisico", "No haz comenzado a recorrer el laberinto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                            bCrearLaberinto.PerformClick();
                            x = matriz[7, 0].X;
                            y = matriz[7, 0].Y;
                            posicion = 1;
                            pictureBox1.Invalidate();
                            lTiempo.Visible = false;
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
