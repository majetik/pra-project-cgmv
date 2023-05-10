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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CMOdaberiKolegij = new System.Windows.Forms.ComboBox();
            this.BtnNatrag = new System.Windows.Forms.Button();
            this.BtnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CGMV.Properties.Resources.Algebra_logo;
            this.pictureBox1.Location = new System.Drawing.Point(145, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CGMV.Properties.Resources.Algebra_logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(315, 399);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(338, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Obriši kolegij";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(145, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odaberi kolegij za brisanje:";
            // 
            // CMOdaberiKolegij
            // 
            this.CMOdaberiKolegij.FormattingEnabled = true;
            this.CMOdaberiKolegij.Location = new System.Drawing.Point(145, 165);
            this.CMOdaberiKolegij.Name = "CMOdaberiKolegij";
            this.CMOdaberiKolegij.Size = new System.Drawing.Size(408, 23);
            this.CMOdaberiKolegij.TabIndex = 4;
            // 
            // BtnNatrag
            // 
            this.BtnNatrag.Location = new System.Drawing.Point(145, 273);
            this.BtnNatrag.Name = "BtnNatrag";
            this.BtnNatrag.Size = new System.Drawing.Size(75, 23);
            this.BtnNatrag.TabIndex = 5;
            this.BtnNatrag.Text = "Natrag";
            this.BtnNatrag.UseVisualStyleBackColor = true;
            this.BtnNatrag.Click += new System.EventHandler(this.BtnNatrag_Click);
            // 
            // BtnObrisi
            // 
            this.BtnObrisi.Location = new System.Drawing.Point(478, 283);
            this.BtnObrisi.Name = "BtnObrisi";
            this.BtnObrisi.Size = new System.Drawing.Size(75, 23);
            this.BtnObrisi.TabIndex = 6;
            this.BtnObrisi.Text = "Obriši";
            this.BtnObrisi.UseVisualStyleBackColor = true;
            this.BtnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // ObrisiKolegij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.BtnObrisi);
            this.Controls.Add(this.BtnNatrag);
            this.Controls.Add(this.CMOdaberiKolegij);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ObrisiKolegij";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObrisiKolegij";
            this.Load += new System.EventHandler(this.ObrisiKolegij_Load);
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
        private ComboBox CMOdaberiKolegij;
        private Button BtnNatrag;
        private Button BtnObrisi;
    }
}