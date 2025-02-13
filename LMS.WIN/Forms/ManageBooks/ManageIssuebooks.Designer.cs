namespace LMS.WIN.Forms.ManageBooks
{
    partial class ManageIssuebooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageIssuebooks));
            this.dataGridissueBook = new System.Windows.Forms.DataGridView();
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnissuebook = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxrefersh = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtendDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDateDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridissueBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrefersh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridissueBook
            // 
            this.dataGridissueBook.AllowUserToResizeColumns = false;
            this.dataGridissueBook.AllowUserToResizeRows = false;
            this.dataGridissueBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridissueBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridissueBook.BackgroundColor = System.Drawing.Color.White;
            this.dataGridissueBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridissueBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridissueBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridissueBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridissueBook.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridissueBook.EnableHeadersVisualStyles = false;
            this.dataGridissueBook.GridColor = System.Drawing.Color.White;
            this.dataGridissueBook.Location = new System.Drawing.Point(17, 164);
            this.dataGridissueBook.Name = "dataGridissueBook";
            this.dataGridissueBook.ReadOnly = true;
            this.dataGridissueBook.RowHeadersVisible = false;
            this.dataGridissueBook.RowHeadersWidth = 60;
            this.dataGridissueBook.RowTemplate.Height = 30;
            this.dataGridissueBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridissueBook.Size = new System.Drawing.Size(1040, 210);
            this.dataGridissueBook.TabIndex = 123;
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
            this.CandidateName.DataPropertyName = "CandidateNames";
            this.CandidateName.HeaderText = "Candidate Name";
            this.CandidateName.MinimumWidth = 6;
            this.CandidateName.Name = "CandidateName";
            this.CandidateName.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "BookName";
            this.Name.HeaderText = "Book Name";
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
            this.BookBarcode.FillWeight = 60F;
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
            this.IssuedOn.FillWeight = 40F;
            this.IssuedOn.HeaderText = "IssuedOn";
            this.IssuedOn.MinimumWidth = 6;
            this.IssuedOn.Name = "IssuedOn";
            this.IssuedOn.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.FillWeight = 60F;
            this.ReturnDate.HeaderText = "Estimated Date";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // ReturnedOn
            // 
            this.ReturnedOn.DataPropertyName = "ReturnedOn";
            this.ReturnedOn.FillWeight = 40F;
            this.ReturnedOn.HeaderText = "ReturnedOn";
            this.ReturnedOn.MinimumWidth = 6;
            this.ReturnedOn.Name = "ReturnedOn";
            this.ReturnedOn.ReadOnly = true;
            this.ReturnedOn.Visible = false;
            // 
            // LastRenewaledOn
            // 
            this.LastRenewaledOn.DataPropertyName = "LastRenewaledOn";
            this.LastRenewaledOn.FillWeight = 23.08601F;
            this.LastRenewaledOn.HeaderText = "LastRenewaledOn";
            this.LastRenewaledOn.MinimumWidth = 6;
            this.LastRenewaledOn.Name = "LastRenewaledOn";
            this.LastRenewaledOn.ReadOnly = true;
            this.LastRenewaledOn.Visible = false;
            // 
            // NoOfTimeRenewal
            // 
            this.NoOfTimeRenewal.DataPropertyName = "NoOfTimeRenewal";
            this.NoOfTimeRenewal.FillWeight = 23.08601F;
            this.NoOfTimeRenewal.HeaderText = "NoOfTimeRenewal";
            this.NoOfTimeRenewal.MinimumWidth = 6;
            this.NoOfTimeRenewal.Name = "NoOfTimeRenewal";
            this.NoOfTimeRenewal.ReadOnly = true;
            this.NoOfTimeRenewal.Visible = false;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.FillWeight = 87.37048F;
            this.Remark.HeaderText = "Remark";
            this.Remark.MinimumWidth = 6;
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.FillWeight = 26.21115F;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(130, 111);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(146, 26);
            this.txtSearch.TabIndex = 122;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.label3.Location = new System.Drawing.Point(28, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 15);
            this.label3.TabIndex = 120;
            this.label3.Text = "Add, Edit, Delete your Book through manage issue Book.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.label4.Location = new System.Drawing.Point(28, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 24);
            this.label4.TabIndex = 119;
            this.label4.Text = "Manage Issue Book";
            // 
            // btnissuebook
            // 
            this.btnissuebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnissuebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnissuebook.FlatAppearance.BorderSize = 0;
            this.btnissuebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnissuebook.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnissuebook.ForeColor = System.Drawing.Color.White;
            this.btnissuebook.Location = new System.Drawing.Point(946, 54);
            this.btnissuebook.Name = "btnissuebook";
            this.btnissuebook.Size = new System.Drawing.Size(111, 33);
            this.btnissuebook.TabIndex = 118;
            this.btnissuebook.Text = "Issue Book";
            this.btnissuebook.UseVisualStyleBackColor = false;
            this.btnissuebook.Click += new System.EventHandler(this.btnissuebook_Click);
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
            this.button3.Location = new System.Drawing.Point(282, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 27);
            this.button3.TabIndex = 121;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(25, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 124;
            this.label1.Text = "Search Book";
            // 
            // picboxrefersh
            // 
            this.picboxrefersh.Image = ((System.Drawing.Image)(resources.GetObject("picboxrefersh.Image")));
            this.picboxrefersh.Location = new System.Drawing.Point(360, 20);
            this.picboxrefersh.Name = "picboxrefersh";
            this.picboxrefersh.Size = new System.Drawing.Size(40, 35);
            this.picboxrefersh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxrefersh.TabIndex = 126;
            this.picboxrefersh.TabStop = false;
            this.picboxrefersh.Click += new System.EventHandler(this.picboxrefersh_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.label2.Location = new System.Drawing.Point(665, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 137;
            this.label2.Text = "End Date";
            // 
            // lblStart
            // 
            this.lblStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.lblStart.Location = new System.Drawing.Point(378, 115);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(81, 19);
            this.lblStart.TabIndex = 136;
            this.lblStart.Text = "Start Date";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(946, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 33);
            this.btnSearch.TabIndex = 135;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtendDate
            // 
            this.dtendDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtendDate.CustomFormat = "dd-MM-yyyy";
            this.dtendDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtendDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtendDate.Location = new System.Drawing.Point(754, 111);
            this.dtendDate.Name = "dtendDate";
            this.dtendDate.Size = new System.Drawing.Size(186, 26);
            this.dtendDate.TabIndex = 134;
            // 
            // dtStartDateDate
            // 
            this.dtStartDateDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtStartDateDate.CustomFormat = "dd-MM-yyyy";
            this.dtStartDateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDateDate.Location = new System.Drawing.Point(474, 111);
            this.dtStartDateDate.Name = "dtStartDateDate";
            this.dtStartDateDate.Size = new System.Drawing.Size(186, 26);
            this.dtStartDateDate.TabIndex = 133;
            // 
            // ManageIssuebooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtendDate);
            this.Controls.Add(this.dtStartDateDate);
            this.Controls.Add(this.picboxrefersh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridissueBook);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnissuebook);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageIssuebooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManageIssuebooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridissueBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrefersh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridissueBook;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnissuebook;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picboxrefersh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtendDate;
        private System.Windows.Forms.DateTimePicker dtStartDateDate;
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