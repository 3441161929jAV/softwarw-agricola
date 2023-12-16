using System;
using System.Windows.Forms;

namespace softwarw_agricola
{
    public partial class F21 : Form
    {
        public F21()
        {
            InitializeComponent();
            // Asigna los valores al ComboBox
            comboBox1.Items.Add("0.5");
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("1.5");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("2.5");
            comboBox1.Items.Add("3");
        }

        private void LlenarComboBox()
        {
            // Agrega las opciones al ComboBox
            for (double i = 0.5; i <= 3.0; i += 0.5)
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            CalcularResultadoAutomatico();
        }

        private void CalcularResultadoAutomatico()
        {
            if (double.TryParse(textBox12.Text, out double valorTextBox12))
            {
                double resultado = Math.Abs(0.2 - valorTextBox12) / 3.6;
                label17.Text = resultado.ToString("N2");
                label17.Visible = true;
            }
            else
            {
                label17.Text = "Error: Valor no válido en TextBox12";
                label17.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            // Ocultar el Formulario 1
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F22 f22 = new F22();
            // Ocultar el Formulario 1
            this.Hide();

            // Mostrar el Formulario 2
            f22.Show();
        }

        private void F21_Load(object sender, EventArgs e)
        {

        }



        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpia los valores anteriores en las etiquetas
            label24.Text = "";
            label24.Visible = true;
            label25.Text = "";
            label25.Visible = true;
            label26.Text = "";
            label26.Visible = true;
            label27.Text = "";
            label27.Visible = true;
            label28.Text = "";
            label28.Visible = true;
            label29.Text = "";
            label29.Visible = true;

            // Obtiene el valor seleccionado en el ComboBox
            string valorSeleccionado = comboBox1.SelectedItem.ToString();

            // Obtén los valores correspondientes y asígnalos a las etiquetas
            switch (valorSeleccionado)
            {
                case "0.5":
                    label24.Text = "3";
                    label25.Text = "0.25";
                    label26.Text = "1.75";
                    label27.Text = "1.75";
                    label28.Text = "2.25";
                    label29.Text = "1";
                    break;
                case "1":
                    label24.Text = "6";
                    label25.Text = "0.5";
                    label26.Text = "3.5";
                    label27.Text = "3.5";
                    label28.Text = "4.5";
                    label29.Text = "2";
                    break;
                case "1.5":
                    label24.Text = "9";
                    label25.Text = "0.75";
                    label26.Text = "5.25";
                    label27.Text = "5.25";
                    label28.Text = "6.75";
                    label29.Text = "3";
                    break;
                case "2":
                    label24.Text = "12";
                    label25.Text = "1";
                    label26.Text = "7";
                    label27.Text = "7";
                    label28.Text = "9";
                    label29.Text = "4";
                    break;
                case "2.5":
                    label24.Text = "15";
                    label25.Text = "1.25";
                    label26.Text = "8.75";
                    label27.Text = "8.75";
                    label28.Text = "11.25";
                    label29.Text = "5";
                    break;
                case "3":
                    label24.Text = "18";
                    label25.Text = "1.5";
                    label26.Text = "10.5";
                    label27.Text = "10.5";
                    label28.Text = "13.5";
                    label29.Text = "6";
                    break;
                default:
                    // Manejar cualquier otro caso si es necesario
                    break;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
