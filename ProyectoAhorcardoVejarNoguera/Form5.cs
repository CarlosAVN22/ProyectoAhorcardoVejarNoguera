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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void picAhorcado_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresarLogin_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void cartaspic_Click(object sender, EventArgs e)
        {
            cartas cartas = new cartas();
            cartas.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pingpong pingpong = new pingpong();
            pingpong.Show();
            this.Hide();
        }

        private void PicChess_Click(object sender, EventArgs e)
        {
            Ajedrez ajedrez = new Ajedrez();
            ajedrez.Show();
            this.Hide();
        }

        private void PicRompecabezas_Click(object sender, EventArgs e)
        {
            Rompecabeza rompecabeza = new Rompecabeza();
            rompecabeza.Show();
            this.Hide();
        }

        private void PicMonopoly_Click(object sender, EventArgs e)
        {
            Interfaz_Monopoy interfaz_Monopoy = new Interfaz_Monopoy();
            interfaz_Monopoy.Show();
            this.Hide();
        }

        private void PicSudoku_Click(object sender, EventArgs e)
        {
            Sudoku sudoku = new Sudoku();
            sudoku.Show();
            this.Hide();
        }

        private void PicTetris_Click(object sender, EventArgs e)
        {
            Tetris tetris = new Tetris();
            tetris.Show();
            this.Hide();
        }

        private void PicSnake_Click(object sender, EventArgs e)
        {
            Serpiente serpiente = new Serpiente();
            serpiente.Show();
            this.Hide();
        }

        private void PicUno_Click(object sender, EventArgs e)
        {
            Uno_Interfaz uno_Interfaz = new Uno_Interfaz();
            uno_Interfaz.Show();
            this.Hide();
        }
    }
}
