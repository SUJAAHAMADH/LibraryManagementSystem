using LMS.BL;
using LMS.MOD;
using LMS.WIN.Forms.ManageJournal;
using LMS.WIN.Forms.ManageVolume;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS.WIN.Forms.ManageSubject
{
    public partial class ManageSubject : Form
    {
        public ManageSubject()
        {
            InitializeComponent();
        }

        private void ManageSubject_Load(object sender, EventArgs e)
        {
            bindSubjectList();
        }

        private void bindSubjectList(string name = null)
        {
            string searchValue = txtSearch.Text;
            List<Subject> data = null;
            data = SubjectBL.Get(-1,null);
            if (data != null)
            {
                dataGridBook.AutoGenerateColumns = false;
                dataGridBook.DataSource = data;
                dataGridBook.Refresh();
                //getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Subject not found");
                dataGridBook.DataSource = null;
                dataGridBook.AutoGenerateColumns = false;
                dataGridBook.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            dataGridBook.ColumnHeadersHeight = 35;
            dataGridBook.BorderStyle = BorderStyle.None;
            dataGridBook.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridBook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridBook.DefaultCellStyle.SelectionBackColor = Color.Teal;
            dataGridBook.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridBook.BackgroundColor = Color.White;
            dataGridBook.EnableHeadersVisualStyles = false;
            dataGridBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 58);
            dataGridBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnAddNewJournal_Click(object sender, EventArgs e)
        {
            AddSubject addSubject = new AddSubject(null);
            addSubject.ShowDialog();
            bindSubjectList();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            bindSubjectList(searchValue);
        }

        private void dataGridBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a row is selected
            DataGridViewRow dgvRow = dataGridBook.CurrentRow;
            if (dgvRow == null)
            {
                MessageBox.Show("No row selected.");
                return;
            }
            else if (dataGridBook.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Do you want to Deactivate the Subject?", "Subject?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (dgvRow != null)
                    {
                        int subjectId = Convert.ToInt32(dgvRow.Cells["SubjectID"].Value);

                        Subject subject = new Subject
                        {
                            SubjectID = subjectId
                        };

                        SubjectBL.Deactive(subject);

                        MessageBox.Show("Subject deactivated successfully.");
                        bindSubjectList();
                    }
                }
            }

            else if (dataGridBook.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (dgvRow != null)
                {
                    int subjectId = dgvRow.Cells["SubjectID"].Value == DBNull.Value ? -1 : Convert.ToInt32(dgvRow.Cells["SubjectID"].Value);
                    string name = dgvRow.Cells["Name"].Value?.ToString() ?? string.Empty;

                    Subject subject = new Subject
                    {
                        SubjectID = subjectId,
                        Name = name,
 
                        
                    };
                    AddSubject addSubject = new AddSubject(subject);
                    addSubject.ShowDialog();
                    bindSubjectList();
                }
            }
           
        }

        private void picboxrefersh_Click(object sender, EventArgs e)
        {
            bindSubjectList();
        }
    }
}
