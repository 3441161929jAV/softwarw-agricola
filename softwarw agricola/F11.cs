using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Drawing;
using System.Text.RegularExpressions;
using System;

using System.Diagnostics;
using static softwarw_agricola.F13;

using System.Globalization;

namespace softwarw_agricola
{
    public partial class F11 : Form


    {

        public F11()
        {
            InitializeComponent();

            comboBox1.Items.Add(new ComboBoxItem("Aguacate", "Persea americana Miller", "11", "2", "20"));
            comboBox1.Items.Add(new ComboBoxItem("Alfalfa", "Medicago sativa", "27", "2.5", "21"));
            comboBox1.Items.Add(new ComboBoxItem("Apio", "Apium graveolens L.", "1.7", "0.4", "3.7"));
            comboBox1.Items.Add(new ComboBoxItem("Arroz", "Oryza sativa L.", "22", "4", "26"));
            comboBox1.Items.Add(new ComboBoxItem("Brócoli", "Brassica oleracea var. Italica", "3.4", "0.8", "3.5"));
            comboBox1.Items.Add(new ComboBoxItem("Café", "Coffea arabica L.", "24", "2", "19"));
            comboBox1.Items.Add(new ComboBoxItem("Calabacita", "Cucurbita pepo L.", "4", "0.6", "6"));
            comboBox1.Items.Add(new ComboBoxItem("Calabaza", "Cucurbita inífe Dutch.", "4.2", "0.3", "4.8"));
            comboBox1.Items.Add(new ComboBoxItem("Caña de azúcar", "Saccharum officinarum L.", "5", "1.3", "6"));
            comboBox1.Items.Add(new ComboBoxItem("Cebada", "Hordeum vulgare L.", "26", "4", "20"));
            comboBox1.Items.Add(new ComboBoxItem("Cebolla", "Allium cepa L.", "3.9", "0.6", "4"));
            comboBox1.Items.Add(new ComboBoxItem("Chicharo", "Pisum sativum L.", "56", "6", "25"));
            comboBox1.Items.Add(new ComboBoxItem("Chile ", "Capsicum annuum L.", "5", "0.7", "7"));
            comboBox1.Items.Add(new ComboBoxItem("Ciruelo", "Prunus domestica L.", "6.5", "0.9", "6"));
            comboBox1.Items.Add(new ComboBoxItem("Col", "Brassica campestris L.", "4.2", "0.7", "5"));
            comboBox1.Items.Add(new ComboBoxItem("Coliflor", "Brassica oleracea L.", "4.7", "0.8", "6.5"));
            comboBox1.Items.Add(new ComboBoxItem("Durazno", "Prunus inífer L.", "5.1", "0.7", "4.6"));
            comboBox1.Items.Add(new ComboBoxItem("Espárrago", "Asparagus officinalis L.", "19.3", "2.9", "17.9"));
            comboBox1.Items.Add(new ComboBoxItem("Espinaca", "Spinacia oleracea L.", "5.1", "0.8", "5.6"));
            comboBox1.Items.Add(new ComboBoxItem("Fresa ", "Fragaria x ananassa", "3.5", "0.8", "4.5"));
            comboBox1.Items.Add(new ComboBoxItem("Garbanzo", "Cicer arietinum L.", "0", "0", "0"));
            comboBox1.Items.Add(new ComboBoxItem("Girasol", "Helianthus annus L.", "40", "11", "29"));
            comboBox1.Items.Add(new ComboBoxItem("Haba", "Vicia faba L.", "62", "7", "33"));
            comboBox1.Items.Add(new ComboBoxItem("Higo ", "Ficus carica", "17", "8", "15"));
            comboBox1.Items.Add(new ComboBoxItem("Jitomate", "Lycopersicon esculentum Mill L.", "2.8", "0.4", "4.5"));
            comboBox1.Items.Add(new ComboBoxItem("Kiwi", "Actinidia delicioso Chev.", "6.5", "0", "0"));
            comboBox1.Items.Add(new ComboBoxItem("Lechuga", "Lactuca sativa L.", "2", "0.5", "4.3"));
            comboBox1.Items.Add(new ComboBoxItem("Lenteja", "Lens culinaris", "65", "8", "40"));
            comboBox1.Items.Add(new ComboBoxItem("Limón", "Citrus iníf L. Burm.", "6.3", "0.7", "4.4"));
            comboBox1.Items.Add(new ComboBoxItem("Macadamia", "Macadamia ternifolia", "6", "0.7", "0"));
            comboBox1.Items.Add(new ComboBoxItem("Maíz (grano)", "Zea mays L.", "22", "8.8", "19"));
            comboBox1.Items.Add(new ComboBoxItem("Mandarina", "Citrus reticulata Blanco", "4.4", "0.4", "4.5"));
            comboBox1.Items.Add(new ComboBoxItem("Manzana", "Malus pumila Mil L.", "3.6", "0.8", "2.5"));
            comboBox1.Items.Add(new ComboBoxItem("Melón", "Cucumis melo L,", "4", "0.6", "5.5"));
            comboBox1.Items.Add(new ComboBoxItem("Naranja", "Citrus sinensis Osbeck", "5.7", "0.7", "5.3"));
            comboBox1.Items.Add(new ComboBoxItem("Nogal", "Juglans regia L.", "14.7", "1.9", "10.4"));
            comboBox1.Items.Add(new ComboBoxItem("Papa", "Solanum tuberosum L.", "5.5", "0.9", "8.2"));
            comboBox1.Items.Add(new ComboBoxItem("Pepino", "Cucumis sativus L.", "4", "0.7", "5.3"));
            comboBox1.Items.Add(new ComboBoxItem("Pera", "Pyrus communis L.", "2.6", "0.4", "2.8"));
            comboBox1.Items.Add(new ComboBoxItem("Piña", "Ananas comosus L.", "4", "0.9", "9.8"));
            comboBox1.Items.Add(new ComboBoxItem("Plátano", "Musa spp.", "8.4", "1.1", "8.3"));
            comboBox1.Items.Add(new ComboBoxItem("Sandia ", "Citrullus lanatus Thumb", "2", "0.3", "3"));
            comboBox1.Items.Add(new ComboBoxItem("Sorgo (grano)", "Sorghum bicolor L", "30", "4", "21"));
            comboBox1.Items.Add(new ComboBoxItem("Soya", "Glycine max L.", "80", "8", "33"));
            comboBox1.Items.Add(new ComboBoxItem("Trigo", "Triticum aestivum L.", "30", "5", "19"));
            comboBox1.Items.Add(new ComboBoxItem("Uva", "Vitis inífera L.", "6.9", "1", "8"));
            comboBox1.Items.Add(new ComboBoxItem("Zanahoria", "Daucus carota L.", "4", "0.8", "6"));

        }
        // MENU 11111111



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void Form11_Load(object sender, EventArgs e)
        { }
        public class ComboBoxItem
        {
            //para para el primer menu
            public string Name { get; set; }
            public string Value { get; set; }
            public string n { get; set; }
            public string p { get; set; }
            public string k { get; set; }


            public ComboBoxItem(string name, string value, string n, string p, string k)
            {
                Name = name;
                Value = value;
                // Utiliza "this" para referirte a las propiedades de
                // la claseasegurarme de que estás asignando los valores
                // a las propiedades de la clase y no a los parámetros del constructor
                this.n = n;
                this.p = p;
                this.k = k;


            }

            public override string ToString()
            {
                return Name;
            }


        }



        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)comboBox1.SelectedItem;

                // Mostrar el nombre en label6
                cultivo.Text = selectedItem.Name;
                // Mostrar el nombre cientifico
                nombrecientifico.Text = selectedItem.Value;
                nombrecientifico.Visible = true;
                // Mostrar n
                nitrogenoplanta.Text = selectedItem.n;
                // Mostrar p
                fosforoplanta.Text = selectedItem.p;
                // Mostrar k
                potasioplanta.Text = selectedItem.k;



            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Obtener los valores ingresados 
            if (double.TryParse(densidad.Text, out double numero1) && double.TryParse(profundidad.Text, out double numero2))
            {
                double resultado = 10000 * numero1 * numero2;

                // Formatear el resultado con comas para separar los miles
                CultureInfo cultureInfo = new CultureInfo("es-ES");
                pesoton.Text = resultado.ToString("N2");
                pesoton.Text = resultado.ToString("N2", cultureInfo);
            }
            else
            {
                // Mostrar un mensaje de error si los valores ingresados no son números válidos
                MessageBox.Show("Por favor, ingrese números vál-idos en ambos campos.");
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void densidad_TextChanged(object sender, EventArgs e)
        {
            CalcularMultiplicacion();
        }

        private void profundidad_TextChanged(object sender, EventArgs e)
        {
            CalcularMultiplicacion();
        }

        private void CalcularMultiplicacion()
        {
            // Obtén los valores de los TextBox (asegúrate de que los nombres coincidan)
            if (double.TryParse(densidad.Text, out double numero1) && double.TryParse(profundidad.Text, out double numero2))
            {
                // Realiza la multiplicación
                double resultado = 10000 * numero1 * numero2;

                // Muestra el resultado en el control Label correcto (por ejemplo, pesoton)
                pesoton.Text = resultado.ToString();
                pesoton.Visible = true;
            }
            else
            {
                pesoton.Text = "Ingrese densidad y profundidad";
                pesoton.Visible = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia del Formulario 2
            F12 form12 = new F12();

            // Ocultar el Formulario 1
            this.Hide();

            // Mostrar el Formulario 2
            form12.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void pesoton_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void mENÚToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dATOSGENERALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F11 f11 = new F11();
            f11.Show();
        }

        private void eNMIENDAORGANICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F12 f13 = new F12();
            f13.Show();
        }

        private void eNCALADOYOENYESADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F14 f13 = new F14();
            f13.Show();
        }

        private void pROGRAMADEFERTILIZACIÓNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F13 f14 = new F13();
            f14.Show();
        }

        private void rECOMENDACIONGENERALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F15 f15 = new F15();
            f15.Show();
        }

        private void rECOMENDASIÓNGENERANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F16 f16 = new F16();
            f16.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoSuelo.SelectedItem != null)
            {
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                string opcionSeleccionada = comboBoxTipoSuelo.SelectedItem.ToString();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

                switch (opcionSeleccionada)
                {
                    case "ARENOSO":
                        label15.Text = "40";
                        label16.Text = "30";
                        label17.Text = "40";
                        break;
                    case "FRANCO":
                        label15.Text = "50";
                        label16.Text = "40";
                        label17.Text = "55";
                        break;
                    case "ARCILLOZO":
                        label15.Text = "65";
                        label16.Text = "50";
                        label17.Text = "70";
                        break;
                    default:
                        label15.Text = string.Empty;
                        label16.Text = string.Empty;
                        label17.Text = string.Empty;
                        break;

                }
            }
        }

        private void nombrecientifico_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoSuelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // Abre la cámara
            System.Diagnostics.Process.Start("your_camera_executable_or_command");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fcam fcam = new fcam();
            fcam.Show();
        }

        private void nitrogenoplanta_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
