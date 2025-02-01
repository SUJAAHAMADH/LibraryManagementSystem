using LMS.BL;
using LMS.MOD;
using System;
using System.Windows.Forms;

namespace LMS.WIN.Forms
{
    public partial class frmDashboard : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void AddControlToPanel(Control C)
        {
            C.Dock = DockStyle.Fill;
            PnlControl.Controls.Clear();
            PnlControl.Controls.Add(C);
        }

        private void bindUserList(string searchValue = null)
        {
            User data = new User();
            data = UserBL.GetByID(userID);
            if (data != null)
            {
                txtuserName.Text = data.UserName.ToString();
            }
        }

        private void MoveSidePanel(Control btn)
        {
            PnlControl.Controls.Clear();
            SidePanel.Top = btn.Top;
            SidePanel.Height = btn.Height;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnDashboard);
            ManageHome.ManageHome manageHome = new ManageHome.ManageHome();
            manageHome.TopLevel = false;
            PnlControl.Controls.Add(manageHome);
            manageHome.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            PnlControl.Controls.Clear();
            ManageHome.ManageHome manageHome = new ManageHome.ManageHome();
            manageHome.TopLevel = false;
            manageHome.Dock = DockStyle.Fill;
            PnlControl.Controls.Add(manageHome);
            manageHome.Show();
            bindUserList();
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnPublisher);
            ManagePublisher.ManagePublisher managePublisher = new ManagePublisher.ManagePublisher();
            managePublisher.TopLevel = false;
            PnlControl.Controls.Add(managePublisher);
            managePublisher.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnManageBook_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnManageBook);
            ManageBooks.ManageBook manageBook = new ManageBooks.ManageBook();
            manageBook.TopLevel = false;
            PnlControl.Controls.Add(manageBook);
            manageBook.Show();
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnAuthor);
            ManageAuthor.ManageAuthor manageAuthor = new ManageAuthor.ManageAuthor();
            manageAuthor.TopLevel = false;
            PnlControl.Controls.Add(manageAuthor);
            manageAuthor.Show();
        }

        private void btnCandidate_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnCandidate);
            ManageCandidate.ManageCandidates manageCandidate = new ManageCandidate.ManageCandidates();
            manageCandidate.TopLevel = false;
            PnlControl.Controls.Add(manageCandidate);
            manageCandidate.Show();
        }

        private void btnManageLibrarian_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnManageLibrarian);
            ManageUser.ManageLibrarian manageLibrarian = new ManageUser.ManageLibrarian();
            manageLibrarian.TopLevel = false;
            PnlControl.Controls.Add(manageLibrarian);
            manageLibrarian.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnChangePassword);
            frmChangePassword changePassword = new frmChangePassword();
            changePassword.TopLevel = false;
            PnlControl.Controls.Add(changePassword);
            changePassword.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnReport);
            ManageIssuebook manageIssuebook = new ManageIssuebook();
            manageIssuebook.TopLevel = false;
            PnlControl.Controls.Add(manageIssuebook);
            manageIssuebook.Show();
        }

        private void btnbookhistory_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnbookhistory);
            ManageBooks.ManageBookHistory manageBookHistory = new ManageBooks.ManageBookHistory();
            manageBookHistory.TopLevel = false;
            PnlControl.Controls.Add(manageBookHistory);
            manageBookHistory.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnReports);
            Reports.ManageReport manageReport = new Reports.ManageReport();
            manageReport.TopLevel = false;
            PnlControl.Controls.Add(manageReport);
            manageReport.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnCourse);
            ManageCourses.ManageCourse manageCourse = new ManageCourses.ManageCourse();
            manageCourse.TopLevel = false;
            PnlControl.Controls.Add(manageCourse);
            manageCourse.Show();
        }

        private void btnAlerts_Click(object sender, EventArgs e)
        {
            MoveSidePanel(btnAlerts);
            ManageAlerts.ManageAlert manageAlert = new ManageAlerts.ManageAlert();
            manageAlert.TopLevel = false;
            PnlControl.Controls.Add(manageAlert);
            manageAlert.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
