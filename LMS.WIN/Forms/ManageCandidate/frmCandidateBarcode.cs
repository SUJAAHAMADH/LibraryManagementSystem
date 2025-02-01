using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageCandidate
{
    public partial class frmCandidateBarcode : Form
    {
        public frmCandidateBarcode()
        {
            InitializeComponent();
        }

        private void frmCandidateBarcode_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
