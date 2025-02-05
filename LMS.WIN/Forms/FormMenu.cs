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
        public FormMenu()
        {
            InitializeComponent();
        }

        bool expend = false;
        bool expend1 = false;

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

        private void FormMenu_Load(object sender, EventArgs e)
        {
            MenuVertical.Width = 260;
        }

        private void button5_Click(object sender, EventArgs e)
        {
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

              
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnEMPLEADOS_Click(object sender, EventArgs e)
        {
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
            if (expend == false)
            {
                reportPanel.Height += 40;
                if (reportPanel.Height >= 220)
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
            ManageBooks.ManageBookHistory manageBookHistory = new ManageBooks.ManageBookHistory();
            AbrirFormInPanel(manageBookHistory);
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
