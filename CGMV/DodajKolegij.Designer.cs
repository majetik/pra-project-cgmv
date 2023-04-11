namespace CGMV
{
    partial class DodajKolegij
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
            label3 = new Label();
            TBImeKolegija = new TextBox();
            TBSifraKolegija = new TextBox();
            BtnNatrag = new Button();
            BtnDodaj = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Algebra_logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Algebra_logo_2;
            pictureBox2.Location = new Point(119, 399);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(128, 21);
            label1.Name = "label1";
            label1.Size = new Size(130, 25);
            label1.TabIndex = 2;
            label1.Text = "Dodaj kolegij";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 3;
            label2.Text = "Unesi ime kolegija:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(12, 173);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 4;
            label3.Text = "Unesi sifru kolegija";
            // 
            // TBImeKolegija
            // 
            TBImeKolegija.Location = new Point(12, 123);
            TBImeKolegija.Name = "TBImeKolegija";
            TBImeKolegija.Size = new Size(338, 23);
            TBImeKolegija.TabIndex = 5;
            // 
            // TBSifraKolegija
            // 
            TBSifraKolegija.Location = new Point(12, 200);
            TBSifraKolegija.Name = "TBSifraKolegija";
            TBSifraKolegija.Size = new Size(338, 23);
            TBSifraKolegija.TabIndex = 6;
            // 
            // BtnNatrag
            // 
            BtnNatrag.Location = new Point(12, 340);
            BtnNatrag.Name = "BtnNatrag";
            BtnNatrag.Size = new Size(75, 23);
            BtnNatrag.TabIndex = 7;
            BtnNatrag.Text = "Natrag";
            BtnNatrag.UseVisualStyleBackColor = true;
            BtnNatrag.Click += BtnNatrag_Click;
            // 
            // BtnDodaj
            // 
            BtnDodaj.Location = new Point(275, 340);
            BtnDodaj.Name = "BtnDodaj";
            BtnDodaj.Size = new Size(75, 23);
            BtnDodaj.TabIndex = 8;
            BtnDodaj.Text = "Dodaj";
            BtnDodaj.UseVisualStyleBackColor = true;
            BtnDodaj.Click += BtnDodaj_Click;
            // 
            // DodajKolegij
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(384, 461);
            Controls.Add(BtnDodaj);
            Controls.Add(BtnNatrag);
            Controls.Add(TBSifraKolegija);
            Controls.Add(TBImeKolegija);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "DodajKolegij";
            Text = "DodajKolegij";
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
        private Label label3;
        private TextBox TBImeKolegija;
        private TextBox TBSifraKolegija;
        private Button BtnNatrag;
        private Button BtnDodaj;
    }
}