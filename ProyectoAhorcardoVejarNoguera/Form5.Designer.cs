﻿namespace ProyectoAhorcardoVejarNoguera
{
    partial class Form5
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
            this.picAhorcado = new System.Windows.Forms.PictureBox();
            this.PicChess = new System.Windows.Forms.PictureBox();
            this.PicSnake = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicChess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSnake)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20);
            this.label1.Size = new System.Drawing.Size(173, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Juegos ";
            // 
            // picAhorcado
            // 
            this.picAhorcado.BackColor = System.Drawing.Color.Transparent;
            this.picAhorcado.Image = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.Ahorcado;
            this.picAhorcado.Location = new System.Drawing.Point(50, 150);
            this.picAhorcado.Name = "picAhorcado";
            this.picAhorcado.Size = new System.Drawing.Size(150, 150);
            this.picAhorcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAhorcado.TabIndex = 1;
            this.picAhorcado.TabStop = false;
            this.picAhorcado.Click += new System.EventHandler(this.picAhorcado_Click);
            // 
            // PicChess
            // 
            this.PicChess.BackColor = System.Drawing.Color.Transparent;
            this.PicChess.Image = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.chess11;
            this.PicChess.Location = new System.Drawing.Point(197, 150);
            this.PicChess.Name = "PicChess";
            this.PicChess.Size = new System.Drawing.Size(150, 150);
            this.PicChess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicChess.TabIndex = 2;
            this.PicChess.TabStop = false;
            // 
            // PicSnake
            // 
            this.PicSnake.BackColor = System.Drawing.Color.Transparent;
            this.PicSnake.Image = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.Snake;
            this.PicSnake.Location = new System.Drawing.Point(341, 150);
            this.PicSnake.Name = "PicSnake";
            this.PicSnake.Size = new System.Drawing.Size(150, 150);
            this.PicSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSnake.TabIndex = 3;
            this.PicSnake.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoAhorcardoVejarNoguera.Properties.Resources.ae508467_2673_43d5_9fb9_53570ac3a51d;
            this.ClientSize = new System.Drawing.Size(1175, 519);
            this.Controls.Add(this.PicSnake);
            this.Controls.Add(this.PicChess);
            this.Controls.Add(this.picAhorcado);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.picAhorcado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicChess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSnake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAhorcado;
        private System.Windows.Forms.PictureBox PicChess;
        private System.Windows.Forms.PictureBox PicSnake;
    }
}