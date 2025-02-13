using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LMS.WIN.Forms.ManageDue
{
    public partial class frmManageDue : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        public frmManageDue()
        {
            InitializeComponent();
        }

        private void frmManageDue_Load(object sender, EventArgs e)
        {

        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
