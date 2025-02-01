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
            this.label8 = new System.Windows.Forms.Label();
            this.txtBookCopies = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richtextDescription = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloses = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbookName
            // 
            this.txtbookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookName.Location = new System.Drawing.Point(167, 143);
            this.txtbookName.Name = "txtbookName";
            this.txtbookName.Size = new System.Drawing.Size(244, 23);
            this.txtbookName.TabIndex = 4;
            this.txtbookName.Leave += new System.EventHandler(this.txtbookName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(516, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(576, 145);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(275, 23);
            this.txtAuthor.TabIndex = 5;
            this.txtAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAuthor_KeyDown);
            this.txtAuthor.Leave += new System.EventHandler(this.txtAuthor_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(103, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edition";
            // 
            // txtEdition
            // 
            this.txtEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdition.Location = new System.Drawing.Point(167, 184);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(244, 23);
            this.txtEdition.TabIndex = 6;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(576, 194);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(274, 23);
            this.txtPublisher.TabIndex = 7;
            this.txtPublisher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPublisher_KeyDown);
            this.txtPublisher.Leave += new System.EventHandler(this.txtPublisher_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(501, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Publisher";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(167, 225);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(244, 23);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(117, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cost";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(167, 264);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(244, 23);
            this.txtISBN.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(122, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "ISBN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(60, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "No Of Copies";
            // 
            // txtBookCopies
            // 
            this.txtBookCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookCopies.Location = new System.Drawing.Point(167, 300);
            this.txtBookCopies.Name = "txtBookCopies";
            this.txtBookCopies.Size = new System.Drawing.Size(244, 23);
            this.txtBookCopies.TabIndex = 11;
            this.txtBookCopies.TextChanged += new System.EventHandler(this.txtBookCopies_TextChanged);
            this.txtBookCopies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBookCopies_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.Location = new System.Drawing.Point(485, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Description";
            // 
            // richtextDescription
            // 
            this.richtextDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richtextDescription.Location = new System.Drawing.Point(576, 270);
            this.richtextDescription.Name = "richtextDescription";
            this.richtextDescription.Size = new System.Drawing.Size(329, 63);
            this.richtextDescription.TabIndex = 12;
            this.richtextDescription.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(691, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(576, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 29);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnCloses);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 33);
            this.panel2.TabIndex = 96;
            // 
            // btnCloses
            // 
            this.btnCloses.BackColor = System.Drawing.Color.Teal;
            this.btnCloses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCloses.FlatAppearance.BorderSize = 0;
            this.btnCloses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloses.ForeColor = System.Drawing.Color.White;
            this.btnCloses.Location = new System.Drawing.Point(0, 0);
            this.btnCloses.Name = "btnCloses";
            this.btnCloses.Size = new System.Drawing.Size(951, 26);
            this.btnCloses.TabIndex = 24;
            this.btnCloses.Text = "X";
            this.btnCloses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloses.UseVisualStyleBackColor = false;
            this.btnCloses.Click += new System.EventHandler(this.btnCloses_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Add Book Here";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 488);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(941, 5);
            this.panel4.TabIndex = 100;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(946, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 460);
            this.panel3.TabIndex = 99;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 460);
            this.panel1.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(71, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.Teal;
            this.btnAddAuthor.FlatAppearance.BorderSize = 0;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAuthor.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthor.Location = new System.Drawing.Point(857, 145);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(46, 24);
            this.btnAddAuthor.TabIndex = 103;
            this.btnAddAuthor.Text = "ADD";
            this.btnAddAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.BackColor = System.Drawing.Color.Teal;
            this.btnAddPublisher.FlatAppearance.BorderSize = 0;
            this.btnAddPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPublisher.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAddPublisher.ForeColor = System.Drawing.Color.White;
            this.btnAddPublisher.Location = new System.Drawing.Point(856, 193);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(47, 24);
            this.btnAddPublisher.TabIndex = 104;
            this.btnAddPublisher.Text = "ADD";
            this.btnAddPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPublisher.UseVisualStyleBackColor = false;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // lblnoofcopy
            // 
            this.lblnoofcopy.AutoSize = true;
            this.lblnoofcopy.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblnoofcopy.Location = new System.Drawing.Point(417, 303);
            this.lblnoofcopy.Name = "lblnoofcopy";
            this.lblnoofcopy.Size = new System.Drawing.Size(18, 19);
            this.lblnoofcopy.TabIndex = 105;
            this.lblnoofcopy.Text = "o";
            this.lblnoofcopy.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(575, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 15);
            this.label11.TabIndex = 106;
            this.label11.Text = "Press Enter For Search Author";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(576, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(179, 15);
            this.label12.TabIndex = 107;
            this.label12.Text = "Press Enter For Search Publisher";
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.Teal;
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLanguage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnLanguage.ForeColor = System.Drawing.Color.White;
            this.btnLanguage.Location = new System.Drawing.Point(856, 232);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(47, 25);
            this.btnLanguage.TabIndex = 108;
            this.btnLanguage.Text = "ADD";
            this.btnLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // cmboxLanguage
            // 
            this.cmboxLanguage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmboxLanguage.FormattingEnabled = true;
            this.cmboxLanguage.Location = new System.Drawing.Point(576, 232);
            this.cmboxLanguage.Name = "cmboxLanguage";
            this.cmboxLanguage.Size = new System.Drawing.Size(274, 25);
            this.cmboxLanguage.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label13.Location = new System.Drawing.Point(447, 235);
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
            this.comboBoxtype.Location = new System.Drawing.Point(167, 66);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(244, 25);
            this.comboBoxtype.TabIndex = 0;
            this.comboBoxtype.SelectedIndexChanged += new System.EventHandler(this.comboBoxtype_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(80, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 112;
            this.label5.Text = "Select Tpe";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label14.Location = new System.Drawing.Point(8, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 19);
            this.label14.TabIndex = 114;
            this.label14.Text = "Select Sub-Category";
            // 
            // comboBoxSubCategry
            // 
            this.comboBoxSubCategry.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comboBoxSubCategry.FormattingEnabled = true;
            this.comboBoxSubCategry.Location = new System.Drawing.Point(167, 103);
            this.comboBoxSubCategry.Name = "comboBoxSubCategry";
            this.comboBoxSubCategry.Size = new System.Drawing.Size(244, 25);
            this.comboBoxSubCategry.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label15.Location = new System.Drawing.Point(448, 69);
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
            this.comboBoxcategory.Location = new System.Drawing.Point(576, 66);
            this.comboBoxcategory.Name = "comboBoxcategory";
            this.comboBoxcategory.Size = new System.Drawing.Size(327, 25);
            this.comboBoxcategory.TabIndex = 1;
            this.comboBoxcategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxcategory_SelectedIndexChanged);
            // 
            // txtFound
            // 
            this.txtFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFound.Location = new System.Drawing.Point(576, 103);
            this.txtFound.Name = "txtFound";
            this.txtFound.Size = new System.Drawing.Size(327, 23);
            this.txtFound.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label16.Location = new System.Drawing.Point(516, 103);
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
            this.gridBookList.Location = new System.Drawing.Point(64, 352);
            this.gridBookList.Name = "gridBookList";
            this.gridBookList.ReadOnly = true;
            this.gridBookList.RowHeadersVisible = false;
            this.gridBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBookList.Size = new System.Drawing.Size(371, 129);
            this.gridBookList.TabIndex = 19;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Teal;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(441, 453);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 29);
            this.btnPrint.TabIndex = 119;
            this.btnPrint.Text = "Print Barcode";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmAddbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 493);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtFound);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBoxcategory);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxSubCategry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxtype);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmboxLanguage);
            this.Controls.Add(this.btnLanguage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblnoofcopy);
            this.Controls.Add(this.btnAddPublisher);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridBookList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.richtextDescription);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBookCopies);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbookName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddbook";
            this.Load += new System.EventHandler(this.frmAddbook_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookList)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBookCopies;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richtextDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCloses;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
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
    }
}