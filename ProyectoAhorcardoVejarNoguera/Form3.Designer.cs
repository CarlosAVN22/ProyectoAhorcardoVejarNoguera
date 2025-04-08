namespace ProyectoAhorcardoVejarNoguera
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(599, 489);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(148, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir ";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInicioSesion.Location = new System.Drawing.Point(599, 366);
            this.btnInicioSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(148, 43);
            this.btnInicioSesion.TabIndex = 7;
            this.btnInicioSesion.Text = "Iniciar Sesion";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            this.btnInicioSesion.MouseEnter += new System.EventHandler(this.btnInicioSesion_MouseEnter);
            this.btnInicioSesion.MouseLeave += new System.EventHandler(this.btnInicioSesion_MouseLeave);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrarse.Location = new System.Drawing.Point(599, 427);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(148, 44);
            this.btnRegistrarse.TabIndex = 9;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            this.btnRegistrarse.MouseEnter += new System.EventHandler(this.btnRegistrarse_MouseEnter);
            this.btnRegistrarse.MouseLeave += new System.EventHandler(this.btnRegistrarse_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.inicio__1_;
            this.pictureBox1.Location = new System.Drawing.Point(552, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 219);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.fondo__1_;
            this.ClientSize = new System.Drawing.Size(991, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Devs Console Games";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}