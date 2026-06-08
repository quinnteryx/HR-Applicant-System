using System;
using System.Windows.Forms;
using HRApplicantSystem.Classes;

namespace HRApplicantSystem.Forms
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + UserSession.Username + "!";
            lblRole.Text = "Role: " + UserSession.Role;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePass = new ChangePasswordForm();
            changePass.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserSession.UserID = 0;
                UserSession.Username = "";
                UserSession.Role = "";

                MessageBox.Show("You have been logged out successfully.",
                    "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }
    }
}