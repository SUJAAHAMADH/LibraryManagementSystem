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
            if (panelHr.Visible == false)
            {
                panelHr.Visible = true;
            }
            else

                panelHr.Visible = false;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            panelHr.Visible = false;
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
                panelHr.Visible = false;
            }

              
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnEMPLEADOS_Click(object sender, EventArgs e)
        {
            ManageCandidate.ManageCandidates frmmanageCandidate = new ManageCandidate.ManageCandidates();
            //frm.FormClosed += new FormClosedEventHandler(mostrarlogoAlCerrarForm);
            AbrirFormInPanel(frmmanageCandidate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageIssuebook manageIssueBook = new ManageIssuebook();
            AbrirFormInPanel(manageIssueBook);
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
