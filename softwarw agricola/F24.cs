using System;
using System.Windows.Forms;

namespace softwarw_agricola
{
    public partial class F24 : Form
    {
        public F24()
        {
            InitializeComponent();
            ActualizarDatosDesdeF23();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "HIDROPONÍA")
            {
                // Mostrar datos para HIDROPONÍA
                label24.Text = label44.Text;
                label25.Text = label42.Text;
                label26.Text = label40.Text;
                label27.Text = label36.Text;
                label28.Text = label36.Text;
                label29.Text = label34.Text;
                label30.Text = label38.Text;
                // Realizar cálculos
                CalcularPorcentaje();
            }
            else if (comboBox1.SelectedItem.ToString() == "SUELO - ERF (80%)")
            {
                // Mostrar datos para SUELO - ERF (80%)
                label24.Text = label43.Text;
                label25.Text = label41.Text;
                label26.Text = label37.Text;
                label27.Text = label33.Text;
                label28.Text = label31.Text;
                label29.Text = label35.Text;
                label30.Text = label39.Text;
                // Realizar cálculos
                CalcularPorcentaje();
            }
        }

        private void ActualizarDatosDesdeF23()
        {
            F23 F23 = Application.OpenForms["F23"] as F23;

            if (F23 != null)
            {

                // Muestra el valor en labels en F23
                label44.Text = F23.label14.Text;
                label42.Text = F23.label18.Text;
                label40.Text = F23.label22.Text;
                label36.Text = F23.label26.Text;
                label32.Text = F23.label30.Text;
                label34.Text = F23.label34.Text;
                label38.Text = F23.label38.Text;
                label43.Text = F23.label15.Text;
                label41.Text = F23.label19.Text;
                label37.Text = F23.label23.Text;
                label33.Text = F23.label27.Text;
                label31.Text = F23.label31.Text;
                label35.Text = F23.label35.Text;
                label39.Text = F23.label39.Text;
            }


        }
        private void CalcularPorcentaje()
        {
            // Obtener el valor de label30 y otros valores necesarios
            double valorLabel30 = double.Parse(label30.Text);
            double valorLabel28 = double.Parse(label28.Text);

            // Realizar los cálculos y asignar los resultados a las etiquetas correspondientes
            label46.Text = ((valorLabel28 / 17) * 100).ToString("N2");

            double valorLabel46 = double.Parse(label46.Text);  // Se agrega esta variable para evitar repeticiones de cálculos
            double valorLabel53 = (valorLabel46 * 15) / 100;
            double valorLabel62 = (valorLabel46 * 17) / 100;

            label53.Text = valorLabel53.ToString("N2");
            label62.Text = valorLabel62.ToString("N2");

            // Realizar el cálculo para label54
            double valorLabel24 = double.Parse(label24.Text);
            double valorLabel54 = (valorLabel30 > 1) ? 0 : (valorLabel24 - valorLabel53);
            label54.Text = valorLabel54.ToString("N2");

            // Realizar el cálculo para label47
            label47.Text = ((valorLabel54 / 13) * 100).ToString("N2");

            // Realizar el cálculo para label61
            bool condicionLabel54 = (valorLabel54 == 0);  // Corregido el error aquí
            double valorLabel61 = condicionLabel54 ? 0 : ((double.Parse(label47.Text) * 37) / 100);
            label61.Text = valorLabel61.ToString("N2");
            // Realizar el cálculo para label48
            label48.Text = ((double.Parse(label25.Text) / 23) * 100).ToString("N2");

            // Realizar el cálculo para label55
            double valorLabel48 = double.Parse(label48.Text);
            label55.Text = ((valorLabel48 * 23) / 100).ToString("N2");

            // Realizar el cálculo para label60
            label60.Text = ((valorLabel48 * 24) / 100).ToString("N2");

            // Realizar el cálculo para label49
            label49.Text = ((double.Parse(label29.Text) / 10) * 100).ToString("N2");

            // Realizar el cálculo para label63
            double valorLabel49 = double.Parse(label49.Text);
            label63.Text = ((valorLabel49 * 10) / 100).ToString("N2");

            // Realizar el cálculo para label56
            label56.Text = ((valorLabel49 * 13) / 100).ToString("N2");

            // Realizar el cálculo para label59
            double valorLabel27 = double.Parse(label27.Text);

            double valorLabel60 = double.Parse(label60.Text);
            label59.Text = (valorLabel27 - valorLabel61 - valorLabel60).ToString("N2");

            // Realizar el cálculo para label50
            label50.Text = ((double.Parse(label59.Text) / 44) * 100).ToString("N2");

            // Realizar el cálculo para label57
            label57.Text = ((double.Parse(label50.Text) * 18) / 100).ToString("N2");

            // Realizar el cálculo para label51

            label51.Text = (valorLabel30 < 1) ? "0" : (((valorLabel30 / 21) * 100) * 2).ToString("N2");

            // Realizar el cálculo para label58
            label58.Text = ((double.Parse(label51.Text) * 24) / 100).ToString("N2");

            // Realizar el cálculo para label64
            label64.Text = ((double.Parse(label51.Text) * 21) / 100).ToString("N2");
            // Asignar valores a las nuevas etiquetas
            label65.Text = label46.Text;
            label66.Text = label47.Text;
            label67.Text = label48.Text;
            label68.Text = label49.Text;
            label69.Text = label50.Text;
            label70.Text = label51.Text;
            label71.Text = (double.Parse(label53.Text) + double.Parse(label54.Text)).ToString("N2");
            label8.Text = label55.Text;
            label74.Text = (double.Parse(label56.Text) + double.Parse(label57.Text) + double.Parse(label58.Text)).ToString("N2");
            label77.Text = (double.Parse(label61.Text) + double.Parse(label60.Text) + double.Parse(label59.Text)).ToString("N2");
            label80.Text = label62.Text;
            label83.Text = label63.Text;
            label86.Text = label64.Text;
            label5.Text = (4.4286 / 62).ToString("N2");
            label72.Text = ((3.129 * double.Parse(label8.Text)) / 97).ToString("N2");
            label75.Text = ((3 * double.Parse(label74.Text)) / 96).ToString("N2");
            label78.Text = (double.Parse(label77.Text) / 39).ToString("N2");
            label81.Text = (double.Parse(label80.Text) / 20).ToString("N2");
            label84.Text = (double.Parse(label83.Text) / 12).ToString("N2");
            label87.Text = ((1.2857 * double.Parse(label86.Text)) / 14).ToString("N2");
            label6.Text = label5.Text;
            label73.Text = label72.Text;
            label76.Text = (double.Parse(label75.Text) / 2).ToString("N2");
            label79.Text = label78.Text;
            label82.Text = (double.Parse(label81.Text) / 2).ToString("N2");
            label85.Text = (double.Parse(label84.Text) / 2).ToString("N2");
            label88.Text = label87.Text;
            label90.Text = ((double.Parse(label6.Text) + double.Parse(label73.Text) + double.Parse(label76.Text) +
                            double.Parse(label82.Text) + double.Parse(label85.Text) + double.Parse(label88.Text)) * 0.024).ToString("N2");

            label93.Text = (double.Parse(label90.Text) / 0.36).ToString("N2");
            label96.Text = (double.Parse(label90.Text) * -0.01).ToString("N2");

        }

        private void F24_Load(object sender, EventArgs e)
        {
        }

        private void label54_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            F23 f1 = new F23();
            // Ocultar el Formulario 1
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F25 f1 = new F25();
            // Ocultar el Formulario 1
            this.Hide();
            f1.Show();
        }

        private void label96_Click(object sender, EventArgs e)
        {

        }

        private void label95_Click(object sender, EventArgs e)
        {

        }
    }
}

