using System;
using System.Data.OleDb;
using System.Windows.Forms;
using HRApplicantSystem.Database;
using HRApplicantSystem.Classes;

namespace HRApplicantSystem.Forms
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string current = txtCurrent.Text.Trim();
            string newPass = txtNew.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            if (current == "" || newPass == "" || confirm == "")
            {
                MessageBox.Show("Please fill in all fields.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass != confirm)
            {
                MessageBox.Show("New passwords do not match.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPass.Length < 6)
            {
                MessageBox.Show("New password must be at least 6 characters.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (current == newPass)
            {
                MessageBox.Show("New password must be different from current password.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OleDbConnection conn = DBConnection.GetConnection();
            if (conn == null) return;

            try
            {
                conn.Open();

                string table = UserSession.Role == "Applicant" ?
                               "ApplicantAccounts" : "Users";
                string idColumn = UserSession.Role == "Applicant" ?
                                  "ApplicantAccountID" : "UserID";

                string verifyQuery = "SELECT COUNT(*) FROM " + table +
                                     " WHERE " + idColumn + "=@id" +
                                     " AND PasswordHash=@current";
                OleDbCommand verifyCmd = new OleDbCommand(verifyQuery, conn);
                verifyCmd.Parameters.AddWithValue("@id", UserSession.UserID);
                verifyCmd.Parameters.AddWithValue("@current", current);
                int match = Convert.ToInt32(verifyCmd.ExecuteScalar());

                if (match == 0)
                {
                    MessageBox.Show("Current password is incorrect.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                    return;
                }

                string updateQuery = "UPDATE " + table +
                                     " SET PasswordHash=@newPass" +
                                     " WHERE " + idColumn + "=@id";
                OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn);
                updateCmd.Parameters.AddWithValue("@newPass", newPass);
                updateCmd.Parameters.AddWithValue("@id", UserSession.UserID);
                updateCmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Password changed successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }
    }
}