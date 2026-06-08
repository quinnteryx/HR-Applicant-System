using System;
using System.Data.OleDb;
using System.Windows.Forms;
using HRApplicantSystem.Database;
using HRApplicantSystem.Classes;

namespace HRApplicantSystem.Forms
{
    public partial class HRLoginForm : Form
    {
        public HRLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter your email and password.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OleDbConnection conn = DBConnection.GetConnection();
            if (conn == null) return;

            try
            {
                conn.Open();

                string query = "SELECT UserID, FullName, Role, IsActive " +
                               "FROM Users " +
                               "WHERE Email=@email AND PasswordHash=@password";

                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    bool isActive = Convert.ToBoolean(reader["IsActive"]);
                    if (!isActive)
                    {
                        MessageBox.Show(
                            "Your account is deactivated. Please contact Admin.",
                            "Account Disabled", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        reader.Close();
                        conn.Close();
                        return;
                    }

                    UserSession.UserID = Convert.ToInt32(reader["UserID"]);
                    UserSession.Username = reader["FullName"].ToString();
                    UserSession.Role = reader["Role"].ToString();

                    reader.Close();
                    conn.Close();

                    MessageBox.Show("Welcome, " + UserSession.Username + "!" +
                        "\nRole: " + UserSession.Role,
                        "Login Successful", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    WelcomeForm welcome = new WelcomeForm();
                    welcome.ShowDialog();
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    MessageBox.Show("Invalid email or password.",
                        "Login Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}