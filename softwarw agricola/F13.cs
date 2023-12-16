


namespace softwarw_agricola
{
    public partial class F13 : Form
    {
        public F13()
        {
            InitializeComponent();
            //llamar dato del formulario 12 CARACTERISTICAS
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            F11 form11 = Application.OpenForms["F11"] as F11;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            if (form11 != null)
            {
                // Muestra el valor en label9 en Form16
                label14.Text = form11.pesoton.Text;
            }
            else
            {
                // Maneja la situación si Form12 no está abierto
                label14.Text = "Form12 no está abierto o no se encontró.";
            }
            //llamar dato del formulario 14

#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            F12 f12 = Application.OpenForms["F12"] as F12;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            if (f12 != null)
            {
                // Muestra el valor 
                label11.Text = f12.textBox3.Text;
                // Muestra el valor 
                label19.Text = f12.textBox4.Text;
                // Muestra el valor 
                label20.Text = f12.textBox5.Text;
                // Muestra el valor 
                label21.Text = f12.textBox6.Text;
                // Muestra el valor 
                label22.Text = f12.textBox13.Text;
                // Muestra el valor 
                label49.Text = f12.textBox14.Text;
            }
            else
            {
                // Maneja la situación si Form12 no está abierto
                label11.Text = "Form12 no está abierto o no se encontró.";
                label19.Text = "Form12 no está abierto o no se encontró.";
                label20.Text = "Form12 no está abierto o no se encontró.";
                label21.Text = "Form12 no está abierto o no se encontró.";
                label22.Text = "Form12 no está abierto o no se encontró.";
                label49.Text = "Form12 no está abierto o no se encontró.";
            }
            label16.TextChanged += (sender, e) => CalcularResultado();
            label5.TextChanged += (sender, e) => CalcularResultado();
            label7.TextChanged += (sender, e) => CalcularResultado();
            label14.TextChanged += (sender, e) => CalcularResultado();
            label18.TextChanged += (sender, e) => CalcularResultado();
            // para las ociones de obciones 1
            comboBox1.Items.Add(new ComboBoxItem(" Mg", "12 ", "mg"));
            comboBox1.Items.Add(new ComboBoxItem(" Ca ", "20", "ca"));

            // Opción 2
            comboBox2.Items.Add(new ComboBoxItem("HIDRÓXIDO DE CALCIO", "Ca(OH)2", "1.4"));
            comboBox2.Items.Add(new ComboBoxItem("CAL AGRÍCOLA O CALCITA", "CaCO3", "1.85"));
            comboBox2.Items.Add(new ComboBoxItem("DOLOMITA", "CaCO3 MgCO3", "2.5"));
            comboBox2.Items.Add(new ComboBoxItem("ÓXIDO DE MAGNESIO", "MgO", "2.5"));
            comboBox2.Items.Add(new ComboBoxItem("MAGNESITA", "MgCO3", "1.66"));
            comboBox2.Items.Add(new ComboBoxItem("YESO AGRÍCOLA", "CaSO4", "3.5"));


        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)comboBox1.SelectedItem;

                label7.Text = selectedItem.Value;

                // Realiza la resta según la selección
                if (selectedItem.Tag == "ca")
                {
                    // Realiza la resta o ajustes según la etiqueta "ca"
                    double valorResta = 65 - double.Parse(label33.Text);
                    label5.Text = valorResta.ToString("N2");
                    // PAA MOSTRAR EL DATO

                }
                else if (selectedItem.Tag == "mg")
                {
                    // Realiza la resta o ajustes según la etiqueta "mg"
                    double valorResta = 15 - double.Parse(label32.Text);
                    label5.Text = valorResta.ToString("N2");
                }
            }
        }


        public class ComboBoxItem
        {
            // Para el menú 1
            public string Text { get; set; }
            public string Value { get; set; }
            public string Tag { get; set; }

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
            public ComboBoxItem(string text, string value, string tag)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
            {
                Text = text;
                Value = value;
                Tag = tag;
            }
            public string op2 { get; set; }
            public string op3 { get; set; }

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
            public ComboBoxItem(string text, string value, string tag, int extraParameter)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
            {
                Text = text;
                Value = value;
                Tag = tag;
            }
            public override string ToString()
            {
                return Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form17_Load(object sender, EventArgs e)

        {
            if (comboBox2.SelectedIndex >= 0)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)comboBox2.SelectedItem;

                // Mostrar el valor del ComboBoxItem en label17 y label18
                label17.Text = selectedItem.Value; // Esto puede variar según lo que quieras mostrar en label17
                label18.Text = selectedItem.Tag; // Esto también puede variar según lo que quieras mostrar en label18
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            F14 form14 = new F14();

            // Ocultar el Formulario 1
            this.Hide();

            // Mostrar el Formulario 2
            form14.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)comboBox2.SelectedItem;

                // Mostrar el valor del ComboBoxItem en label17 y label18
                label17.Text = selectedItem.Value; // Esto puede variar según lo que quieras mostrar en label17
                label18.Text = selectedItem.Tag; // Esto también puede variar según lo que quieras mostrar en label18
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_TextChanged(object sender, EventArgs e)
        {
            CalcularResultado();
        }
        private void CalcularResultado()
        {
            if (double.TryParse(label5.Text, out double valorLabel5) &&
        double.TryParse(label35.Text, out double valorLabel35) &&
        double.TryParse(label7.Text, out double valorLabel7) &&
        double.TryParse(label14.Text, out double valorLabel14) &&
        double.TryParse(label18.Text, out double valorLabel18))
            {
                double resultado = ((((((valorLabel5 * valorLabel35) / 100.0) * 10.0) * valorLabel7) / 1000000.0) *
                    (valorLabel14 * 1000.0)) * valorLabel18;

                label12.Text = resultado.ToString("N2");
                label12.Visible = true;
            }
            else
            {
                label12.Text = "Capturar datos";
                label12.Visible = true;
            }
        }
        private void label5_TextChanged(object sender, EventArgs e)
        {
            CalcularResultado();
        }
        private void label35_TextChanged(object sender, EventArgs e)
        {
            CalcularResultado();
        }
        private void label7_TextChanged(object sender, EventArgs e)
        {
            CalcularResultado();
        }


        private void label14_TextChanged(object sender, EventArgs e)
        {
            CalcularResultado();
        }

        private void label18_TextChanged(object sender, EventArgs e)
        {
            CalcularResultado();
        }
        private void label17_TextChanged(object sender, EventArgs e)
        {
            CalcularResultado();
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void label25_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(label13.Text, out double valorTextBox13))
            {
                double resultadoDivision = valorTextBox13 / 90;
                label25.Text = resultadoDivision.ToString("N2");
                label25.Visible = true;
            }
            else
            {
                label25.Text = "Valor no válido Al";
                label25.Visible = true;
            }
        }


        private void CalcularDivision(TextBox textBox, Label label, double divisor)
        {
            if (double.TryParse(textBox.Text, out double valorTextBox))
            {
                double resultadoDivision = valorTextBox / divisor;
                label.Text = resultadoDivision.ToString("N2");
                label.Visible = true;
            }
            else
            {
                label.Text = "Valor no válido";
                label.Visible = true;
            }

            //  calcular la suma total
            CalcularTotal();
        }
        private void CalcularTotal()
        {
            double total = 0.0;

            if (double.TryParse(label28.Text, out double valorLabel28))
            {
                total += valorLabel28;
            }

            if (double.TryParse(label27.Text, out double valorLabel27))
            {
                total += valorLabel27;
            }

            if (double.TryParse(label23.Text, out double valorLabel23))
            {
                total += valorLabel23;
            }

            if (double.TryParse(label24.Text, out double valorLabel24))
            {
                total += valorLabel24;
            }

            if (double.TryParse(label25.Text, out double valorLabel25))
            {
                total += valorLabel25;
            }

            if (double.TryParse(label26.Text, out double valorLabel26))
            {
                total += valorLabel26;
            }

            label35.Text = total.ToString("N2");
            label35.Visible = true;
            if (total != 0.0)
            {
                double porcentaje28 = (valorLabel28 * 100) / total;
                double porcentaje27 = (valorLabel27 * 100) / total;
                double porcentaje23 = (valorLabel23 * 100) / total;
                double porcentaje24 = (valorLabel24 * 100) / total;
                double porcentaje25 = (valorLabel25 * 100) / total;
                double porcentaje26 = (valorLabel26 * 100) / total;

                // Mostrar los porcentajes en otros Label
                label34.Text = porcentaje28.ToString("N2");
                label34.Visible = true;
                label33.Text = porcentaje27.ToString("N2");
                label33.Visible = true;
                label32.Text = porcentaje23.ToString("N2");
                label32.Visible = true;
                label31.Text = porcentaje24.ToString("N2");
                label31.Visible = true;
                label30.Text = porcentaje25.ToString("N2");
                label30.Visible = true;
                label29.Text = porcentaje26.ToString("N2");
                label29.Visible = true;
            }
            else
            {
                // Manejar el caso cuando el total es 0
                label34.Text = "Valor no válido K ";
                label34.Visible = true;
                label33.Text = "Valor no válido Ca ";
                label33.Visible = true;
                label32.Text = "Valor no válido Mg ";
                label32.Visible = true;
                label31.Text = "Valor no válido Na ";
                label31.Visible = true;
                label30.Text = "Valor no válido Al ";
                label30.Visible = true;
                label29.Text = "Valor no válido H ";
                label29.Visible = true;
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void ActualizarSuma()
        {

            if (double.TryParse(label11.Text, out double valorLabel11) &&
                double.TryParse(label19.Text, out double valorLabel19) &&
                double.TryParse(label20.Text, out double valorLabel20) &&
                double.TryParse(label21.Text, out double valorLabel21) &&
                double.TryParse(label22.Text, out double valorLabel22) &&
                double.TryParse(label49.Text, out double valorLabel49))
            {
                // Realizar la suma de los valores
                double suma = valorLabel11 / 390.0 +
                             valorLabel19 / 200.0 +
                             valorLabel20 / 120.0 +
                             valorLabel21 / 230.0 +
                             valorLabel22 / 90.0 +
                             valorLabel49 / 10.0;

                // Actualizar el label deseado con el resultado
                label35.Text = suma.ToString("N2");
            }
            else
            {
                // Manejar el caso en el que alguno de los valores no sea un número válido
                label35.Text = "Error: Valores no válidos en los labels";
            }
        }
        private void CalcularPorcentajes()
        {
            if (double.TryParse(label28.Text, out double valorLabel28) &&
                double.TryParse(label27.Text, out double valorLabel27) &&
                double.TryParse(label23.Text, out double valorLabel23) &&
                double.TryParse(label24.Text, out double valorLabel24) &&
                double.TryParse(label25.Text, out double valorLabel25) &&
                double.TryParse(label26.Text, out double valorLabel26))
            {
                // Calcular la suma de los valores
                double sumaTotal = valorLabel28 + valorLabel27 + valorLabel23 + valorLabel24 + valorLabel25 + valorLabel26;

                // Calcular los porcentajes
                double porcentajeLabel28 = (valorLabel28 * 100) / sumaTotal;
                double porcentajeLabel27 = (valorLabel27 * 100) / sumaTotal;
                double porcentajeLabel23 = (valorLabel23 * 100) / sumaTotal;
                double porcentajeLabel24 = (valorLabel24 * 100) / sumaTotal;
                double porcentajeLabel25 = (valorLabel25 * 100) / sumaTotal;
                double porcentajeLabel26 = (valorLabel26 * 100) / sumaTotal;

                // Actualizar los labels con los porcentajes
                label34.Text = porcentajeLabel28.ToString("N2");
                label34.Visible = true;
                label33.Text = porcentajeLabel27.ToString("N2");
                label33.Visible = true;
                label32.Text = porcentajeLabel23.ToString("N2");
                label32.Visible = true;
                label31.Text = porcentajeLabel24.ToString("N2");
                label31.Visible = true;
                label30.Text = porcentajeLabel25.ToString("N2");
                label30.Visible = true;
                label29.Text = porcentajeLabel26.ToString("N2");
                label29.Visible = true;
            }
            else
            {
                // Manejar el caso en el que alguno de los valores no sea un número válido
                label34.Text = "Error: Valores no válidos en los labels";
                label34.Visible = true;
                label33.Text = "Error: Valores no válidos en los labels";
                label33.Visible = true;
                label32.Text = "Error: Valores no válidos en los labels";
                label32.Visible = true;
                label31.Text = "Error: Valores no válidos en los labels";
                label31.Visible = true;
                label30.Text = "Error: Valores no válidos en los labels";
                label30.Visible = true;
                label29.Text = "Error: Valores no válidos en los labels";
                label29.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            F12 boton = new F12();
            boton.Show();
        }
        private void label11_TextChanged(object sender, EventArgs e)
        {
            // KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK
            if (double.TryParse(label11.Text, out double valorLabel11))
            {
                // Realizar la división y mostrar el resultado en label28
                double resultado = valorLabel11 / 390.0;
                label28.Text = resultado.ToString("N2");
                label28.Visible = true;
            }
            else
            {
                // Manejar el caso en el que el texto en label11 no sea un número válido
                label28.Text = "Error: Valor no válido en label11";
                label28.Visible = true;
            }
            ActualizarSuma();
        }
        private void label19_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(label19.Text, out double valorLabel19))
            {
                double resultado = valorLabel19 / 200.0;
                label27.Text = resultado.ToString("N2");
                label27.Visible = true;
            }
            else
            {
                label27.Text = "Error";
                label27.Visible = true;
            }
            ActualizarSuma();
        }

        private void label20_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(label20.Text, out double valorLabel20))
            {
                double resultado = valorLabel20 / 120.0;
                label23.Text = resultado.ToString("N2");
                label23.Visible = true;
            }
            else
            {
                label23.Text = "Error:";
                label23.Visible = true;
            }
            ActualizarSuma();
        }

        private void label21_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(label21.Text, out double valorLabel21))
            {
                double resultado = valorLabel21 / 230.0;
                label24.Text = resultado.ToString("N2");
                label24.Visible = true;
            }
            else
            {
                label24.Text = "Error:";
                label24.Visible = true;
            }
            ActualizarSuma();
        }

        private void label22_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(label22.Text, out double valorLabel22))
            {
                double resultado = valorLabel22 / 90.0;
                label25.Text = resultado.ToString("N2");
                label25.Visible = true;
            }
            else
            {
                label25.Text = "Error:";
                label25.Visible = true;
            }
            ActualizarSuma();
        }

        private void label49_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(label49.Text, out double valorLabel49))
            {
                double resultado = valorLabel49 / 10.0;
                label26.Text = resultado.ToString("N2");
                label26.Visible = true;
            }
            else
            {
                label26.Text = "Error: ";
            }
            ActualizarSuma();
        }

        private void label28_TextChanged(object sender, EventArgs e)
        {
            CalcularPorcentajes();
        }

        private void label27_TextChanged(object sender, EventArgs e)
        {
            CalcularPorcentajes();
        }

        private void label23_TextChanged(object sender, EventArgs e)
        {
            CalcularPorcentajes();
        }

        private void label24_TextChanged(object sender, EventArgs e)
        {
            CalcularPorcentajes();
        }

        private void label25_TextChanged_1(object sender, EventArgs e)
        {
            CalcularPorcentajes();
        }

        private void label26_TextChanged(object sender, EventArgs e)
        {
            CalcularPorcentajes();
        }

        //%%%%%%%%%%%%%%%%%%%%%%kkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk
        private void label34_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(label34.Text, out double valorLabel34))
            {
                string estado = "Bajo";

                if (valorLabel34 >= 7)
                {
                    estado = "Alto";
                }
                else if (valorLabel34 >= 5 && valorLabel34 < 7)
                {
                    estado = "Medio";
                }

                label36.Text = estado;
                label36.Visible = true;
            }
            else
            {
                label36.Text = "Valor no válido";
                label36.Visible = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            // Cierra la aplicación
            Application.Exit();
        }

        private void label33_TextChanged(object sender, EventArgs e)
        {
            //%%%%%%%%%%%%%%%%%%%%%%%%%%555555CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCAAAAAAAAAAAAAAAAAAAAA
            if (double.TryParse(label33.Text, out double valorLabel33))
            {
                string estado = "Bajo";

                if (valorLabel33 >= 75)
                {
                    estado = "Alto";
                }
                else if (valorLabel33 >= 65 && valorLabel33 <= 75)
                {
                    estado = "Medio";
                }

                label37.Text = estado;
            }
            else
            {
                label37.Text = "Valor no válido";
                label37.Visible = true;
            }

        }

        private void label32_TextChanged(object sender, EventArgs e)
        {
            //MMMMMMMMMMMMMMMMMMMMMMMGGGGGGGGGGGGGGGGGGGG
            if (double.TryParse(label32.Text, out double valorLabel32))
            {
                string estado = "Bajo";

                if (valorLabel32 >= 20)
                {
                    estado = "Alto";
                }
                else if (valorLabel32 >= 10 && valorLabel32 <= 20)
                {
                    estado = "Medio";
                }

                label38.Text = estado;
                label38.Visible = true;
            }
            else
            {
                label38.Text = "Valor no válido";
                label38.Visible = true;
            }

        }

        private void label31_TextChanged(object sender, EventArgs e)
        {        //NNNNNNNNNNNNNNNNNAAAAAAAAAAAAAAAAAAAAAA
            if (double.TryParse(label31.Text, out double valorLabel31))
            {
                string estado = "Bajo";

                if (valorLabel31 >= 5)
                {
                    estado = "Alto";
                }
                else if (valorLabel31 >= 1 && valorLabel31 <= 5)
                {
                    estado = "Medio";
                }

                label39.Text = estado;
                label39.Visible = true;
            }
            else
            {
                label39.Text = "Valor no válido";
                label39.Visible = true;
            }

        }

        private void label30_TextChanged(object sender, EventArgs e)
        {        //AAAAAAAAAAAAAAAAAAAAAAAAAAALLLLLLLLLLLLLLLLLLLLL
            if (double.TryParse(label30.Text, out double valorLabel30))
            {
                string estado = "Bajo";

                if (valorLabel30 >= 5)
                {
                    estado = "Alto";
                }
                else if (valorLabel30 >= 1 && valorLabel30 <= 5)
                {
                    estado = "Medio";
                }

                label40.Text = estado;
                label40.Visible = true;
            }
            else
            {
                label40.Text = "Valor no válido";
                label40.Visible = true;
            }

        }

        private void label29_TextChanged(object sender, EventArgs e)
        { // HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
            if (double.TryParse(label29.Text, out double valorLabel29))
            {
                string estado = "Bajo";

                if (valorLabel29 >= 5)
                {
                    estado = "Alto";
                }
                else if (valorLabel29 >= 1 && valorLabel29 <= 5)
                {
                    estado = "Medio";
                }

                label41.Text = estado;
                label41.Visible = true;

            }
            else
            {
                label41.Text = "Valor no válido";
                label41.Visible = true;
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }


        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }

}
