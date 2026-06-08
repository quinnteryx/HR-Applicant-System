using System;
using System.Data.OleDb;
using System.Windows.Forms;
using HRApplicantSystem.Database;
using HRApplicantSystem.Classes;

namespace HRApplicantSystem.Forms
{
    public partial class ApplicantRegisterForm : Form
    {
        public ApplicantRegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            // Empty field check
            if (firstName == "" || lastName == "" || email == "" ||
                password == "" || confirm == "")
            {
                MessageBox.Show("Please fill in all fields.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password match check
            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password length check
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OleDbConnection conn = DBConnection.GetConnection();
            if (conn == null) return;

            try
            {
                conn.Open();

                // Duplicate email check
                string checkQuery = "SELECT COUNT(*) FROM ApplicantAccounts " +
                                    "WHERE Email=@email";
                OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@email", email);
                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (exists > 0)
                {
                    MessageBox.Show("That email is already registered.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                // Insert into ApplicantAccounts
                string insertQuery = "INSERT INTO ApplicantAccounts " +
                                     "(Email, PasswordHash, IsActive) " +
                                     "VALUES (@email, @password, True)";
                OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@email", email);
                insertCmd.Parameters.AddWithValue("@password", password);
                insertCmd.ExecuteNonQuery();

                // Get the new account ID
                OleDbCommand idCmd = new OleDbCommand(
                    "SELECT @@IDENTITY", conn);
                int newAccountID = Convert.ToInt32(idCmd.ExecuteScalar());

                // Insert into Applicants table
                string insertApplicant = "INSERT INTO Applicants " +
                                         "(ApplicantAccountID, FirstName, LastName) " +
                                         "VALUES (@accountID, @firstName, @lastName)";
                OleDbCommand appCmd = new OleDbCommand(insertApplicant, conn);
                appCmd.Parameters.AddWithValue("@accountID", newAccountID);
                appCmd.Parameters.AddWithValue("@firstName", firstName);
                appCmd.Parameters.AddWithValue("@lastName", lastName);
                appCmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Account created successfully! You can now log in.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplicantRegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}