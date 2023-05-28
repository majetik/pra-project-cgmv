namespace CGMV
{
    partial class ObavijestUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNaslov = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblImeiPrezime = new System.Windows.Forms.Label();
            this.lblKreiranoDatuma = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIstječeDatuma = new System.Windows.Forms.Label();
            this.lblKreirano = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNaslov.Location = new System.Drawing.Point(12, 11);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(63, 21);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Naslov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kreirao:";
            // 
            // lblImeiPrezime
            // 
            this.lblImeiPrezime.AutoSize = true;
            this.lblImeiPrezime.Location = new System.Drawing.Point(81, 147);
            this.lblImeiPrezime.Name = "lblImeiPrezime";
            this.lblImeiPrezime.Size = new System.Drawing.Size(78, 15);
            this.lblImeiPrezime.TabIndex = 3;
            this.lblImeiPrezime.Text = "Ime i prezime";
            // 
            // lblKreiranoDatuma
            // 
            this.lblKreiranoDatuma.AutoSize = true;
            this.lblKreiranoDatuma.Location = new System.Drawing.Point(332, 149);
            this.lblKreiranoDatuma.Name = "lblKreiranoDatuma";
            this.lblKreiranoDatuma.Size = new System.Drawing.Size(61, 15);
            this.lblKreiranoDatuma.TabIndex = 5;
            this.lblKreiranoDatuma.Text = "15:11:1999";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(456, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Istječe:";
            // 
            // lblIstječeDatuma
            // 
            this.lblIstječeDatuma.AutoSize = true;
            this.lblIstječeDatuma.Location = new System.Drawing.Point(506, 149);
            this.lblIstječeDatuma.Name = "lblIstječeDatuma";
            this.lblIstječeDatuma.Size = new System.Drawing.Size(61, 15);
            this.lblIstječeDatuma.TabIndex = 7;
            this.lblIstječeDatuma.Text = "15:11:1999";
            // 
            // lblKreirano
            // 
            this.lblKreirano.AutoSize = true;
            this.lblKreirano.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKreirano.ForeColor = System.Drawing.Color.Black;
            this.lblKreirano.Location = new System.Drawing.Point(210, 145);
            this.lblKreirano.Name = "lblKreirano";
            this.lblKreirano.Size = new System.Drawing.Size(126, 19);
            this.lblKreirano.TabIndex = 4;
            this.lblKreirano.Text = "Kreirano datuma:";
            // 
            // tbOpis
            // 
            this.tbOpis.BackColor = System.Drawing.Color.White;
            this.tbOpis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOpis.Enabled = false;
            this.tbOpis.Location = new System.Drawing.Point(12, 35);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.ReadOnly = true;
            this.tbOpis.Size = new System.Drawing.Size(643, 105);
            this.tbOpis.TabIndex = 8;
            // 
            // ObavijestUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.lblIstječeDatuma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblKreiranoDatuma);
            this.Controls.Add(this.lblKreirano);
            this.Controls.Add(this.lblImeiPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNaslov);
            this.Name = "ObavijestUC";
            this.Size = new System.Drawing.Size(658, 169);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNaslov;
        private Label label3;
        private Label lblImeiPrezime;
        private Label lblKreiranoDatuma;
        private Label label7;
        private Label lblIstječeDatuma;
        private Label lblKreirano;
        private TextBox tbOpis;
    }
}
