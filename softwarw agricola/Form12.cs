using static softwarw_agricola.F14;

namespace softwarw_agricola
{
    public partial class Form12 : Form

    {


        public Form12()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form boton = new F12();
            boton.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form boton = new F14();
            boton.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados 
            if (double.TryParse(densidad.Text, out double numero1) && double.TryParse(profundidad.Text, out double numero2))
            {
                // Realizar la multiplicación
                double resultado = 10000 * numero1 * numero2;

                // Mostrar el resultado 
                pesoton.Text = resultado.ToString("N2");
            }
            else
            {
                // Mostrar un mensaje de error si los valores ingresados no son números válidos
                MessageBox.Show("Por favor, ingrese números válidos en ambos campos.");
            }


        }

        private void profundidad_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void densidad_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textura_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void conductividad_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }


        private void profundidad_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void densidad_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pesosuelo_Click(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form boton = new F15();
            boton.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pesoton_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
