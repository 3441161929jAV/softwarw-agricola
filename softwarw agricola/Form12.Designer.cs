namespace softwarw_agricola
{
    partial class Form12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources String1cbeing used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            profundidad = new TextBox();
            densidad = new TextBox();
            button2 = new Button();
            pesoton = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(390, 48);
            label1.Name = "label1";
            label1.Size = new Size(592, 60);
            label1.TabIndex = 0;
            label1.Text = "CARACTERÍSTICAS FÍSICAS ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(113, 188);
            label2.Name = "label2";
            label2.Size = new Size(267, 50);
            label2.TabIndex = 1;
            label2.Text = "PROFUNDIDAD DE LA \r\n        MUESTRA (m)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(443, 193);
            label3.Name = "label3";
            label3.Size = new Size(268, 50);
            label3.TabIndex = 2;
            label3.Text = "DENSIDAD APARENTE \r\n         (g cm3)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(781, 194);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 3;
            label4.Text = "TEXTURA ";
            // 
            // profundidad
            // 
            profundidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            profundidad.Location = new Point(164, 273);
            profundidad.Name = "profundidad";
            profundidad.Size = new Size(125, 34);
            profundidad.TabIndex = 5;
            profundidad.TextChanged += profundidad_TextChanged;
            profundidad.KeyPress += profundidad_KeyPress;
            // 
            // densidad
            // 
            densidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            densidad.Location = new Point(490, 273);
            densidad.Name = "densidad";
            densidad.Size = new Size(125, 34);
            densidad.TabIndex = 6;
            densidad.TextChanged += densidad_TextChanged;
            densidad.KeyPress += densidad_KeyPress;
            // 
            // button2
            // 
            button2.Location = new Point(1306, 436);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "SIGUIENTE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pesoton
            // 
            pesoton.AutoSize = true;
            pesoton.BackColor = SystemColors.Info;
            pesoton.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            pesoton.Location = new Point(176, 436);
            pesoton.Name = "pesoton";
            pesoton.Size = new Size(90, 25);
            pesoton.TabIndex = 16;
            pesoton.Text = "pesoton";
            pesoton.TextChanged += pesoton_TextChanged;
            pesoton.Click += pesosuelo_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(604, 383);
            button1.Name = "button1";
            button1.Size = new Size(137, 84);
            button1.TabIndex = 17;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "NR", "ARCILLOSA", "ARENOSA", "MEDIA " });
            comboBox1.Location = new Point(741, 273);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 36);
            comboBox1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(52, 383);
            label6.Name = "label6";
            label6.Size = new Size(315, 25);
            label6.TabIndex = 20;
            label6.Text = "PESO DEL SUELO ES (TON)";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(1482, 553);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(pesoton);
            Controls.Add(button2);
            Controls.Add(densidad);
            Controls.Add(profundidad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button1;
        public TextBox profundidad;
        public TextBox densidad;
        private ComboBox comboBox1;
        public Label pesoton;
        private Label label6;
    }
}