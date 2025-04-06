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
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                this.Close();
            }
            
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }
    }
    
}
