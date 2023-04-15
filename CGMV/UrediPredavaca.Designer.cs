namespace CGMV
{
    partial class UrediPredavaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrediPredavaca));
            this.btnNastavi = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.cbPredavaci = new System.Windows.Forms.ComboBox();
            this.lblOdabir = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbDodajPredavaca = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNastavi
            // 
            this.btnNastavi.ForeColor = System.Drawing.Color.Black;
            this.btnNastavi.Location = new System.Drawing.Point(511, 384);
            this.btnNastavi.Name = "btnNastavi";
            this.btnNastavi.Size = new System.Drawing.Size(94, 29);
            this.btnNastavi.TabIndex = 52;
            this.btnNastavi.Text = "Nastavi";
            this.btnNastavi.UseVisualStyleBackColor = true;
            this.btnNastavi.Click += new System.EventHandler(this.btnNastavi_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.ForeColor = System.Drawing.Color.Black;
            this.btnNatrag.Location = new System.Drawing.Point(288, 384);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(94, 29);
            this.btnNatrag.TabIndex = 51;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.BtnNatrag_Click);
            // 
            // cbPredavaci
            // 
            this.cbPredavaci.FormattingEnabled = true;
            this.cbPredavaci.Location = new System.Drawing.Point(257, 244);
            this.cbPredavaci.Name = "cbPredavaci";
            this.cbPredavaci.Size = new System.Drawing.Size(382, 28);
            this.cbPredavaci.TabIndex = 50;
            // 
            // lblOdabir
            // 
            this.lblOdabir.AutoSize = true;
            this.lblOdabir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOdabir.Location = new System.Drawing.Point(257, 197);
            this.lblOdabir.Name = "lblOdabir";
            this.lblOdabir.Size = new System.Drawing.Size(202, 20);
            this.lblOdabir.TabIndex = 49;
            this.lblOdabir.Text = "Odaberi predavača za urediti";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(294, 467);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(286, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // tbDodajPredavaca
            // 
            this.tbDodajPredavaca.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbDodajPredavaca.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDodajPredavaca.ForeColor = System.Drawing.SystemColors.Window;
            this.tbDodajPredavaca.Location = new System.Drawing.Point(459, 113);
            this.tbDodajPredavaca.Name = "tbDodajPredavaca";
            this.tbDodajPredavaca.Size = new System.Drawing.Size(180, 38);
            this.tbDodajPredavaca.TabIndex = 47;
            this.tbDodajPredavaca.Text = "Uredi predavača";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // UrediPredavaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(896, 615);
            this.Controls.Add(this.btnNastavi);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.cbPredavaci);
            this.Controls.Add(this.lblOdabir);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tbDodajPredavaca);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UrediPredavaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrediPredavaca";
            this.Load += new System.EventHandler(this.UrediPredavaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNastavi;
        private Button btnNatrag;
        private ComboBox cbPredavaci;
        private Label lblOdabir;
        private PictureBox pictureBox3;
        private TextBox tbDodajPredavaca;
        private PictureBox pictureBox1;
    }
}