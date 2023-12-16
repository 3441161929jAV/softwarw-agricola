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
    public partial class F22 : Form
    {
        public F22()
        {
            InitializeComponent();
            CalcularYActualizarEtiquetas();
            RealizarCalculos();


        }
        private void CalcularYActualizarEtiquetas()
        {
            F21 F21 = Application.OpenForms["F21"] as F21;

            if (F21 != null)
            {
                // Muestra el valor en labels en F21
                label6.Text = F21.comboBox1.Text;
                label7.Text = F21.label24.Text;
                label8.Text = F21.label25.Text;
                label9.Text = F21.label26.Text;
                label10.Text = F21.label27.Text;
                label11.Text = F21.label28.Text;
                label12.Text = F21.label29.Text;
                label31.Text = label8.Text;
                label35.Text = label12.Text;
                label27.Text = label11.Text;
                label32.Text = label35.Text;
                label25.Text = label27.Text;
                label36.Text = label27.Text;
                label38.Text = label31.Text;
                label39.Text = label32.Text;


            }
        }
        private void RealizarCalculos()
        {
            // Obtener los valores de las etiquetas que necesitas para los cálculos
            double valorLabel27, valorLabel7, valorLabel25, valorLabel31, valorLabel10;

            if (double.TryParse(label27.Text, out valorLabel27) &&
                double.TryParse(label7.Text, out valorLabel7) &&
                double.TryParse(label25.Text, out valorLabel25) &&
                double.TryParse(label31.Text, out valorLabel31) &&
                double.TryParse(label10.Text, out valorLabel10))
            {
                // Realizar los cálculos

                label26.Text = (valorLabel7 - valorLabel25).ToString();
                label28.Text = label26.Text;
                label37.Text = label28.Text;
                label29.Text = label31.Text;

                // Calcular LABEL34 como (LABEL10 - (LABEL28 + LABEL29))
                label34.Text = (valorLabel10 - (valorLabel7 - valorLabel25 + valorLabel31)).ToString();

                label33.Text = label34.Text;
                label40.Text = label33.Text;
            }
            else
            {
                // Manejar la situación en la que los valores no son números válidos
                MessageBox.Show("No se pueden realizar cálculos porque algunos valores no son números válidos.");
            }
            // Obtener los valores de las etiquetas que necesitas para los cálculos
            double valorLabel36, valorLabel37, valorLabel38, valorLabel39, valorLabel40;

            if (double.TryParse(label36.Text, out valorLabel36) &&
                double.TryParse(label37.Text, out valorLabel37) &&
                double.TryParse(label38.Text, out valorLabel38) &&
                double.TryParse(label39.Text, out valorLabel39) &&
                double.TryParse(label40.Text, out valorLabel40))
            {
                // Realizar la suma
                double resultadoSuma = valorLabel36 + valorLabel37 + valorLabel38 + valorLabel39 + valorLabel40;

                // Mostrar el resultado en label62
                label62.Text = resultadoSuma.ToString();

               
            }
            else
            {
                // Manejar la situación en la que los valores no son números válidos
                MessageBox.Show("No se pueden realizar cálculos porque algunos valores no son números válidos.");
            }
            // Obtener los valores de las etiquetas que necesitas para los cálculos

            if (double.TryParse(label36.Text, out valorLabel36) &&
                double.TryParse(label37.Text, out valorLabel37) &&
                double.TryParse(label38.Text, out valorLabel38) &&
                double.TryParse(label39.Text, out valorLabel39) &&
                double.TryParse(label40.Text, out valorLabel40))
            {
                // Realizar los cálculos
                label46.Text = (valorLabel36 * 118).ToString();
                label47.Text = (valorLabel37 * 101).ToString();
                label48.Text = (valorLabel38 * 136).ToString();
                label49.Text = (valorLabel39 * 123).ToString();
                label50.Text = (valorLabel40 * 87).ToString();
            }
            else
            {
                // Manejar la situación en la que los valores no son números válidos
                MessageBox.Show("No se pueden realizar cálculos porque algunos valores no son números válidos.");
            }
            if (double.TryParse(label36.Text, out valorLabel36) &&
                 double.TryParse(label37.Text, out valorLabel37) &&
                 double.TryParse(label38.Text, out valorLabel38) &&
                 double.TryParse(label39.Text, out valorLabel39) &&
                 double.TryParse(label40.Text, out valorLabel40))

            {
                // Realizar los cálculos
                label46.Text = Math.Floor(valorLabel36 * 118).ToString();
                label47.Text = Math.Floor(valorLabel37 * 101).ToString();
                label48.Text = Math.Floor(valorLabel38 * 136).ToString();
                label49.Text = Math.Floor(valorLabel39 * 123).ToString();
                label50.Text = Math.Floor(valorLabel40 * 87).ToString();

                // Mostrar como enteros quitando los decimales
                label51.Text = label46.Text;
                label52.Text = label47.Text;
                label53.Text = label48.Text;
                label54.Text = label49.Text;
                label55.Text = label50.Text;
            }
            else
            {
                // Manejar la situación en la que los valores no son números válidos
                MessageBox.Show("No se pueden realizar cálculos porque algunos valores no son números válidos.");
            }
            // Obtener los valores de las etiquetas que necesitas para los cálculos
            double valorLabel26, valorLabel32, valorLabel33, valorLabel28, valorLabel29, valorLabel34, valorLabel35;

            if (double.TryParse(label25.Text, out valorLabel25) &&
                double.TryParse(label26.Text, out valorLabel26) &&
                double.TryParse(label31.Text, out valorLabel31) &&
                double.TryParse(label32.Text, out valorLabel32) &&
                double.TryParse(label33.Text, out valorLabel33) &&
                double.TryParse(label29.Text, out valorLabel29) &&
                double.TryParse(label34.Text, out valorLabel34) &&
                double.TryParse(label27.Text, out valorLabel27) &&
                double.TryParse(label28.Text, out valorLabel28) &&
                double.TryParse(label35.Text, out valorLabel35))
            {
                // Realizar los cálculos
                label56.Text = (valorLabel25 + valorLabel26).ToString();
                label57.Text = valorLabel31.ToString();
                label58.Text = (valorLabel32 + valorLabel33).ToString();
                label59.Text = (valorLabel28 + valorLabel29 + valorLabel34).ToString();
                label60.Text = valorLabel27.ToString();
                label61.Text = valorLabel35.ToString();

                // Calcula etiquetas
                label66.Text = label56.Text;
                label67.Text = label57.Text;
                label68.Text = (double.Parse(label58.Text) / 2).ToString();
                label69.Text = label59.Text;
                label70.Text = (double.Parse(label60.Text) / 2).ToString();
                label71.Text = (double.Parse(label61.Text) / 2).ToString();

                // Suma todos los resultados
                double resultadoSuma = double.Parse(label66.Text) + double.Parse(label67.Text) +
                                       double.Parse(label68.Text) + double.Parse(label69.Text) +
                                       double.Parse(label70.Text) + double.Parse(label71.Text);
                label72.Text = resultadoSuma.ToString();
            }
            else
            {
                // Manejar la situación en la que los valores no son números válidos
                MessageBox.Show("No se pueden realizar cálculos porque algunos valores no son números válidos.");
            }
            // Obtener el valor de label72
            double valorLabel72;

            if (double.TryParse(label72.Text, out valorLabel72))
            {
                // Calcular label73
                label73.Text = (valorLabel72 * 0.024).ToString(); // Multiplicar label72 por 0.024

                // Calcular label74
                label74.Text = (double.Parse(label73.Text) / 0.36).ToString(); // Dividir label73 por 0.36

                // Calcular label75
                label75.Text = (valorLabel72 * -0.01).ToString(); // Multiplicar label72 por -0.01

               
            }
            else
            {
                // Manejar la situación en la que el valor de label72 no es un número válido
                MessageBox.Show("No se puede realizar el cálculo porque el valor de label72 no es un número válido.");
            }

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void F22_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void F22_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F21 f1 = new F21();
            // Ocultar el Formulario 1
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F23 f1 = new F23();
            // Ocultar el Formulario 1
            this.Hide();
            f1.Show();
        }

        private void F22_Load_2(object sender, EventArgs e)
        {

        }
    }
}
