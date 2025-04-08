using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAhorcardoVejarNoguera
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Size = new Size(1000, 667);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1000, 667);
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                this.Close();
            }
            
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.Size = new Size(btnSalir.Width + 10, btnSalir.Height + 10);
            btnSalir.BackColor = Color.Red;
            btnSalir.ForeColor = Color.Black;

        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.Size = new Size(btnSalir.Width - 10, btnSalir.Height - 10);
            btnSalir.BackColor = Color.White;
            btnSalir.ForeColor = Color.Black;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnInicioSesion_MouseEnter(object sender, EventArgs e)
        {
            btnInicioSesion.Size = new Size(btnInicioSesion.Width + 10, btnInicioSesion.Height + 10);
            btnInicioSesion.BackColor = Color.Gold;
            btnInicioSesion.ForeColor = Color.Black;
            
        }

        private void btnInicioSesion_MouseLeave(object sender, EventArgs e)
        {
            btnInicioSesion.Size = new Size(btnInicioSesion.Width - 10, btnInicioSesion.Height - 10);
            btnInicioSesion.BackColor = Color.Black;
            btnInicioSesion.ForeColor = Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void btnRegistrarse_MouseEnter(object sender, EventArgs e)
        {
            btnRegistrarse.Size = new Size(btnRegistrarse.Width + 10, btnRegistrarse.Height + 10);
            btnRegistrarse.BackColor = Color.Gold;
            btnRegistrarse.ForeColor = Color.Black;

        }

        private void btnRegistrarse_MouseLeave(object sender, EventArgs e)
        {
            btnRegistrarse.Size = new Size(btnRegistrarse.Width - 10, btnRegistrarse.Height - 10);
            btnRegistrarse.BackColor = Color.Black;
            btnRegistrarse.ForeColor = Color.White;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
