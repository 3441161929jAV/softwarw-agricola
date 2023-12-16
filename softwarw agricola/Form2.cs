namespace softwarw_agricola
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            F11 f11 = new F11();
            // Ocultar el Formulario 1
            this.Hide();

            // Mostrar el Formulario 2
            f11.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form boton = new Form1();
            boton.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            F21 boton = new F21();
            // Ocultar el Formulario 1
            this.Hide();
            boton.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {


          
        }
    }
}
