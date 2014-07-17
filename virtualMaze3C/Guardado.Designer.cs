namespace virtualMaze3C
{
    
    partial class Guardado
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
            this.bAbrirLaberinto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.bCambiarAvatar = new System.Windows.Forms.Button();
            this.bInicio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lTiempo = new System.Windows.Forms.Label();
            this.bEnviarDatos = new System.Windows.Forms.Button();
            this.bModoDeJuego = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAbrirLaberinto
            // 
            this.bAbrirLaberinto.BackColor = System.Drawing.Color.Transparent;
            this.bAbrirLaberinto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAbrirLaberinto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAbrirLaberinto.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.bAbrirLaberinto.FlatAppearance.BorderSize = 0;
            this.bAbrirLaberinto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bAbrirLaberinto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bAbrirLaberinto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bAbrirLaberinto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAbrirLaberinto.ForeColor = System.Drawing.Color.Black;
            this.bAbrirLaberinto.Location = new System.Drawing.Point(151, 16);
            this.bAbrirLaberinto.Name = "bAbrirLaberinto";
            this.bAbrirLaberinto.Size = new System.Drawing.Size(100, 100);
            this.bAbrirLaberinto.TabIndex = 9;
            this.bAbrirLaberinto.TabStop = false;
            this.bAbrirLaberinto.UseVisualStyleBackColor = false;
            this.bAbrirLaberinto.Click += new System.EventHandler(this.button6_Click);
            this.bAbrirLaberinto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teclaPresionada);
            this.bAbrirLaberinto.Leave += new System.EventHandler(this.button6_Leave);
            this.bAbrirLaberinto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            this.bAbrirLaberinto.MouseHover += new System.EventHandler(this.bEnviarDatos_MouseHover);
            this.bAbrirLaberinto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button6_MouseUp);
            this.bAbrirLaberinto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.teclaPrevia);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 152);
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
            this.progreso.Visible = false;
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
            this.bCambiarAvatar.Location = new System.Drawing.Point(287, 16);
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
            this.bInicio.Location = new System.Drawing.Point(22, 16);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(100, 100);
            this.bInicio.TabIndex = 13;
            this.bInicio.TabStop = false;
            this.bInicio.UseVisualStyleBackColor = false;
            this.bInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.bInicio.MouseHover += new System.EventHandler(this.bEnviarDatos_MouseHover);
            this.bInicio.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lTiempo);
            this.groupBox1.Controls.Add(this.bEnviarDatos);
            this.groupBox1.Controls.Add(this.bModoDeJuego);
            this.groupBox1.Controls.Add(this.bInicio);
            this.groupBox1.Controls.Add(this.bCambiarAvatar);
            this.groupBox1.Controls.Add(this.bAbrirLaberinto);
            this.groupBox1.Location = new System.Drawing.Point(3, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 127);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lTiempo
            // 
            this.lTiempo.AutoSize = true;
            this.lTiempo.Font = new System.Drawing.Font("Quartz MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTiempo.ForeColor = System.Drawing.Color.Yellow;
            this.lTiempo.Location = new System.Drawing.Point(710, 58);
            this.lTiempo.Name = "lTiempo";
            this.lTiempo.Size = new System.Drawing.Size(0, 35);
            this.lTiempo.TabIndex = 17;
            // 
            // bEnviarDatos
            // 
            this.bEnviarDatos.BackColor = System.Drawing.Color.Transparent;
            this.bEnviarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEnviarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEnviarDatos.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.bEnviarDatos.FlatAppearance.BorderSize = 0;
            this.bEnviarDatos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bEnviarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bEnviarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bEnviarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnviarDatos.ForeColor = System.Drawing.Color.Black;
            this.bEnviarDatos.Location = new System.Drawing.Point(551, 16);
            this.bEnviarDatos.Name = "bEnviarDatos";
            this.bEnviarDatos.Size = new System.Drawing.Size(100, 100);
            this.bEnviarDatos.TabIndex = 15;
            this.bEnviarDatos.TabStop = false;
            this.bEnviarDatos.UseVisualStyleBackColor = false;
            this.bEnviarDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bEnviarDatos_MouseDown);
            this.bEnviarDatos.MouseHover += new System.EventHandler(this.bEnviarDatos_MouseHover);
            this.bEnviarDatos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bEnviarDatos_MouseUp);
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
            this.bModoDeJuego.Location = new System.Drawing.Point(420, 16);
            this.bModoDeJuego.Name = "bModoDeJuego";
            this.bModoDeJuego.Size = new System.Drawing.Size(100, 100);
            this.bModoDeJuego.TabIndex = 14;
            this.bModoDeJuego.TabStop = false;
            this.bModoDeJuego.UseVisualStyleBackColor = false;
            this.bModoDeJuego.Click += new System.EventHandler(this.bModoDeJuego_Click);
            this.bModoDeJuego.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bModoDeJuego_MouseDown);
            this.bModoDeJuego.MouseHover += new System.EventHandler(this.bEnviarDatos_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Guardado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(725, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Guardado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Creacion del laberinto (Automatico)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Guardado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bAbrirLaberinto;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.Button bCambiarAvatar;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bEnviarDatos;
        private System.Windows.Forms.Button bModoDeJuego;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lTiempo;





    }
}

