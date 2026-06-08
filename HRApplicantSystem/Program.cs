using System;
using System.Windows.Forms;
using HRApplicantSystem.Forms;

namespace HRApplicantSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ApplicantLoginForm());
        }
    }
}