namespace LMS.WIN.Forms.ManageBooks
{
    partial class ManageRenewbook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRenewbook));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrenewbook = new System.Windows.Forms.Button();
            this.dataGridRenewBook = new System.Windows.Forms.DataGridView();
            this.IssueBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookBarcodeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastRenewaledOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfTimeRenewal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.dtStartDateDate = new System.Windows.Forms.DateTimePicker();
            this.dtendDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picboxrefersh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRenewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrefersh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(127, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 23);
            this.txtSearch.TabIndex = 126;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(23, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 14);
            this.label3.TabIndex = 124;
            this.label3.Text = "Add, Edit, Delete your Book through manage Renew Book.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 25);
            this.label4.TabIndex = 123;
            this.label4.Text = "Manage Renew Book";
            // 
            // btnrenewbook
            // 
            this.btnrenewbook.BackColor = System.Drawing.Color.Teal;
            this.btnrenewbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrenewbook.FlatAppearance.BorderSize = 0;
            this.btnrenewbook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrenewbook.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnrenewbook.ForeColor = System.Drawing.Color.White;
            this.btnrenewbook.Location = new System.Drawing.Point(945, 55);
            this.btnrenewbook.Name = "btnrenewbook";
            this.btnrenewbook.Size = new System.Drawing.Size(117, 27);
            this.btnrenewbook.TabIndex = 122;
            this.btnrenewbook.Text = "Renewal Book";
            this.btnrenewbook.UseVisualStyleBackColor = false;
            this.btnrenewbook.Click += new System.EventHandler(this.btnrenewbook_Click);
            // 
            // dataGridRenewBook
            // 
            this.dataGridRenewBook.AllowUserToResizeRows = false;
            this.dataGridRenewBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRenewBook.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRenewBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridRenewBook.ColumnHeadersHeight = 20;
            this.dataGridRenewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridRenewBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssueBookID,
            this.CandidateName,
            this.Name,
            this.BookBarcodeID,
            this.BookBarcode,
            this.CandidateID,
            this.IssuedOn,
            this.ReturnDate,
            this.ReturnedOn,
            this.LastRenewaledOn,
            this.NoOfTimeRenewal,
            this.Remark,
            this.Delete});
            this.dataGridRenewBook.GridColor = System.Drawing.Color.White;
            this.dataGridRenewBook.Location = new System.Drawing.Point(27, 94);
            this.dataGridRenewBook.Name = "dataGridRenewBook";
            this.dataGridRenewBook.ReadOnly = true;
            this.dataGridRenewBook.RowHeadersVisible = false;
            this.dataGridRenewBook.RowHeadersWidth = 60;
            this.dataGridRenewBook.RowTemplate.Height = 30;
            this.dataGridRenewBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRenewBook.Size = new System.Drawing.Size(1035, 420);
            this.dataGridRenewBook.TabIndex = 127;
            // 
            // IssueBookID
            // 
            this.IssueBookID.DataPropertyName = "IssueBookID";
            this.IssueBookID.HeaderText = "IssueBookID";
            this.IssueBookID.MinimumWidth = 6;
            this.IssueBookID.Name = "IssueBookID";
            this.IssueBookID.ReadOnly = true;
            this.IssueBookID.Visible = false;
            // 
            // CandidateName
            // 
            this.CandidateName.DataPropertyName = "CandidateName";
            this.CandidateName.HeaderText = "Candidate Name";
            this.CandidateName.MinimumWidth = 6;
            this.CandidateName.Name = "CandidateName";
            this.CandidateName.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "BookName";
            this.Name.FillWeight = 130F;
            this.Name.HeaderText = "BookName";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // BookBarcodeID
            // 
            this.BookBarcodeID.DataPropertyName = "BookBarcodeID";
            this.BookBarcodeID.HeaderText = "BookBarcodeID";
            this.BookBarcodeID.MinimumWidth = 6;
            this.BookBarcodeID.Name = "BookBarcodeID";
            this.BookBarcodeID.ReadOnly = true;
            this.BookBarcodeID.Visible = false;
            // 
            // BookBarcode
            // 
            this.BookBarcode.DataPropertyName = "BookBarcode";
            this.BookBarcode.HeaderText = "BookBarcode";
            this.BookBarcode.MinimumWidth = 6;
            this.BookBarcode.Name = "BookBarcode";
            this.BookBarcode.ReadOnly = true;
            // 
            // CandidateID
            // 
            this.CandidateID.DataPropertyName = "CandidateID";
            this.CandidateID.HeaderText = "CandidateID";
            this.CandidateID.MinimumWidth = 6;
            this.CandidateID.Name = "CandidateID";
            this.CandidateID.ReadOnly = true;
            this.CandidateID.Visible = false;
            // 
            // IssuedOn
            // 
            this.IssuedOn.DataPropertyName = "IssuedOn";
            this.IssuedOn.HeaderText = "IssuedOn";
            this.IssuedOn.MinimumWidth = 6;
            this.IssuedOn.Name = "IssuedOn";
            this.IssuedOn.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "Estimated Date";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // ReturnedOn
            // 
            this.ReturnedOn.DataPropertyName = "ReturnedOn";
            this.ReturnedOn.HeaderText = "ReturnedOn";
            this.ReturnedOn.MinimumWidth = 6;
            this.ReturnedOn.Name = "ReturnedOn";
            this.ReturnedOn.ReadOnly = true;
            this.ReturnedOn.Visible = false;
            // 
            // LastRenewaledOn
            // 
            this.LastRenewaledOn.DataPropertyName = "RenewalOn";
            this.LastRenewaledOn.HeaderText = "LastRenewaledOn";
            this.LastRenewaledOn.MinimumWidth = 6;
            this.LastRenewaledOn.Name = "LastRenewaledOn";
            this.LastRenewaledOn.ReadOnly = true;
            // 
            // NoOfTimeRenewal
            // 
            this.NoOfTimeRenewal.DataPropertyName = "NoOfTimeRenewal";
            this.NoOfTimeRenewal.HeaderText = "NoOfTimeRenewal";
            this.NoOfTimeRenewal.MinimumWidth = 6;
            this.NoOfTimeRenewal.Name = "NoOfTimeRenewal";
            this.NoOfTimeRenewal.ReadOnly = true;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "Remark";
            this.Remark.MinimumWidth = 6;
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.FillWeight = 30F;
            this.Delete.HeaderText = "Delete";
         
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Delete";
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "Delete";

            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(402, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 32);
            this.button3.TabIndex = 125;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dtStartDateDate
            // 
            this.dtStartDateDate.CustomFormat = "dd-MM-yyyy";
            this.dtStartDateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtStartDateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDateDate.Location = new System.Drawing.Point(618, 19);
            this.dtStartDateDate.Name = "dtStartDateDate";
            this.dtStartDateDate.Size = new System.Drawing.Size(142, 23);
            this.dtStartDateDate.TabIndex = 128;
            // 
            // dtendDate
            // 
            this.dtendDate.CustomFormat = "dd-MM-yyyy";
            this.dtendDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtendDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtendDate.Location = new System.Drawing.Point(849, 19);
            this.dtendDate.Name = "dtendDate";
            this.dtendDate.Size = new System.Drawing.Size(126, 23);
            this.dtendDate.TabIndex = 129;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(981, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 27);
            this.btnSearch.TabIndex = 130;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblStart.Location = new System.Drawing.Point(539, 24);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(73, 17);
            this.lblStart.TabIndex = 131;
            this.lblStart.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(770, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 132;
            this.label1.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 133;
            this.label2.Text = "Search Book";
            // 
            // picboxrefersh
            // 
            this.picboxrefersh.Image = ((System.Drawing.Image)(resources.GetObject("picboxrefersh.Image")));
            this.picboxrefersh.Location = new System.Drawing.Point(324, 25);
            this.picboxrefersh.Name = "picboxrefersh";
            this.picboxrefersh.Size = new System.Drawing.Size(31, 26);
            this.picboxrefersh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxrefersh.TabIndex = 143;
            this.picboxrefersh.TabStop = false;
            this.picboxrefersh.Click += new System.EventHandler(this.picboxrefersh_Click);
            // 
            // ManageRenewbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 582);
            this.Controls.Add(this.picboxrefersh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtendDate);
            this.Controls.Add(this.dtStartDateDate);
            this.Controls.Add(this.dataGridRenewBook);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnrenewbook);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          //  this.Name = "ManageRenewbook";
            this.Load += new System.EventHandler(this.ManageRenewbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRenewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrefersh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnrenewbook;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridRenewBook;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DateTimePicker dtStartDateDate;
        private System.Windows.Forms.DateTimePicker dtendDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picboxrefersh;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookBarcodeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastRenewaledOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoOfTimeRenewal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}