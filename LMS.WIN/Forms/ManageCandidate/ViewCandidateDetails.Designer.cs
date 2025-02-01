namespace LMS.WIN.Forms.ManageCandidate
{
    partial class ViewCandidateDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCandidateDetails));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloses = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridBookHistory = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookHistoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookBarcodeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblrank = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblcandidateName = new System.Windows.Forms.Label();
            this.lblunit = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblServiceNo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCandidateBarcode = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblrole = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lbltypebinding = new System.Windows.Forms.Label();
            this.lblFormDate = new System.Windows.Forms.Label();
            this.lblFromDateBind = new System.Windows.Forms.Label();
            this.lbltoDate = new System.Windows.Forms.Label();
            this.lblToDateBinding = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookHistory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnCloses);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 33);
            this.panel2.TabIndex = 102;
            // 
            // btnCloses
            // 
            this.btnCloses.BackColor = System.Drawing.Color.Teal;
            this.btnCloses.FlatAppearance.BorderSize = 0;
            this.btnCloses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloses.ForeColor = System.Drawing.Color.White;
            this.btnCloses.Location = new System.Drawing.Point(876, 3);
            this.btnCloses.Name = "btnCloses";
            this.btnCloses.Size = new System.Drawing.Size(28, 26);
            this.btnCloses.TabIndex = 24;
            this.btnCloses.Text = "X";
            this.btnCloses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloses.UseVisualStyleBackColor = false;
            this.btnCloses.Click += new System.EventHandler(this.btnCloses_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(905, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 511);
            this.panel3.TabIndex = 107;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 544);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(905, 5);
            this.panel4.TabIndex = 106;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 516);
            this.panel1.TabIndex = 105;
            // 
            // dataGridBookHistory
            // 
            this.dataGridBookHistory.AllowUserToResizeColumns = false;
            this.dataGridBookHistory.AllowUserToResizeRows = false;
            this.dataGridBookHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBookHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridBookHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridBookHistory.ColumnHeadersHeight = 20;
            this.dataGridBookHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridBookHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Date,
            this.ReturnDate,
            this.BookName,
            this.BookBarcode,
            this.Language,
            this.Price,
            this.ContactNumber,
            this.Email,
            this.Status,
            this.BookHistoryID,
            this.BookBarcodeID,
            this.CandidateID});
            this.dataGridBookHistory.GridColor = System.Drawing.Color.White;
            this.dataGridBookHistory.Location = new System.Drawing.Point(16, 352);
            this.dataGridBookHistory.Name = "dataGridBookHistory";
            this.dataGridBookHistory.ReadOnly = true;
            this.dataGridBookHistory.RowHeadersVisible = false;
            this.dataGridBookHistory.RowHeadersWidth = 60;
            this.dataGridBookHistory.RowTemplate.Height = 30;
            this.dataGridBookHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBookHistory.Size = new System.Drawing.Size(888, 191);
            this.dataGridBookHistory.TabIndex = 138;
            this.dataGridBookHistory.Visible = false;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Candidate Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Issue Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "Estimated Date";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            this.ReturnDate.Visible = false;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "BookName";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            // 
            // BookBarcode
            // 
            this.BookBarcode.DataPropertyName = "BookBarcode";
            this.BookBarcode.HeaderText = "Book Barcode";
            this.BookBarcode.MinimumWidth = 6;
            this.BookBarcode.Name = "BookBarcode";
            this.BookBarcode.ReadOnly = true;
            // 
            // Language
            // 
            this.Language.DataPropertyName = "Language";
            this.Language.HeaderText = "Language";
            this.Language.MinimumWidth = 6;
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Visible = false;
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "ContactNumber";
            this.ContactNumber.HeaderText = "ContactNumber";
            this.ContactNumber.MinimumWidth = 6;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            this.ContactNumber.Visible = false;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // BookHistoryID
            // 
            this.BookHistoryID.DataPropertyName = "BookHistoryID";
            this.BookHistoryID.HeaderText = "BookHistoryID";
            this.BookHistoryID.MinimumWidth = 6;
            this.BookHistoryID.Name = "BookHistoryID";
            this.BookHistoryID.ReadOnly = true;
            this.BookHistoryID.Visible = false;
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
            // CandidateID
            // 
            this.CandidateID.DataPropertyName = "CandidateID";
            this.CandidateID.HeaderText = "CandidateID";
            this.CandidateID.MinimumWidth = 6;
            this.CandidateID.Name = "CandidateID";
            this.CandidateID.ReadOnly = true;
            this.CandidateID.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(623, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 26);
            this.txtSearch.TabIndex = 140;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
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
            this.button3.Location = new System.Drawing.Point(868, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 34);
            this.button3.TabIndex = 139;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 14);
            this.label3.TabIndex = 142;
            this.label3.Text = "View Candidate Issued Book through View Candidate Details.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 25);
            this.label4.TabIndex = 141;
            this.label4.Text = "View Candidate Details";
            // 
            // lblrank
            // 
            this.lblrank.AutoSize = true;
            this.lblrank.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblrank.ForeColor = System.Drawing.Color.Black;
            this.lblrank.Location = new System.Drawing.Point(104, 90);
            this.lblrank.Name = "lblrank";
            this.lblrank.Size = new System.Drawing.Size(13, 19);
            this.lblrank.TabIndex = 45;
            this.lblrank.Text = ".";
            this.lblrank.Visible = false;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblContactNo.ForeColor = System.Drawing.Color.Black;
            this.lblContactNo.Location = new System.Drawing.Point(104, 60);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(13, 19);
            this.lblContactNo.TabIndex = 44;
            this.lblContactNo.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(50, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 17);
            this.label12.TabIndex = 41;
            this.label12.Text = "Rank:";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 40;
            this.label13.Text = "Contact No:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(41, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "Name:";
            // 
            // lblcandidateName
            // 
            this.lblcandidateName.AutoSize = true;
            this.lblcandidateName.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblcandidateName.ForeColor = System.Drawing.Color.Black;
            this.lblcandidateName.Location = new System.Drawing.Point(104, 32);
            this.lblcandidateName.Name = "lblcandidateName";
            this.lblcandidateName.Size = new System.Drawing.Size(13, 19);
            this.lblcandidateName.TabIndex = 143;
            this.lblcandidateName.Text = ".";
            // 
            // lblunit
            // 
            this.lblunit.AutoSize = true;
            this.lblunit.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblunit.ForeColor = System.Drawing.Color.Black;
            this.lblunit.Location = new System.Drawing.Point(104, 116);
            this.lblunit.Name = "lblunit";
            this.lblunit.Size = new System.Drawing.Size(13, 19);
            this.lblunit.TabIndex = 145;
            this.lblunit.Text = ".";
            this.lblunit.Visible = false;
            // 
            // Unit
            // 
            this.Unit.AutoSize = true;
            this.Unit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Unit.ForeColor = System.Drawing.Color.Black;
            this.Unit.Location = new System.Drawing.Point(58, 118);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(37, 17);
            this.Unit.TabIndex = 144;
            this.Unit.Text = "Unit:";
            this.Unit.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(457, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 147;
            this.label1.Text = "Serach By Book Name";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCountry.ForeColor = System.Drawing.Color.Black;
            this.lblCountry.Location = new System.Drawing.Point(104, 177);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(13, 19);
            this.lblCountry.TabIndex = 151;
            this.lblCountry.Text = ".";
            this.lblCountry.Visible = false;
            // 
            // lblServiceNo
            // 
            this.lblServiceNo.AutoSize = true;
            this.lblServiceNo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblServiceNo.ForeColor = System.Drawing.Color.Black;
            this.lblServiceNo.Location = new System.Drawing.Point(104, 146);
            this.lblServiceNo.Name = "lblServiceNo";
            this.lblServiceNo.Size = new System.Drawing.Size(13, 19);
            this.lblServiceNo.TabIndex = 153;
            this.lblServiceNo.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(32, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 149;
            this.label10.Text = "Country:";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(11, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 17);
            this.label11.TabIndex = 148;
            this.label11.Text = "Service No:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lblcandidateName);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblContactNo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.lblrank);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblServiceNo);
            this.groupBox1.Controls.Add(this.Unit);
            this.groupBox1.Controls.Add(this.lblunit);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Location = new System.Drawing.Point(16, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 245);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCandidateBarcode);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.txtBarcode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblrole);
            this.groupBox2.Controls.Add(this.lblType);
            this.groupBox2.Controls.Add(this.lbltypebinding);
            this.groupBox2.Controls.Add(this.lblFormDate);
            this.groupBox2.Controls.Add(this.lblFromDateBind);
            this.groupBox2.Controls.Add(this.lbltoDate);
            this.groupBox2.Controls.Add(this.lblToDateBinding);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Location = new System.Drawing.Point(471, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 245);
            this.groupBox2.TabIndex = 157;
            this.groupBox2.TabStop = false;
            // 
            // lblCandidateBarcode
            // 
            this.lblCandidateBarcode.AutoSize = true;
            this.lblCandidateBarcode.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblCandidateBarcode.ForeColor = System.Drawing.Color.Black;
            this.lblCandidateBarcode.Location = new System.Drawing.Point(12, 216);
            this.lblCandidateBarcode.Name = "lblCandidateBarcode";
            this.lblCandidateBarcode.Size = new System.Drawing.Size(13, 19);
            this.lblCandidateBarcode.TabIndex = 158;
            this.lblCandidateBarcode.Text = ".";
            this.lblCandidateBarcode.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Teal;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(321, 210);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(104, 29);
            this.btnPrint.TabIndex = 147;
            this.btnPrint.Text = "Print Barcode";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.SystemColors.Control;
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(16, 161);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(409, 19);
            this.txtBarcode.TabIndex = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(64, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Role:";
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblrole.ForeColor = System.Drawing.Color.Black;
            this.lblrole.Location = new System.Drawing.Point(117, 32);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(13, 19);
            this.lblrole.TabIndex = 143;
            this.lblrole.Text = ".";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(5, 62);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(12, 17);
            this.lblType.TabIndex = 40;
            this.lblType.Text = ".";
            // 
            // lbltypebinding
            // 
            this.lbltypebinding.AutoSize = true;
            this.lbltypebinding.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lbltypebinding.ForeColor = System.Drawing.Color.Black;
            this.lbltypebinding.Location = new System.Drawing.Point(117, 62);
            this.lbltypebinding.Name = "lbltypebinding";
            this.lbltypebinding.Size = new System.Drawing.Size(13, 19);
            this.lbltypebinding.TabIndex = 44;
            this.lbltypebinding.Text = ".";
            // 
            // lblFormDate
            // 
            this.lblFormDate.AutoSize = true;
            this.lblFormDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblFormDate.ForeColor = System.Drawing.Color.Black;
            this.lblFormDate.Location = new System.Drawing.Point(13, 92);
            this.lblFormDate.Name = "lblFormDate";
            this.lblFormDate.Size = new System.Drawing.Size(12, 17);
            this.lblFormDate.TabIndex = 41;
            this.lblFormDate.Text = ".";
            // 
            // lblFromDateBind
            // 
            this.lblFromDateBind.AutoSize = true;
            this.lblFromDateBind.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblFromDateBind.ForeColor = System.Drawing.Color.Black;
            this.lblFromDateBind.Location = new System.Drawing.Point(117, 90);
            this.lblFromDateBind.Name = "lblFromDateBind";
            this.lblFromDateBind.Size = new System.Drawing.Size(13, 19);
            this.lblFromDateBind.TabIndex = 45;
            this.lblFromDateBind.Text = ".";
            // 
            // lbltoDate
            // 
            this.lbltoDate.AutoSize = true;
            this.lbltoDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lbltoDate.ForeColor = System.Drawing.Color.Black;
            this.lbltoDate.Location = new System.Drawing.Point(13, 118);
            this.lbltoDate.Name = "lbltoDate";
            this.lbltoDate.Size = new System.Drawing.Size(12, 17);
            this.lbltoDate.TabIndex = 144;
            this.lbltoDate.Text = ".";
            // 
            // lblToDateBinding
            // 
            this.lblToDateBinding.AutoSize = true;
            this.lblToDateBinding.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblToDateBinding.ForeColor = System.Drawing.Color.Black;
            this.lblToDateBinding.Location = new System.Drawing.Point(117, 116);
            this.lblToDateBinding.Name = "lblToDateBinding";
            this.lblToDateBinding.Size = new System.Drawing.Size(13, 19);
            this.lblToDateBinding.TabIndex = 145;
            this.lblToDateBinding.Text = ".";
            // 
            // ViewCandidateDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridBookHistory);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCandidateDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCandidateDetails";
            this.Load += new System.EventHandler(this.ViewCandidateDetails_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookHistory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCloses;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridBookHistory;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblrank;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblcandidateName;
        private System.Windows.Forms.Label lblunit;
        private System.Windows.Forms.Label Unit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblServiceNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lbltypebinding;
        private System.Windows.Forms.Label lblFormDate;
        private System.Windows.Forms.Label lblFromDateBind;
        private System.Windows.Forms.Label lbltoDate;
        private System.Windows.Forms.Label lblToDateBinding;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookHistoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookBarcodeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateID;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblCandidateBarcode;
    }
}