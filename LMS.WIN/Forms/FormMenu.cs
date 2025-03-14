﻿using LMS.BL;
using LMS.MOD;
using System;
using System.Drawing;
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
                this.panelContenedor.Controls.RemoveAt(0);  

            Form fh = formHijo as Form;  
            fh.TopLevel = false;  
            fh.FormBorderStyle = FormBorderStyle.None;  
            fh.Dock = DockStyle.Fill;  

            this.panelContenedor.Controls.Add(fh);  
            this.panelContenedor.Tag = fh;  
            fh.Show(); 

        }

        int LX, LY, SW, SH;

        private void btnREPORTES_Click(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void bindUserList(string searchValue = null)
        {
            // Retrieve user data based on userID
            MOD.User data = UserBL.GetByID(userID);
            if (data != null)
            {
                // Display the user's role in lblUser
                txtuserName.Text = data.Role.ToString();
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
            // Toggle the width of MenuVertical
            if (MenuVertical.Width == 60)
            {
                MenuVertical.Width = 260;

                //btnmenu.Image = Properties.Resources.; // Replace with your actual resource name
            }
            else
            {
                MenuVertical.Width = 60;

                //btnmenu.Image = Properties.Resources.YourCollapsedImage; // Replace with your actual resource name
            }

            // Adjust the width of the loaded form if necessary
            if (panelContenedor.Controls.Count > 0)
            {
                Control loadedControl = panelContenedor.Controls[0];
                if (loadedControl is Form loadedForm)
                {
                    string formName = loadedForm.GetType().Name;
                    if (formName == "ManageIssuebook" || formName == "ManageIssuebooks")
                    {
                        loadedForm.Width = panelContenedor.Width;
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
            frmCandidatesReport.TopLevel = false;
            panelContenedor.Controls.Add(frmCandidatesReport);
            frmCandidatesReport.Width = panelContenedor.Width;
            frmCandidatesReport.Height = panelContenedor.Height;
            frmCandidatesReport.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Reports.frmBookWiseReport frmBooksReport = new Reports.frmBookWiseReport();
            frmBooksReport.TopLevel = false;
            panelContenedor.Controls.Add(frmBooksReport);
            frmBooksReport.Width = panelContenedor.Width;
            frmBooksReport.Height = panelContenedor.Height;
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
                if (panel9.Height >= 260)
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
            if (txtuserName.Text == "ADMIN")
            {
                panelContenedor.Controls.Clear();
                ManageUser.ManageLibrarian manageLibrarian = new ManageUser.ManageLibrarian();
                AbrirFormInPanel(manageLibrarian);
            }
            else
            {
      
                MessageBox.Show("You do not have permission to Add a User.");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManageBooks.SearchBooks book = new ManageBooks.SearchBooks();
            AbrirFormInPanel(book);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            ManageCategory.ManageCategory category = new ManageCategory.ManageCategory();
            AbrirFormInPanel(category);

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
