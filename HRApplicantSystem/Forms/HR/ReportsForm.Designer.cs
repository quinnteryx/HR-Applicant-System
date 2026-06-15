namespace HRApplicantSystem.Forms.HR
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpReportType = new System.Windows.Forms.GroupBox();
            this.rdoAllApplicants = new System.Windows.Forms.RadioButton();
            this.rdoPending = new System.Windows.Forms.RadioButton();
            this.rdoInterviews = new System.Windows.Forms.RadioButton();
            this.rdoHired = new System.Windows.Forms.RadioButton();
            this.rdoMissingDocs = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpReportType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grpReportType
            // 
            this.grpReportType.BackColor = System.Drawing.SystemColors.Control;
            this.grpReportType.Controls.Add(this.rdoAllApplicants);
            this.grpReportType.Controls.Add(this.rdoPending);
            this.grpReportType.Controls.Add(this.rdoInterviews);
            this.grpReportType.Controls.Add(this.rdoHired);
            this.grpReportType.Controls.Add(this.rdoMissingDocs);
            this.grpReportType.Location = new System.Drawing.Point(10, 120);
            this.grpReportType.Name = "grpReportType";
            this.grpReportType.Size = new System.Drawing.Size(176, 152);
            this.grpReportType.TabIndex = 0;
            this.grpReportType.TabStop = false;
            this.grpReportType.Text = "Select Report Type";
            // 
            // rdoAllApplicants
            // 
            this.rdoAllApplicants.AutoSize = true;
            this.rdoAllApplicants.Location = new System.Drawing.Point(10, 22);
            this.rdoAllApplicants.Name = "rdoAllApplicants";
            this.rdoAllApplicants.Size = new System.Drawing.Size(88, 17);
            this.rdoAllApplicants.TabIndex = 0;
            this.rdoAllApplicants.Text = "All Applicants";
            // 
            // rdoPending
            // 
            this.rdoPending.AutoSize = true;
            this.rdoPending.Location = new System.Drawing.Point(10, 48);
            this.rdoPending.Name = "rdoPending";
            this.rdoPending.Size = new System.Drawing.Size(124, 17);
            this.rdoPending.TabIndex = 1;
            this.rdoPending.Text = "Pending Applications";
            // 
            // rdoInterviews
            // 
            this.rdoInterviews.AutoSize = true;
            this.rdoInterviews.Location = new System.Drawing.Point(10, 74);
            this.rdoInterviews.Name = "rdoInterviews";
            this.rdoInterviews.Size = new System.Drawing.Size(127, 17);
            this.rdoInterviews.TabIndex = 2;
            this.rdoInterviews.Text = "Scheduled Interviews";
            // 
            // rdoHired
            // 
            this.rdoHired.AutoSize = true;
            this.rdoHired.Location = new System.Drawing.Point(10, 100);
            this.rdoHired.Name = "rdoHired";
            this.rdoHired.Size = new System.Drawing.Size(125, 17);
            this.rdoHired.TabIndex = 3;
            this.rdoHired.Text = "Accepted / Rejected";
            // 
            // rdoMissingDocs
            // 
            this.rdoMissingDocs.AutoSize = true;
            this.rdoMissingDocs.Location = new System.Drawing.Point(10, 126);
            this.rdoMissingDocs.Name = "rdoMissingDocs";
            this.rdoMissingDocs.Size = new System.Drawing.Size(128, 17);
            this.rdoMissingDocs.TabIndex = 4;
            this.rdoMissingDocs.Text = "Missing Requirements";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Chartreuse;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerate.Location = new System.Drawing.Point(10, 296);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(176, 52);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExportCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExportCSV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExportCSV.Location = new System.Drawing.Point(10, 359);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(176, 49);
            this.btnExportCSV.TabIndex = 6;
            this.btnExportCSV.Text = "Export to CSV";
            this.btnExportCSV.UseVisualStyleBackColor = false;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(10, 419);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(176, 46);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblReportTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblReportTitle.Location = new System.Drawing.Point(195, 10);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(410, 26);
            this.lblReportTitle.TabIndex = 8;
            this.lblReportTitle.Text = "Select a report type and click Generate Report";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(195, 43);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(617, 425);
            this.dgvReport.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(195, 475);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(122, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "No report generated yet.";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(826, 498);
            this.Controls.Add(this.grpReportType);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblReportTitle);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.grpReportType.ResumeLayout(false);
            this.grpReportType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // ── Field declarations ─────────────────────────────────
        private System.Windows.Forms.GroupBox grpReportType;
        private System.Windows.Forms.RadioButton rdoAllApplicants;
        private System.Windows.Forms.RadioButton rdoPending;
        private System.Windows.Forms.RadioButton rdoInterviews;
        private System.Windows.Forms.RadioButton rdoHired;
        private System.Windows.Forms.RadioButton rdoMissingDocs;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExportCSV;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblStatus;
    }
}
