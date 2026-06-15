namespace HRApplicantSystem.Forms.HR
{
    partial class InterviewScheduleForm
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
            this.grpApplicants = new System.Windows.Forms.GroupBox();
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.grpSchedule = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtInterviewer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInterviewDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblApplicant = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpApplicants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.grpSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpApplicants
            // 
            this.grpApplicants.BackColor = System.Drawing.SystemColors.Control;
            this.grpApplicants.Controls.Add(this.dgvApplicants);
            this.grpApplicants.Location = new System.Drawing.Point(9, 10);
            this.grpApplicants.Margin = new System.Windows.Forms.Padding(2);
            this.grpApplicants.Name = "grpApplicants";
            this.grpApplicants.Padding = new System.Windows.Forms.Padding(2);
            this.grpApplicants.Size = new System.Drawing.Size(644, 137);
            this.grpApplicants.TabIndex = 0;
            this.grpApplicants.TabStop = false;
            this.grpApplicants.Text = "Shortlisted / Scheduled / Cancelled Applicants";
            // 
            // dgvApplicants
            // 
            this.dgvApplicants.AllowUserToAddRows = false;
            this.dgvApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvApplicants.Location = new System.Drawing.Point(2, 15);
            this.dgvApplicants.Margin = new System.Windows.Forms.Padding(2);
            this.dgvApplicants.MultiSelect = false;
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.ReadOnly = true;
            this.dgvApplicants.RowHeadersWidth = 51;
            this.dgvApplicants.RowTemplate.Height = 24;
            this.dgvApplicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicants.Size = new System.Drawing.Size(640, 120);
            this.dgvApplicants.TabIndex = 0;
            this.dgvApplicants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvApplicants_CellClick);
            // 
            // grpSchedule
            // 
            this.grpSchedule.BackColor = System.Drawing.SystemColors.Control;
            this.grpSchedule.Controls.Add(this.cboStatus);
            this.grpSchedule.Controls.Add(this.label5);
            this.grpSchedule.Controls.Add(this.cboMode);
            this.grpSchedule.Controls.Add(this.label4);
            this.grpSchedule.Controls.Add(this.label3);
            this.grpSchedule.Controls.Add(this.txtLocation);
            this.grpSchedule.Controls.Add(this.txtInterviewer);
            this.grpSchedule.Controls.Add(this.label2);
            this.grpSchedule.Controls.Add(this.dtpInterviewDate);
            this.grpSchedule.Controls.Add(this.label1);
            this.grpSchedule.Controls.Add(this.lblJob);
            this.grpSchedule.Controls.Add(this.lblApplicant);
            this.grpSchedule.Location = new System.Drawing.Point(11, 165);
            this.grpSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.grpSchedule.Name = "grpSchedule";
            this.grpSchedule.Padding = new System.Windows.Forms.Padding(2);
            this.grpSchedule.Size = new System.Drawing.Size(547, 171);
            this.grpSchedule.TabIndex = 1;
            this.grpSchedule.TabStop = false;
            this.grpSchedule.Text = "Schedule Interview";
            // 
            // cboStatus
            // 
            this.cboStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Cancelled",
            "Completed",
            "Scheduled"});
            this.cboStatus.Location = new System.Drawing.Point(393, 40);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(92, 21);
            this.cboStatus.Sorted = true;
            this.cboStatus.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status:";
            // 
            // cboMode
            // 
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Items.AddRange(new object[] {
            "Face-to-Face",
            "Online"});
            this.cboMode.Location = new System.Drawing.Point(157, 146);
            this.cboMode.Margin = new System.Windows.Forms.Padding(2);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(92, 21);
            this.cboMode.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(10, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Location / Link:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(157, 123);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(151, 20);
            this.txtLocation.TabIndex = 6;
            // 
            // txtInterviewer
            // 
            this.txtInterviewer.Location = new System.Drawing.Point(157, 97);
            this.txtInterviewer.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterviewer.Name = "txtInterviewer";
            this.txtInterviewer.Size = new System.Drawing.Size(151, 20);
            this.txtInterviewer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(10, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interviewer Name:";
            // 
            // dtpInterviewDate
            // 
            this.dtpInterviewDate.Location = new System.Drawing.Point(157, 68);
            this.dtpInterviewDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpInterviewDate.Name = "dtpInterviewDate";
            this.dtpInterviewDate.Size = new System.Drawing.Size(151, 20);
            this.dtpInterviewDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Interview Date:";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(5, 48);
            this.lblJob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(33, 13);
            this.lblJob.TabIndex = 1;
            this.lblJob.Text = "Job: -";
            // 
            // lblApplicant
            // 
            this.lblApplicant.AutoSize = true;
            this.lblApplicant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblApplicant.Location = new System.Drawing.Point(4, 24);
            this.lblApplicant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicant.Name = "lblApplicant";
            this.lblApplicant.Size = new System.Drawing.Size(123, 25);
            this.lblApplicant.TabIndex = 0;
            this.lblApplicant.Text = "Applicant: -";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(562, 202);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 51);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save Schedule";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(562, 263);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 45);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // InterviewScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(683, 378);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpSchedule);
            this.Controls.Add(this.grpApplicants);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "InterviewScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interview Schedule — HR Applicant System";
            this.Load += new System.EventHandler(this.InterviewScheduleForm_Load);
            this.grpApplicants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.grpSchedule.ResumeLayout(false);
            this.grpSchedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpApplicants;
        private System.Windows.Forms.DataGridView dgvApplicants;
        private System.Windows.Forms.GroupBox grpSchedule;
        private System.Windows.Forms.DateTimePicker dtpInterviewDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblApplicant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtInterviewer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}
