namespace HRApplicantSystem.Forms.HR
{
    partial class ScreeningForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpApplications = new System.Windows.Forms.GroupBox();
            this.dgvApplications = new System.Windows.Forms.DataGridView();
            this.grpDecision = new System.Windows.Forms.GroupBox();
            this.lblSelectedApplicant = new System.Windows.Forms.Label();
            this.lblSelectedJob = new System.Windows.Forms.Label();
            this.lblDecisionStatic = new System.Windows.Forms.Label();
            this.rdoQualified = new System.Windows.Forms.RadioButton();
            this.rdoNotQualified = new System.Windows.Forms.RadioButton();
            this.lblRemarksStatic = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).BeginInit();
            this.grpDecision.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpApplications
            // 
            this.grpApplications.BackColor = System.Drawing.SystemColors.Control;
            this.grpApplications.Controls.Add(this.dgvApplications);
            this.grpApplications.Location = new System.Drawing.Point(9, 8);
            this.grpApplications.Margin = new System.Windows.Forms.Padding(2);
            this.grpApplications.Name = "grpApplications";
            this.grpApplications.Padding = new System.Windows.Forms.Padding(2);
            this.grpApplications.Size = new System.Drawing.Size(496, 175);
            this.grpApplications.TabIndex = 0;
            this.grpApplications.TabStop = false;
            this.grpApplications.Text = "Applications Under Review";
            // 
            // dgvApplications
            // 
            this.dgvApplications.AllowUserToAddRows = false;
            this.dgvApplications.AllowUserToDeleteRows = false;
            this.dgvApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplications.Location = new System.Drawing.Point(8, 18);
            this.dgvApplications.Margin = new System.Windows.Forms.Padding(2);
            this.dgvApplications.MultiSelect = false;
            this.dgvApplications.Name = "dgvApplications";
            this.dgvApplications.ReadOnly = true;
            this.dgvApplications.RowHeadersVisible = false;
            this.dgvApplications.RowHeadersWidth = 51;
            this.dgvApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplications.Size = new System.Drawing.Size(482, 149);
            this.dgvApplications.TabIndex = 0;
            this.dgvApplications.SelectionChanged += new System.EventHandler(this.dgvApplications_SelectionChanged);
            // 
            // grpDecision
            // 
            this.grpDecision.BackColor = System.Drawing.SystemColors.Control;
            this.grpDecision.Controls.Add(this.lblSelectedApplicant);
            this.grpDecision.Controls.Add(this.lblSelectedJob);
            this.grpDecision.Controls.Add(this.lblDecisionStatic);
            this.grpDecision.Controls.Add(this.rdoQualified);
            this.grpDecision.Controls.Add(this.rdoNotQualified);
            this.grpDecision.Controls.Add(this.lblRemarksStatic);
            this.grpDecision.Controls.Add(this.txtRemarks);
            this.grpDecision.Enabled = false;
            this.grpDecision.Location = new System.Drawing.Point(9, 192);
            this.grpDecision.Margin = new System.Windows.Forms.Padding(2);
            this.grpDecision.Name = "grpDecision";
            this.grpDecision.Padding = new System.Windows.Forms.Padding(2);
            this.grpDecision.Size = new System.Drawing.Size(496, 184);
            this.grpDecision.TabIndex = 1;
            this.grpDecision.TabStop = false;
            this.grpDecision.Text = "Screening Decision";
            // 
            // lblSelectedApplicant
            // 
            this.lblSelectedApplicant.AutoSize = true;
            this.lblSelectedApplicant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelectedApplicant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSelectedApplicant.Location = new System.Drawing.Point(8, 23);
            this.lblSelectedApplicant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedApplicant.Name = "lblSelectedApplicant";
            this.lblSelectedApplicant.Size = new System.Drawing.Size(95, 19);
            this.lblSelectedApplicant.TabIndex = 0;
            this.lblSelectedApplicant.Text = "Applicant: —";
            // 
            // lblSelectedJob
            // 
            this.lblSelectedJob.AutoSize = true;
            this.lblSelectedJob.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblSelectedJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblSelectedJob.Location = new System.Drawing.Point(8, 65);
            this.lblSelectedJob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedJob.Name = "lblSelectedJob";
            this.lblSelectedJob.Size = new System.Drawing.Size(36, 12);
            this.lblSelectedJob.TabIndex = 1;
            this.lblSelectedJob.Text = "Job: —";
            // 
            // lblDecisionStatic
            // 
            this.lblDecisionStatic.AutoSize = true;
            this.lblDecisionStatic.Location = new System.Drawing.Point(8, 107);
            this.lblDecisionStatic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDecisionStatic.Name = "lblDecisionStatic";
            this.lblDecisionStatic.Size = new System.Drawing.Size(51, 13);
            this.lblDecisionStatic.TabIndex = 2;
            this.lblDecisionStatic.Text = "Decision:";
            // 
            // rdoQualified
            // 
            this.rdoQualified.AutoSize = true;
            this.rdoQualified.Checked = true;
            this.rdoQualified.Location = new System.Drawing.Point(64, 105);
            this.rdoQualified.Margin = new System.Windows.Forms.Padding(2);
            this.rdoQualified.Name = "rdoQualified";
            this.rdoQualified.Size = new System.Drawing.Size(66, 17);
            this.rdoQualified.TabIndex = 3;
            this.rdoQualified.TabStop = true;
            this.rdoQualified.Text = "Qualified";
            // 
            // rdoNotQualified
            // 
            this.rdoNotQualified.AutoSize = true;
            this.rdoNotQualified.Location = new System.Drawing.Point(139, 105);
            this.rdoNotQualified.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNotQualified.Name = "rdoNotQualified";
            this.rdoNotQualified.Size = new System.Drawing.Size(86, 17);
            this.rdoNotQualified.TabIndex = 4;
            this.rdoNotQualified.Text = "Not Qualified";
            // 
            // lblRemarksStatic
            // 
            this.lblRemarksStatic.AutoSize = true;
            this.lblRemarksStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblRemarksStatic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblRemarksStatic.Location = new System.Drawing.Point(250, 19);
            this.lblRemarksStatic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemarksStatic.Name = "lblRemarksStatic";
            this.lblRemarksStatic.Size = new System.Drawing.Size(185, 24);
            this.lblRemarksStatic.TabIndex = 5;
            this.lblRemarksStatic.Text = "Remarks / HR Notes:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(247, 44);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(243, 134);
            this.txtRemarks.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(107, 376);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Decision";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(269, 376);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 40);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ScreeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(525, 418);
            this.Controls.Add(this.grpApplications);
            this.Controls.Add(this.grpDecision);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScreeningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screening — HR Applicant System";
            this.Load += new System.EventHandler(this.ScreeningForm_Load);
            this.grpApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplications)).EndInit();
            this.grpDecision.ResumeLayout(false);
            this.grpDecision.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpApplications;
        private System.Windows.Forms.DataGridView dgvApplications;
        private System.Windows.Forms.GroupBox grpDecision;
        private System.Windows.Forms.Label lblSelectedApplicant;
        private System.Windows.Forms.Label lblSelectedJob;
        private System.Windows.Forms.Label lblDecisionStatic;
        private System.Windows.Forms.RadioButton rdoQualified;
        private System.Windows.Forms.RadioButton rdoNotQualified;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRemarksStatic;
    }
}
