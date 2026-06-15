namespace HRApplicantSystem.Forms.HR
{
    partial class HiringDecisionForm
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
            this.grpDecision = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoOnHold = new System.Windows.Forms.RadioButton();
            this.rdoRejected = new System.Windows.Forms.RadioButton();
            this.rdoAccepted = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApplicant = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.grpApplicants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.grpDecision.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpApplicants
            // 
            this.grpApplicants.BackColor = System.Drawing.SystemColors.Control;
            this.grpApplicants.Controls.Add(this.dgvApplicants);
            this.grpApplicants.ForeColor = System.Drawing.Color.Green;
            this.grpApplicants.Location = new System.Drawing.Point(9, 8);
            this.grpApplicants.Margin = new System.Windows.Forms.Padding(2);
            this.grpApplicants.Name = "grpApplicants";
            this.grpApplicants.Padding = new System.Windows.Forms.Padding(2);
            this.grpApplicants.Size = new System.Drawing.Size(496, 175);
            this.grpApplicants.TabIndex = 0;
            this.grpApplicants.TabStop = false;
            this.grpApplicants.Text = "Applicants For Final Decision";
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
            this.dgvApplicants.Size = new System.Drawing.Size(492, 158);
            this.dgvApplicants.TabIndex = 0;
            this.dgvApplicants.SelectionChanged += new System.EventHandler(this.dgvApplicants_SelectionChanged);
            // 
            // grpDecision
            // 
            this.grpDecision.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpDecision.Controls.Add(this.btnSave);
            this.grpDecision.Controls.Add(this.btnBack);
            this.grpDecision.Controls.Add(this.txtRemarks);
            this.grpDecision.Controls.Add(this.label2);
            this.grpDecision.Controls.Add(this.rdoOnHold);
            this.grpDecision.Controls.Add(this.rdoRejected);
            this.grpDecision.Controls.Add(this.rdoAccepted);
            this.grpDecision.Controls.Add(this.label1);
            this.grpDecision.Controls.Add(this.lblApplicant);
            this.grpDecision.Controls.Add(this.lblJob);
            this.grpDecision.Location = new System.Drawing.Point(9, 192);
            this.grpDecision.Margin = new System.Windows.Forms.Padding(2);
            this.grpDecision.Name = "grpDecision";
            this.grpDecision.Padding = new System.Windows.Forms.Padding(2);
            this.grpDecision.Size = new System.Drawing.Size(494, 215);
            this.grpDecision.TabIndex = 1;
            this.grpDecision.TabStop = false;
            this.grpDecision.Text = "Hiring Decision";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(363, 46);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 53);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save Decision\n";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(363, 133);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 53);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(60, 85);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(270, 126);
            this.txtRemarks.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Remarks:";
            // 
            // rdoOnHold
            // 
            this.rdoOnHold.AutoSize = true;
            this.rdoOnHold.Location = new System.Drawing.Point(211, 64);
            this.rdoOnHold.Margin = new System.Windows.Forms.Padding(2);
            this.rdoOnHold.Name = "rdoOnHold";
            this.rdoOnHold.Size = new System.Drawing.Size(64, 17);
            this.rdoOnHold.TabIndex = 9;
            this.rdoOnHold.TabStop = true;
            this.rdoOnHold.Text = "On Hold";
            this.rdoOnHold.UseVisualStyleBackColor = true;
            // 
            // rdoRejected
            // 
            this.rdoRejected.AutoSize = true;
            this.rdoRejected.Location = new System.Drawing.Point(144, 63);
            this.rdoRejected.Margin = new System.Windows.Forms.Padding(2);
            this.rdoRejected.Name = "rdoRejected";
            this.rdoRejected.Size = new System.Drawing.Size(68, 17);
            this.rdoRejected.TabIndex = 8;
            this.rdoRejected.TabStop = true;
            this.rdoRejected.Text = "Rejected";
            this.rdoRejected.UseVisualStyleBackColor = true;
            // 
            // rdoAccepted
            // 
            this.rdoAccepted.AutoSize = true;
            this.rdoAccepted.Location = new System.Drawing.Point(75, 63);
            this.rdoAccepted.Margin = new System.Windows.Forms.Padding(2);
            this.rdoAccepted.Name = "rdoAccepted";
            this.rdoAccepted.Size = new System.Drawing.Size(71, 17);
            this.rdoAccepted.TabIndex = 7;
            this.rdoAccepted.TabStop = true;
            this.rdoAccepted.Text = "Accepted";
            this.rdoAccepted.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Decision:";
            // 
            // lblApplicant
            // 
            this.lblApplicant.AutoSize = true;
            this.lblApplicant.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblApplicant.ForeColor = System.Drawing.Color.Green;
            this.lblApplicant.Location = new System.Drawing.Point(8, 23);
            this.lblApplicant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicant.Name = "lblApplicant";
            this.lblApplicant.Size = new System.Drawing.Size(95, 19);
            this.lblApplicant.TabIndex = 4;
            this.lblApplicant.Text = "Applicant: —";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblJob.Location = new System.Drawing.Point(8, 44);
            this.lblJob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(49, 17);
            this.lblJob.TabIndex = 5;
            this.lblJob.Text = "Job: —";
            // 
            // HiringDecisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(525, 418);
            this.Controls.Add(this.grpDecision);
            this.Controls.Add(this.grpApplicants);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HiringDecisionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HiringDecisionForm";
            this.Load += new System.EventHandler(this.HiringDecisionForm_Load);
            this.grpApplicants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.grpDecision.ResumeLayout(false);
            this.grpDecision.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpApplicants;
        private System.Windows.Forms.DataGridView dgvApplicants;
        private System.Windows.Forms.GroupBox grpDecision;
        private System.Windows.Forms.Label lblApplicant;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.RadioButton rdoRejected;
        private System.Windows.Forms.RadioButton rdoAccepted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoOnHold;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}