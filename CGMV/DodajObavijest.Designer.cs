namespace CGMV
{
    partial class DodajObavijest
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
            label4 = new Label();
            BtnNatrag = new Button();
            BtnKreirajObavijest = new Button();
            CBOdabirKolegija = new ComboBox();
            TBNaslov = new TextBox();
            TBOpis = new TextBox();
            CBKreiraoObavijest = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Algebra_logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Algebra_logo_2;
            pictureBox2.Location = new Point(254, 399);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(22, 76);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Odabir kolegija:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(22, 130);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 3;
            label2.Text = "Unesi naslov obavijesti:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(22, 185);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Unesi opis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(22, 283);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 5;
            label4.Text = "Kreirao obavijest:";
            // 
            // BtnNatrag
            // 
            BtnNatrag.Location = new Point(22, 366);
            BtnNatrag.Name = "BtnNatrag";
            BtnNatrag.Size = new Size(75, 23);
            BtnNatrag.TabIndex = 6;
            BtnNatrag.Text = "Natrag";
            BtnNatrag.UseVisualStyleBackColor = true;
            BtnNatrag.Click += BtnNatrag_Click;
            // 
            // BtnKreirajObavijest
            // 
            BtnKreirajObavijest.Location = new Point(603, 366);
            BtnKreirajObavijest.Name = "BtnKreirajObavijest";
            BtnKreirajObavijest.Size = new Size(106, 23);
            BtnKreirajObavijest.TabIndex = 7;
            BtnKreirajObavijest.Text = "Kreiraj obavijest";
            BtnKreirajObavijest.UseVisualStyleBackColor = true;
            // 
            // CBOdabirKolegija
            // 
            CBOdabirKolegija.FormattingEnabled = true;
            CBOdabirKolegija.Location = new Point(22, 94);
            CBOdabirKolegija.Name = "CBOdabirKolegija";
            CBOdabirKolegija.Size = new Size(553, 23);
            CBOdabirKolegija.TabIndex = 8;
            // 
            // TBNaslov
            // 
            TBNaslov.Location = new Point(22, 148);
            TBNaslov.Name = "TBNaslov";
            TBNaslov.Size = new Size(553, 23);
            TBNaslov.TabIndex = 9;
            // 
            // TBOpis
            // 
            TBOpis.Location = new Point(22, 203);
            TBOpis.Multiline = true;
            TBOpis.Name = "TBOpis";
            TBOpis.Size = new Size(553, 68);
            TBOpis.TabIndex = 10;
            // 
            // CBKreiraoObavijest
            // 
            CBKreiraoObavijest.FormattingEnabled = true;
            CBKreiraoObavijest.Location = new Point(22, 313);
            CBKreiraoObavijest.Name = "CBKreiraoObavijest";
            CBKreiraoObavijest.Size = new Size(553, 23);
            CBKreiraoObavijest.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(307, 26);
            label5.Name = "label5";
            label5.Size = new Size(149, 25);
            label5.TabIndex = 12;
            label5.Text = "Dodaj obavijest";
            // 
            // DodajObavijest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(784, 461);
            Controls.Add(label5);
            Controls.Add(CBKreiraoObavijest);
            Controls.Add(TBOpis);
            Controls.Add(TBNaslov);
            Controls.Add(CBOdabirKolegija);
            Controls.Add(BtnKreirajObavijest);
            Controls.Add(BtnNatrag);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "DodajObavijest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DodajObavijest";
            Load += DodajObavijest_Load;
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
        private Label label4;
        private Button BtnNatrag;
        private Button BtnKreirajObavijest;
        private ComboBox CBOdabirKolegija;
        private TextBox TBNaslov;
        private TextBox TBOpis;
        private ComboBox CBKreiraoObavijest;
        private Label label5;
    }
}