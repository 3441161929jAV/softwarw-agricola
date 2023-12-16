using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace softwarw_agricola
{
    public partial class F15 : Form

    {
        public F15()
        {
            InitializeComponent();
            // DATO DE FORM 11
            F11 f11 = Application.OpenForms["F11"] as F11;
            if (f11 != null)
            {
                // Muestra el valor 
                label2.Text = f11.cultivo.Text;
                label4.Text = f11.textBox1.Text;
                label11.Text = f11.fosforoplanta.Text;
                label34.Text = f11.fosforoplanta.Text;
                label10.Text = f11.nitrogenoplanta.Text;
                label36.Text = f11.nitrogenoplanta.Text;
                label12.Text = f11.potasioplanta.Text;
                label32.Text = f11.potasioplanta.Text;
                label30.Text = f11.pesoton.Text;
                label18.Text = f11.label15.Text;
                label19.Text = f11.label16.Text;
                label20.Text = f11.label17.Text;
            }
            else
            {
                // Maneja la situación si Form12 no está abierto
                label11.Text = "Form12 no está abierto o no se encontró.";
                label19.Text = "Form12 no está abierto o no se encontró.";
            }
            F12 f12 = Application.OpenForms["f12"] as F12;

            {
                if (f12 != null)
                {
                    // Muestra el valor en label9 en Form16

                    label40.Text = f12.textBox1.Text;
                    label42.Text = f12.textBox2.Text;
                    label44.Text = f12.textBox3.Text;
                }
                else
                {
                    // Maneja la situación si Form12 no está abierto
                    label30.Text = "k  no se encontró.";
                }
                ///// P-BRAY (ppm)
            }
        }
        private void label13_Click(object sender, EventArgs e)
        { }
        private void Form18_Load(object sender, EventArgs e)
        { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(label30.Text, out double valorLabel9))
            {
                //POTASIO
                // Verifica si el texto en label32 es un número válido
                if (double.TryParse(label44.Text, out double valorLabel30))
                {

                    // Suma el resultado de la multiplicación al valor en textBox1
                    double resultado = (valorLabel30 / 1000000) * (valorLabel9 * 1000);


                    // Muestra el resultado en label8
                    label16.Text = resultado.ToString("N2");

                }
                else
                {
                    // fodforo
                    // Maneja el caso en el que label7 no contenga un número válido
                    label16.Text = "El valor en label7 no es válido.";

                }
                //FOSFORO

                // Verifica si el texto en label7 es un número válido
                if (double.TryParse(label42.Text, out double valorLabel34))
                {

                    // Suma el resultado de la multiplicación al valor en textBox1
                    double resultado = (valorLabel34 / 1000000) * (valorLabel9 * 1000);


                    // Muestra el resultado en label8
                    label15.Text = resultado.ToString("N2");

                }
                else
                {
                    // Maneja el caso en el que label7 no contenga un número válido
                    label15.Text = "El valor en label7 no es válido.";

                }
                //NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
                if (double.TryParse(label40.Text, out double valorLabel36))
                {

                    // Suma el resultado de la multiplicación al valor en textBox1
                    double resultado = (valorLabel36 / 1000000) * (valorLabel9 * 1000);


                    // Muestra el resultado en label8
                    label14.Text = resultado.ToString("N2");

                }
                else
                {
                    // Maneja el caso en el que label7 no contenga un número válido
                    label14.Text = "El valor en label7 no es válido.";

                }
                // PARATE DE LA DOSIS DE FERTILIZACION 


                if (double.TryParse(label4.Text, out double RENDIMIENTO))
                {
                    // Cálculo de nitrógeno
                    if (double.TryParse(label10.Text, out double valorLabel10) &&
                        double.TryParse(label14.Text, out double valorLabel14) &&
                        double.TryParse(label18.Text, out double valorLabel18))
                    {
                        double resultadoNitrógeno = ((RENDIMIENTO * valorLabel10) - valorLabel14) / (valorLabel18 / 100);
                        label22.Text = resultadoNitrógeno.ToString("N2");
                        label22.Visible = true;
                    }
                    else
                    {
                        label22.Text = "Valores no válidos en los labels 10, 14 o 18.";
                        label12.Visible = true;
                    }

                    // Cálculo de fósforo
                    if (double.TryParse(label11.Text, out double valorLabel11) &&
                        double.TryParse(label15.Text, out double valorLabel15) &&
                        double.TryParse(label19.Text, out double valorLabel19))
                    {
                        double resultadoFósforo = ((RENDIMIENTO * valorLabel11) - valorLabel15) / (valorLabel19 / 100);
                        label23.Text = resultadoFósforo.ToString("N2");
                        label23.Visible = true;
                    }
                    else
                    {
                        label23.Text = "Valores no válidos en los labels 11, 15 o 19.";
                        label23.Visible = true;
                    }

                    // Cálculo de potasio
                    if (double.TryParse(label12.Text, out double valorLabel12) &&
                        double.TryParse(label16.Text, out double valorLabel16) &&
                        double.TryParse(label20.Text, out double valorLabel20))
                    {
                        double resultadoPotasio = ((RENDIMIENTO * valorLabel12) - valorLabel16) / (valorLabel20 / 100);
                        label24.Text = resultadoPotasio.ToString("N2");
                        label24.Visible = true;
                    }
                    else
                    {
                        label24.Text = "Valores no válidos en los labels 12, 16 o 20.";
                        label24.Visible = true;
                    }
                }
                else
                {
                    label24.Text = "El valor en label4 no es válido.";
                    label24.Visible = true;
                }

                // Cálculo de formula nitrogeno
                if (double.TryParse(label22.Text, out double valorLabel22))
                    if (double.TryParse(label10.Text, out double valorLabel10))
                    {
                        label26.Text = valorLabel22 > 1
                            // ? se utiliza como parte de una expresión condicional en C# y se conoce como el operador ternario
                            ? valorLabel22.ToString("N2")
                            //El símbolo: en una expresión condicional en C# se utiliza para separar el valor que se asignará 
                            // si la condición es verdadera del valor que se asignará si la condición es falsa
                            : (RENDIMIENTO * valorLabel10 / 2).ToString("N2");

                        label26.Visible = true;
                    }
                    else
                    {
                        label26.Text = "El valor en label22 no es válido.";
                        label26.Visible = true;
                    }

                // Cálculo de formula fosforo
                if (double.TryParse(label23.Text, out double valorLabel23))
                    if (double.TryParse(label11.Text, out double valorLabel11))
                    {
                        label27.Text = valorLabel23 > 1
                            // ? se utiliza como parte de una expresión condicional en C# y se conoce como el operador ternario
                            ? valorLabel23.ToString("N2")
                            //El símbolo : en una expresión condicional en C# se utiliza para separar el valor que se asignará 
                            // si la condición es verdadera del valor que se asignará si la condición es falsa
                            : (RENDIMIENTO * valorLabel11 / 2).ToString("N2");
                        label27.Visible = true;
                    }
                    else
                    {
                        label27.Text = "El valor en label23 no es válido.";
                        label27.Visible = true;
                    }

                // Cálculo de formula potacio
                if (double.TryParse(label24.Text, out double valorLabel24))
                    if (double.TryParse(label12.Text, out double valorLabel12))
                    {
                        label28.Text = valorLabel24 > 1
                            // ? se utiliza como parte de una expresión condicional en C# y se conoce como el operador ternario

                            ? valorLabel24.ToString("N2")
                            //El símbolo : en una expresión condicional en C# se utiliza para separar el valor que se asignará 
                            // si la condición es verdadera del valor que se asignará si la condición es falsa
                            : (RENDIMIENTO * valorLabel12 / 2).ToString("N2");
                        label28.Visible = true;
                    }
                    else
                    {
                        label28.Text = "El valor en label24 no es válido.";
                        label28.Visible = true;
                    }
            }
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            F16 form16 = new F16();

            // Ocultar el Formulario 1
            this.Hide();

            // Mostrar el Formulario 2
            form16.Show();
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            F13 boton = new F13();
            boton.Show();
        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click_1(object sender, EventArgs e)
        {

        }
    }


}
