namespace CGMV
{
    partial class ObrisiPredavaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObrisiPredavaca));
            btnObriši = new Button();
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
            // btnObriši
            // 
            btnObriši.ForeColor = Color.Black;
            btnObriši.Location = new Point(447, 289);
            btnObriši.Margin = new Padding(3, 2, 3, 2);
            btnObriši.Name = "btnObriši";
            btnObriši.Size = new Size(82, 22);
            btnObriši.TabIndex = 45;
            btnObriši.Text = "Obriši";
            btnObriši.UseVisualStyleBackColor = true;
            btnObriši.Click += BtnObriši_Click;
            // 
            // btnNatrag
            // 
            btnNatrag.ForeColor = Color.Black;
            btnNatrag.Location = new Point(252, 289);
            btnNatrag.Margin = new Padding(3, 2, 3, 2);
            btnNatrag.Name = "btnNatrag";
            btnNatrag.Size = new Size(82, 22);
            btnNatrag.TabIndex = 44;
            btnNatrag.Text = "Natrag";
            btnNatrag.UseVisualStyleBackColor = true;
            btnNatrag.Click += BtnNatrag_Click;
            // 
            // cbPredavaci
            // 
            cbPredavaci.FormattingEnabled = true;
            cbPredavaci.Location = new Point(225, 184);
            cbPredavaci.Margin = new Padding(3, 2, 3, 2);
            cbPredavaci.Name = "cbPredavaci";
            cbPredavaci.Size = new Size(335, 23);
            cbPredavaci.TabIndex = 43;
            // 
            // lblOdabir
            // 
            lblOdabir.AutoSize = true;
            lblOdabir.ForeColor = SystemColors.ButtonFace;
            lblOdabir.Location = new Point(225, 148);
            lblOdabir.Name = "lblOdabir";
            lblOdabir.Size = new Size(164, 15);
            lblOdabir.TabIndex = 42;
            lblOdabir.Text = "Odaberi predavača za brisanje";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(258, 350);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(250, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 41;
            pictureBox3.TabStop = false;
            // 
            // tbDodajPredavaca
            // 
            tbDodajPredavaca.BackColor = SystemColors.MenuText;
            tbDodajPredavaca.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbDodajPredavaca.ForeColor = SystemColors.Window;
            tbDodajPredavaca.Location = new Point(402, 86);
            tbDodajPredavaca.Margin = new Padding(3, 2, 3, 2);
            tbDodajPredavaca.Name = "tbDodajPredavaca";
            tbDodajPredavaca.Size = new Size(158, 32);
            tbDodajPredavaca.TabIndex = 40;
            tbDodajPredavaca.Text = "Obriši predavača";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(225, 68);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // ObrisiPredavaca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(784, 461);
            Controls.Add(btnObriši);
            Controls.Add(btnNatrag);
            Controls.Add(cbPredavaci);
            Controls.Add(lblOdabir);
            Controls.Add(pictureBox3);
            Controls.Add(tbDodajPredavaca);
            Controls.Add(pictureBox1);
            Name = "ObrisiPredavaca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ObrisiPredavaca";
            Load += ObrisiPredavaca_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnObriši;
        private Button btnNatrag;
        private ComboBox cbPredavaci;
        private Label lblOdabir;
        private PictureBox pictureBox3;
        private TextBox tbDodajPredavaca;
        private PictureBox pictureBox1;
    }
}