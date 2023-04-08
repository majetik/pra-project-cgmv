namespace CGMV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(222, 319);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(340, 72);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Prijava";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(222, 251);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(340, 23);
            this.tbLozinka.TabIndex = 8;
            this.tbLozinka.UseSystemPasswordChar = true;
            this.tbLozinka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbLozinka_KeyPress);
            // 
            // lbLozinka
            // 
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLozinka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLozinka.Location = new System.Drawing.Point(222, 185);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(101, 32);
            this.lbLozinka.TabIndex = 7;
            this.lbLozinka.Text = "Lozinka";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(222, 135);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(340, 23);
            this.tbEmail.TabIndex = 6;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbEmail_KeyPress);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmail.Location = new System.Drawing.Point(222, 69);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(76, 32);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.lbLozinka);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogin;
        private TextBox tbLozinka;
        private Label lbLozinka;
        private TextBox tbEmail;
        private Label lbEmail;
    }
}