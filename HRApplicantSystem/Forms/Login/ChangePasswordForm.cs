using HRApplicantSystem.Classes;
using HRApplicantSystem.Database;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Login
{
    public class ChangePasswordForm : Form
    {
        private bool _isHR;

        // Cleaned Core UI Controls matching the runtime engine
        private Label lblTitle, lblIdentifier, lblOld, lblNew, lblConfirm;
        private TextBox txtIdentifier, txtOldPassword, txtNewPassword, txtConfirmPassword;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ChangePasswordForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ChangePasswordForm";
            this.ResumeLayout(false);

        }

        private Button btnSave, btnCancel;

        /// <summary>
        /// Explicit Constructor called by the Login Portal.
        /// </summary>
        /// <param name="isHR">Passes true if management user; false if applicant.</param>
        public ChangePasswordForm(bool isHR)
        {
            _isHR = isHR;

            // 1. Explicitly build the visual workspace from clean source declarations
            BuildUI();

            // 2. Pre-populate user identity bounds if a session is already present
            InitializeSessionState();
        }

        /// <summary>
        /// Programmatic UI Factory method. Completely replaces the broken Designer tracks.
        /// </summary>
        private void BuildUI()
        {
            // Window Configuration Properties
            this.Text = "Security Center - Change Password";
            this.Size = new Size(420, 340);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.FromArgb(248, 250, 252); // Soft professional modern gray

            // Title Label
            lblTitle = new Label()
            {
                Text = "Modify Account Credentials",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(20, 15),
                Size = new Size(360, 25)
            };

            // Dynamic User Identifier Label (Changes label layout natively based on login mode choice)
            lblIdentifier = new Label()
            {
                Text = _isHR ? "Username:" : "Email Address:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(71, 85, 105),
                Location = new Point(20, 55),
                Size = new Size(130, 20)
            };

            txtIdentifier = new TextBox()
            {
                Location = new Point(160, 52),
                Size = new Size(220, 23),
                Font = new Font("Segoe UI", 9F),
                BackColor = Color.White
            };

            // Old Password Inputs
            lblOld = new Label()
            {
                Text = "Current Password:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(71, 85, 105),
                Location = new Point(20, 95),
                Size = new Size(130, 20)
            };

            txtOldPassword = new TextBox()
            {
                Location = new Point(160, 92),
                Size = new Size(220, 23),
                Font = new Font("Segoe UI", 9F),
                PasswordChar = '●',
                UseSystemPasswordChar = true
            };

            // New Password Inputs
            lblNew = new Label()
            {
                Text = "New Password:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(71, 85, 105),
                Location = new Point(20, 135),
                Size = new Size(130, 20)
            };

            txtNewPassword = new TextBox()
            {
                Location = new Point(160, 132),
                Size = new Size(220, 23),
                Font = new Font("Segoe UI", 9F),
                PasswordChar = '●',
                UseSystemPasswordChar = true
            };

            // Confirm Password Inputs
            lblConfirm = new Label()
            {
                Text = "Confirm Password:",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.FromArgb(71, 85, 105),
                Location = new Point(20, 175),
                Size = new Size(130, 20)
            };

            txtConfirmPassword = new TextBox()
            {
                Location = new Point(160, 172),
                Size = new Size(220, 23),
                Font = new Font("Segoe UI", 9F),
                PasswordChar = '●',
                UseSystemPasswordChar = true
            };

            // Action Execution Button (Save Changes)
            btnSave = new Button()
            {
                Text = "Update Password",
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                BackColor = Color.ForestGreen,
                ForeColor = Color.White,
                Location = new Point(160, 225),
                Size = new Size(125, 35),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += BtnSave_Click;

            // Cancel/Exit Button
            btnCancel = new Button()
            {
                Text = "Cancel",
                Font = new Font("Segoe UI", 9.5F, FontStyle.Regular),
                BackColor = Color.FromArgb(226, 232, 240),
                ForeColor = Color.FromArgb(71, 85, 105),
                Location = new Point(295, 225),
                Size = new Size(85, 35),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, e) => this.Close();

            // Register controls to the Form Workspace view canvas cleanly
            this.Controls.AddRange(new Control[] {
                lblTitle, lblIdentifier, txtIdentifier,
                lblOld, txtOldPassword,
                lblNew, txtNewPassword,
                lblConfirm, txtConfirmPassword,
                btnSave, btnCancel
            });
        }

        /// <summary>
        /// Auto-fills the identifier field if a user updates their password while logged into their session.
        /// </summary>
        private void InitializeSessionState()
        {
            if (UserSession.UserID > 0 && !string.IsNullOrEmpty(UserSession.Username))
            {
                txtIdentifier.Text = UserSession.Username;
                txtIdentifier.ReadOnly = true; // Lock field safely to match active tracking context
                txtIdentifier.BackColor = Color.FromArgb(241, 245, 249);
            }
        }

        /// <summary>
        /// Handles database updates, access rules verification, and criteria validation checks.
        /// </summary>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation Trap: Check for empty input strings
            if (string.IsNullOrWhiteSpace(txtIdentifier.Text) ||
                string.IsNullOrWhiteSpace(txtOldPassword.Text) ||
                string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please fill out all field paths completely.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation Trap: Check if new password confirmation entries match
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password confirmation entries do not match. Re-enter your new password choice.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Capstone Engineering Requirement: Password Complexity Matrix Verification Check
            // Enforces a minimum of 6 characters containing at least one numerical digit for security
            if (txtNewPassword.Text.Length < 6 || !Regex.IsMatch(txtNewPassword.Text, @"\d"))
            {
                MessageBox.Show("Security Block: New password must be at least 6 characters long and contain at least one numeric digit.",
                                "Complexity Requirement Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OleDbConnection con = DBConnection.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();

                // Dynamic SQL Target Routing depending on context flag (_isHR)
                string checkQuery = _isHR
                    ? "SELECT COUNT(*) FROM Users WHERE Username = ? AND [Password] = ?"
                    : "SELECT COUNT(*) FROM ApplicantAccounts WHERE Email = ? AND [Password] = ?";

                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@Identifier", txtIdentifier.Text.Trim());
                    checkCmd.Parameters.AddWithValue("@OldPass", txtOldPassword.Text);

                    int matchCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (matchCount == 0)
                    {
                        MessageBox.Show("Verification Failure: The account identity or current password you entered is incorrect.",
                                        "Access Rejected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Execute the parameterized update script to prevent SQL Injection
                string updateQuery = _isHR
                    ? "UPDATE Users SET [Password] = ? WHERE Username = ?"
                    : "UPDATE ApplicantAccounts SET [Password] = ? WHERE Email = ?";

                using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, con))
                {
                    updateCmd.Parameters.Add("@NewPass", OleDbType.VarWChar).Value = txtNewPassword.Text;
                    updateCmd.Parameters.Add("@Identifier", OleDbType.VarWChar).Value = txtIdentifier.Text.Trim();
                    updateCmd.ExecuteNonQuery();
                }

                // Audit Trail Integration Logging hook
                string actor = string.IsNullOrEmpty(UserSession.Username) ? txtIdentifier.Text.Trim() : UserSession.Username;
                string userScope = _isHR ? "HR Staff/Admin" : "Applicant Account";

                try
                {
                    string logQuery = "INSERT INTO AuditTrail (ActorUser, ActionDescription, Timestamp) VALUES (?, ?, ?)";
                    using (OleDbCommand logCmd = new OleDbCommand(logQuery, con))
                    {
                        logCmd.Parameters.AddWithValue("@Actor", actor);
                        logCmd.Parameters.AddWithValue("@Desc", $"Password updated successfully via security center for context scope: {userScope}.");
                        logCmd.Parameters.AddWithValue("@Time", DateTime.Now);
                        logCmd.ExecuteNonQuery();
                    }
                }
                catch { /* Prevents execution crashing if the optional logging system table is temporarily locked */ }

                MessageBox.Show("Password changed successfully! Please log in with your new credentials during your next session.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected execution block error occurred while updating the password:\n" + ex.Message,
                                "Database System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}