namespace virtualMaze3C
{
    
    public partial class Auto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.bGenerarLaberinto = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCambiarAvatar = new System.Windows.Forms.Button();
            this.bInicio = new System.Windows.Forms.Button();
            this.bModoDeJuego = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lTiempo = new System.Windows.Forms.Label();
            this.bEnviarDatos = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 162);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.teclaPrevia);
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(350, 154);
            this.progreso.MarqueeAnimationSpeed = 1;
            this.progreso.Maximum = 8610;
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(137, 33);
            this.progreso.Step = 1;
            this.progreso.TabIndex = 10;
            // 
            // bGenerarLaberinto
            // 
            this.bGenerarLaberinto.BackColor = System.Drawing.Color.Transparent;
            this.bGenerarLaberinto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bGenerarLaberinto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGenerarLaberinto.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.bGenerarLaberinto.FlatAppearance.BorderSize = 0;
            this.bGenerarLaberinto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bGenerarLaberinto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bGenerarLaberinto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bGenerarLaberinto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGenerarLaberinto.ForeColor = System.Drawing.Color.Black;
            this.bGenerarLaberinto.Location = new System.Drawing.Point(146, 9);
            this.bGenerarLaberinto.Name = "bGenerarLaberinto";
            this.bGenerarLaberinto.Size = new System.Drawing.Size(100, 100);
            this.bGenerarLaberinto.TabIndex = 9;
            this.bGenerarLaberinto.TabStop = false;
            this.bGenerarLaberinto.UseVisualStyleBackColor = false;
            this.bGenerarLaberinto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teclaPresionada);
            this.bGenerarLaberinto.Leave += new System.EventHandler(this.button6_Leave);
            this.bGenerarLaberinto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            this.bGenerarLaberinto.MouseHover += new System.EventHandler(this.bEnviarDatos_MouseHover);
            this.bGenerarLaberinto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button6_MouseUp);
            this.bGenerarLaberinto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.teclaPrevia);
            // 
            // bGuardar
            // 
            this.bGuardar.BackColor = System.Drawing.Color.Transparent;
            this.bGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.bGuardar.FlatAppearance.BorderSize = 0;
            this.bGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.ForeColor = System.Drawing.Color.Black;
            this.bGuardar.Location = new System.Drawing.Point(276, 9);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 100);
            this.bGuardar.TabIndex = 11;
            this.bGuardar.TabStop = false;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.button1_Click);
            this.bGuardar.MouseHover += new System.EventHandler(this.bEnviarDatos_MouseHover);
            // 
            // bCambiarAvatar
            // 
            this.bCambiarAvatar.BackColor = System.Drawing.Color.Transparent;
            this.bCambiarAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCambiarAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCambiarAvatar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.bCambiarAvatar.FlatAppearance.BorderSize = 0;
            this.bCambiarAvatar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bCambiarAvatar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bCambiarAvatar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bCambiarAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCambiarAvatar.ForeColor = System.Drawing.Color.Black;
            this.bCambiarAvatar.Location = new System.Drawing.Point(408, 9);
            this.bCambiarAvatar.Name = "bCambiarAvatar";
            this.bCambiarAvatar.Size = new System.Drawing.Size(100, 100);
            this.bCambiarAvatar.TabIndex = 12;
            this.bCambiarAvatar.TabStop = false;
            this.bCambiarAvatar.UseVisualStyleBackColor = false;
            this.bCambiarAvatar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.bCambiarAvatar.MouseHover += new System.EventHandler(this.bEnviarDatos_MouseHover);
            this.bCambiarAvatar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // bInicio
            // 
            this.bInicio.BackColor = System.Drawing.Color.Transparent;
            this.bInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInicio.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.bInicio.FlatAppearance.BorderSize = 0;
            this.bInicio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInicio.ForeColor = System.Drawing.Color.Black;
            this.bInicio.Location = new System.Drawing.Point(20, 9);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(100, 100);
            this.bInicio.TabIndex = 13;
            this.bInicio.TabStop = false;
            this.bInicio.UseVisualStyleBackColor = false;
            this.bInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.bInicio.MouseHover += new System.EventHandler(this.bEnviarDatos_MouseHover);
            this.bInicio.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // bModoDeJuego
            // 
            this.bModoDeJuego.BackColor = System.Drawing.Color.Transparent;
            this.bModoDeJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bModoDeJuego.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bModoDeJuego.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.bModoDeJuego.FlatAppearance.BorderSize = 0;
            this.bModoDeJuego.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bModoDeJuego.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bModoDeJuego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bModoDeJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModoDeJuego.ForeColor = System.Drawing.Color.Black;
            this.bModoDeJuego.Location = new System.Drawing.Point(544, 9);
            this.bModoDeJuego.Name = "bModoDeJuego";
            this.bModoDeJuego.Size = new System.Drawing.Size(100, 100);
            this.bModoDeJuego.TabIndex = 14;
            this.bModoDeJuego.TabStop = false;
            this.bModoDeJuego.UseVisualStyleBackColor = false;
            this.bModoDeJuego.Click += new System.EventHandler(this.bModoDeJuego_Click);
            this.bModoDeJuego.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bModoDeJuego_MouseDown);
            this.bModoDeJuego.MouseHover += new System.EventHandler(this.bEnviarDatos_MouseHover);
            this.bModoDeJuego.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bModoDeJuego_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lTiempo);
            this.groupBox1.Controls.Add(this.bEnviarDatos);
            this.groupBox1.Controls.Add(this.bModoDeJuego);
            this.groupBox1.Controls.Add(this.bInicio);
            this.groupBox1.Controls.Add(this.bGuardar);
            this.groupBox1.Controls.Add(this.bCambiarAvatar);
            this.groupBox1.Controls.Add(this.bGenerarLaberinto);
            this.groupBox1.Location = new System.Drawing.Point(3, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 115);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // lTiempo
            // 
            this.lTiempo.AutoSize = true;
            this.lTiempo.Font = new System.Drawing.Font("Quartz MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTiempo.ForeColor = System.Drawing.Color.Yellow;
            this.lTiempo.Location = new System.Drawing.Point(795, 53);
            this.lTiempo.Name = "lTiempo";
            this.lTiempo.Size = new System.Drawing.Size(0, 35);
            this.lTiempo.TabIndex = 16;
            // 
            // bEnviarDatos
            // 
            this.bEnviarDatos.BackColor = System.Drawing.Color.Transparent;
            this.bEnviarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEnviarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnviarDatos.FlatAppearance.BorderSize = 0;
            this.bEnviarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bEnviarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bEnviarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnviarDatos.Location = new System.Drawing.Point(675, 9);
            this.bEnviarDatos.Name = "bEnviarDatos";
            this.bEnviarDatos.Size = new System.Drawing.Size(100, 100);
            this.bEnviarDatos.TabIndex = 16;
            this.bEnviarDatos.UseVisualStyleBackColor = false;
            this.bEnviarDatos.Click += new System.EventHandler(this.button4_Click);
            this.bEnviarDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bEnviarDatos_MouseDown);
            this.bEnviarDatos.MouseHover += new System.EventHandler(this.bEnviarDatos_MouseHover);
            this.bEnviarDatos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bEnviarDatos_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Auto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(816, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Auto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Creacion del laberinto (Automatico)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.labAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.Button bGenerarLaberinto;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bCambiarAvatar;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Button bModoDeJuego;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bEnviarDatos;
        public System.Windows.Forms.Label lTiempo;
        private System.Windows.Forms.Timer timer1;





    }
}

