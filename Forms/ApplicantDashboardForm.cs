using System;
using System.Data.OleDb;
using System.Windows.Forms;
using HRApplicantSystem.Database;
using HRApplicantSystem.Classes;

namespace FINAL_PROJECT.Forms
{
    public partial class ApplicantDashboardForm : Form
    {
        private int applicantID = 0;

        public ApplicantDashboardForm()
        {
            InitializeComponent();
        }

        private void ApplicantDashboardForm_Load(object sender, EventArgs e)
        {
            applicantID = UserSession.UserID;
            LoadStatus();
            LoadMissingDocuments();
            LoadInterviewSchedule();
        }

        private void LoadStatus()
        {
            OleDbConnection con = DBConnection.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();
                string query = @"SELECT TOP 1 Status FROM Applications 
                                WHERE ApplicantID = @id 
                                ORDER BY ApplicationID DESC";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@id", applicantID);

                object result = cmd.ExecuteScalar();
                if (result != null)
                    lblStatus.Text = result.ToString();
                else
                    lblStatus.Text = "No application submitted yet.";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error loading status.";
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadMissingDocuments()
        {
            lstMissingDocs.Items.Clear();

            OleDbConnection con = DBConnection.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();

                string reqQuery = "SELECT RequirementName FROM RequirementTypes";
                OleDbCommand reqCmd = new OleDbCommand(reqQuery, con);
                OleDbDataReader reqReader = reqCmd.ExecuteReader();

                System.Collections.Generic.List<string> allRequirements =
                    new System.Collections.Generic.List<string>();

                while (reqReader.Read())
                    allRequirements.Add(reqReader["RequirementName"].ToString());

                reqReader.Close();

                string subQuery = "SELECT DocumentType FROM ApplicantDocuments WHERE ApplicantID = @id";
                OleDbCommand subCmd = new OleDbCommand(subQuery, con);
                subCmd.Parameters.AddWithValue("@id", applicantID);
                OleDbDataReader subReader = subCmd.ExecuteReader();

                System.Collections.Generic.List<string> submittedDocs =
                    new System.Collections.Generic.List<string>();

                while (subReader.Read())
                    submittedDocs.Add(subReader["DocumentType"].ToString());

                subReader.Close();

                foreach (string req in allRequirements)
                {
                    if (!submittedDocs.Contains(req))
                        lstMissingDocs.Items.Add(req);
                }

                if (lstMissingDocs.Items.Count == 0)
                    lstMissingDocs.Items.Add("All documents submitted!");
            }
            catch (Exception ex)
            {
                lstMissingDocs.Items.Add("Error loading documents.");
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadInterviewSchedule()
        {
            OleDbConnection con = DBConnection.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();
                string query = @"SELECT TOP 1 InterviewDate, InterviewTime, Location 
                                FROM InterviewSchedules 
                                WHERE ApplicantID = @id 
                                ORDER BY InterviewDate DESC";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@id", applicantID);

                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string date = Convert.ToDateTime(reader["InterviewDate"]).ToString("MMMM dd, yyyy");
                    string time = reader["InterviewTime"].ToString();
                    string location = reader["Location"].ToString();
                    lblInterviewSchedule.Text = $"Date: {date}\nTime: {time}\nLocation: {location}";
                }
                else
                {
                    lblInterviewSchedule.Text = "No interview scheduled.";
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                lblInterviewSchedule.Text = "Error loading schedule.";
            }
            finally
            {
                con.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}