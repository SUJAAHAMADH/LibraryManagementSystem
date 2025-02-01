namespace LMS.WIN.Forms.ManageBooks
{
    partial class frmRenewalBook
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloses = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubCategory = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtbookName = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.richtextRemark = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.dataGridissueBook = new System.Windows.Forms.DataGridView();
            this.IssueBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.picThumb = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridissueBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnCloses);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 37);
            this.panel2.TabIndex = 96;
            // 
            // btnCloses
            // 
            this.btnCloses.BackColor = System.Drawing.Color.Teal;
            this.btnCloses.FlatAppearance.BorderSize = 0;
            this.btnCloses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloses.ForeColor = System.Drawing.Color.White;
            this.btnCloses.Location = new System.Drawing.Point(911, 7);
            this.btnCloses.Name = "btnCloses";
            this.btnCloses.Size = new System.Drawing.Size(29, 26);
            this.btnCloses.TabIndex = 24;
            this.btnCloses.Text = "X";
            this.btnCloses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloses.UseVisualStyleBackColor = false;
            this.btnCloses.Click += new System.EventHandler(this.btnCloses_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Book Renewal Here";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 492);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(934, 5);
            this.panel4.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(939, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 460);
            this.panel3.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 460);
            this.panel1.TabIndex = 98;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtType);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtSubCategory);
            this.panel5.Controls.Add(this.txtRole);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.lblBarcode);
            this.panel5.Controls.Add(this.txtbookName);
            this.panel5.Controls.Add(this.btnCapture);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtLanguage);
            this.panel5.Controls.Add(this.txtPublisher);
            this.panel5.Controls.Add(this.txtAuthor);
            this.panel5.Controls.Add(this.lblLanguage);
            this.panel5.Controls.Add(this.lblPublisher);
            this.panel5.Controls.Add(this.lblAuthor);
            this.panel5.Controls.Add(this.txtContactNumber);
            this.panel5.Controls.Add(this.txtName);
            this.panel5.Controls.Add(this.lblContactNumber);
            this.panel5.Controls.Add(this.lblName);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.closebutton);
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Controls.Add(this.richtextRemark);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.dtReturnDate);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtBarcode);
            this.panel5.Location = new System.Drawing.Point(12, 193);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(921, 296);
            this.panel5.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(631, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 157;
            this.label2.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtType.ForeColor = System.Drawing.Color.Black;
            this.txtType.Location = new System.Drawing.Point(688, 191);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(13, 19);
            this.txtType.TabIndex = 156;
            this.txtType.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(567, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 155;
            this.label6.Text = "Sub-Category:";
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.AutoSize = true;
            this.txtSubCategory.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtSubCategory.ForeColor = System.Drawing.Color.Black;
            this.txtSubCategory.Location = new System.Drawing.Point(688, 217);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(13, 19);
            this.txtSubCategory.TabIndex = 154;
            this.txtSubCategory.Text = ".";
            // 
            // txtRole
            // 
            this.txtRole.AutoSize = true;
            this.txtRole.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtRole.Location = new System.Drawing.Point(172, 123);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(13, 19);
            this.txtRole.TabIndex = 153;
            this.txtRole.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 152;
            this.label1.Text = "Role:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label16.Location = new System.Drawing.Point(47, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 19);
            this.label16.TabIndex = 149;
            this.label16.Text = "Estimated Date:";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblBarcode.Location = new System.Drawing.Point(7, 20);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(213, 19);
            this.lblBarcode.TabIndex = 148;
            this.lblBarcode.Text = "Enter Barcode And Press Enter";
            // 
            // txtbookName
            // 
            this.txtbookName.AutoSize = true;
            this.txtbookName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtbookName.Location = new System.Drawing.Point(689, 75);
            this.txtbookName.Name = "txtbookName";
            this.txtbookName.Size = new System.Drawing.Size(13, 19);
            this.txtbookName.TabIndex = 147;
            this.txtbookName.Text = ".";
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.Teal;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapture.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.Location = new System.Drawing.Point(767, 10);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(120, 29);
            this.btnCapture.TabIndex = 129;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(621, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 146;
            this.label4.Text = "Name:";
            // 
            // txtLanguage
            // 
            this.txtLanguage.AutoSize = true;
            this.txtLanguage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtLanguage.Location = new System.Drawing.Point(688, 165);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(13, 19);
            this.txtLanguage.TabIndex = 145;
            this.txtLanguage.Text = ".";
            // 
            // txtPublisher
            // 
            this.txtPublisher.AutoSize = true;
            this.txtPublisher.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtPublisher.Location = new System.Drawing.Point(689, 140);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(13, 19);
            this.txtPublisher.TabIndex = 143;
            this.txtPublisher.Text = ".";
            // 
            // txtAuthor
            // 
            this.txtAuthor.AutoSize = true;
            this.txtAuthor.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtAuthor.Location = new System.Drawing.Point(689, 108);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(13, 19);
            this.txtAuthor.TabIndex = 142;
            this.txtAuthor.Text = ".";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblLanguage.Location = new System.Drawing.Point(597, 165);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(84, 19);
            this.lblLanguage.TabIndex = 141;
            this.lblLanguage.Text = "Language:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblPublisher.Location = new System.Drawing.Point(603, 140);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(73, 19);
            this.lblPublisher.TabIndex = 139;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblAuthor.Location = new System.Drawing.Point(618, 108);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(58, 19);
            this.lblAuthor.TabIndex = 138;
            this.lblAuthor.Text = "Author:";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.AutoSize = true;
            this.txtContactNumber.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtContactNumber.Location = new System.Drawing.Point(172, 93);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(13, 19);
            this.txtContactNumber.TabIndex = 135;
            this.txtContactNumber.Text = ".";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtName.Location = new System.Drawing.Point(172, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(13, 19);
            this.txtName.TabIndex = 134;
            this.txtName.Text = ".";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblContactNumber.Location = new System.Drawing.Point(72, 93);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(94, 19);
            this.lblContactNumber.TabIndex = 131;
            this.lblContactNumber.Text = "Contact No:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblName.Location = new System.Drawing.Point(111, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 19);
            this.lblName.TabIndex = 130;
            this.lblName.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(39, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 17);
            this.label11.TabIndex = 129;
            this.label11.Text = "Candidate Details:";
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Teal;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closebutton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.closebutton.ForeColor = System.Drawing.Color.White;
            this.closebutton.Location = new System.Drawing.Point(767, 255);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(120, 29);
            this.closebutton.TabIndex = 128;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(641, 255);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 29);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "Renew";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // richtextRemark
            // 
            this.richtextRemark.Location = new System.Drawing.Point(176, 191);
            this.richtextRemark.Name = "richtextRemark";
            this.richtextRemark.Size = new System.Drawing.Size(308, 62);
            this.richtextRemark.TabIndex = 126;
            this.richtextRemark.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(101, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 125;
            this.label3.Text = "Remark:";
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.CustomFormat = "dd-MM-yyyy";
            this.dtReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReturnDate.Location = new System.Drawing.Point(176, 153);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(308, 23);
            this.dtReturnDate.TabIndex = 124;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(551, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 122;
            this.label8.Text = "Book Details:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(226, 20);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(308, 23);
            this.txtBarcode.TabIndex = 120;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown_1);
            // 
            // dataGridissueBook
            // 
            this.dataGridissueBook.AllowUserToResizeColumns = false;
            this.dataGridissueBook.AllowUserToResizeRows = false;
            this.dataGridissueBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridissueBook.BackgroundColor = System.Drawing.Color.White;
            this.dataGridissueBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridissueBook.ColumnHeadersHeight = 20;
            this.dataGridissueBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridissueBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssueBookID,
            this.BookID,
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
            this.Select});
            this.dataGridissueBook.GridColor = System.Drawing.Color.White;
            this.dataGridissueBook.Location = new System.Drawing.Point(15, 43);
            this.dataGridissueBook.Name = "dataGridissueBook";
            this.dataGridissueBook.ReadOnly = true;
            this.dataGridissueBook.RowHeadersVisible = false;
            this.dataGridissueBook.RowHeadersWidth = 60;
            this.dataGridissueBook.RowTemplate.Height = 30;
            this.dataGridissueBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridissueBook.Size = new System.Drawing.Size(721, 144);
            this.dataGridissueBook.TabIndex = 130;
            this.dataGridissueBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridissueBook_CellContentClick);
            // 
            // IssueBookID
            // 
            this.IssueBookID.DataPropertyName = "IssueBookID";
            this.IssueBookID.HeaderText = "IssueBookID";
            this.IssueBookID.Name = "IssueBookID";
            this.IssueBookID.ReadOnly = true;
            this.IssueBookID.Visible = false;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Visible = false;
            // 
            // CandidateName
            // 
            this.CandidateName.DataPropertyName = "CandidateNames";
            this.CandidateName.HeaderText = "CandidateName";
            this.CandidateName.Name = "CandidateName";
            this.CandidateName.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "BookName";
            this.Name.HeaderText = "Book Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // BookBarcodeID
            // 
            this.BookBarcodeID.DataPropertyName = "BookBarcodeID";
            this.BookBarcodeID.HeaderText = "BookBarcodeID";
            this.BookBarcodeID.Name = "BookBarcodeID";
            this.BookBarcodeID.ReadOnly = true;
            this.BookBarcodeID.Visible = false;
            // 
            // BookBarcode
            // 
            this.BookBarcode.DataPropertyName = "BookBarcode";
            this.BookBarcode.FillWeight = 87.37048F;
            this.BookBarcode.HeaderText = "BookBarcode";
            this.BookBarcode.Name = "BookBarcode";
            this.BookBarcode.ReadOnly = true;
            // 
            // CandidateID
            // 
            this.CandidateID.DataPropertyName = "CandidateID";
            this.CandidateID.HeaderText = "CandidateID";
            this.CandidateID.Name = "CandidateID";
            this.CandidateID.ReadOnly = true;
            this.CandidateID.Visible = false;
            // 
            // IssuedOn
            // 
            this.IssuedOn.DataPropertyName = "IssuedOn";
            this.IssuedOn.FillWeight = 40F;
            this.IssuedOn.HeaderText = "IssuedOn";
            this.IssuedOn.Name = "IssuedOn";
            this.IssuedOn.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.FillWeight = 60F;
            this.ReturnDate.HeaderText = "Estimated Date";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // ReturnedOn
            // 
            this.ReturnedOn.DataPropertyName = "ReturnedOn";
            this.ReturnedOn.FillWeight = 40F;
            this.ReturnedOn.HeaderText = "ReturnedOn";
            this.ReturnedOn.Name = "ReturnedOn";
            this.ReturnedOn.ReadOnly = true;
            this.ReturnedOn.Visible = false;
            // 
            // LastRenewaledOn
            // 
            this.LastRenewaledOn.DataPropertyName = "LastRenewaledOn";
            this.LastRenewaledOn.FillWeight = 23.08601F;
            this.LastRenewaledOn.HeaderText = "LastRenewaledOn";
            this.LastRenewaledOn.Name = "LastRenewaledOn";
            this.LastRenewaledOn.ReadOnly = true;
            this.LastRenewaledOn.Visible = false;
            // 
            // NoOfTimeRenewal
            // 
            this.NoOfTimeRenewal.DataPropertyName = "NoOfTimeRenewal";
            this.NoOfTimeRenewal.FillWeight = 23.08601F;
            this.NoOfTimeRenewal.HeaderText = "NoOfTimeRenewal";
            this.NoOfTimeRenewal.Name = "NoOfTimeRenewal";
            this.NoOfTimeRenewal.ReadOnly = true;
            this.NoOfTimeRenewal.Visible = false;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.FillWeight = 87.37048F;
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Visible = false;
            // 
            // Select
            // 
            this.Select.DataPropertyName = "Select";
            this.Select.FillWeight = 26.21115F;
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.Text = "Select";
            this.Select.UseColumnTextForButtonValue = true;
            // 
            // picThumb
            // 
            this.picThumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picThumb.Location = new System.Drawing.Point(741, 43);
            this.picThumb.Name = "picThumb";
            this.picThumb.Size = new System.Drawing.Size(192, 144);
            this.picThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThumb.TabIndex = 131;
            this.picThumb.TabStop = false;
            // 
            // frmRenewalBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 497);
            this.Controls.Add(this.picThumb);
            this.Controls.Add(this.dataGridissueBook);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         //   this.Name = "frmRenewalBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRenewalBook";
            this.Load += new System.EventHandler(this.frmRenewalBook_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridissueBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCloses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label txtLanguage;
        private System.Windows.Forms.Label txtPublisher;
        private System.Windows.Forms.Label txtAuthor;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label txtContactNumber;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox richtextRemark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtReturnDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.DataGridView dataGridissueBook;
        private System.Windows.Forms.Label txtbookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picThumb;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
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
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtSubCategory;
    }
}