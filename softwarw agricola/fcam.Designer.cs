namespace softwarw_agricola
{
    partial class fcam
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
            pictureBox1 = new PictureBox();
            btnIniciarCaptura = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(269, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(901, 356);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnIniciarCaptura
            // 
            btnIniciarCaptura.Location = new Point(581, 400);
            btnIniciarCaptura.Name = "btnIniciarCaptura";
            btnIniciarCaptura.Size = new Size(224, 53);
            btnIniciarCaptura.TabIndex = 1;
            btnIniciarCaptura.Text = "button1";
            btnIniciarCaptura.UseVisualStyleBackColor = true;
            // 
            // fcam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 516);
            Controls.Add(btnIniciarCaptura);
            Controls.Add(pictureBox1);
            Name = "fcam";
            Text = "fcam";
            Load += fcam_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnIniciarCaptura;
    }
}