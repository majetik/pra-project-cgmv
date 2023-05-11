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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBImeKolegija = new System.Windows.Forms.TextBox();
            this.TBSifraKolegija = new System.Windows.Forms.TextBox();
            this.BtnNatrag = new System.Windows.Forms.Button();
            this.BtnDodaj = new System.Windows.Forms.Button();
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
            this.pictureBox2.Location = new System.Drawing.Point(265, 399);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(320, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dodaj kolegij";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unesi ime kolegija:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unesi sifru kolegija";
            // 
            // TBImeKolegija
            // 
            this.TBImeKolegija.Location = new System.Drawing.Point(12, 123);
            this.TBImeKolegija.Name = "TBImeKolegija";
            this.TBImeKolegija.Size = new System.Drawing.Size(731, 23);
            this.TBImeKolegija.TabIndex = 5;
            // 
            // TBSifraKolegija
            // 
            this.TBSifraKolegija.Location = new System.Drawing.Point(12, 200);
            this.TBSifraKolegija.Name = "TBSifraKolegija";
            this.TBSifraKolegija.Size = new System.Drawing.Size(731, 23);
            this.TBSifraKolegija.TabIndex = 6;
            // 
            // BtnNatrag
            // 
            this.BtnNatrag.Location = new System.Drawing.Point(12, 331);
            this.BtnNatrag.Name = "BtnNatrag";
            this.BtnNatrag.Size = new System.Drawing.Size(75, 23);
            this.BtnNatrag.TabIndex = 7;
            this.BtnNatrag.Text = "Natrag";
            this.BtnNatrag.UseVisualStyleBackColor = true;
            this.BtnNatrag.Click += new System.EventHandler(this.BtnNatrag_Click);
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Location = new System.Drawing.Point(668, 357);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(75, 23);
            this.BtnDodaj.TabIndex = 8;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // DodajKolegij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.BtnNatrag);
            this.Controls.Add(this.TBSifraKolegija);
            this.Controls.Add(this.TBImeKolegija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DodajKolegij";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajKolegij";
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
        private TextBox TBImeKolegija;
        private TextBox TBSifraKolegija;
        private Button BtnNatrag;
        private Button BtnDodaj;
    }
}