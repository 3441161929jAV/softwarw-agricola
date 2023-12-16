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
    public partial class F25 : Form
    {
        public F25()
        {
            InitializeComponent();
            F24 F24 = Application.OpenForms["F24"] as F24;

            if (F24 != null)
            {

                // Muestra el valor en labels en F24
                label30.Text = F24.label46.Text;
                label31.Text = F24.label47.Text;
                label32.Text = F24.label48.Text;
                label36.Text = F24.label49.Text;
                label33.Text = F24.label50.Text;
                label34.Text = F24.label51.Text;
                // Realizar cálculos 
                label37.Text = ((double.Parse(label30.Text) * (1000.0 / 10) / 1000.0)).ToString("N2");
                label38.Text = ((double.Parse(label31.Text) * (1000.0 / 10) / 1000.0)).ToString("N2");
                label39.Text = ((double.Parse(label32.Text) * (1000.0 / 10) / 1000.0)).ToString("N2");
                label40.Text = ((double.Parse(label36.Text) * (1000.0 / 10) / 1000.0)).ToString("N2");
                label41.Text = ((double.Parse(label33.Text) * (1000.0 / 10) / 1000.0)).ToString("N2");
                label42.Text = ((double.Parse(label34.Text) * (1000.0 / 10) / 1000.0)).ToString("N2");

                label43.Text = ((double.Parse(label37.Text) * 200) / 1000.0).ToString("N2");
                label44.Text = ((double.Parse(label38.Text) * 200) / 1000.0).ToString("N2");
                label45.Text = ((double.Parse(label39.Text) * 200) / 1000.0).ToString("N2");
                label46.Text = ((double.Parse(label40.Text) * 200) / 1000.0).ToString("N2");
                label47.Text = ((double.Parse(label41.Text) * 200) / 1000.0).ToString("N2");
                label48.Text = ((double.Parse(label42.Text) * 200) / 1000.0).ToString("N2");
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F24 f1 = new F24();
            // Ocultar el Formulario 1
            this.Hide();

            // Mostrar el Formulario 2
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Cierra la aplicación
            Application.Exit();
        }

        private void f24_Load(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }
    }
}
