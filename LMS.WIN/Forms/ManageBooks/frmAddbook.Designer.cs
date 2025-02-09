namespace LMS.WIN.Forms.ManageBooks
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBookCopies = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.txtbookName.Location = new System.Drawing.Point(232, 178);
            this.txtbookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbookName.Name = "txtbookName";
            this.txtbookName.Size = new System.Drawing.Size(435, 26);
            this.txtbookName.TabIndex = 4;
            this.txtbookName.Leave += new System.EventHandler(this.txtbookName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(65, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author/Editor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(232, 301);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(435, 26);
            this.txtAuthor.TabIndex = 5;
            this.txtAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAuthor_KeyDown);
            this.txtAuthor.Leave += new System.EventHandler(this.txtAuthor_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(40, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year and Edition";
            // 
            // txtEdition
            // 
            this.txtEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdition.Location = new System.Drawing.Point(232, 246);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(435, 26);
            this.txtEdition.TabIndex = 6;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(232, 351);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(435, 26);
            this.txtPublisher.TabIndex = 7;
            this.txtPublisher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPublisher_KeyDown);
            this.txtPublisher.Leave += new System.EventHandler(this.txtPublisher_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(104, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Publisher";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(232, 585);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(435, 26);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(136, 590);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cost";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(232, 212);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(435, 26);
            this.txtISBN.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(139, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "ISBN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.Location = new System.Drawing.Point(17, 455);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Remark";
            // 
            // richtextDescription
            // 
            this.richtextDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richtextDescription.Location = new System.Drawing.Point(15, 490);
            this.richtextDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richtextDescription.Name = "richtextDescription";
            this.richtextDescription.Size = new System.Drawing.Size(453, 126);
            this.richtextDescription.TabIndex = 12;
            this.richtextDescription.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(775, 749);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 43);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(8)))), ((int)(((byte)(26)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(605, 749);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 43);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(76, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title of Book";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnAddAuthor.FlatAppearance.BorderSize = 0;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAuthor.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthor.Location = new System.Drawing.Point(675, 297);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(97, 30);
            this.btnAddAuthor.TabIndex = 103;
            this.btnAddAuthor.Text = "ADD";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnAddPublisher.FlatAppearance.BorderSize = 0;
            this.btnAddPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPublisher.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAddPublisher.ForeColor = System.Drawing.Color.White;
            this.btnAddPublisher.Location = new System.Drawing.Point(675, 351);
            this.btnAddPublisher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(97, 30);
            this.btnAddPublisher.TabIndex = 104;
            this.btnAddPublisher.Text = "ADD";
            this.btnAddPublisher.UseVisualStyleBackColor = false;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // lblnoofcopy
            // 
            this.lblnoofcopy.AutoSize = true;
            this.lblnoofcopy.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblnoofcopy.Location = new System.Drawing.Point(42, 536);
            this.lblnoofcopy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnoofcopy.Name = "lblnoofcopy";
            this.lblnoofcopy.Size = new System.Drawing.Size(21, 21);
            this.lblnoofcopy.TabIndex = 105;
            this.lblnoofcopy.Text = "o";
            this.lblnoofcopy.Visible = false;
            this.lblnoofcopy.Click += new System.EventHandler(this.lblnoofcopy_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(232, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 17);
            this.label11.TabIndex = 106;
            this.label11.Text = "Press Enter For Search Author";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(232, 332);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 17);
            this.label12.TabIndex = 107;
            this.label12.Text = "Press Enter For Search Publisher";
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLanguage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.ForeColor = System.Drawing.Color.White;
            this.btnLanguage.Location = new System.Drawing.Point(352, 417);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(97, 31);
            this.btnLanguage.TabIndex = 108;
            this.btnLanguage.Text = "ADD";
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // cmboxLanguage
            // 
            this.cmboxLanguage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmboxLanguage.FormattingEnabled = true;
            this.cmboxLanguage.Location = new System.Drawing.Point(15, 417);
            this.cmboxLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmboxLanguage.Name = "cmboxLanguage";
            this.cmboxLanguage.Size = new System.Drawing.Size(315, 29);
            this.cmboxLanguage.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label13.Location = new System.Drawing.Point(11, 388);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 21);
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
            this.comboBoxtype.Location = new System.Drawing.Point(232, 64);
            this.comboBoxtype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(435, 29);
            this.comboBoxtype.TabIndex = 0;
            this.comboBoxtype.SelectedIndexChanged += new System.EventHandler(this.comboBoxtype_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(88, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 112;
            this.label5.Text = "Select Tpe";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label14.Location = new System.Drawing.Point(4, 149);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 21);
            this.label14.TabIndex = 114;
            this.label14.Text = "Select Sub-Category";
            // 
            // comboBoxSubCategry
            // 
            this.comboBoxSubCategry.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comboBoxSubCategry.FormattingEnabled = true;
            this.comboBoxSubCategry.Location = new System.Drawing.Point(232, 141);
            this.comboBoxSubCategry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSubCategry.Name = "comboBoxSubCategry";
            this.comboBoxSubCategry.Size = new System.Drawing.Size(435, 29);
            this.comboBoxSubCategry.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label15.Location = new System.Drawing.Point(40, 104);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 21);
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
            this.comboBoxcategory.Location = new System.Drawing.Point(232, 104);
            this.comboBoxcategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxcategory.Name = "comboBoxcategory";
            this.comboBoxcategory.Size = new System.Drawing.Size(435, 29);
            this.comboBoxcategory.TabIndex = 1;
            this.comboBoxcategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxcategory_SelectedIndexChanged);
            // 
            // txtFound
            // 
            this.txtFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFound.Location = new System.Drawing.Point(15, 358);
            this.txtFound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFound.Name = "txtFound";
            this.txtFound.Size = new System.Drawing.Size(315, 26);
            this.txtFound.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label16.Location = new System.Drawing.Point(11, 328);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 21);
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
            this.gridBookList.Location = new System.Drawing.Point(15, 86);
            this.gridBookList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridBookList.Name = "gridBookList";
            this.gridBookList.ReadOnly = true;
            this.gridBookList.RowHeadersVisible = false;
            this.gridBookList.RowHeadersWidth = 51;
            this.gridBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBookList.Size = new System.Drawing.Size(453, 186);
            this.gridBookList.TabIndex = 19;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(323, 280);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(145, 36);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1380, 53);
            this.panel2.TabIndex = 120;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1333, 11);
            this.pbClose.Margin = new System.Windows.Forms.Padding(4);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(40, 37);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 104;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(316, 25);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(900, 5);
            this.panel5.TabIndex = 103;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(81, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 37);
            this.lblTitle.TabIndex = 102;
            this.lblTitle.Text = "Add Book";
            // 
            // pbLibrary
            // 
            this.pbLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.pbLibrary.Image = ((System.Drawing.Image)(resources.GetObject("pbLibrary.Image")));
            this.pbLibrary.Location = new System.Drawing.Point(16, 6);
            this.pbLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.pbLibrary.Name = "pbLibrary";
            this.pbLibrary.Size = new System.Drawing.Size(47, 42);
            this.pbLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLibrary.TabIndex = 101;
            this.pbLibrary.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1373, 53);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 1049);
            this.panel3.TabIndex = 121;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 1049);
            this.panel1.TabIndex = 122;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(7, 1096);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1366, 6);
            this.panel4.TabIndex = 123;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(232, 386);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(435, 26);
            this.textBox1.TabIndex = 124;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label10.Location = new System.Drawing.Point(16, 391);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 21);
            this.label10.TabIndex = 125;
            this.label10.Text = "Vendor and Source";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(232, 619);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(435, 26);
            this.textBox2.TabIndex = 126;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label17.Location = new System.Drawing.Point(103, 624);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 21);
            this.label17.TabIndex = 127;
            this.label17.Text = "Discount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(17, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "No Of Copies";
            // 
            // txtBookCopies
            // 
            this.txtBookCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookCopies.Location = new System.Drawing.Point(15, 52);
            this.txtBookCopies.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookCopies.Name = "txtBookCopies";
            this.txtBookCopies.Size = new System.Drawing.Size(315, 26);
            this.txtBookCopies.TabIndex = 11;
            this.txtBookCopies.TextChanged += new System.EventHandler(this.txtBookCopies_TextChanged);
            this.txtBookCopies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBookCopies_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(232, 420);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(435, 26);
            this.textBox3.TabIndex = 128;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label18.Location = new System.Drawing.Point(122, 425);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 21);
            this.label18.TabIndex = 129;
            this.label18.Text = "Bill No.";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(232, 454);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(435, 26);
            this.textBox4.TabIndex = 130;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label19.Location = new System.Drawing.Point(111, 459);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 21);
            this.label19.TabIndex = 131;
            this.label19.Text = "Bill Date";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(232, 522);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(435, 26);
            this.textBox5.TabIndex = 134;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label20.Location = new System.Drawing.Point(24, 527);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(161, 21);
            this.label20.TabIndex = 135;
            this.label20.Text = "Office Order Date";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(232, 488);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(435, 26);
            this.textBox6.TabIndex = 132;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label21.Location = new System.Drawing.Point(72, 490);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 21);
            this.label21.TabIndex = 133;
            this.label21.Text = "Office Order";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(232, 556);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(435, 26);
            this.textBox7.TabIndex = 136;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label22.Location = new System.Drawing.Point(104, 561);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 21);
            this.label22.TabIndex = 137;
            this.label22.Text = "Rack No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.txtbookName);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.txtEdition);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBoxtype);
            this.groupBox1.Controls.Add(this.textBox1);
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
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.groupBox1.Location = new System.Drawing.Point(26, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(785, 663);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
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
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.groupBox2.Location = new System.Drawing.Point(819, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(482, 663);
            this.groupBox2.TabIndex = 139;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barcode Details";
            // 
            // frmAddbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 1102);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBookCopies;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}