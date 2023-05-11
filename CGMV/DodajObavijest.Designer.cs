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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnNatrag = new System.Windows.Forms.Button();
            this.BtnKreirajObavijest = new System.Windows.Forms.Button();
            this.CBOdabirKolegija = new System.Windows.Forms.ComboBox();
            this.TBNaslov = new System.Windows.Forms.TextBox();
            this.TBOpis = new System.Windows.Forms.TextBox();
            this.CBKreiraoObavijest = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CGMV.Properties.Resources.Algebra_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CGMV.Properties.Resources.Algebra_logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(254, 399);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odabir kolegija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unesi naslov obavijesti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(22, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unesi opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(22, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kreirao obavijest:";
            // 
            // BtnNatrag
            // 
            this.BtnNatrag.Location = new System.Drawing.Point(22, 366);
            this.BtnNatrag.Name = "BtnNatrag";
            this.BtnNatrag.Size = new System.Drawing.Size(75, 23);
            this.BtnNatrag.TabIndex = 6;
            this.BtnNatrag.Text = "Natrag";
            this.BtnNatrag.UseVisualStyleBackColor = true;
            this.BtnNatrag.Click += new System.EventHandler(this.BtnNatrag_Click);
            // 
            // BtnKreirajObavijest
            // 
            this.BtnKreirajObavijest.Location = new System.Drawing.Point(603, 366);
            this.BtnKreirajObavijest.Name = "BtnKreirajObavijest";
            this.BtnKreirajObavijest.Size = new System.Drawing.Size(106, 23);
            this.BtnKreirajObavijest.TabIndex = 7;
            this.BtnKreirajObavijest.Text = "Kreiraj obavijest";
            this.BtnKreirajObavijest.UseVisualStyleBackColor = true;
            // 
            // CBOdabirKolegija
            // 
            this.CBOdabirKolegija.FormattingEnabled = true;
            this.CBOdabirKolegija.Location = new System.Drawing.Point(22, 94);
            this.CBOdabirKolegija.Name = "CBOdabirKolegija";
            this.CBOdabirKolegija.Size = new System.Drawing.Size(553, 23);
            this.CBOdabirKolegija.TabIndex = 8;
            // 
            // TBNaslov
            // 
            this.TBNaslov.Location = new System.Drawing.Point(22, 148);
            this.TBNaslov.Name = "TBNaslov";
            this.TBNaslov.Size = new System.Drawing.Size(553, 23);
            this.TBNaslov.TabIndex = 9;
            // 
            // TBOpis
            // 
            this.TBOpis.Location = new System.Drawing.Point(22, 203);
            this.TBOpis.Multiline = true;
            this.TBOpis.Name = "TBOpis";
            this.TBOpis.Size = new System.Drawing.Size(553, 68);
            this.TBOpis.TabIndex = 10;
            // 
            // CBKreiraoObavijest
            // 
            this.CBKreiraoObavijest.FormattingEnabled = true;
            this.CBKreiraoObavijest.Location = new System.Drawing.Point(22, 313);
            this.CBKreiraoObavijest.Name = "CBKreiraoObavijest";
            this.CBKreiraoObavijest.Size = new System.Drawing.Size(553, 23);
            this.CBKreiraoObavijest.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(307, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Dodaj obavijest";
            // 
            // DodajObavijest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBKreiraoObavijest);
            this.Controls.Add(this.TBOpis);
            this.Controls.Add(this.TBNaslov);
            this.Controls.Add(this.CBOdabirKolegija);
            this.Controls.Add(this.BtnKreirajObavijest);
            this.Controls.Add(this.BtnNatrag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DodajObavijest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajObavijest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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