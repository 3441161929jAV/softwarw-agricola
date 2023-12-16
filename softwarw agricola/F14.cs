
using System.Drawing;

namespace softwarw_agricola
{
    public partial class F14 : Form
    {

        private Dictionary<string, double> opciones = new Dictionary<string, double>
        {
            { "Lombricomposta", 22.5 },
            { "Estiércol bovino", 28.4 },
            { "Estiércol porcino", 26.3 },
            { "Estiércol caprino", 30.6 },
            { "Estiércol de conejo", 37.0 },
            { "Gallinaza", 31.4 },
            { "Bocashi", 12.9 },
            { "Pulpa de café", 52.0 },
            { "Paja de arroz", 15.6 },
            { "Rastrojo de maíz", 38.0 }
        };
        public F14()
        {
            InitializeComponent();

#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            F11 f11 = Application.OpenForms["F11"] as F11;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

            if (f11 != null)
            {
                // Muestra el valor en label9 en Form16
                label9.Text = f11.pesoton.Text;
            }
            else
            {
                // Maneja la situación si Form12 no está abierto
                label9.Text = "No se encontro el peso del suelo";
            }

            // Llenar el ComboBox con las opciones
            foreach (var opcion in opciones.Keys)
            {
                comboBox1.Items.Add(opcion);
            }


        }
        public static class DatosCompartidos
        {
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
            public static string Dato { get; set; }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form boton = new Form2();
            boton.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)

        {


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

        private void incrementar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void aportado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            string opcionSeleccionada = comboBox1.SelectedItem.ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

            // Verificar si la opción seleccionada está en el diccionario
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            if (opciones.ContainsKey(opcionSeleccionada))
            {
                double valorSeleccionado = opciones[opcionSeleccionada];
                label7.Text = valorSeleccionado.ToString("N1"); // Mostrar como número con un decimal

                // Obtener el valor numérico de label9
                if (double.TryParse(label9.Text, out double valorLabel9))
                {
                    // Realizar el cálculo adicional y mostrarlo en label8
                    double resultado = (((((valorSeleccionado / 1.724) * 10000) / 1000000)) * (valorLabel9 * 1000) / valorSeleccionado) * 100;
                    label8.Text = resultado.ToString("N2");
                    label8.Visible = true;
                }
                else
                {
                    label8.Text = "Valor no válido en label9";
                    label8.Visible = true;
                }
            }
            else
            {
                label7.Text = "Valor no encontrado";
                label7.Visible = true;
                label8.Text = "Valor no válido";
                label8.Visible = true;
            }
#pragma warning restore CS8604 // Posible argumento de referencia nulo

        }
        private void Form144_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // centrar el texto
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(incrementar.Text, out double valorTextBox))
            {
                // Verifica si el texto en label9 es un número válido
                if (double.TryParse(label9.Text, out double valorLabel9))
                {
                    // Verifica si el texto en label7 es un número válido
                    if (double.TryParse(label7.Text, out double valorLabel7))
                    {

                        // Suma el resultado de la multiplicación al valor en textBox1
                        double resultado = ((((((valorTextBox / 1.724) * 10000) / 1000000))) * (valorLabel9 * 1000) / valorLabel7) * 100;


                        // Muestra el resultado en label8
                        label8.Text = "Resultado: " + resultado.ToString("N2");
                        label8.Visible = true;
                    }
                    else
                    {
                        // Maneja el caso en el que label7 no contenga un número válido
                        label8.Text = "El valor en label7 no es válido.";
                        label8.Visible = true;
                    }
                }
                else
                {
                    // Maneja el caso en el que label9 no contenga un número válido
                    label8.Text = "El valor en label9 no es válido.";
                    label8.Visible = true;
                }
            }
            else
            {
                // Maneja el caso en el que textBox1 no contenga un número válido
                label8.Text = "El valor en textBox1 no es válido.";
                label8.Visible = true;
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void incrementar_TextChanged(object sender, EventArgs e)
        {
            CalcularResultado();
        }

        private void label7_TextAlignChanged(object sender, EventArgs e)
        {
            CalcularResultado();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            CalcularResultado();
        }
        private void CalcularResultado()
        {
            if (double.TryParse(incrementar.Text, out double valorLabelin) &&
                double.TryParse(label9.Text, out double valorLabel9) &&
                double.TryParse(label7.Text, out double valorLabel7))
            {
                double resultado = (((((valorLabelin / 1.724) * 10000) / 1000000)) * (valorLabel9 * 1000) / valorLabel7) * 100;
                label8.Text = resultado.ToString("N2");
                label8.Visible = true;
            }
            else
            {
                label8.Text = "Valor no válido";
                label8.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            F13 boton = new F13();
            boton.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            F15 form15 = new F15();

            // Ocultar el Formulario 1
            this.Hide();

            // Mostrar el Formulario 2
            form15.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}






