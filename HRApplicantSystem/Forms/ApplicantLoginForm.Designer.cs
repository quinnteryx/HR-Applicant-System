namespace HRApplicantSystem.Forms
{
    partial class ApplicantLoginForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(24, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Applicant Login";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(55, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(37, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(55, 170);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(37, 204);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(108, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(108, 281);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(150, 35);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "New here? Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // ApplicantLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 341);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ApplicantLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicant Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
    }
}