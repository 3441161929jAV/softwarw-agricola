using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softwarw_agricola
{
    public partial class F12 : Form
    {
        public F12()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn
            if (double.TryParse(textBox1.Text, out double valorTextBox1))
            {
                double rangoAlto = 40;  // Define tus propios valores de rango
                double rangoMedio = 20;

                if (valorTextBox1 > rangoAlto)
                {
                    label17.Text = "Alto";
                    label17.Visible = true;
                }
                else if (valorTextBox1 >= rangoMedio)
                {
                    label17.Text = "Medio";
                    label17.Visible = true;
                }
                else
                {
                    label17.Text = "Bajo";
                    label17.Visible = true;
                }
            }
            else
            {
                label17.Text = "Valor no válido";
                label17.Visible = true;
            }
        }
        //ppppppppppppppppppppppppppppp
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double valorTextBox2))
            {
                double rangoAlto = 30;  // Define tus propios valores de rango
                double rangoMedio = 11;

                if (valorTextBox2 > rangoAlto)
                {
                    label18.Text = "Alto";
                    label18.Visible = true;
                }
                else if (valorTextBox2 >= rangoMedio)
                {
                    label18.Text = "Medio";
                    label18.Visible = true;
                }
                else
                {
                    label18.Text = "Bajo";
                    label18.Visible = true;
                }
            }
            else
            {
                label18.Text = "Valor no válido";
                label18.Visible = true;
            }
        }
        //KKKKKKKKKKKKKKKKKKKKKKKKKKKKK
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox3.Text, out double valorTextBox3))
            {
                double rangoAlto = 234;  // Define tus propios valores de rango
                double rangoMedio = 117;

                if (valorTextBox3 > rangoAlto)
                {
                    label19.Text = "Alto";
                    label19.Visible = true;
                }
                else if (valorTextBox3 >= rangoMedio)
                {
                    label19.Text = "Medio";
                    label19.Visible = true;
                }
                else
                {
                    label19.Text = "Bajo";
                    label19.Visible = true;
                }
            }
            else
            {
                label19.Text = "Valor no válido";
                label19.Visible = true;
            }
        }
        //CACACACACACACACACACACCACACACACACACCA

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox4.Text, out double valorTextBox4))
            {
                double rangoAlto = 2000;  // Define tus propios valores de rango
                double rangoMedio = 1000;

                if (valorTextBox4 > rangoAlto)
                {
                    label20.Text = "Alto";
                    label20.Visible = true;
                }
                else if (valorTextBox4 >= rangoMedio)
                {
                    label20.Text = "Medio";
                    label20.Visible = true;
                }
                else
                {
                    label20.Text = "Bajo";
                    label20.Visible = true;
                }
            }
            else
            {
                label20.Text = "Valor no válido";
                label20.Visible = true;
            }
        }
        // MGMGMGMGMGMGMGMGMGMMGMGMGMGMGMGM
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox5.Text, out double valorTextBox5))
            {
                double rangoAlto = 360;  // Define tus propios valores de rango
                double rangoMedio = 156;

                if (valorTextBox5 > rangoAlto)
                {
                    label21.Text = "Alto";
                    label21.Visible = true;
                }
                else if (valorTextBox5 >= rangoMedio)
                {
                    label21.Text = "Medio";
                    label21.Visible = true;
                }
                else
                {
                    label21.Text = "Bajo";
                    label21.Visible = true;
                }
            }
            else
            {
                label21.Text = "Valor no válido";
                label21.Visible = true;
            }
        }
        // NANANANANANANNANANANANANANAA
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox6.Text, out double valorTextBox6))
            {
                double rangoAlto = 0.1;  // Define tus propios valores de rango
                double rangoMedio = 0;

                if (valorTextBox6 > rangoAlto)
                {
                    label22.Text = "Alto";
                    label22.Visible = true;
                }
                else if (valorTextBox6 >= rangoMedio)
                {
                    label22.Text = "Normal";
                    label22.Visible = true;
                }

            }
            else
            {
                label22.Text = "Valor no válido";
                label22.Visible = true;
            }
        }
        // FEFEFEFEFEFEFEFFEFEFEFEF
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox7.Text, out double valorTextBox7))
            {
                double rangoAlto = 6;  // Define tus propios valores de rango
                double rangoMedio = 3;

                if (valorTextBox7 > rangoAlto)
                {
                    label23.Text = "Alto";
                    label23.Visible = true;
                }
                else if (valorTextBox7 >= rangoMedio)
                {
                    label23.Text = "Medio";
                    label23.Visible = true;
                }
                else
                {
                    label23.Text = "Bajo";
                    label23.Visible = true;
                }
            }
            else
            {
                label23.Text = "Valor no válido";
                label23.Visible = true;
            }
        }
        //ZNZNZNZNZNZNZNZZNZN
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox8.Text, out double valorTextBox8))
            {
                double rangoAlto = 2;  // Define tus propios valores de rango
                double rangoMedio = 1;

                if (valorTextBox8 > rangoAlto)
                {
                    label24.Text = "Alto";
                    label24.Visible = true;
                }
                else if (valorTextBox8 >= rangoMedio)
                {
                    label24.Text = "Medio";
                    label24.Visible = true;
                }
                else
                {
                    label24.Text = "Bajo";
                    label24.Visible = true;
                }
            }
            else
            {
                label24.Text = "Rango Valor no válido";
                label24.Visible = true;
            }
        }
        // MNMNMNMNMNMNMNMNMNNM
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox9.Text, out double valorTextBox9))
            {
                double rangoAlto = 3;  // Define tus propios valores de rango
                double rangoMedio = 1.5;

                if (valorTextBox9 > rangoAlto)
                {
                    label25.Text = "Alto";
                    label25.Visible = true;
                }
                else if (valorTextBox9 >= rangoMedio)
                {
                    label25.Text = "Medio";
                    label25.Visible = true;
                }
                else
                {
                    label25.Text = "Bajo";
                    label25.Visible = true;
                }
            }
            else
            {
                label25.Text = "Valor no válido";
                label25.Visible = true;
            }
        }
        // CUCUCUCUCUCUCUCUCUCUCCU
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox10.Text, out double valorTextBox10))
            {
                double rangoAlto = 0.8;  // Define tus propios valores de rango
                double rangoMedio = 0.4;

                if (valorTextBox10 > rangoAlto)
                {
                    label26.Text = "Alto";
                    label26.Visible = true;
                }
                else if (valorTextBox10 >= rangoMedio)
                {
                    label26.Text = "Medio";
                    label26.Visible = true;
                }
                else
                {
                    label26.Text = "Bajo";
                    label26.Visible = true;
                }
            }
            else
            {
                label26.Text = "Valor no válido";
                label26.Visible = true;
            }
        }
        // BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox11.Text, out double valorTextBox11))
            {
                double rangoAlto = 3;  // Define tus propios valores de rango
                double rangoMedio = 0.5;

                if (valorTextBox11 > rangoAlto)
                {
                    label27.Text = "Alto";
                    label27.Visible = true;
                }
                else if (valorTextBox11 >= rangoMedio)
                {
                    label27.Text = "Medio";
                    label27.Visible = true;
                }
                else
                {
                    label27.Text = "Bajo";
                    label27.Visible = true;
                }
            }
            else
            {
                label27.Text = "Valor no válido";
                label27.Visible = true;
            }
        }
        //SSSSSSSSSSSSSSS
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox12.Text, out double valorTextBox12))
            {
                double rangoAlto = 20;  // Define tus propios valores de rango
                double rangoMedio = 12;

                if (valorTextBox12 > rangoAlto)
                {
                    label28.Text = "Alto";
                    label28.Visible = true;
                }
                else if (valorTextBox12 >= rangoMedio)
                {
                    label28.Text = "Medio";
                    label28.Visible = true;
                }
                else
                {
                    label28.Text = "Bajo";
                    label28.Visible = true;
                }
            }
            else
            {
                label28.Text = "Valor no válido";
                label28.Visible = true;
            }
        }
        //ALALALALALALALALALALALALALALAL
        private void textBox13_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox13.Text, out double valorTextBox13))
            {
                double rangoAlto = 0.1;  // Define tus propios valores de rango
                double rangoMedio = 0;

                if (valorTextBox13 > rangoAlto)
                {
                    label29.Text = "Alto";
                    label29.Visible = true;
                }
                else if (valorTextBox13 >= rangoMedio)
                {
                    label29.Text = "Normal";
                    label29.Visible = true;
                }

            }
            else
            {
                label29.Text = "Valor no válido";
                label29.Visible = true;
            }
        }
        //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

            if (double.TryParse(textBox14.Text, out double valorTextBox14))
            {
                double rangoAlto = 0.1;  // Define tus propios valores de rango
                double rangoMedio = 0;

                if (valorTextBox14 > rangoAlto)
                {
                    label30.Text = "Alto";
                    label30.Visible = true;
                }
                else if (valorTextBox14 >= rangoMedio)
                {
                    label30.Text = "Normal";
                    label30.Visible = true;
                }

            }
            else
            {
                label30.Text = "Valor no válido";
                label30.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            F13 form13 = new F13();

            // Ocultar el Formulario 1
            this.Hide();

            // Mostrar el Formulario 2
            form13.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F11 boton = new F11();
            boton.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

