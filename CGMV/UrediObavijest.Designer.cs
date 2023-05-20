namespace CGMV
{
    partial class UrediObavijest
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
            this.BtnNastavi = new System.Windows.Forms.Button();
            this.BtnNatrag = new System.Windows.Forms.Button();
            this.CMOdaberiObavijest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNastavi
            // 
            this.BtnNastavi.Location = new System.Drawing.Point(521, 283);
            this.BtnNastavi.Name = "BtnNastavi";
            this.BtnNastavi.Size = new System.Drawing.Size(75, 23);
            this.BtnNastavi.TabIndex = 20;
            this.BtnNastavi.Text = "Nastavi";
            this.BtnNastavi.UseVisualStyleBackColor = true;
            // 
            // BtnNatrag
            // 
            this.BtnNatrag.Location = new System.Drawing.Point(188, 273);
            this.BtnNatrag.Name = "BtnNatrag";
            this.BtnNatrag.Size = new System.Drawing.Size(75, 23);
            this.BtnNatrag.TabIndex = 19;
            this.BtnNatrag.Text = "Natrag";
            this.BtnNatrag.UseVisualStyleBackColor = true;
            this.BtnNatrag.Click += new System.EventHandler(this.BtnNatrag_Click);
            // 
            // CMOdaberiObavijest
            // 
            this.CMOdaberiObavijest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMOdaberiObavijest.FormattingEnabled = true;
            this.CMOdaberiObavijest.Location = new System.Drawing.Point(188, 165);
            this.CMOdaberiObavijest.Name = "CMOdaberiObavijest";
            this.CMOdaberiObavijest.Size = new System.Drawing.Size(408, 23);
            this.CMOdaberiObavijest.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(188, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Odabir naslova obavijesti za uređivanje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(426, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Uredi obavijest";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CGMV.Properties.Resources.Algebra_logo_2;
            this.pictureBox2.Location = new System.Drawing.Point(358, 399);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CGMV.Properties.Resources.Algebra_logo;
            this.pictureBox1.Location = new System.Drawing.Point(188, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // UrediObavijest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.BtnNastavi);
            this.Controls.Add(this.BtnNatrag);
            this.Controls.Add(this.CMOdaberiObavijest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UrediObavijest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrediObavijest";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnNastavi;
        private Button BtnNatrag;
        private ComboBox CMOdaberiObavijest;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}