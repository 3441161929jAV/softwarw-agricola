
namespace softwarw_agricola
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {

            InitializeComponent();
           

        }
       


        private void button1_load(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del Formulario 2
            Form2 form2 = new Form2();

            // Ocultar el Formulario 1
            this.Hide();

            // Mostrar el Formulario 2
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}