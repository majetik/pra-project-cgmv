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
            this.btnObriši = new System.Windows.Forms.Button();
            this.btnNatrag = new System.Windows.Forms.Button();
            this.cbPredavaci = new System.Windows.Forms.ComboBox();
            this.lblOdabir = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObriši
            // 
            this.btnObriši.ForeColor = System.Drawing.Color.Black;
            this.btnObriši.Location = new System.Drawing.Point(447, 289);
            this.btnObriši.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(82, 22);
            this.btnObriši.TabIndex = 45;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = true;
            this.btnObriši.Click += new System.EventHandler(this.BtnObriši_Click);
            // 
            // btnNatrag
            // 
            this.btnNatrag.ForeColor = System.Drawing.Color.Black;
            this.btnNatrag.Location = new System.Drawing.Point(252, 289);
            this.btnNatrag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(82, 22);
            this.btnNatrag.TabIndex = 44;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.BtnNatrag_Click);
            // 
            // cbPredavaci
            // 
            this.cbPredavaci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPredavaci.FormattingEnabled = true;
            this.cbPredavaci.Location = new System.Drawing.Point(225, 184);
            this.cbPredavaci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPredavaci.Name = "cbPredavaci";
            this.cbPredavaci.Size = new System.Drawing.Size(335, 23);
            this.cbPredavaci.TabIndex = 43;
            // 
            // lblOdabir
            // 
            this.lblOdabir.AutoSize = true;
            this.lblOdabir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOdabir.Location = new System.Drawing.Point(225, 148);
            this.lblOdabir.Name = "lblOdabir";
            this.lblOdabir.Size = new System.Drawing.Size(164, 15);
            this.lblOdabir.TabIndex = 42;
            this.lblOdabir.Text = "Odaberi predavača za brisanje";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(258, 350);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(371, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Obriši predavača";
            // 
            // ObrisiPredavaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.cbPredavaci);
            this.Controls.Add(this.lblOdabir);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ObrisiPredavaca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObrisiPredavaca";
            this.Load += new System.EventHandler(this.ObrisiPredavaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnObriši;
        private Button btnNatrag;
        private ComboBox cbPredavaci;
        private Label lblOdabir;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label1;
    }
}