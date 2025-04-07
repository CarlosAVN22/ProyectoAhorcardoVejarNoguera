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
    public partial class pingpong: Form
    {
        public pingpong()
        {
            InitializeComponent();
        }

        private void pingpong_Load(object sender, EventArgs e)
        {

        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
