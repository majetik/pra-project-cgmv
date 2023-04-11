namespace CGMV
{
    partial class ObrisiKolegij
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
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            CMOdaberiKolegij = new ComboBox();
            BtnNatrag = new Button();
            BtnObrisi = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Algebra_logo;
            pictureBox1.Location = new Point(145, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Algebra_logo_2;
            pictureBox2.Location = new Point(315, 399);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(338, 37);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 2;
            label1.Text = "Obriši kolegij";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(145, 133);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 3;
            label2.Text = "Odaberi kolegij za brisanje:";
            // 
            // CMOdaberiKolegij
            // 
            CMOdaberiKolegij.FormattingEnabled = true;
            CMOdaberiKolegij.Location = new Point(145, 165);
            CMOdaberiKolegij.Name = "CMOdaberiKolegij";
            CMOdaberiKolegij.Size = new Size(408, 23);
            CMOdaberiKolegij.TabIndex = 4;
            // 
            // BtnNatrag
            // 
            BtnNatrag.Location = new Point(145, 273);
            BtnNatrag.Name = "BtnNatrag";
            BtnNatrag.Size = new Size(75, 23);
            BtnNatrag.TabIndex = 5;
            BtnNatrag.Text = "Natrag";
            BtnNatrag.UseVisualStyleBackColor = true;
            BtnNatrag.Click += BtnNatrag_Click;
            // 
            // BtnObrisi
            // 
            BtnObrisi.Location = new Point(478, 283);
            BtnObrisi.Name = "BtnObrisi";
            BtnObrisi.Size = new Size(75, 23);
            BtnObrisi.TabIndex = 6;
            BtnObrisi.Text = "Obriši";
            BtnObrisi.UseVisualStyleBackColor = true;
            BtnObrisi.Click += BtnObrisi_Click;
            // 
            // ObrisiKolegij
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(784, 461);
            Controls.Add(BtnObrisi);
            Controls.Add(BtnNatrag);
            Controls.Add(CMOdaberiKolegij);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "ObrisiKolegij";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ObrisiKolegij";
            Load += ObrisiKolegij_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private ComboBox CMOdaberiKolegij;
        private Button BtnNatrag;
        private Button BtnObrisi;
    }
}