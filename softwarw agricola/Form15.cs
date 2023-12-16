using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Diagnostics;
using System.Drawing;

namespace softwarw_agricola
{
    public partial class Form133 : Form
    {
        public Form133(string valorDesdeForm14)

        {
            InitializeComponent();
            label5.Text = valorDesdeForm14;
            // PARA QUE IMICIE SIN NINGUNBOTOL EL RANGO
#pragma warning disable CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).
            textBox2.TextChanged += textBox2_TextChanged;
#pragma warning restore CS8622 // La nulabilidad de los tipos de referencia del tipo de parámetro no coincide con el delegado de destino (posiblemente debido a los atributos de nulabilidad).
        }

        private void Form133_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form boton = new F13();
            boton.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form boton = new Form2();
            boton.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números, punto decimal y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Bloquear el carácter ingresado
                MessageBox.Show("Solo se aceptan números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Permitir solo un punto decimal
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Bloquear el segundo punto decimal
                MessageBox.Show("Solo se permite un punto decimal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números, punto decimal y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Bloquear el carácter ingresado
                MessageBox.Show("Solo se aceptan números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Permitir solo un punto decimal
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Bloquear el segundo punto decimal
                MessageBox.Show("Solo se permite un punto decimal.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // centrar el texto
            textBox2.TextAlign = HorizontalAlignment.Center;
            if (double.TryParse(textBox2.Text, out double valorTextBox2))
            {
                // Realiza la categorización de salinidad según los rangos definidos
                if (valorTextBox2 <= 1)
                {
                    label6.Text = "Efectos Despreciables de la Salinidad";
                }
                else if (valorTextBox2 <= 2)
                {
                    label6.Text = "Muy Ligeramente Salino";
                }
                else if (valorTextBox2 <= 4)
                {
                    label6.Text = "Moderadamente Salino";
                }
                else if (valorTextBox2 <= 8)
                {
                    label6.Text = "Suelo Salino";
                }
                else if (valorTextBox2 <= 16)
                {
                    label6.Text = "Fuertemente Salino";
                }
                else
                {
                    label6.Text = "Muy Fuertemente Salino";
                }
            }
            else
            {
                // Maneja el caso en el que textBox2 no contenga un número válido
                label6.Text = "El valor en CONDUCTIVIDAD ELÉCTRICA no es válido.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // centrar el texto
            textBox1.TextAlign = HorizontalAlignment.Center;
        }
    }
}
