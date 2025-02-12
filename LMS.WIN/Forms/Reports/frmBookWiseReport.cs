using LMS.BL;
using LMS.DAL.Shared;
using LMS.MOD;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;


namespace LMS.WIN.Forms.Reports
{
    public partial class frmBookWiseReport : Form
    {
        int userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
        Book bookObj = null;
        public frmBookWiseReport()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetBookList();
        }

        private void FrmBookWiseReport_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadAuther();
            LoadPublication();
            ResetBookList();
        }
        private void LoadCategory()
        {
            try
            {
                using (SqlConnection con = SqlConnectionHelper.GetConnectionSync())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open(); // Open the connection only if it's not already open
                    }

                    string query = "SELECT CategoryID, Name FROM Category ORDER BY Name";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adp.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                cbSubject.DataSource = dt;
                                cbSubject.DisplayMember = "Name";
                                cbSubject.ValueMember = "CategoryID";
                                cbSubject.SelectedIndex = -1;
                            }
                            else
                            {
                                MessageBox.Show("No subjects found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cbSubject.DataSource = null;
                            }
                        }
                    }
                } // The using statement ensures the connection is closed properly
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Subjects: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAuther()
        {
            try
            {
                using (SqlConnection con = SqlConnectionHelper.GetConnectionSync())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open(); // Open the connection only if it's not already open
                    }

                    string query = "SELECT AuthorID, Name FROM Author ORDER BY Name";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adp.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                cbAuther.DataSource = dt;
                                cbAuther.DisplayMember = "Name";
                                cbAuther.ValueMember = "AuthorID";
                                cbAuther.SelectedIndex = -1;
                            }
                            else
                            {
                                MessageBox.Show("No authors found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cbAuther.DataSource = null;
                            }
                        }
                    }
                } // The using statement ensures the connection is closed properly
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Author: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPublication()
        {
            try
            {
                using (SqlConnection con = SqlConnectionHelper.GetConnectionSync())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open(); // Open the connection only if it's not already open
                    }

                    string query = "SELECT PublisherID, Name FROM Publisher ORDER BY Name";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adp.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                cbPublication.DataSource = dt;
                                cbPublication.DisplayMember = "Name";
                                cbPublication.ValueMember = "PublisherID";
                                cbPublication.SelectedIndex = -1;
                            }
                            else
                            {
                                MessageBox.Show("No Publishers found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cbPublication.DataSource = null;
                            }
                        }
                    }
                } // The using statement ensures the connection is closed properly
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Publisher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ResetBookList()
        {
            List<Book> data = null;
            data = ReportBL.GetBookWiseReport(-1, -1, -1, -1, -1);
            if (data != null)
            {
                dataGridBook.AutoGenerateColumns = false;
                dataGridBook.DataSource = data;
                dataGridBook.Refresh();
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("book list not found");
                dataGridBook.DataSource = null;
                dataGridBook.AutoGenerateColumns = false;
                dataGridBook.Refresh();
            }
            cbSubject.Text = "";
            cbPublication.Text = "";
            cbAuther.Text = "";
            cbSubject.Focus();
        }
        private void SortBookList()
        {
           
        }





        public void getGridviewByDefaultDesign()
        {
            dataGridBook.ColumnHeadersHeight = 35;
            dataGridBook.BorderStyle = BorderStyle.None;
            dataGridBook.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 246, 255);
            dataGridBook.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridBook.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 123, 255); // Bright Blue
            dataGridBook.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridBook.BackgroundColor = Color.FromArgb(245, 247, 250);
            dataGridBook.EnableHeadersVisualStyles = false;
            dataGridBook.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridBook.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 53, 147); // Darker Blue
            dataGridBook.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



            // Center align columns' content
            foreach (DataGridViewColumn column in dataGridBook.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridBook.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbCategory_Click(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(cbSubject.SelectedValue); // Get the selected CategoryID from cbSubject

            if (categoryId > 0) // Check if a category is selected
            {
                try
                {
                    // Retrieve the filtered list based on selected category
                    List<Book> filteredBooks = ReportBL.GetBookWiseReport(userID, -1, -1, -1, categoryId); // Add other parameters if needed

                    if (filteredBooks != null && filteredBooks.Count > 0)
                    {
                        dataGridBook.AutoGenerateColumns = false;
                        dataGridBook.DataSource = filteredBooks;
                        dataGridBook.Refresh();
                        getGridviewByDefaultDesign(); // Optional, to retain grid style
                    }
                    else
                    {
                        MessageBox.Show("No books found for the selected category.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridBook.DataSource = null;
                        dataGridBook.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error filtering books by category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a category first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbAuthor_Click(object sender, EventArgs e)
        {
            int authorId = Convert.ToInt32(cbAuther.SelectedValue); // Get the selected CategoryID from cbSubject

            if (authorId > 0) // Check if a category is selected
            {
                try
                {
                    // Retrieve the filtered list based on selected category
                    List<Book> filteredBooks = ReportBL.GetBookWiseReport(userID, authorId, -1, -1, -1); // Add other parameters if needed

                    if (filteredBooks != null && filteredBooks.Count > 0)
                    {
                        dataGridBook.AutoGenerateColumns = false;
                        dataGridBook.DataSource = filteredBooks;
                        dataGridBook.Refresh();
                        getGridviewByDefaultDesign(); // Optional, to retain grid style
                    }
                    else
                    {
                        MessageBox.Show("No books found for the selected Auther.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridBook.DataSource = null;
                        dataGridBook.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error filtering books by Auther: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a auther first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pbPublication_Click(object sender, EventArgs e)
        {

            int publisherId = Convert.ToInt32(cbPublication.SelectedValue); // Get the selected CategoryID from cbSubject

            if (publisherId > 0) // Check if a category is selected
            {
                try
                {
                    // Retrieve the filtered list based on selected category
                    List<Book> filteredBooks = ReportBL.GetBookWiseReport(userID, -1, publisherId, -1, -1); // Add other parameters if needed

                    if (filteredBooks != null && filteredBooks.Count > 0)
                    {
                        dataGridBook.AutoGenerateColumns = false;
                        dataGridBook.DataSource = filteredBooks;
                        dataGridBook.Refresh();
                        getGridviewByDefaultDesign(); // Optional, to retain grid style
                    }
                    else
                    {
                        MessageBox.Show("No books found for the selected publisher.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridBook.DataSource = null;
                        dataGridBook.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error filtering books by publisher: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a publisher first.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
