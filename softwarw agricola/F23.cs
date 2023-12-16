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
    public partial class F23 : Form
    {
        public F23()
        {
            InitializeComponent();
            F21 F21 = Application.OpenForms["F21"] as F21;

            if (F21 != null)
            {
                // Muestra el valor en labels en F21
                label37.Text = F21.label24.Text;
                label40.Text = F21.label25.Text;
                label41.Text = F21.label26.Text;
                label42.Text = F21.label27.Text;
                label43.Text = F21.label28.Text;
                label44.Text = F21.label29.Text;

                // Primeros datos
                label13.Text = (double.Parse(F21.textBox4.Text) * 0.2259).ToString("N2");//N
                label17.Text = (double.Parse(F21.textBox5.Text) * 0.3261).ToString("N2");//P
                label21.Text = (double.Parse(F21.textBox9.Text) * 0.3333).ToString("N2");//S
                label25.Text = F21.textBox6.Text;//K
                label29.Text = F21.textBox7.Text;//CA
                label33.Text = F21.textBox8.Text;//MG

                RealizarCalculos();
            }
        }
        private void RealizarCalculos()
        {
            // Obtener los valores de las etiquetas y textBox que necesitas para los cálculos
            double valorLabel37, valorLabel40, valorLabel41, valorLabel42, valorLabel43, valorLabel44;

            if (double.TryParse(label37.Text, out valorLabel37) &&
                double.TryParse(label40.Text, out valorLabel40) &&
                double.TryParse(label41.Text, out valorLabel41) &&
                double.TryParse(label42.Text, out valorLabel42) &&
                double.TryParse(label43.Text, out valorLabel43) &&
                double.TryParse(label44.Text, out valorLabel44))
            {
                // Realizar los cálculos
                label12.Text = (valorLabel37 * 62 * 0.2258).ToString("N2");
                label16.Text = (valorLabel40 * 97 * 0.3195).ToString("N2");
                label20.Text = (valorLabel41 * 48 * 0.3333).ToString("N2");
                label24.Text = (valorLabel42 * 39 * 1).ToString("N2");
                label28.Text = (valorLabel43 * 20 * 1).ToString("N2");
                label32.Text = (valorLabel44 * 12 * 1).ToString("N2");

                // Nuevas fórmulas
                label14.Text = ((59 > 1) ? (double.Parse(label12.Text) - (double.Parse(label12.Text) * 50 * 0.01)) : (double.Parse(label12.Text) * 1) - double.Parse(label13.Text)).ToString("N2");

                label18.Text = (double.Parse(label16.Text) - double.Parse(label17.Text)).ToString("N2");
                label22.Text = (double.Parse(label20.Text) - double.Parse(label21.Text)).ToString("N2");
                label26.Text = (double.Parse(label24.Text) - double.Parse(label25.Text)).ToString("N2");
                label30.Text = (double.Parse(label28.Text) - double.Parse(label29.Text)).ToString("N2");
                label34.Text = (double.Parse(label32.Text) - double.Parse(label33.Text)).ToString("N2");
                label38.Text = ((50 < 1) ? "0" : (double.Parse(label12.Text) * 50 / 100).ToString("N2"));

                // Fórmulas con multiplicación por 1.2
                label15.Text = (double.Parse(label14.Text) * 1.2).ToString("N2");
                label19.Text = (double.Parse(label18.Text) * 1.2).ToString("N2");
                label23.Text = (double.Parse(label22.Text) * 1.2).ToString("N2");
                label27.Text = (double.Parse(label26.Text) * 1.2).ToString("N2");
                label31.Text = (double.Parse(label30.Text) * 1.2).ToString("N2");
                label35.Text = (double.Parse(label34.Text) * 1.2).ToString("N2");
                label39.Text = (double.Parse(label38.Text) * 1.2).ToString("N2");
            }
            else
            {
                // Manejar la situación en la que los valores no son números válidos
                MessageBox.Show("No se pueden realizar cálculos porque algunos valores no son números válidos.");
            }

        }
        





        private void button1_Click(object sender, EventArgs e)
        {
            F22 f1 = new F22();
            // Ocultar el Formulario 1
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F24 f24 = new F24();
            // Ocultar el Formulario 1
            this.Hide();
            f24.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void F23_Load(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }
    }
}
