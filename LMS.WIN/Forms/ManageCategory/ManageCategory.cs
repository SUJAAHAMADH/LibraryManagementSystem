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

namespace LMS.WIN.Forms.ManageCategory
{
    public partial class ManageCategory : Form
    {
        public ManageCategory()
        {
            InitializeComponent();
        }

        private void ManageSubject_Load(object sender, EventArgs e)
        {
            bindSubjectList();
        }

        private void bindSubjectList()
        {
            List<Category> data = null;
            data = new List<Category>();
            data = CategoryBL.GetAll();
            if (data != null)
            {
                dataGridBook.AutoGenerateColumns = false;
                dataGridBook.DataSource = data;
                dataGridBook.Refresh();
                //getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Category not found");
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
            AddCategory addCategory = new AddCategory(null);
            addCategory.ShowDialog();
            bindSubjectList();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //string searchValue = txtSearch.Text;
            //bindSubjectList(searchValue);
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
                if (MessageBox.Show("Do you want to Delete the Category?", "Category?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (dgvRow != null)
                    {
                        int scategoryId = Convert.ToInt32(dgvRow.Cells["CategoryID"].Value);

                        Category category = new Category
                        {
                            CategoryID = scategoryId
                        };

                        CategoryBL.Deactive(category);

                        MessageBox.Show("Category removed successfully.");
                        bindSubjectList();
                    }
                }
            }

            else if (dataGridBook.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (dgvRow != null)
                {
                    int categoryId = dgvRow.Cells["CategoryID"].Value == DBNull.Value ? -1 : Convert.ToInt32(dgvRow.Cells["CategoryID"].Value);
                    string name = dgvRow.Cells["Name"].Value?.ToString() ?? string.Empty;
                    int parentCategory = dgvRow.Cells["ParentName"].Value?.ToString() == "Technical" ? 1 : 2;

                    Category category = new Category
                    {
                        CategoryID = categoryId,
                        Name = name,
                        ParentID = parentCategory

                    };
                    AddCategory addCategory = new AddCategory(category);
                    addCategory.ShowDialog();
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
