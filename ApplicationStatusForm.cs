using System;
using System.Windows.Forms;

namespace HRApplicantSystem
{
    public partial class ApplicationStatusForm : Form
    {
        private JobApplication application;

        public ApplicationStatusForm(JobApplication app)
        {
            InitializeComponent();

            application = app;

            LoadHistory();
        }

        private void LoadHistory()
        {
            lstHistory.Items.Clear();

            lstHistory.Items.Add(
                application.DateApplied.ToString("MM/dd/yyyy hh:mm tt")
                + " - Submitted"
            );
        }
    }
}