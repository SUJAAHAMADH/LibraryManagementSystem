﻿namespace LMS.WIN.Forms.ManageBooks
{
    partial class frmAddbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddbook));
            this.txtbookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richtextDescription = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.lblnoofcopy = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.cmboxLanguage = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxSubCategry = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxcategory = new System.Windows.Forms.ComboBox();
            this.txtFound = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gridBookList = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbLibrary = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtvendor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBookCopies = new System.Windows.Forms.TextBox();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtofficeorder = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtrackno = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderdate = new System.Windows.Forms.DateTimePicker();
            this.dtpbilldate = new System.Windows.Forms.DateTimePicker();
            this.txtvolume = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookList)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibrary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbookName
            // 
            this.txtbookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookName.Location = new System.Drawing.Point(174, 116);
            this.txtbookName.Name = "txtbookName";
            this.txtbookName.Size = new System.Drawing.Size(327, 23);
            this.txtbookName.TabIndex = 4;
            this.txtbookName.Leave += new System.EventHandler(this.txtbookName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(49, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author/Editor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(174, 216);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(327, 23);
            this.txtAuthor.TabIndex = 5;
            this.txtAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAuthor_KeyDown);
            this.txtAuthor.Leave += new System.EventHandler(this.txtAuthor_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(30, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year and Edition";
            // 
            // txtEdition
            // 
            this.txtEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdition.Location = new System.Drawing.Point(174, 171);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(327, 23);
            this.txtEdition.TabIndex = 6;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(174, 257);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(327, 23);
            this.txtPublisher.TabIndex = 7;
            this.txtPublisher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPublisher_KeyDown);
            this.txtPublisher.Leave += new System.EventHandler(this.txtPublisher_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(78, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Publisher";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(174, 470);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(327, 23);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(102, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cost";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(174, 144);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(327, 23);
            this.txtISBN.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(104, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "ISBN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.Location = new System.Drawing.Point(13, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Remark";
            // 
            // richtextDescription
            // 
            this.richtextDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richtextDescription.Location = new System.Drawing.Point(11, 398);
            this.richtextDescription.Name = "richtextDescription";
            this.richtextDescription.Size = new System.Drawing.Size(341, 103);
            this.richtextDescription.TabIndex = 12;
            this.richtextDescription.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(483, 608);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(49)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(356, 608);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(57, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title of Book";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnAddAuthor.FlatAppearance.BorderSize = 0;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthor.Location = new System.Drawing.Point(506, 214);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(73, 24);
            this.btnAddAuthor.TabIndex = 103;
            this.btnAddAuthor.Text = "ADD";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnAddPublisher.FlatAppearance.BorderSize = 0;
            this.btnAddPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPublisher.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPublisher.ForeColor = System.Drawing.Color.White;
            this.btnAddPublisher.Location = new System.Drawing.Point(506, 255);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(73, 24);
            this.btnAddPublisher.TabIndex = 104;
            this.btnAddPublisher.Text = "ADD";
            this.btnAddPublisher.UseVisualStyleBackColor = false;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // lblnoofcopy
            // 
            this.lblnoofcopy.AutoSize = true;
            this.lblnoofcopy.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblnoofcopy.Location = new System.Drawing.Point(32, 436);
            this.lblnoofcopy.Name = "lblnoofcopy";
            this.lblnoofcopy.Size = new System.Drawing.Size(18, 19);
            this.lblnoofcopy.TabIndex = 105;
            this.lblnoofcopy.Text = "o";
            this.lblnoofcopy.Visible = false;
            this.lblnoofcopy.Click += new System.EventHandler(this.lblnoofcopy_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(49)))));
            this.label11.Location = new System.Drawing.Point(174, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 15);
            this.label11.TabIndex = 106;
            this.label11.Text = "Press Enter For Search Author";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(49)))));
            this.label12.Location = new System.Drawing.Point(174, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 15);
            this.label12.TabIndex = 107;
            this.label12.Text = "Press Enter For Search Publisher";
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLanguage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLanguage.ForeColor = System.Drawing.Color.White;
            this.btnLanguage.Location = new System.Drawing.Point(264, 339);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(73, 25);
            this.btnLanguage.TabIndex = 108;
            this.btnLanguage.Text = "ADD";
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // cmboxLanguage
            // 
            this.cmboxLanguage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmboxLanguage.FormattingEnabled = true;
            this.cmboxLanguage.Location = new System.Drawing.Point(11, 339);
            this.cmboxLanguage.Name = "cmboxLanguage";
            this.cmboxLanguage.Size = new System.Drawing.Size(237, 25);
            this.cmboxLanguage.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label13.Location = new System.Drawing.Point(8, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 19);
            this.label13.TabIndex = 110;
            this.label13.Text = "Select Language";
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Items.AddRange(new object[] {
            "Restricted",
            "Non-Restricted"});
            this.comboBoxtype.Location = new System.Drawing.Point(174, 24);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(327, 25);
            this.comboBoxtype.TabIndex = 0;
            this.comboBoxtype.SelectedIndexChanged += new System.EventHandler(this.comboBoxtype_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(66, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 112;
            this.label5.Text = "Select Tpe";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label14.Location = new System.Drawing.Point(3, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 19);
            this.label14.TabIndex = 114;
            this.label14.Text = "Select Sub-Category";
            // 
            // comboBoxSubCategry
            // 
            this.comboBoxSubCategry.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comboBoxSubCategry.FormattingEnabled = true;
            this.comboBoxSubCategry.Location = new System.Drawing.Point(174, 86);
            this.comboBoxSubCategry.Name = "comboBoxSubCategry";
            this.comboBoxSubCategry.Size = new System.Drawing.Size(327, 25);
            this.comboBoxSubCategry.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label15.Location = new System.Drawing.Point(30, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 19);
            this.label15.TabIndex = 116;
            this.label15.Text = "Select Category";
            // 
            // comboBoxcategory
            // 
            this.comboBoxcategory.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comboBoxcategory.FormattingEnabled = true;
            this.comboBoxcategory.Items.AddRange(new object[] {
            "Technical",
            "Others"});
            this.comboBoxcategory.Location = new System.Drawing.Point(174, 56);
            this.comboBoxcategory.Name = "comboBoxcategory";
            this.comboBoxcategory.Size = new System.Drawing.Size(327, 25);
            this.comboBoxcategory.TabIndex = 1;
            this.comboBoxcategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxcategory_SelectedIndexChanged);
            // 
            // txtFound
            // 
            this.txtFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFound.Location = new System.Drawing.Point(11, 291);
            this.txtFound.Name = "txtFound";
            this.txtFound.Size = new System.Drawing.Size(237, 23);
            this.txtFound.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label16.Location = new System.Drawing.Point(8, 266);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 19);
            this.label16.TabIndex = 118;
            this.label16.Text = "Funds";
            // 
            // gridBookList
            // 
            this.gridBookList.AllowUserToAddRows = false;
            this.gridBookList.AllowUserToResizeColumns = false;
            this.gridBookList.AllowUserToResizeRows = false;
            this.gridBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBookList.BackgroundColor = System.Drawing.Color.White;
            this.gridBookList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridBookList.ColumnHeadersHeight = 20;
            this.gridBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridBookList.Location = new System.Drawing.Point(11, 70);
            this.gridBookList.Name = "gridBookList";
            this.gridBookList.ReadOnly = true;
            this.gridBookList.RowHeadersVisible = false;
            this.gridBookList.RowHeadersWidth = 51;
            this.gridBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBookList.Size = new System.Drawing.Size(340, 151);
            this.gridBookList.TabIndex = 19;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(242, 228);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 29);
            this.btnPrint.TabIndex = 119;
            this.btnPrint.Text = "Print Barcode";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.pbClose);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.pbLibrary);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 43);
            this.panel2.TabIndex = 120;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1000, 9);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 104;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(237, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(675, 4);
            this.panel5.TabIndex = 103;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(61, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 29);
            this.lblTitle.TabIndex = 102;
            this.lblTitle.Text = "Add Book";
            // 
            // pbLibrary
            // 
            this.pbLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.pbLibrary.Image = ((System.Drawing.Image)(resources.GetObject("pbLibrary.Image")));
            this.pbLibrary.Location = new System.Drawing.Point(12, 5);
            this.pbLibrary.Name = "pbLibrary";
            this.pbLibrary.Size = new System.Drawing.Size(35, 34);
            this.pbLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLibrary.TabIndex = 101;
            this.pbLibrary.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1030, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 851);
            this.panel3.TabIndex = 121;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 851);
            this.panel1.TabIndex = 122;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 889);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1025, 5);
            this.panel4.TabIndex = 123;
            // 
            // txtvendor
            // 
            this.txtvendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvendor.Location = new System.Drawing.Point(174, 309);
            this.txtvendor.Name = "txtvendor";
            this.txtvendor.Size = new System.Drawing.Size(327, 23);
            this.txtvendor.TabIndex = 124;
            this.txtvendor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label10.Location = new System.Drawing.Point(12, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 19);
            this.label10.TabIndex = 125;
            this.label10.Text = "Vendor and Source";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(174, 498);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(327, 23);
            this.txtdiscount.TabIndex = 126;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label17.Location = new System.Drawing.Point(77, 502);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 19);
            this.label17.TabIndex = 127;
            this.label17.Text = "Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(13, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "No Of Copies";
            // 
            // txtBookCopies
            // 
            this.txtBookCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookCopies.Location = new System.Drawing.Point(11, 42);
            this.txtBookCopies.Name = "txtBookCopies";
            this.txtBookCopies.Size = new System.Drawing.Size(237, 23);
            this.txtBookCopies.TabIndex = 11;
            this.txtBookCopies.TextChanged += new System.EventHandler(this.txtBookCopies_TextChanged);
            this.txtBookCopies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBookCopies_KeyPress);
            // 
            // txtBillNo
            // 
            this.txtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNo.Location = new System.Drawing.Point(174, 336);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(327, 23);
            this.txtBillNo.TabIndex = 128;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label18.Location = new System.Drawing.Point(92, 340);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 19);
            this.label18.TabIndex = 129;
            this.label18.Text = "Bill No.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label19.Location = new System.Drawing.Point(83, 368);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 19);
            this.label19.TabIndex = 131;
            this.label19.Text = "Bill Date";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label20.Location = new System.Drawing.Point(18, 423);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(131, 19);
            this.label20.TabIndex = 135;
            this.label20.Text = "Office Order Date";
            // 
            // txtofficeorder
            // 
            this.txtofficeorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtofficeorder.Location = new System.Drawing.Point(174, 392);
            this.txtofficeorder.Name = "txtofficeorder";
            this.txtofficeorder.Size = new System.Drawing.Size(327, 23);
            this.txtofficeorder.TabIndex = 132;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label21.Location = new System.Drawing.Point(54, 393);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 19);
            this.label21.TabIndex = 133;
            this.label21.Text = "Office Order";
            // 
            // txtrackno
            // 
            this.txtrackno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrackno.Location = new System.Drawing.Point(174, 447);
            this.txtrackno.Name = "txtrackno";
            this.txtrackno.Size = new System.Drawing.Size(327, 23);
            this.txtrackno.TabIndex = 136;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label22.Location = new System.Drawing.Point(78, 451);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(67, 19);
            this.label22.TabIndex = 137;
            this.label22.Text = "Rack No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderdate);
            this.groupBox1.Controls.Add(this.dtpbilldate);
            this.groupBox1.Controls.Add(this.txtvolume);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.txtrackno);
            this.groupBox1.Controls.Add(this.txtbookName);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtofficeorder);
            this.groupBox1.Controls.Add(this.txtEdition);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.txtBillNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtdiscount);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBoxtype);
            this.groupBox1.Controls.Add(this.txtvendor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboBoxSubCategry);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboBoxcategory);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnAddAuthor);
            this.groupBox1.Controls.Add(this.btnAddPublisher);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.groupBox1.Location = new System.Drawing.Point(20, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 539);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // orderdate
            // 
            this.orderdate.CalendarFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdate.CustomFormat = " dd/MM/yyyy";
            this.orderdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderdate.Location = new System.Drawing.Point(174, 419);
            this.orderdate.Name = "orderdate";
            this.orderdate.Size = new System.Drawing.Size(327, 24);
            this.orderdate.TabIndex = 141;
            this.orderdate.Value = new System.DateTime(2025, 2, 3, 0, 0, 0, 0);
            // 
            // dtpbilldate
            // 
            this.dtpbilldate.CalendarFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpbilldate.CustomFormat = " dd/MM/yyyy";
            this.dtpbilldate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpbilldate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpbilldate.Location = new System.Drawing.Point(174, 362);
            this.dtpbilldate.Name = "dtpbilldate";
            this.dtpbilldate.Size = new System.Drawing.Size(327, 24);
            this.dtpbilldate.TabIndex = 140;
            this.dtpbilldate.Value = new System.DateTime(2025, 2, 3, 0, 0, 0, 0);
            // 
            // txtvolume
            // 
            this.txtvolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvolume.Location = new System.Drawing.Point(174, 283);
            this.txtvolume.Name = "txtvolume";
            this.txtvolume.Size = new System.Drawing.Size(327, 23);
            this.txtvolume.TabIndex = 138;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label23.Location = new System.Drawing.Point(31, 287);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 19);
            this.label23.TabIndex = 139;
            this.label23.Text = "Volume Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBookCopies);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.gridBookList);
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.richtextDescription);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnLanguage);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cmboxLanguage);
            this.groupBox2.Controls.Add(this.txtFound);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.groupBox2.Location = new System.Drawing.Point(626, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 539);
            this.groupBox2.TabIndex = 139;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barcode Details";
            // 
            // frmAddbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 894);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblnoofcopy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddbook";
            this.Load += new System.EventHandler(this.frmAddbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBookList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibrary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richtextDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Label lblnoofcopy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.ComboBox cmboxLanguage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxSubCategry;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxcategory;
        private System.Windows.Forms.TextBox txtFound;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView gridBookList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbLibrary;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtvendor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBookCopies;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtofficeorder;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtrackno;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtvolume;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker orderdate;
        private System.Windows.Forms.DateTimePicker dtpbilldate;
    }
}