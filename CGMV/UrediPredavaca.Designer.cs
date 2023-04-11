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
            btnNastavi = new Button();
            btnNatrag = new Button();
            cbPredavaci = new ComboBox();
            lblOdabir = new Label();
            pictureBox3 = new PictureBox();
            tbDodajPredavaca = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNastavi
            // 
            btnNastavi.ForeColor = Color.Black;
            btnNastavi.Location = new Point(447, 288);
            btnNastavi.Margin = new Padding(3, 2, 3, 2);
            btnNastavi.Name = "btnNastavi";
            btnNastavi.Size = new Size(82, 22);
            btnNastavi.TabIndex = 52;
            btnNastavi.Text = "Nastavi";
            btnNastavi.UseVisualStyleBackColor = true;
            // 
            // btnNatrag
            // 
            btnNatrag.ForeColor = Color.Black;
            btnNatrag.Location = new Point(252, 288);
            btnNatrag.Margin = new Padding(3, 2, 3, 2);
            btnNatrag.Name = "btnNatrag";
            btnNatrag.Size = new Size(82, 22);
            btnNatrag.TabIndex = 51;
            btnNatrag.Text = "Natrag";
            btnNatrag.UseVisualStyleBackColor = true;
            btnNatrag.Click += BtnNatrag_Click;
            // 
            // cbPredavaci
            // 
            cbPredavaci.FormattingEnabled = true;
            cbPredavaci.Location = new Point(225, 183);
            cbPredavaci.Margin = new Padding(3, 2, 3, 2);
            cbPredavaci.Name = "cbPredavaci";
            cbPredavaci.Size = new Size(335, 23);
            cbPredavaci.TabIndex = 50;
            // 
            // lblOdabir
            // 
            lblOdabir.AutoSize = true;
            lblOdabir.ForeColor = SystemColors.ButtonHighlight;
            lblOdabir.Location = new Point(225, 148);
            lblOdabir.Name = "lblOdabir";
            lblOdabir.Size = new Size(157, 15);
            lblOdabir.TabIndex = 49;
            lblOdabir.Text = "Odaberi predavača za urediti";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(257, 350);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            // 
            // tbDodajPredavaca
            // 
            tbDodajPredavaca.BackColor = SystemColors.MenuText;
            tbDodajPredavaca.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbDodajPredavaca.ForeColor = SystemColors.Window;
            tbDodajPredavaca.Location = new Point(402, 85);
            tbDodajPredavaca.Margin = new Padding(3, 2, 3, 2);
            tbDodajPredavaca.Name = "tbDodajPredavaca";
            tbDodajPredavaca.Size = new Size(158, 32);
            tbDodajPredavaca.TabIndex = 47;
            tbDodajPredavaca.Text = "Uredi predavača";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(225, 75);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // UrediPredavaca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(784, 461);
            Controls.Add(btnNastavi);
            Controls.Add(btnNatrag);
            Controls.Add(cbPredavaci);
            Controls.Add(lblOdabir);
            Controls.Add(pictureBox3);
            Controls.Add(tbDodajPredavaca);
            Controls.Add(pictureBox1);
            Name = "UrediPredavaca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UrediPredavaca";
            Load += UrediPredavaca_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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