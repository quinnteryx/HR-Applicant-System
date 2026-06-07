using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRApplicantSystem
{
    public partial class JobVacancyForm : Form
    {
        private List<Job> jobs = new List<Job>();
        public static List<JobApplication> applications = new List<JobApplication>();

        public JobVacancyForm()
        {
            InitializeComponent();

            dgvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJobs.MultiSelect = false;

            LoadJobs();
        }

        private void LoadJobs()
        {

            dgvJobs.Columns.Clear();

            dgvJobs.Columns.Add("JobID", "Job ID");
            dgvJobs.Columns.Add("Position", "Position");
            dgvJobs.Columns.Add("Department", "Department");

            dgvJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            jobs.Add(new Job
            {
                JobID = "1",
                Position = "Software Developer",
                Department = "IT"
            });

            jobs.Add(new Job
            {
                JobID = "2",
                Position = "HR Assistant",
                Department = "HR"
            });

            jobs.Add(new Job
            {
                JobID = "3",
                Position = "Accounting Staff",
                Department = "Finance"
            });

            DisplayJobs(jobs);
        }

        private void DisplayJobs(List<Job> jobList)
        {
            dgvJobs.Rows.Clear();

            foreach (var job in jobList)
            {
                dgvJobs.Rows.Add(
                    job.JobID,
                    job.Position,
                    job.Department
                );
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                DisplayJobs(jobs);
                return;
            }

            var filteredJobs = jobs.Where(job =>
                job.JobID.ToLower().Contains(keyword) ||
                job.Position.ToLower().Contains(keyword) ||
                job.Department.ToLower().Contains(keyword)
            ).ToList();

            DisplayJobs(filteredJobs);
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a job first.");
                return;
            }

            DataGridViewRow row = dgvJobs.SelectedRows[0];

            string jobID = row.Cells["JobID"].Value.ToString();
            string position = row.Cells["Position"].Value.ToString();
            string department = row.Cells["Department"].Value.ToString();

            MessageBox.Show(
                "Job ID: " + jobID +
                "\nPosition: " + position +
                "\nDepartment: " + department,
                "Job Details"
            );
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (dgvJobs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a job first.");
                return;
            }

            DataGridViewRow row = dgvJobs.SelectedRows[0];

            string jobID = row.Cells["JobID"].Value.ToString();
            string position = row.Cells["Position"].Value.ToString();

            bool alreadyApplied = applications.Any(a => a.JobID == jobID);

            if (alreadyApplied)
            {
                MessageBox.Show("You already applied for this job.");
                return;
            }

            applications.Add(new JobApplication
            {
                JobID = jobID,
                Position = position,
                Status = "Submitted",
                DateApplied = DateTime.Now
            });

            MessageBox.Show("Application submitted successfully.");
        }

        private void btnMyApplications_Click(object sender, EventArgs e)
        {
            MyApplicationsForm form = new MyApplicationsForm();
            form.ShowDialog();
        }
    }

    public class Job
    {
        public string JobID { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
    }
    public class JobApplication
    {
        public string JobID { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }

        public DateTime DateApplied { get; set; }
    }
}