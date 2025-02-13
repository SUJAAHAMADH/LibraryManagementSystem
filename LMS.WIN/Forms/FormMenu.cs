using LMS.BL;
using LMS.MOD;
using LMS.WIN.Forms.Login;
using LMS.WIN.Forms.ManageAuthor;
using LMS.WIN.Forms.ManageBooks;
using LMS.WIN.Forms.ManagePublisher;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.WIN.Forms
{
    public partial class FormMenu : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        public FormMenu()
        {
            InitializeComponent();
        }

        bool expend = false;
        bool expend1 = false;
        bool expend2 = false;

        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);  // Remove the existing form, if any

            Form fh = formHijo as Form;  // Cast the passed form to a Form object
            fh.TopLevel = false;  // Make the form a child control of the panel
            fh.FormBorderStyle = FormBorderStyle.None;  // Remove the form border
            fh.Dock = DockStyle.Fill;  // Ensure the form fills the entire panel

            this.panelContenedor.Controls.Add(fh);  // Add the form to the panel
            this.panelContenedor.Tag = fh;  // Optional: Store a reference to the form (if needed)
            fh.Show();  // Show the form

        }

        int LX, LY, SW, SH;

        private void btnREPORTES_Click(object sender, EventArgs e)
        {
           timer1.Start();
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

        private void FormMenu_Load(object sender, EventArgs e)
        {
            MenuVertical.Width = 260;
            bindUserList();
            panelContenedor.Controls.Clear();
            ManageHome.ManageHome manageHome = new ManageHome.ManageHome();
            manageHome.TopLevel = false;
            manageHome.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(manageHome);
            manageHome.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManageHome.ManageHome frmmanageHome = new ManageHome.ManageHome();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frmmanageHome);
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {

        }

        private void iconCerrar_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You want to close this Application?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //tus codigos
                Application.Exit();
            }
            else
            {
                //tus codigos
            }
        }

        private void iconrestaurar_Click_1(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(SW, SH);
            this.Location = new Point(LX, LY);
            iconmaximizar.Visible = true;
            iconrestaurar.Visible = false;
        }

        private void iconMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmenu_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 53)
            {
                MenuVertical.Width = 260;
            }
            else
            {
                MenuVertical.Width = 53;          
            }
            if (panelContenedor.Controls.Count > 0)
            {
                // Get the currently loaded form (first control in the panel)
                Control loadedControl = panelContenedor.Controls[0];

                // Check if the loaded control is a form (or a specific type of form)
                if (loadedControl is Form)
                {
                    Form loadedForm = (Form)loadedControl;
                    string formName = loadedForm.GetType().Name;  // or loadedForm.GetType().Name to get the form's class name
                    switch (formName) {
                        case "ManageIssuebook":
                        case "ManageIssuebooks":
                            loadedForm.Width = panelContenedor.Width;
                            break;
                    }
                    
                                    
                }
            }
            

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnEMPLEADOS_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManageCandidate.ManageCandidates frmmanageCandidate = new ManageCandidate.ManageCandidates();
            AbrirFormInPanel(frmmanageCandidate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void iconmaximizar_Click_1(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;
        }

        private void btnManageBook_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManageBooks.ManageBook manageBooks = new ManageBooks.ManageBook();
            AbrirFormInPanel(manageBooks);
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (expend == false )
            {
                panelBookManagement.Height += 20;
                if (panelBookManagement.Height >= 160)
                {
                    menuTransition.Stop();
                    expend = true;
                }
            }
            else
            {
                panelBookManagement.Height -= 20;
                if (panelBookManagement.Height <= 60)
                {
                    menuTransition.Stop();
                    expend = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expend1 == false)
            {
                reportPanel.Height += 40;
                if (reportPanel.Height >= 210)
                {
                    timer1.Stop();
                    expend1 = true;
                }
            }
            else
            {
                reportPanel.Height -= 40;
                if (reportPanel.Height <= 60)
                {
                    timer1.Stop();
                    expend1 = false;
                }
            }
        }

        private void btnBookHistory_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManageBooks.ManageBookHistory manageBookHistory = new ManageBooks.ManageBookHistory();
            AbrirFormInPanel(manageBookHistory);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Logout?", "User Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                Login.frmLogin formLogin = new Login.frmLogin();
                formLogin.Show();
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManageBooks.ManageIssuebook manageIssuebook = new ManageBooks.ManageIssuebook();
            manageIssuebook.TopLevel = false;
            panelContenedor.Controls.Add(manageIssuebook);
            manageIssuebook.Width = panelContenedor.Width;
            manageIssuebook.Height = panelContenedor.Height;
            manageIssuebook.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Reports.frmCandidatesReport frmCandidatesReport = new Reports.frmCandidatesReport();
            AbrirFormInPanel(frmCandidatesReport);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Reports.frmBookWiseReport frmBooksReport = new Reports.frmBookWiseReport();
            frmBooksReport.TopLevel = false;
            panelContenedor.Controls.Add(frmBooksReport);
            frmBooksReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Reports.frmBookTransactionReport manageReport = new Reports.frmBookTransactionReport();
            manageReport.TopLevel = false;
            panelContenedor.Controls.Add(manageReport);
            manageReport.Show();
        }

        private void MasterTimer_Tick(object sender, EventArgs e)
        {
            if (expend2 == false)
            {
                panel9.Height += 40;
                if (panel9.Height >= 205)
                {
                    MasterTimer.Stop();
                    expend2 = true;
                }
            }
            else
            {
                panel9.Height -= 40;
                if (panel9.Height <= 60)
                {
                    MasterTimer.Stop();
                    expend2 = false;
                }
            }       
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MasterTimer.Start();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManageAuthor.ManageAuthor manageAuthor = new ManageAuthor.ManageAuthor();
            AbrirFormInPanel(manageAuthor);
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManagePublisher.ManagePublisher managePublisher = new ManagePublisher.ManagePublisher();
            AbrirFormInPanel(managePublisher);


        }

        private void button13_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManageSubject.ManageSubject manageSubject = new ManageSubject.ManageSubject();
            AbrirFormInPanel(manageSubject);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManageJournal.ManageJournal manageJournal = new ManageJournal.ManageJournal();
            AbrirFormInPanel(manageJournal);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManageUser.ManageLibrarian manageLibrarian = new ManageUser.ManageLibrarian();
            AbrirFormInPanel(manageLibrarian);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManageBooks.SearchBooks book = new ManageBooks.SearchBooks();
            AbrirFormInPanel(book);

        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            SW = this.Size.Width;
            SH = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;
        }
        private void iconrestaurar_Click(object sender, EventArgs e)
        {
   
        }
    }
}
