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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            
            axWindowsMediaPlayer1.URL = @"C:\Users\ASUS\Desktop\ahorcado.mp4"; 
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(int newState)
        {
           
            if (newState == 1)
            {
                this.Close(); 
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }


    }
}



