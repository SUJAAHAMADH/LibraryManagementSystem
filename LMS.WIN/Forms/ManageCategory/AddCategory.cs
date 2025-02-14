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

namespace LMS.WIN.Forms.ManageCategory
{
    public partial class AddCategory : Form
    {
  
        private Category _category;
        public AddCategory(Category category)
        {
            InitializeComponent();
            _category = category;
        }
        private void Clear()
        {
           tbSubject.Text = "";
           tbSubject.Focus();

        }

        private void btnCloses_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSubject.Text))
            {
                tbSubject.BackColor = Color.Red;
                tbSubject.ForeColor = Color.White;
                tbSubject.Focus();
                return;
            }

            if (MessageBox.Show("Do You Want To Save the Category?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                    try
                    {
                        Category category = new Category
                        {
                            CategoryID = _category?.CategoryID ?? 0, // Use 0 for new subjects
                            Name = tbSubject.Text.Trim(),
                            ParentID = Convert.ToInt32(comboBoxcategory.SelectedIndex.ToString())
                    };

                    if (_category == null)
                    {
                        category = CategoryBL.Save(category,-1);
                        MessageBox.Show("Category Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        category = CategoryBL.Save(category, (int)category.CategoryID);
                        MessageBox.Show("Category Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public void bindCategory()
        {
            try
            {
                List<Category> categories = new List<Category>();
                categories = CategoryBL.Get();
                if (categories != null)
                {
                    //Insert the Default Item to DataTable.

                    Category category = new Category();
                    category.CategoryID = 0;
                    category.Name = "Select";
                    categories.Insert(0, category);

                    comboBoxcategory.DataSource = categories;
                    comboBoxcategory.ValueMember = "CategoryID";
                    comboBoxcategory.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
            if (_category != null)
            {
                tbSubject.Text = _category.Name;
            }

            bindCategory();
        }


    }
}
