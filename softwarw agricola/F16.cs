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
    public partial class F16 : Form
    {
        public F16()
        {
            InitializeComponent();
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            F14 f14 = Application.OpenForms["F14"] as F14;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

            if (f14 != null)
            {
                // Muestra el valor en label9 en Form16
                label3.Text = f14.label8.Text;
                label4.Text = f14.comboBox1.Text;
            }
            else
            {
                // Maneja la situación si Form12 no está abierto
                label3.Text = "No se encontro";
                label4.Text = "No se encontro";
            }
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            F13 f13 = Application.OpenForms["F13"] as F13;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

            if (f13 != null)
            {
                // Muestra el valor en label9 en Form16
                label5.Text = f13.label12.Text;
                label6.Text = f13.comboBox2.Text;
            }
            else
            {
                // Maneja la situación si Form12 no está abierto
                label5.Text = "No se encontro";
                label6.Text = "No se encontro";
            }
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            F11 f11 = Application.OpenForms["F11"] as F11;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

            if (f11 != null)
            {
                // Muestra el valor en label9 en Form16
                label7.Text = f11.textBox1.Text;
                label8.Text = f11.comboBox1.Text;
            }
            else
            {
                // Maneja la situación si Form12 no está abierto
                label7.Text = "No se encontro";
                label8.Text = "No se encontro";
            }
            F15 f15 = Application.OpenForms["F15"] as F15;

            if (f15 != null)
            {
                // Muestra el valor en label9 en Form16
                label9.Text = f15.label26.Text;
                label10.Text = f15.label27.Text;
                label11.Text = f15.label28.Text;
            }
            else
            {
                // Maneja la situación si Form12 no está abierto
                label9.Text = "No se encontro";
                label10.Text = "No se encontro";
                label11.Text = "No se encontro";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void F16_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            // Ocultar el Formulario 1
            this.Hide();

            // Mostrar el Formulario 2
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Ocultar el Formulario 1
            this.Hide();

            // Mostrar el Formulario 2
            form2.Show();
        }
    }
}
