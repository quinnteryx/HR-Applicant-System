using HRApplicantSystem.Classes;
using HRApplicantSystem.Database;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace FINAL_PROJECT.Forms
{
    public partial class ApplicantProfileForm : Form
    {
        private int applicantID = 0;
        private bool profileExists = false;

        public ApplicantProfileForm()
        {
            InitializeComponent();
        }

        private void ApplicantProfileForm_Load(object sender, EventArgs e)
        {
            applicantID = UserSession.UserID;
            LoadProfile();
        }

        private void LoadProfile()
        {
            OleDbConnection con = DBConnection.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();
                string query = "SELECT * FROM Applicants WHERE ApplicantID = @id";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@id", applicantID);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    profileExists = true;
                    txtFirstName.Text = reader["FirstName"].ToString();
                    txtLastName.Text = reader["LastName"].ToString();
                    txtPhone.Text = reader["ContactNumber"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    txtEducation.Text = reader["Education"].ToString();
                    txtSkills.Text = reader["Skills"].ToString();
                    txtWorkExperience.Text = reader["WorkExperience"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (profileExists)
            {
                MessageBox.Show("Profile already exists. Click Update to make changes.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "")
            {
                MessageBox.Show("First Name and Last Name are required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OleDbConnection con = DBConnection.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();
                string query = @"INSERT INTO Applicants 
                    (ApplicantID, FirstName, LastName, ContactNumber, Address, Education, Skills, WorkExperience)
                    VALUES (@id, @fn, @ln, @phone, @address, @education, @skills, @workexp)";

                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@id", applicantID);
                cmd.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@ln", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@education", txtEducation.Text.Trim());
                cmd.Parameters.AddWithValue("@skills", txtSkills.Text.Trim());
                cmd.Parameters.AddWithValue("@workexp", txtWorkExperience.Text.Trim());

                cmd.ExecuteNonQuery();
                profileExists = true;
                MessageBox.Show("Profile saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving profile:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!profileExists)
            {
                MessageBox.Show("No profile found. Please save first.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            OleDbConnection con = DBConnection.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();
                string query = @"UPDATE Applicants SET
                    FirstName = @fn,
                    LastName = @ln,
                    ContactNumber = @phone,
                    Address = @address,
                    Education = @education,
                    Skills = @skills,
                    WorkExperience = @workexp
                    WHERE ApplicantID = @id";

                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@fn", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@ln", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@education", txtEducation.Text.Trim());
                cmd.Parameters.AddWithValue("@skills", txtSkills.Text.Trim());
                cmd.Parameters.AddWithValue("@workexp", txtWorkExperience.Text.Trim());
                cmd.Parameters.AddWithValue("@id", applicantID);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating profile:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtEducation.Clear();
            txtSkills.Clear();
            txtWorkExperience.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}