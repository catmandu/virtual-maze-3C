namespace virtualMaze3C
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.bPrincipalGenerar = new System.Windows.Forms.Button();
            this.bPrincipalCrear = new System.Windows.Forms.Button();
            this.bPrincipalAbrir = new System.Windows.Forms.Button();
            this.bPrincipalSalir = new System.Windows.Forms.Button();
            this.reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).BeginInit();
            this.SuspendLayout();
            // 
            // bPrincipalGenerar
            // 
            this.bPrincipalGenerar.BackColor = System.Drawing.Color.White;
            this.bPrincipalGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrincipalGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPrincipalGenerar.FlatAppearance.BorderSize = 0;
            this.bPrincipalGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrincipalGenerar.Location = new System.Drawing.Point(65, 188);
            this.bPrincipalGenerar.Name = "bPrincipalGenerar";
            this.bPrincipalGenerar.Size = new System.Drawing.Size(156, 129);
            this.bPrincipalGenerar.TabIndex = 0;
            this.bPrincipalGenerar.UseVisualStyleBackColor = false;
            this.bPrincipalGenerar.Click += new System.EventHandler(this.button1_Click);
            this.bPrincipalGenerar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.bPrincipalGenerar.MouseHover += new System.EventHandler(this.button3_MouseHover);
            this.bPrincipalGenerar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // bPrincipalCrear
            // 
            this.bPrincipalCrear.BackColor = System.Drawing.Color.White;
            this.bPrincipalCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrincipalCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPrincipalCrear.FlatAppearance.BorderSize = 0;
            this.bPrincipalCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrincipalCrear.Location = new System.Drawing.Point(241, 188);
            this.bPrincipalCrear.Name = "bPrincipalCrear";
            this.bPrincipalCrear.Size = new System.Drawing.Size(156, 129);
            this.bPrincipalCrear.TabIndex = 1;
            this.bPrincipalCrear.UseVisualStyleBackColor = false;
            this.bPrincipalCrear.Click += new System.EventHandler(this.button2_Click);
            this.bPrincipalCrear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.bPrincipalCrear.MouseHover += new System.EventHandler(this.button3_MouseHover);
            this.bPrincipalCrear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // bPrincipalAbrir
            // 
            this.bPrincipalAbrir.BackColor = System.Drawing.Color.White;
            this.bPrincipalAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrincipalAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPrincipalAbrir.FlatAppearance.BorderSize = 0;
            this.bPrincipalAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrincipalAbrir.Location = new System.Drawing.Point(415, 188);
            this.bPrincipalAbrir.Name = "bPrincipalAbrir";
            this.bPrincipalAbrir.Size = new System.Drawing.Size(156, 129);
            this.bPrincipalAbrir.TabIndex = 2;
            this.bPrincipalAbrir.UseVisualStyleBackColor = false;
            this.bPrincipalAbrir.Click += new System.EventHandler(this.button3_Click);
            this.bPrincipalAbrir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.bPrincipalAbrir.MouseHover += new System.EventHandler(this.button3_MouseHover);
            this.bPrincipalAbrir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // bPrincipalSalir
            // 
            this.bPrincipalSalir.BackColor = System.Drawing.Color.White;
            this.bPrincipalSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bPrincipalSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bPrincipalSalir.FlatAppearance.BorderSize = 0;
            this.bPrincipalSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrincipalSalir.Location = new System.Drawing.Point(494, 338);
            this.bPrincipalSalir.Name = "bPrincipalSalir";
            this.bPrincipalSalir.Size = new System.Drawing.Size(109, 72);
            this.bPrincipalSalir.TabIndex = 3;
            this.bPrincipalSalir.UseVisualStyleBackColor = false;
            this.bPrincipalSalir.Click += new System.EventHandler(this.button4_Click);
            this.bPrincipalSalir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.bPrincipalSalir.MouseHover += new System.EventHandler(this.button3_MouseHover);
            this.bPrincipalSalir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // reproductor
            // 
            this.reproductor.Enabled = true;
            this.reproductor.Location = new System.Drawing.Point(31, 363);
            this.reproductor.Name = "reproductor";
            this.reproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("reproductor.OcxState")));
            this.reproductor.Size = new System.Drawing.Size(75, 23);
            this.reproductor.TabIndex = 4;
            this.reproductor.Visible = false;
            this.reproductor.Enter += new System.EventHandler(this.reproductor_Enter);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 431);
            this.ControlBox = false;
            this.Controls.Add(this.reproductor);
            this.Controls.Add(this.bPrincipalSalir);
            this.Controls.Add(this.bPrincipalAbrir);
            this.Controls.Add(this.bPrincipalCrear);
            this.Controls.Add(this.bPrincipalGenerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Maze 3C";
            this.Load += new System.EventHandler(this.principal_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.principal_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.reproductor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bPrincipalGenerar;
        private System.Windows.Forms.Button bPrincipalCrear;
        private System.Windows.Forms.Button bPrincipalAbrir;
        private System.Windows.Forms.Button bPrincipalSalir;
        private AxWMPLib.AxWindowsMediaPlayer reproductor;

    }
}