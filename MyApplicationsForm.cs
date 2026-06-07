using System;
using System.Windows.Forms;

namespace HRApplicantSystem
{
    public partial class MyApplicationsForm : Form
    {
        public MyApplicationsForm()
        {
            InitializeComponent();

            dgvApplications.Columns.Clear();

            dgvApplications.Columns.Add("JobID", "Job ID");
            dgvApplications.Columns.Add("Position", "Position");
            dgvApplications.Columns.Add("Status", "Status");

            dgvApplications.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvApplications.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvApplications.MultiSelect = false;

            LoadApplications();
        }

        private void LoadApplications()
        {
            dgvApplications.Rows.Clear();

            foreach (var app in JobVacancyForm.applications)
            {
                dgvApplications.Rows.Add(
                    app.JobID,
                    app.Position,
                    app.Status
                );
            }
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an application.");
                return;
            }

            string jobID = dgvApplications.SelectedRows[0]
                .Cells["JobID"]
                .Value.ToString();

            JobApplication selectedApp =
                JobVacancyForm.applications.Find(a => a.JobID == jobID);

            if (selectedApp != null)
            {
                ApplicationStatusForm form =
                    new ApplicationStatusForm(selectedApp);

                form.ShowDialog();
            }
        }
    }
}