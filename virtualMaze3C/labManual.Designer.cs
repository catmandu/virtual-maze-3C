namespace virtualMaze3C
{
    partial class labManual
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
            this.bInvertir = new System.Windows.Forms.Button();
            this.bCrearLaberinto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.bComenzar = new System.Windows.Forms.Button();
            this.bInicio = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lTiempo = new System.Windows.Forms.Label();
            this.bCambiarAvatar = new System.Windows.Forms.Button();
            this.bEnviarDatos = new System.Windows.Forms.Button();
            this.bModoDeJuego = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bInvertir
            // 
            this.bInvertir.BackColor = System.Drawing.Color.Transparent;
            this.bInvertir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bInvertir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInvertir.FlatAppearance.BorderSize = 0;
            this.bInvertir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bInvertir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bInvertir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bInvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInvertir.Location = new System.Drawing.Point(376, 11);
            this.bInvertir.Name = "bInvertir";
            this.bInvertir.Size = new System.Drawing.Size(100, 100);
            this.bInvertir.TabIndex = 14;
            this.bInvertir.UseVisualStyleBackColor = false;
            this.bInvertir.Enter += new System.EventHandler(this.button4_Enter);
            this.bInvertir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.bInvertir.MouseHover += new System.EventHandler(this.button4_MouseHover);
            this.bInvertir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // bCrearLaberinto
            // 
            this.bCrearLaberinto.BackColor = System.Drawing.Color.Transparent;
            this.bCrearLaberinto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCrearLaberinto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCrearLaberinto.FlatAppearance.BorderSize = 0;
            this.bCrearLaberinto.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bCrearLaberinto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bCrearLaberinto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bCrearLaberinto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCrearLaberinto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearLaberinto.Location = new System.Drawing.Point(141, 11);
            this.bCrearLaberinto.Name = "bCrearLaberinto";
            this.bCrearLaberinto.Size = new System.Drawing.Size(100, 100);
            this.bCrearLaberinto.TabIndex = 13;
            this.bCrearLaberinto.UseVisualStyleBackColor = false;
            this.bCrearLaberinto.Click += new System.EventHandler(this.button6_Click);
            this.bCrearLaberinto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teclaPresionada);
            this.bCrearLaberinto.Leave += new System.EventHandler(this.button6_Leave);
            this.bCrearLaberinto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            this.bCrearLaberinto.MouseHover += new System.EventHandler(this.button4_MouseHover);
            this.bCrearLaberinto.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button6_MouseUp);
            this.bCrearLaberinto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.teclaPrevia);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 172);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(371, 166);
            this.progreso.MarqueeAnimationSpeed = 1;
            this.progreso.Maximum = 6206;
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(137, 33);
            this.progreso.Step = 1;
            this.progreso.TabIndex = 15;
            // 
            // bComenzar
            // 
            this.bComenzar.BackColor = System.Drawing.Color.Transparent;
            this.bComenzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bComenzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bComenzar.FlatAppearance.BorderSize = 0;
            this.bComenzar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.bComenzar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bComenzar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bComenzar.Location = new System.Drawing.Point(258, 11);
            this.bComenzar.Name = "bComenzar";
            this.bComenzar.Size = new System.Drawing.Size(100, 100);
            this.bComenzar.TabIndex = 16;
            this.bComenzar.UseVisualStyleBackColor = false;
            this.bComenzar.Enter += new System.EventHandler(this.button4_Enter);
            this.bComenzar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iniciar_MouseDown);
            this.bComenzar.MouseHover += new System.EventHandler(this.button4_MouseHover);
            this.bComenzar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.iniciar_MouseUp);
            // 
            // bInicio
            // 
            this.bInicio.BackColor = System.Drawing.Color.Transparent;
            this.bInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bInicio.FlatAppearance.BorderSize = 0;
            this.bInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bInicio.Location = new System.Drawing.Point(22, 11);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(100, 100);
            this.bInicio.TabIndex = 17;
            this.bInicio.UseVisualStyleBackColor = false;
            this.bInicio.Enter += new System.EventHandler(this.button4_Enter);
            this.bInicio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.bInicio.MouseHover += new System.EventHandler(this.button4_MouseHover);
            this.bInicio.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
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
            this.bGuardar.Location = new System.Drawing.Point(494, 11);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(100, 100);
            this.bGuardar.TabIndex = 18;
            this.bGuardar.TabStop = false;
            this.bGuardar.UseVisualStyleBackColor = false;
            this.bGuardar.Click += new System.EventHandler(this.button3_Click);
            this.bGuardar.Enter += new System.EventHandler(this.button4_Enter);
            this.bGuardar.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(743, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 54);
            this.button4.TabIndex = 19;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Enter += new System.EventHandler(this.button4_Enter);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lTiempo);
            this.groupBox1.Controls.Add(this.bCambiarAvatar);
            this.groupBox1.Controls.Add(this.bEnviarDatos);
            this.groupBox1.Controls.Add(this.bModoDeJuego);
            this.groupBox1.Controls.Add(this.bGuardar);
            this.groupBox1.Controls.Add(this.bInicio);
            this.groupBox1.Controls.Add(this.bComenzar);
            this.groupBox1.Controls.Add(this.bInvertir);
            this.groupBox1.Controls.Add(this.bCrearLaberinto);
            this.groupBox1.Location = new System.Drawing.Point(5, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 115);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // lTiempo
            // 
            this.lTiempo.AutoSize = true;
            this.lTiempo.BackColor = System.Drawing.Color.Black;
            this.lTiempo.Font = new System.Drawing.Font("Quartz MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTiempo.ForeColor = System.Drawing.Color.Yellow;
            this.lTiempo.Location = new System.Drawing.Point(972, 35);
            this.lTiempo.Name = "lTiempo";
            this.lTiempo.Size = new System.Drawing.Size(0, 35);
            this.lTiempo.TabIndex = 22;
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
            this.bCambiarAvatar.Location = new System.Drawing.Point(611, 11);
            this.bCambiarAvatar.Name = "bCambiarAvatar";
            this.bCambiarAvatar.Size = new System.Drawing.Size(100, 100);
            this.bCambiarAvatar.TabIndex = 21;
            this.bCambiarAvatar.TabStop = false;
            this.bCambiarAvatar.UseVisualStyleBackColor = false;
            this.bCambiarAvatar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.bCambiarAvatar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
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
            this.bEnviarDatos.Location = new System.Drawing.Point(850, 11);
            this.bEnviarDatos.Name = "bEnviarDatos";
            this.bEnviarDatos.Size = new System.Drawing.Size(100, 100);
            this.bEnviarDatos.TabIndex = 20;
            this.bEnviarDatos.TabStop = false;
            this.bEnviarDatos.UseVisualStyleBackColor = false;
            this.bEnviarDatos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bEnviarDatos_MouseDown);
            this.bEnviarDatos.MouseHover += new System.EventHandler(this.button4_MouseHover);
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
            this.bModoDeJuego.Location = new System.Drawing.Point(729, 11);
            this.bModoDeJuego.Name = "bModoDeJuego";
            this.bModoDeJuego.Size = new System.Drawing.Size(100, 100);
            this.bModoDeJuego.TabIndex = 19;
            this.bModoDeJuego.TabStop = false;
            this.bModoDeJuego.UseVisualStyleBackColor = false;
            this.bModoDeJuego.Click += new System.EventHandler(this.bModoDeJuego_Click);
            this.bModoDeJuego.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bModoDeJuego_MouseDown);
            this.bModoDeJuego.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1027, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "labManual";
            this.Text = "labManual";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.labManual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bCrearLaberinto;
        private System.Windows.Forms.Button bInvertir;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.Button bComenzar;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bEnviarDatos;
        private System.Windows.Forms.Button bModoDeJuego;
        private System.Windows.Forms.Button bCambiarAvatar;
        public System.Windows.Forms.Label lTiempo;
        private System.Windows.Forms.Timer timer1;
    }
}