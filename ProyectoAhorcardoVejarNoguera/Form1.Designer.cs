namespace ProyectoAhorcardoVejarNoguera
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flFichas = new System.Windows.Forms.FlowLayoutPanel();
            this.flPalabras = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIntentos = new System.Windows.Forms.ComboBox();
            this.lblDerrotas = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVictorias = new System.Windows.Forms.Label();
            this.btnAbrirForm2 = new System.Windows.Forms.Button();
            this.btnInterfaz = new System.Windows.Forms.Button();
            this.btnFinDelJuego = new System.Windows.Forms.PictureBox();
            this.btnInicioJuegoo = new System.Windows.Forms.PictureBox();
            this.picAhorcado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinDelJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicioJuegoo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // flFichas
            // 
            this.flFichas.BackColor = System.Drawing.Color.Transparent;
            this.flFichas.Location = new System.Drawing.Point(27, 207);
            this.flFichas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flFichas.Name = "flFichas";
            this.flFichas.Size = new System.Drawing.Size(461, 174);
            this.flFichas.TabIndex = 0;
            // 
            // flPalabras
            // 
            this.flPalabras.BackColor = System.Drawing.Color.Transparent;
            this.flPalabras.Location = new System.Drawing.Point(27, 400);
            this.flPalabras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flPalabras.Name = "flPalabras";
            this.flPalabras.Size = new System.Drawing.Size(763, 82);
            this.flPalabras.TabIndex = 1;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(612, 124);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(2);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.lblMensaje.Size = new System.Drawing.Size(119, 32);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "LO MATASTE!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(23, 124);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label2.Size = new System.Drawing.Size(250, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "ADIVINA LA PALABRA SI PUEDES!!";
            // 
            // cmbIntentos
            // 
            this.cmbIntentos.FormattingEnabled = true;
            this.cmbIntentos.Location = new System.Drawing.Point(425, 86);
            this.cmbIntentos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIntentos.Name = "cmbIntentos";
            this.cmbIntentos.Size = new System.Drawing.Size(85, 24);
            this.cmbIntentos.TabIndex = 6;
            // 
            // lblDerrotas
            // 
            this.lblDerrotas.AutoSize = true;
            this.lblDerrotas.Location = new System.Drawing.Point(551, 46);
            this.lblDerrotas.Name = "lblDerrotas";
            this.lblDerrotas.Size = new System.Drawing.Size(77, 32);
            this.lblDerrotas.TabIndex = 7;
            this.lblDerrotas.Text = "Numero de \r\nderrotas: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Elige numero\r\n de intentos";
            // 
            // lblVictorias
            // 
            this.lblVictorias.AutoSize = true;
            this.lblVictorias.Location = new System.Drawing.Point(551, 86);
            this.lblVictorias.Name = "lblVictorias";
            this.lblVictorias.Size = new System.Drawing.Size(62, 16);
            this.lblVictorias.TabIndex = 10;
            this.lblVictorias.Text = "Victorias:";
            // 
            // btnAbrirForm2
            // 
            this.btnAbrirForm2.Location = new System.Drawing.Point(436, 10);
            this.btnAbrirForm2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbrirForm2.Name = "btnAbrirForm2";
            this.btnAbrirForm2.Size = new System.Drawing.Size(122, 26);
            this.btnAbrirForm2.TabIndex = 11;
            this.btnAbrirForm2.Text = "Reproducir video";
            this.btnAbrirForm2.UseVisualStyleBackColor = true;
            this.btnAbrirForm2.Click += new System.EventHandler(this.btnAbrirForm2_Click_1);
            // 
            // btnInterfaz
            // 
            this.btnInterfaz.Location = new System.Drawing.Point(789, 431);
            this.btnInterfaz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInterfaz.Name = "btnInterfaz";
            this.btnInterfaz.Size = new System.Drawing.Size(92, 50);
            this.btnInterfaz.TabIndex = 12;
            this.btnInterfaz.Text = "Salir";
            this.btnInterfaz.UseVisualStyleBackColor = true;
            this.btnInterfaz.Click += new System.EventHandler(this.btnInterfaz_Click);
            // 
            // btnFinDelJuego
            // 
            this.btnFinDelJuego.Image = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.findeljuego;
            this.btnFinDelJuego.Location = new System.Drawing.Point(733, 15);
            this.btnFinDelJuego.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinDelJuego.Name = "btnFinDelJuego";
            this.btnFinDelJuego.Size = new System.Drawing.Size(117, 68);
            this.btnFinDelJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFinDelJuego.TabIndex = 8;
            this.btnFinDelJuego.TabStop = false;
            this.btnFinDelJuego.Click += new System.EventHandler(this.btnFinDelJuego_Click);
            // 
            // btnInicioJuegoo
            // 
            this.btnInicioJuegoo.BackColor = System.Drawing.Color.Transparent;
            this.btnInicioJuegoo.Image = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.btnstart_removebg__1_;
            this.btnInicioJuegoo.Location = new System.Drawing.Point(11, 2);
            this.btnInicioJuegoo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicioJuegoo.Name = "btnInicioJuegoo";
            this.btnInicioJuegoo.Size = new System.Drawing.Size(267, 106);
            this.btnInicioJuegoo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnInicioJuegoo.TabIndex = 3;
            this.btnInicioJuegoo.TabStop = false;
            this.btnInicioJuegoo.Click += new System.EventHandler(this.btnInicioJuegoo_Click);
            // 
            // picAhorcado
            // 
            this.picAhorcado.BackColor = System.Drawing.Color.Transparent;
            this.picAhorcado.Location = new System.Drawing.Point(555, 207);
            this.picAhorcado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAhorcado.Name = "picAhorcado";
            this.picAhorcado.Size = new System.Drawing.Size(235, 157);
            this.picAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcado.TabIndex = 2;
            this.picAhorcado.TabStop = false;
            this.picAhorcado.Click += new System.EventHandler(this.picAhorcado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.fondoahorcado_jpeg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(892, 503);
            this.Controls.Add(this.btnInterfaz);
            this.Controls.Add(this.btnAbrirForm2);
            this.Controls.Add(this.lblVictorias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFinDelJuego);
            this.Controls.Add(this.lblDerrotas);
            this.Controls.Add(this.cmbIntentos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnInicioJuegoo);
            this.Controls.Add(this.picAhorcado);
            this.Controls.Add(this.flPalabras);
            this.Controls.Add(this.flFichas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnFinDelJuego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicioJuegoo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flFichas;
        private System.Windows.Forms.FlowLayoutPanel flPalabras;
        private System.Windows.Forms.PictureBox picAhorcado;
        private System.Windows.Forms.PictureBox btnInicioJuegoo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIntentos;
        private System.Windows.Forms.Label lblDerrotas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox btnFinDelJuego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVictorias;
        private System.Windows.Forms.Button btnAbrirForm2;
        private System.Windows.Forms.Button btnInterfaz;
    }
}

