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
            this.btnFinDelJuego = new System.Windows.Forms.PictureBox();
            this.btnInicioJuegoo = new System.Windows.Forms.PictureBox();
            this.picAhorcado = new System.Windows.Forms.PictureBox();
            this.btnInterfaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinDelJuego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicioJuegoo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // flFichas
            // 
            this.flFichas.Location = new System.Drawing.Point(30, 259);
            this.flFichas.Name = "flFichas";
            this.flFichas.Size = new System.Drawing.Size(519, 217);
            this.flFichas.TabIndex = 0;
            // 
            // flPalabras
            // 
            this.flPalabras.Location = new System.Drawing.Point(30, 500);
            this.flPalabras.Name = "flPalabras";
            this.flPalabras.Size = new System.Drawing.Size(858, 102);
            this.flPalabras.TabIndex = 1;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(689, 155);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(2);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Padding = new System.Windows.Forms.Padding(10);
            this.lblMensaje.Size = new System.Drawing.Size(141, 40);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "LO MATASTE!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(26, 155);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15);
            this.label2.Size = new System.Drawing.Size(307, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "ADIVINA LA PALABRA SI PUEDES!!";
            // 
            // cmbIntentos
            // 
            this.cmbIntentos.FormattingEnabled = true;
            this.cmbIntentos.Location = new System.Drawing.Point(478, 107);
            this.cmbIntentos.Name = "cmbIntentos";
            this.cmbIntentos.Size = new System.Drawing.Size(95, 28);
            this.cmbIntentos.TabIndex = 6;
            // 
            // lblDerrotas
            // 
            this.lblDerrotas.AutoSize = true;
            this.lblDerrotas.Location = new System.Drawing.Point(620, 57);
            this.lblDerrotas.Name = "lblDerrotas";
            this.lblDerrotas.Size = new System.Drawing.Size(91, 40);
            this.lblDerrotas.TabIndex = 7;
            this.lblDerrotas.Text = "Numero de \r\nderrotas: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Elige numero\r\n de intentos";
            // 
            // lblVictorias
            // 
            this.lblVictorias.AutoSize = true;
            this.lblVictorias.Location = new System.Drawing.Point(620, 107);
            this.lblVictorias.Name = "lblVictorias";
            this.lblVictorias.Size = new System.Drawing.Size(74, 20);
            this.lblVictorias.TabIndex = 10;
            this.lblVictorias.Text = "Victorias:";
            // 
            // btnAbrirForm2
            // 
            this.btnAbrirForm2.Location = new System.Drawing.Point(490, 12);
            this.btnAbrirForm2.Name = "btnAbrirForm2";
            this.btnAbrirForm2.Size = new System.Drawing.Size(137, 32);
            this.btnAbrirForm2.TabIndex = 11;
            this.btnAbrirForm2.Text = "Reproducir video";
            this.btnAbrirForm2.UseVisualStyleBackColor = true;
            // 
            // btnFinDelJuego
            // 
            this.btnFinDelJuego.Image = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.findeljuego;
            this.btnFinDelJuego.Location = new System.Drawing.Point(825, 19);
            this.btnFinDelJuego.Name = "btnFinDelJuego";
            this.btnFinDelJuego.Size = new System.Drawing.Size(132, 85);
            this.btnFinDelJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFinDelJuego.TabIndex = 8;
            this.btnFinDelJuego.TabStop = false;
            this.btnFinDelJuego.Click += new System.EventHandler(this.btnFinDelJuego_Click);
            // 
            // btnInicioJuegoo
            // 
            this.btnInicioJuegoo.Image = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.Screenshot_2025_03_26_162758;
            this.btnInicioJuegoo.Location = new System.Drawing.Point(12, 3);
            this.btnInicioJuegoo.Name = "btnInicioJuegoo";
            this.btnInicioJuegoo.Size = new System.Drawing.Size(275, 85);
            this.btnInicioJuegoo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnInicioJuegoo.TabIndex = 3;
            this.btnInicioJuegoo.TabStop = false;
            this.btnInicioJuegoo.Click += new System.EventHandler(this.btnInicioJuegoo_Click);
            // 
            // picAhorcado
            // 
            this.picAhorcado.Location = new System.Drawing.Point(624, 259);
            this.picAhorcado.Name = "picAhorcado";
            this.picAhorcado.Size = new System.Drawing.Size(264, 196);
            this.picAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcado.TabIndex = 2;
            this.picAhorcado.TabStop = false;
            this.picAhorcado.Click += new System.EventHandler(this.picAhorcado_Click);
            // 
            // btnInterfaz
            // 
            this.btnInterfaz.Location = new System.Drawing.Point(888, 539);
            this.btnInterfaz.Name = "btnInterfaz";
            this.btnInterfaz.Size = new System.Drawing.Size(103, 63);
            this.btnInterfaz.TabIndex = 12;
            this.btnInterfaz.Text = "Salir";
            this.btnInterfaz.UseVisualStyleBackColor = true;
            this.btnInterfaz.Click += new System.EventHandler(this.btnInterfaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1003, 629);
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

