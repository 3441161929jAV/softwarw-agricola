namespace softwarw_agricola
{
    partial class F14
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F14));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            incrementar = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            bindingSource1 = new BindingSource(components);
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(426, 98);
            label1.Name = "label1";
            label1.Size = new Size(474, 52);
            label1.TabIndex = 0;
            label1.Text = "MATERIA ORGANICA ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(364, 211);
            label2.Name = "label2";
            label2.Size = new Size(344, 33);
            label2.TabIndex = 1;
            label2.Text = "MATERIA ORGÁNICA ( % )";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(364, 285);
            label3.Name = "label3";
            label3.Size = new Size(570, 33);
            label3.TabIndex = 2;
            label3.Text = "MATERIA ORGÁNICA A INCREMENTAR ( % )";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(364, 372);
            label4.Name = "label4";
            label4.Size = new Size(453, 33);
            label4.TabIndex = 3;
            label4.Text = "MATERIAL ORGÁNICO A UTILIZAR";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(364, 432);
            label5.Name = "label5";
            label5.Size = new Size(606, 33);
            label5.TabIndex = 4;
            label5.Text = "CARBONO APORTADO POR EL MATERIAL ( % )";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(364, 488);
            label6.Name = "label6";
            label6.Size = new Size(424, 33);
            label6.TabIndex = 5;
            label6.Text = "CANTIDAD NECESARIA (kg  ha⁻¹)";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(984, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 39);
            textBox1.TabIndex = 6;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // incrementar
            // 
            incrementar.BackColor = Color.FromArgb(224, 224, 224);
            incrementar.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            incrementar.Location = new Point(984, 282);
            incrementar.Name = "incrementar";
            incrementar.Size = new Size(125, 39);
            incrementar.TabIndex = 7;
            incrementar.TextAlign = HorizontalAlignment.Center;
            incrementar.TextChanged += incrementar_TextChanged;
            incrementar.KeyPress += incrementar_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(224, 224, 224);
            comboBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(984, 369);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(222, 39);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(984, 432);
            label7.Name = "label7";
            label7.Size = new Size(83, 33);
            label7.TabIndex = 15;
            label7.Text = "label7";
            label7.TextAlignChanged += label7_TextAlignChanged;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(192, 64, 0);
            label8.Location = new Point(984, 488);
            label8.Name = "label8";
            label8.Size = new Size(83, 33);
            label8.TabIndex = 16;
            label8.Text = "label8";
            label8.Visible = false;
            label8.TextChanged += label8_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(564, 776);
            label9.Name = "label9";
            label9.Size = new Size(83, 33);
            label9.TabIndex = 17;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(364, 776);
            label10.Name = "label10";
            label10.Size = new Size(150, 20);
            label10.TabIndex = 18;
            label10.Text = "PESO DE SUELO (ton)";
            label10.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1597, 853);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(25, 742);
            button3.Name = "button3";
            button3.Size = new Size(183, 89);
            button3.TabIndex = 28;
            button3.Text = "Anterior";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_2;
            // 
            // button4
            // 
            button4.Location = new Point(668, 768);
            button4.Name = "button4";
            button4.Size = new Size(158, 63);
            button4.TabIndex = 46;
            button4.Text = "SALIR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1336, 742);
            button1.Name = "button1";
            button1.Size = new Size(191, 89);
            button1.TabIndex = 47;
            button1.Text = "Sigiente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // F14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1597, 853);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(incrementar);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "F14";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enmienda Organica";
            Load += Form144_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox incrementar;
        private Label label7;
        private BindingSource bindingSource1;
        public Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private Button button1;
        public Label label8;
        public ComboBox comboBox1;
    }
}