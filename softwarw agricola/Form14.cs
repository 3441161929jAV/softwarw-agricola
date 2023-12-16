using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace softwarw_agricola
{
    public partial class Form14 : Form
    {
        //declaramos apar exponer el dato
        public int ValorDesdeFormulario14 { get; private set; }
        // recopilamos en dato
        public double DatoRecopilado { get; private set; }
        public Form14()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            //para sumar 
            double sumaTotal = 0.0;
            double resultadoK = 0.0;
            double resultadoCa = 0.0;
            double resultadoMg = 0.0;
            double resultadoNa = 0.0;
            double resultadoAl = 0.0;
            double resultadoh = 0.0;

            // Obtener el valor dato k 
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            F12 form15 = Application.OpenForms.OfType<F12>().FirstOrDefault();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

            if (form15 != null && double.TryParse(form15.textBox3.Text, out double num1))
            {
                resultadoK = num1 / 390;
                sumaTotal += resultadoK;
                label1.Text = resultadoK.ToString("N2");
            }

            // Obtener el valor dato Ca
            if (form15 != null && double.TryParse(form15.textBox4.Text, out double num2))
            {
                resultadoCa = num2 / 200;
                sumaTotal += resultadoCa;
                label2.Text = resultadoCa.ToString("N2");
            }

            // Obtener el valor dato Mg
            if (form15 != null && double.TryParse(form15.textBox5.Text, out double num3))
            {
                resultadoMg = num3 / 120;
                sumaTotal += resultadoMg;
                label3.Text = resultadoMg.ToString("N2");
            }

            // Obtener el valor dato Na
            if (form15 != null && double.TryParse(form15.textBox6.Text, out double num4))
            {
                resultadoNa = num4 / 230;
                sumaTotal += resultadoNa;
                label4.Text = resultadoNa.ToString("N2");
            }

            // Obtener el valor dato Al
            if (form15 != null && double.TryParse(form15.textBox13.Text, out double num5))
            {
                resultadoAl = num5 / 90;
                sumaTotal += resultadoAl;
                label5.Text = resultadoAl.ToString("N2");
            }
            // Obtener el valor dato h
            if (form15 != null && double.TryParse(form15.textBox14.Text, out double num6))
            {
                resultadoh = num6 / 10;
                sumaTotal += resultadoh;
                label6.Text = resultadoh.ToString("N2");
            }

            // Resto de los cálculos y etiquetas

            label7.Text = sumaTotal.ToString("N2");

            // Calcular porcentajes y etiquetas k
            double porcentajek = ((resultadoK * 100) / sumaTotal);
            label21.Text = porcentajek.ToString("N2");

            if (porcentajek < 4)
            {
                label8.Text = "Bajo";
            }
            else if (porcentajek >= 5 && porcentajek <= 7)
            {
                label8.Text = "OPTIMO";
            }
            else
            {
                label8.Text = "Alto";
            }
            // Calcular porcentajes y etiquetas Ca
            double porcentajeCa = ((resultadoCa * 100) / sumaTotal);
            label22.Text = porcentajeCa.ToString("N2");

            if (porcentajeCa < 64)
            {
                label9.Text = "Bajo";
            }
            else if (porcentajeCa >= 65 && porcentajeCa <= 75)
            {
                label9.Text = "OPTIMO";
            }
            else
            {
                label9.Text = "Alto";
            }
            // Calcular porcentajes y etiquetas Mg
            double porcentajeMg = ((resultadoMg * 100) / sumaTotal);
            label23.Text = porcentajeMg.ToString("N2");

            if (porcentajeMg < 9)
            {
                label15.Text = "Bajo";
            }
            else if (porcentajeMg >= 10 && porcentajeMg <= 20)
            {
                label15.Text = "OPTIMO";
            }
            else
            {
                label15.Text = "Alto";
            }
            // Calcular porcentajes y etiquetas Na
            double porcentajeNa = ((resultadoNa * 100) / sumaTotal);
            label24.Text = porcentajeNa.ToString("N2");

            if (porcentajeNa < 0)
            {
                label18.Text = "Bajo";
            }
            else if (porcentajeNa >= 1 && porcentajeNa <= 5)
            {
                label18.Text = "OPTIMO";
            }
            else
            {
                label18.Text = "Alto";
            }
            // Calcular porcentajes y etiquetas Al

            double porcentajeAl = ((resultadoAl * 100) / sumaTotal);
            label25.Text = porcentajeAl.ToString("N2");

            if (porcentajeAl < 0)
            {
                label19.Text = "Bajo";
            }
            else if (porcentajeAl >= 1 && porcentajeAl <= 5)
            {
                label19.Text = "OPTIMO";
            }
            else
            {
                label19.Text = "Alto";
            }
            // Calcular porcentajes y etiquetas H
            double porcentajeh = ((resultadoh * 100) / sumaTotal);

            label26.Text = porcentajeh.ToString("N2");

            if (porcentajeh < 0)
            {
                label20.Text = "Bajo";
            }
            else if (porcentajeAl >= 1 && porcentajeAl <= 5)
            {
                label20.Text = "OPTIMO";
            }
            else
            {
                label20.Text = "Alto";
            }
        }


        private void Form16_Load(object sender, EventArgs e)
        {

        }
        public string Label7
        {
            get { return label7.Text; }
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            // Obtén el texto de label7 en Form14
            string valorLabel7 = label7.Text;

            // Abre Form15 y pasa el valor de label7 como parámetro
            F13 form177 = new F13();
            form177.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }
    }
}
