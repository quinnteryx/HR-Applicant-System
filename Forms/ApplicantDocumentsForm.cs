using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using HRApplicantSystem.Database;
using HRApplicantSystem.Classes;

namespace FINAL_PROJECT.Forms
{
    public partial class ApplicantDocumentsForm : Form
    {
        private int applicantID = 0;
        private int selectedDocumentID = 0;

        public ApplicantDocumentsForm()
        {
            InitializeComponent();
        }

        private void ApplicantDocumentsForm_Load(object sender, EventArgs e)
        {
            applicantID = UserSession.UserID;
            LoadDocumentTypes();
            LoadDocuments();
        }

        private void LoadDocumentTypes()
        {
            OleDbConnection con = DBConnection.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();
                string query = "SELECT RequirementName FROM RequirementTypes";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader reader = cmd.ExecuteReader();

                cmbDocType.Items.Clear();
                while (reader.Read())
                    cmbDocType.Items.Add(reader["RequirementName"].ToString());

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading document types:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void LoadDocuments()
        {
            OleDbConnection con = DBConnection.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();
                string query = "SELECT * FROM ApplicantDocuments WHERE ApplicantID = @id";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@id", applicantID);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvDocuments.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading documents:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbDocType.SelectedItem == null)
            {
                MessageBox.Show("Please select a document type.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OleDbConnection con = DBConnection.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();
                string query = @"INSERT INTO ApplicantDocuments 
                    (ApplicantID, DocumentType, Remarks)
                    VALUES (@id, @doctype, @remarks)";

                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@id", applicantID);
                cmd.Parameters.AddWithValue("@doctype", cmbDocType.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Document added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDocuments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding document:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDocumentID == 0)
            {
                MessageBox.Show("Please select a document to update.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OleDbConnection con = DBConnection.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();
                string query = @"UPDATE ApplicantDocuments SET
                    DocumentType = @doctype,
                    Remarks = @remarks
                    WHERE DocumentID = @docid";

                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@doctype", cmbDocType.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@remarks", txtRemarks.Text.Trim());
                cmd.Parameters.AddWithValue("@docid", selectedDocumentID);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Document updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDocuments();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating document:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDocumentID == 0)
            {
                MessageBox.Show("Please select a document to delete.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OleDbConnection con = DBConnection.GetConnection();
            if (con == null) return;

            try
            {
                con.Open();

                string checkQuery = "SELECT Status FROM ApplicantDocuments WHERE DocumentID = @docid";
                OleDbCommand checkCmd = new OleDbCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@docid", selectedDocumentID);

                object statusResult = checkCmd.ExecuteScalar();
                if (statusResult != null && statusResult.ToString() == "Under Review")
                {
                    MessageBox.Show("This document is currently under review and cannot be deleted.",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this document?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) return;

                string query = "DELETE FROM ApplicantDocuments WHERE DocumentID = @docid";
                OleDbCommand cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@docid", selectedDocumentID);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Document deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDocuments();
                ClearFields();
                selectedDocumentID = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting document:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void dgvDocuments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDocuments.Rows[e.RowIndex];
                selectedDocumentID = Convert.ToInt32(row.Cells["DocumentID"].Value);
                cmbDocType.SelectedItem = row.Cells["DocumentType"].Value?.ToString();
                txtRemarks.Text = row.Cells["Remarks"].Value?.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            cmbDocType.SelectedIndex = -1;
            txtRemarks.Clear();
            selectedDocumentID = 0;
        }
    }
}