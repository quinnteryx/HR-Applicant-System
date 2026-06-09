namespace HRApplicantSystem.Forms.Applicant
{
    partial class ApplicantDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStatusTracking = new System.Windows.Forms.Button();
            this.btnMyApplications = new System.Windows.Forms.Button();
            this.btnJobVacancies = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDocuments
            // 
            this.btnDocuments.Location = new System.Drawing.Point(45, 378);
            this.btnDocuments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(235, 110);
            this.btnDocuments.TabIndex = 31;
            this.btnDocuments.Text = "MY DOCUMENTS\r\n\r\n[Upload and Edit Documents]\r\n";
            this.btnDocuments.UseVisualStyleBackColor = true;
            this.btnDocuments.Click += new System.EventHandler(this.btnDocuments_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(458, 323);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 30);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStatusTracking
            // 
            this.btnStatusTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStatusTracking.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatusTracking.Location = new System.Drawing.Point(142, 274);
            this.btnStatusTracking.Name = "btnStatusTracking";
            this.btnStatusTracking.Size = new System.Drawing.Size(260, 51);
            this.btnStatusTracking.TabIndex = 29;
            this.btnStatusTracking.Text = "STATUS TRACKING\r\n\r\n[Timeline && Schedules]";
            this.btnStatusTracking.UseVisualStyleBackColor = false;
            this.btnStatusTracking.Click += new System.EventHandler(this.btnStatusTracking_Click);
            // 
            // btnMyApplications
            // 
            this.btnMyApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMyApplications.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMyApplications.Location = new System.Drawing.Point(142, 204);
            this.btnMyApplications.Name = "btnMyApplications";
            this.btnMyApplications.Size = new System.Drawing.Size(260, 55);
            this.btnMyApplications.TabIndex = 28;
            this.btnMyApplications.Text = "MY APPLICATIONS\r\n\r\n[Track && Submit Drafts]";
            this.btnMyApplications.UseVisualStyleBackColor = false;
            this.btnMyApplications.Click += new System.EventHandler(this.btnMyApplications_Click);
            // 
            // btnJobVacancies
            // 
            this.btnJobVacancies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnJobVacancies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJobVacancies.Location = new System.Drawing.Point(142, 137);
            this.btnJobVacancies.Name = "btnJobVacancies";
            this.btnJobVacancies.Size = new System.Drawing.Size(260, 50);
            this.btnJobVacancies.TabIndex = 27;
            this.btnJobVacancies.Text = "JOB VACANCIES\r\n\r\n[Browse && Apply for Jobs]";
            this.btnJobVacancies.UseVisualStyleBackColor = false;
            this.btnJobVacancies.Click += new System.EventHandler(this.btnJobVacancies_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfile.Location = new System.Drawing.Point(142, 81);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(260, 50);
            this.btnProfile.TabIndex = 26;
            this.btnProfile.Text = "MY PROFILE\r\n\r\n[View && Edit Personal Info]";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.lblWelcome.Location = new System.Drawing.Point(419, 81);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 20);
            this.lblWelcome.TabIndex = 25;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblHeader.Location = new System.Drawing.Point(148, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(243, 32);
            this.lblHeader.TabIndex = 24;
            this.lblHeader.Text = "APPLICANT PORTAL";
            // 
            // ApplicantDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(577, 368);
            this.Controls.Add(this.btnDocuments);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStatusTracking);
            this.Controls.Add(this.btnMyApplications);
            this.Controls.Add(this.btnJobVacancies);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ApplicantDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicantDashboard_FormClosing);
            this.Load += new System.EventHandler(this.ApplicantDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnStatusTracking;
        private System.Windows.Forms.Button btnMyApplications;
        private System.Windows.Forms.Button btnJobVacancies;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblHeader;
    }
}