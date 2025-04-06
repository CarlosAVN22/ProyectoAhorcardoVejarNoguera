using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static ProyectoAhorcardoVejarNoguera.Form4;

namespace ProyectoAhorcardoVejarNoguera
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (!string.IsNullOrWhiteSpace(usuario) && !string.IsNullOrWhiteSpace(contraseña))
            {
                Usuarios.RegistrarUsuario(usuario, contraseña);
                MessageBox.Show("Usuario registrado con éxito");

                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un usuario y contraseña válidos");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            {
                txtUsuario.Text = "";
                txtContraseña.Text = "";


                txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
        }
    }
}
