namespace CGMV
{
    partial class UrediKolegij
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbOdaberiKolegij = new System.Windows.Forms.ComboBox();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.btnNastavi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(386, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uredi kolegij";
            // 
            // cbOdaberiKolegij
            // 
            this.cbOdaberiKolegij.FormattingEnabled = true;
            this.cbOdaberiKolegij.Location = new System.Drawing.Point(177, 166);
            this.cbOdaberiKolegij.Name = "cbOdaberiKolegij";
            this.cbOdaberiKolegij.Size = new System.Drawing.Size(350, 23);
            this.cbOdaberiKolegij.TabIndex = 1;
            // 
            // btnNatrag
            // 
            this.btnNatrag.Location = new System.Drawing.Point(239, 270);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(75, 23);
            this.btnNatrag.TabIndex = 2;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // btnNastavi
            // 
            this.btnNastavi.Location = new System.Drawing.Point(378, 270);
            this.btnNastavi.Name = "btnNastavi";
            this.btnNastavi.Size = new System.Drawing.Size(75, 23);
            this.btnNastavi.TabIndex = 3;
            this.btnNastavi.Text = "Nastavi";
            this.btnNastavi.UseVisualStyleBackColor = true;
            this.btnNastavi.Click += new System.EventHandler(this.btnNastavi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CGMV.Properties.Resources.Algebra_logo;
            this.pictureBox1.Location = new System.Drawing.Point(177, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CGMV.Properties.Resources.Algebra_logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(255, 364);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(177, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Odaberi kolegij za urediti";
            // 
            // UrediKolegij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNastavi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.cbOdaberiKolegij);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UrediKolegij";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrediKolegij";
            this.Load += new System.EventHandler(this.UrediKolegij_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbOdaberiKolegij;
        private Button btnNatrag;
        private Button btnNastavi;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}