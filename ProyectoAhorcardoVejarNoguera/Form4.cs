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
    public partial class Form4 : Form
    {
        Dictionary<string, string> usuarios = new Dictionary<string, string>()
        {
           { "CarlosVejar", "casa12345" },
            {"Axel", "ct123" },

        };

        public Form4()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == contraseña)
            {
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
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
