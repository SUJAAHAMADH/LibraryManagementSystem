using LMS.BL;
using LMS.MOD;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LMS.WIN.Search_Control
{
    public partial class frmSearchCountry : Form
    {
        int userID;
        public frmSearchCountry()
        {
            InitializeComponent();
        }

        private void frmSearchCountry_Load(object sender, EventArgs e)
        {
            userID = Convert.ToInt32(GlobalVariable.GlobalUserID);
            txtSearchName.Focus();
            bindCountryList();
        }

        private void bindCountryList(string name = null)
        {
            string searchValue = txtSearchName.Text;
            List<Country> data = null;
            data = CountryBL.Get(-1, searchValue);

            if (data != null)
            {

                gridCountryList.AutoGenerateColumns = false;
                gridCountryList.Refresh();
                gridCountryList.DataSource = data;
                getGridviewByDefaultDesign();
            }
            else
            {
                MessageBox.Show("Country list not found");
                gridCountryList.DataSource = null;
                gridCountryList.AutoGenerateColumns = false;
                gridCountryList.Refresh();
            }
        }

        public void getGridviewByDefaultDesign()
        {
            gridCountryList.ColumnHeadersHeight = 35;
            gridCountryList.BorderStyle = BorderStyle.None;
            gridCountryList.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            gridCountryList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCountryList.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            gridCountryList.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridCountryList.BackgroundColor = Color.White;
            gridCountryList.EnableHeadersVisualStyles = false;
            gridCountryList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridCountryList.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridCountryList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchName.Text;
            bindCountryList(searchValue);
        }

        private void txtSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                GlobalVariable.GlobalCountryObj = null;
            }
            if (e.KeyCode == Keys.Down)
            {
                gridCountryList.Focus();
            }
        }

        private void gridCountryList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtSearchName.Focus();
            }
            if (e.KeyCode == Keys.Enter)
            {
                Country country = new Country();
                country = (Country)gridCountryList.CurrentRow.DataBoundItem;
                if (country != null)
                {
                    GlobalVariable.GlobalCountryObj = country;
                    Close();
                }
                else
                {
                    MessageBox.Show(" No Country list found", "Country list", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gridCountryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridCountryList.Columns[e.ColumnIndex].Name == "Name")
            {
                Country country = new Country();
                country = (Country)gridCountryList.CurrentRow.DataBoundItem;
                if (country != null)
                {
                    GlobalVariable.GlobalCountryObj = country;
                    Close();
                }

            }
            if (gridCountryList.Columns[e.ColumnIndex].Name == "Select")
            {
                Country country = new Country();
                country = (Country)gridCountryList.CurrentRow.DataBoundItem;
                if (country != null)
                {
                    GlobalVariable.GlobalCountryObj = country;
                    Close();
                }

            }
        }
    }
}
