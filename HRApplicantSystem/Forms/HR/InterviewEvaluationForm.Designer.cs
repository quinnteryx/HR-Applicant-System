namespace HRApplicantSystem.Forms.HR
{
    partial class InterviewEvaluationForm
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
            this.grpEvaluation = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRecommendation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoFail = new System.Windows.Forms.RadioButton();
            this.rdoPass = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nudScore = new System.Windows.Forms.NumericUpDown();
            this.Scorelabel = new System.Windows.Forms.Label();
            this.lblInterviewDate = new System.Windows.Forms.Label();
            this.lblApplicant = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.grpApplicants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.grpEvaluation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).BeginInit();
            this.SuspendLayout();
            // 
            // grpApplicants
            // 
            this.grpApplicants.BackColor = System.Drawing.SystemColors.Control;
            this.grpApplicants.Controls.Add(this.dgvApplicants);
            this.grpApplicants.Location = new System.Drawing.Point(8, 10);
            this.grpApplicants.Margin = new System.Windows.Forms.Padding(2);
            this.grpApplicants.Name = "grpApplicants";
            this.grpApplicants.Padding = new System.Windows.Forms.Padding(2);
            this.grpApplicants.Size = new System.Drawing.Size(496, 175);
            this.grpApplicants.TabIndex = 0;
            this.grpApplicants.TabStop = false;
            this.grpApplicants.Text = "Interviewed Applicants";
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
            // grpEvaluation
            // 
            this.grpEvaluation.BackColor = System.Drawing.SystemColors.Control;
            this.grpEvaluation.Controls.Add(this.btnSave);
            this.grpEvaluation.Controls.Add(this.btnBack);
            this.grpEvaluation.Controls.Add(this.txtRecommendation);
            this.grpEvaluation.Controls.Add(this.label3);
            this.grpEvaluation.Controls.Add(this.txtRemarks);
            this.grpEvaluation.Controls.Add(this.label2);
            this.grpEvaluation.Controls.Add(this.rdoFail);
            this.grpEvaluation.Controls.Add(this.rdoPass);
            this.grpEvaluation.Controls.Add(this.label1);
            this.grpEvaluation.Controls.Add(this.nudScore);
            this.grpEvaluation.Controls.Add(this.Scorelabel);
            this.grpEvaluation.Controls.Add(this.lblInterviewDate);
            this.grpEvaluation.Controls.Add(this.lblApplicant);
            this.grpEvaluation.Controls.Add(this.lblJob);
            this.grpEvaluation.Location = new System.Drawing.Point(13, 192);
            this.grpEvaluation.Margin = new System.Windows.Forms.Padding(2);
            this.grpEvaluation.Name = "grpEvaluation";
            this.grpEvaluation.Padding = new System.Windows.Forms.Padding(2);
            this.grpEvaluation.Size = new System.Drawing.Size(491, 215);
            this.grpEvaluation.TabIndex = 1;
            this.grpEvaluation.TabStop = false;
            this.grpEvaluation.Text = "Evaluation Details";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(35, 161);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(212, 37);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save Evaluation";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(241, 161);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(209, 37);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRecommendation
            // 
            this.txtRecommendation.Location = new System.Drawing.Point(327, 93);
            this.txtRecommendation.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecommendation.Multiline = true;
            this.txtRecommendation.Name = "txtRecommendation";
            this.txtRecommendation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecommendation.Size = new System.Drawing.Size(157, 43);
            this.txtRecommendation.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Recommendation:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(278, 51);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(206, 34);
            this.txtRemarks.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Remarks:";
            // 
            // rdoFail
            // 
            this.rdoFail.AutoSize = true;
            this.rdoFail.Location = new System.Drawing.Point(149, 110);
            this.rdoFail.Margin = new System.Windows.Forms.Padding(2);
            this.rdoFail.Name = "rdoFail";
            this.rdoFail.Size = new System.Drawing.Size(41, 17);
            this.rdoFail.TabIndex = 9;
            this.rdoFail.TabStop = true;
            this.rdoFail.Text = "Fail";
            this.rdoFail.UseVisualStyleBackColor = true;
            // 
            // rdoPass
            // 
            this.rdoPass.AutoSize = true;
            this.rdoPass.Location = new System.Drawing.Point(100, 110);
            this.rdoPass.Margin = new System.Windows.Forms.Padding(2);
            this.rdoPass.Name = "rdoPass";
            this.rdoPass.Size = new System.Drawing.Size(48, 17);
            this.rdoPass.TabIndex = 8;
            this.rdoPass.TabStop = true;
            this.rdoPass.Text = "Pass";
            this.rdoPass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Result:";
            // 
            // nudScore
            // 
            this.nudScore.Location = new System.Drawing.Point(100, 86);
            this.nudScore.Margin = new System.Windows.Forms.Padding(2);
            this.nudScore.Name = "nudScore";
            this.nudScore.Size = new System.Drawing.Size(90, 20);
            this.nudScore.TabIndex = 6;
            this.nudScore.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // Scorelabel
            // 
            this.Scorelabel.AutoSize = true;
            this.Scorelabel.Location = new System.Drawing.Point(9, 86);
            this.Scorelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Scorelabel.Name = "Scorelabel";
            this.Scorelabel.Size = new System.Drawing.Size(80, 13);
            this.Scorelabel.TabIndex = 5;
            this.Scorelabel.Text = "Score (0 - 100):";
            // 
            // lblInterviewDate
            // 
            this.lblInterviewDate.AutoSize = true;
            this.lblInterviewDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblInterviewDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblInterviewDate.Location = new System.Drawing.Point(8, 61);
            this.lblInterviewDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterviewDate.Name = "lblInterviewDate";
            this.lblInterviewDate.Size = new System.Drawing.Size(102, 17);
            this.lblInterviewDate.TabIndex = 4;
            this.lblInterviewDate.Text = "Interview Date: -";
            // 
            // lblApplicant
            // 
            this.lblApplicant.AutoSize = true;
            this.lblApplicant.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblApplicant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblApplicant.Location = new System.Drawing.Point(8, 14);
            this.lblApplicant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicant.Name = "lblApplicant";
            this.lblApplicant.Size = new System.Drawing.Size(147, 30);
            this.lblApplicant.TabIndex = 2;
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
            this.lblJob.TabIndex = 3;
            this.lblJob.Text = "Job: —";
            // 
            // InterviewEvaluationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(515, 418);
            this.Controls.Add(this.grpEvaluation);
            this.Controls.Add(this.grpApplicants);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "InterviewEvaluationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interview Evaluation";
            this.Load += new System.EventHandler(this.InterviewEvaluationForm_Load);
            this.grpApplicants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.grpEvaluation.ResumeLayout(false);
            this.grpEvaluation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpApplicants;
        private System.Windows.Forms.DataGridView dgvApplicants;
        private System.Windows.Forms.GroupBox grpEvaluation;
        private System.Windows.Forms.Label lblApplicant;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label Scorelabel;
        private System.Windows.Forms.Label lblInterviewDate;
        private System.Windows.Forms.NumericUpDown nudScore;
        private System.Windows.Forms.RadioButton rdoFail;
        private System.Windows.Forms.RadioButton rdoPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecommendation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
    }
}