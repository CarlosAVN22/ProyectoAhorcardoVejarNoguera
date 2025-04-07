namespace ProyectoAhorcardoVejarNoguera
{
    partial class Ajedrez
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresarJuegos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.descarga__1_;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(748, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresarJuegos
            // 
            this.btnRegresarJuegos.Location = new System.Drawing.Point(642, 565);
            this.btnRegresarJuegos.Name = "btnRegresarJuegos";
            this.btnRegresarJuegos.Size = new System.Drawing.Size(113, 42);
            this.btnRegresarJuegos.TabIndex = 1;
            this.btnRegresarJuegos.Text = "Regresar";
            this.btnRegresarJuegos.UseVisualStyleBackColor = true;
            this.btnRegresarJuegos.Click += new System.EventHandler(this.btnRegresarJuegos_Click);
            // 
            // Ajedrez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.btnRegresarJuegos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ajedrez";
            this.Text = "Ajedrez";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresarJuegos;
    }
}