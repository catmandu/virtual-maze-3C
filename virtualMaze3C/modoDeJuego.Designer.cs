namespace virtualMaze3C
{
    partial class modoDeJuego
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
            this.bModoAceptar = new System.Windows.Forms.Button();
            this.bModoLibre = new System.Windows.Forms.Button();
            this.bModoTiempo = new System.Windows.Forms.Button();
            this.bModoCancelar = new System.Windows.Forms.Button();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // bModoAceptar
            // 
            this.bModoAceptar.BackColor = System.Drawing.Color.White;
            this.bModoAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bModoAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bModoAceptar.FlatAppearance.BorderSize = 0;
            this.bModoAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModoAceptar.Location = new System.Drawing.Point(81, 279);
            this.bModoAceptar.Name = "bModoAceptar";
            this.bModoAceptar.Size = new System.Drawing.Size(100, 80);
            this.bModoAceptar.TabIndex = 5;
            this.bModoAceptar.UseVisualStyleBackColor = false;
            this.bModoAceptar.Click += new System.EventHandler(this.button1_Click);
            this.bModoAceptar.MouseHover += new System.EventHandler(this.bModoCancelar_MouseHover);
            // 
            // bModoLibre
            // 
            this.bModoLibre.BackColor = System.Drawing.Color.White;
            this.bModoLibre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bModoLibre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bModoLibre.FlatAppearance.BorderSize = 0;
            this.bModoLibre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModoLibre.Location = new System.Drawing.Point(49, 114);
            this.bModoLibre.Name = "bModoLibre";
            this.bModoLibre.Size = new System.Drawing.Size(120, 120);
            this.bModoLibre.TabIndex = 6;
            this.bModoLibre.UseVisualStyleBackColor = false;
            this.bModoLibre.Click += new System.EventHandler(this.bModoLibre_Click);
            this.bModoLibre.MouseHover += new System.EventHandler(this.bModoCancelar_MouseHover);
            // 
            // bModoTiempo
            // 
            this.bModoTiempo.BackColor = System.Drawing.Color.White;
            this.bModoTiempo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bModoTiempo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bModoTiempo.FlatAppearance.BorderSize = 0;
            this.bModoTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModoTiempo.Location = new System.Drawing.Point(218, 114);
            this.bModoTiempo.Name = "bModoTiempo";
            this.bModoTiempo.Size = new System.Drawing.Size(120, 120);
            this.bModoTiempo.TabIndex = 7;
            this.bModoTiempo.UseVisualStyleBackColor = false;
            this.bModoTiempo.Click += new System.EventHandler(this.bModoTiempo_Click);
            this.bModoTiempo.MouseHover += new System.EventHandler(this.bModoCancelar_MouseHover);
            // 
            // bModoCancelar
            // 
            this.bModoCancelar.BackColor = System.Drawing.Color.White;
            this.bModoCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bModoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bModoCancelar.FlatAppearance.BorderSize = 0;
            this.bModoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModoCancelar.Location = new System.Drawing.Point(200, 279);
            this.bModoCancelar.Name = "bModoCancelar";
            this.bModoCancelar.Size = new System.Drawing.Size(100, 80);
            this.bModoCancelar.TabIndex = 8;
            this.bModoCancelar.UseVisualStyleBackColor = false;
            this.bModoCancelar.Click += new System.EventHandler(this.bModoCancelar_Click);
            this.bModoCancelar.MouseHover += new System.EventHandler(this.bModoCancelar_MouseHover);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.BackColor = System.Drawing.Color.Transparent;
            this.rb1.Checked = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.ForeColor = System.Drawing.Color.Purple;
            this.rb1.Location = new System.Drawing.Point(40, 245);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(79, 28);
            this.rb1.TabIndex = 9;
            this.rb1.TabStop = true;
            this.rb1.Text = "1 min";
            this.rb1.UseVisualStyleBackColor = false;
            this.rb1.Visible = false;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.BackColor = System.Drawing.Color.Transparent;
            this.rb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.ForeColor = System.Drawing.Color.Purple;
            this.rb3.Location = new System.Drawing.Point(149, 245);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(79, 28);
            this.rb3.TabIndex = 10;
            this.rb3.TabStop = true;
            this.rb3.Text = "3 min";
            this.rb3.UseVisualStyleBackColor = false;
            this.rb3.Visible = false;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.BackColor = System.Drawing.Color.Transparent;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb5.ForeColor = System.Drawing.Color.Purple;
            this.rb5.Location = new System.Drawing.Point(257, 245);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(79, 28);
            this.rb5.TabIndex = 11;
            this.rb5.TabStop = true;
            this.rb5.Text = "5 min";
            this.rb5.UseVisualStyleBackColor = false;
            this.rb5.Visible = false;
            // 
            // modoDeJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 387);
            this.Controls.Add(this.rb5);
            this.Controls.Add(this.rb3);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.bModoCancelar);
            this.Controls.Add(this.bModoTiempo);
            this.Controls.Add(this.bModoLibre);
            this.Controls.Add(this.bModoAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modoDeJuego";
            this.Text = "modoDeJuego";
            this.Load += new System.EventHandler(this.modoDeJuego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bModoAceptar;
        private System.Windows.Forms.Button bModoLibre;
        private System.Windows.Forms.Button bModoTiempo;
        private System.Windows.Forms.Button bModoCancelar;
        public System.Windows.Forms.RadioButton rb1;
        public System.Windows.Forms.RadioButton rb3;
        public System.Windows.Forms.RadioButton rb5;

    }
}