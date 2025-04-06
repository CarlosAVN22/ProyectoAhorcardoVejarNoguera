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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(272, 31);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.label1.Size = new System.Drawing.Size(301, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escoger entre las siguientes opciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(151, 181);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 30, 30, 30);
            this.label2.Size = new System.Drawing.Size(159, 80);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inicio Sesion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(338, 459);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(171, 48);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir ";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInicioSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInicioSesion.Location = new System.Drawing.Point(182, 279);
            this.btnInicioSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(86, 54);
            this.btnInicioSesion.TabIndex = 7;
            this.btnInicioSesion.Text = "Entrar";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 181);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(30);
            this.label3.Size = new System.Drawing.Size(151, 80);
            this.label3.TabIndex = 8;
            this.label3.Text = "Registrarse";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistrarse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegistrarse.Location = new System.Drawing.Point(574, 278);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(87, 55);
            this.btnRegistrarse.TabIndex = 9;
            this.btnRegistrarse.Text = "Entrar";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.ae508467_2673_43d5_9fb9_53570ac3a51d;
            this.ClientSize = new System.Drawing.Size(907, 519);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrarse;
    }
}