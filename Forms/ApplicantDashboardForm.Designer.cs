namespace FINAL_PROJECT.Forms
{
    partial class ApplicantDashboardForm
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

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstMissingDocs = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblInterviewSchedule = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Applicant Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Location = new System.Drawing.Point(115, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Status";
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.SteelBlue;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(93, 31);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 16);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Loading...";
            this.groupBox2.Controls.Add(this.lstMissingDocs);
            this.groupBox2.Location = new System.Drawing.Point(115, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 145);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Missing Documents";
            this.lstMissingDocs.FormattingEnabled = true;
            this.lstMissingDocs.ItemHeight = 16;
            this.lstMissingDocs.Location = new System.Drawing.Point(96, 44);
            this.lstMissingDocs.Name = "lstMissingDocs";
            this.lstMissingDocs.Size = new System.Drawing.Size(120, 84);
            this.lstMissingDocs.TabIndex = 0;
            this.groupBox3.Controls.Add(this.lblInterviewSchedule);
            this.groupBox3.Location = new System.Drawing.Point(115, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 133);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interview Schedule";
            this.lblInterviewSchedule.AutoSize = true;
            this.lblInterviewSchedule.BackColor = System.Drawing.Color.White;
            this.lblInterviewSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterviewSchedule.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblInterviewSchedule.Location = new System.Drawing.Point(93, 44);
            this.lblInterviewSchedule.Name = "lblInterviewSchedule";
            this.lblInterviewSchedule.Size = new System.Drawing.Size(168, 16);
            this.lblInterviewSchedule.TabIndex = 0;
            this.lblInterviewSchedule.Text = "No interview scheduled";
            this.btnBack.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(197, 504);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 556);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ApplicantDashboardForm";
            this.Text = "Applicant Dashboard";
            this.Load += new System.EventHandler(this.ApplicantDashboardForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstMissingDocs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblInterviewSchedule;
        private System.Windows.Forms.Button btnBack;
    }
}