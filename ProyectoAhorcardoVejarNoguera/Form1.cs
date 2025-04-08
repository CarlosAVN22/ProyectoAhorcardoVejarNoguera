using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace ProyectoAhorcardoVejarNoguera
{
    public partial class Form1 : Form
    {
        char[] palabrasAdivinadas;
        int oportunidades;
        char[] palabrasSelecionadas;
        string[] palabras;
        int contadorDerrotas = 0;
        int contadorVictorias = 0;

        public Form1()
        {

            InitializeComponent();

            
            cmbIntentos.Items.Add(1);
            cmbIntentos.Items.Add(2);
            cmbIntentos.Items.Add(3);
            cmbIntentos.Items.Add(4);
            cmbIntentos.Items.Add(5);
            cmbIntentos.Items.Add(6);
            cmbIntentos.Items.Add(7);
            cmbIntentos.Items.Add(8);
            cmbIntentos.Items.Add(9);
            cmbIntentos.Items.Add(10);
            cmbIntentos.SelectedIndex = 0; 

            btnFinDelJuego.Click += BtnFinDelJuego_Click;

            btnAbrirForm2.Click += btnAbrirForm2_Click;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // De momento puede estar vacío
        }



        private void btnAbrirForm2_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.ShowDialog(); 
        }




        private void cmbIntentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            oportunidades = int.Parse(cmbIntentos.SelectedItem.ToString());
        }


        public void iniciarJuego()
        {
            
            flFichas.Controls.Clear();
            flPalabras.Controls.Clear();
            flPalabras.Enabled = true;
            flFichas.Enabled = true;
            picAhorcado.Image = null;
            lblMensaje.Visible = false;

            
            oportunidades = int.Parse(cmbIntentos.SelectedItem?.ToString() ?? "10"); 
            btnInicioJuegoo.Image = Properties.Resources.Screenshot_2025_03_26_162758;

            palabras = new string[] { "barco", "campo", "diente", "rápido", "tierra", "fuego", "nube", "cactus", "fuerte", "pizarra",
                              "carro", "castillo", "pincel", "camello", "relampago", 
                              "cocodrilo", "delfin", "jirafa", "estrella", "biblioteca" };

            
            Random random = new Random();
            int indicePalabraSeleccionada = random.Next(palabras.Length);
            palabrasSelecionadas = palabras[indicePalabraSeleccionada].ToUpper().ToCharArray();
            palabrasAdivinadas = new char[palabrasSelecionadas.Length];
            for (int i = 0; i < palabrasAdivinadas.Length; i++)
                palabrasAdivinadas[i] = '_';

           
            string alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
            foreach (char letra in alfabeto)
            {
                Button btnLetra = new Button();
                btnLetra.Text = letra.ToString();
                btnLetra.Width = 30;
                btnLetra.Height = 40;
                btnLetra.Click += Compara;
                btnLetra.ForeColor = Color.White;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.BackColor = Color.Black;
                btnLetra.Name = letra.ToString();
                flFichas.Controls.Add(btnLetra);
            }

            
            for (int i = 0; i < palabrasSelecionadas.Length; i++)
            {
                Button letra = new Button();
                letra.Tag = palabrasSelecionadas[i].ToString();
                letra.Width = 50;
                letra.Height = 60;
                letra.ForeColor = Color.Blue;
                letra.Font = new Font(letra.Font.Name, 32, FontStyle.Bold);
                letra.BackColor = Color.White;
                letra.Name = "Adivinado" + i;
                letra.Text = "_";
                flPalabras.Controls.Add(letra);
            }
        }

        void Compara(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Blue;
            btn.Enabled = false;

            bool encontrado = false;
            char letraSeleccionada = char.Parse(btn.Text);

            
            for (int i = 0; i < palabrasSelecionadas.Length; i++)
            {
                if (palabrasSelecionadas[i] == letraSeleccionada)
                {
                    Button tbx = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                    if (tbx != null)
                    {
                        tbx.Text = letraSeleccionada.ToString();
                        palabrasAdivinadas[i] = letraSeleccionada;
                    }
                    encontrado = true;
                }
            }

            
            if (!palabrasAdivinadas.Contains('_'))
            {
                contadorVictorias++; 
                lblVictorias.Text = "Victorias: " + contadorVictorias; 
                MessageBox.Show("¡Ganaste!");
                flFichas.Enabled = false;
                return;
            }

            if (!encontrado)
            {
                oportunidades--; 
                int totalIntentos = int.Parse(cmbIntentos.SelectedItem.ToString());
                int[] imagenesPorIntento = { 10 }; 

                switch (totalIntentos)
                {
                    case 1:
                        imagenesPorIntento = new int[] { 4, 10 };
                        break;
                    case 2:
                        imagenesPorIntento = new int[] { 4, 9, 10 };
                        break;
                    case 3:
                        imagenesPorIntento = new int[] { 4, 5, 9, 10 };
                        break;
                    case 4:
                        imagenesPorIntento = new int[] { 4, 5, 7, 9, 10 };
                        break;
                    case 5:
                        imagenesPorIntento = new int[] { 3, 4, 5, 7, 9, 10 };
                        break;
                    case 6:
                        imagenesPorIntento = new int[] { 1, 3, 4, 5, 7, 9, 10 };
                        break;
                    case 7:
                        imagenesPorIntento = new int[] { 1, 2, 3, 4, 5, 7, 9, 10 };
                        break;
                    case 8:
                        imagenesPorIntento = new int[] { 1, 2, 3, 4, 5, 6, 7, 9, 10 };
                        break;
                    case 9:
                        imagenesPorIntento = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        break;
                    case 10:
                        imagenesPorIntento = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        break;
                }


                int errores = totalIntentos - oportunidades;
                if (errores < imagenesPorIntento.Length)
                {
                    int imagenIndex = imagenesPorIntento[errores];
                    try
                    {
                        picAhorcado.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("ahorcado" + imagenIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                    }
                }


                if (oportunidades == 0)
                {
                    lblMensaje.Visible = true;
                    flFichas.Enabled = false;
                    contadorDerrotas++;

                    for (int i = 0; i < palabrasSelecionadas.Length; i++)
                    {
                        Button btnLetra = this.Controls.Find("Adivinado" + i, true).FirstOrDefault() as Button;
                        if (btnLetra != null)
                            btnLetra.Text = btnLetra.Tag.ToString();
                    }

                    lblDerrotas.Text = "Derrotas: " + contadorDerrotas;

                    DialogResult resultado = MessageBox.Show("❌ GAME OVER ❌\nLa palabra era: " + new string(palabrasSelecionadas) +
                        "\nDerrotas acumuladas: " + contadorDerrotas + "\n¿Quieres volver a jugar?", "Fin del juego", MessageBoxButtons.YesNo);

                    if (resultado == DialogResult.Yes)
                    {
                        iniciarJuego(); 
                    }
                    else
                    {
                        Application.Exit(); 
                    }
                }
            }
        }







        


        private void AbrirForm2()
        {
           
            Form2 form2 = new Form2();
            form2.Show(); 
        }

        private void btnInicioJuegoo_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }

        private void BtnFinDelJuego_Click(object sender, EventArgs e)
        {
            contadorDerrotas++;
            lblDerrotas.Text = "Derrotas: " + contadorDerrotas;

            DialogResult resultado = MessageBox.Show("❌ GAME OVER ❌\nHas terminado el juego.\nDerrotas acumuladas: " + contadorDerrotas +
                "\n¿Quieres volver a jugar?", "Fin del juego", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                iniciarJuego();
            }
            else
            {
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();
            }
        }



        private void picAhorcado_Click(object sender, EventArgs e)
        {

        }

        private void cmbIntentos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            oportunidades = int.Parse(cmbIntentos.SelectedItem.ToString());
        }

        private void btnInicioJuegoo_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFinDelJuego_Click(object sender, EventArgs e)
        {

        }

        private void btnInterfaz_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void btnAbrirForm2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}