namespace LMS.WIN.Forms.ManageBooks
{
    partial class frmEditbook
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
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbookName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFound = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxSubCategry = new System.Windows.Forms.ComboBox();
            this.comboBoxcategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxtype = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmboxLanguage = new System.Windows.Forms.ComboBox();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.richtextDescription = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveBarcode = new System.Windows.Forms.Button();
            this.addbarodecopy = new System.Windows.Forms.Button();
            this.dataGridAddmorecopy = new System.Windows.Forms.DataGridView();
            this.txtnoofCopy = new System.Windows.Forms.TextBox();
            this.lblnoofcopies = new System.Windows.Forms.Label();
            this.lblnoofcopy = new System.Windows.Forms.Label();
            this.gridBookList = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddmorecopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnCloses);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 41);
            this.panel2.TabIndex = 97;
            // 
            // btnCloses
            // 
            this.btnCloses.BackColor = System.Drawing.Color.Teal;
            this.btnCloses.FlatAppearance.BorderSize = 0;
            this.btnCloses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloses.ForeColor = System.Drawing.Color.White;
            this.btnCloses.Location = new System.Drawing.Point(1228, 6);
            this.btnCloses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloses.Name = "btnCloses";
            this.btnCloses.Size = new System.Drawing.Size(35, 32);
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
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 22);
            this.label10.TabIndex = 23;
            this.label10.Text = "Edit Book Here";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(7, 682);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1259, 6);
            this.panel4.TabIndex = 103;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1266, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 647);
            this.panel3.TabIndex = 102;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 647);
            this.panel1.TabIndex = 101;
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(228, 348);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(324, 26);
            this.txtISBN.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label7.Location = new System.Drawing.Point(171, 352);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 111;
            this.label7.Text = "ISBN";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(228, 305);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(324, 26);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(145, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 21);
            this.label3.TabIndex = 108;
            this.label3.Text = "Edition";
            // 
            // txtEdition
            // 
            this.txtEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdition.Location = new System.Drawing.Point(228, 228);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(324, 26);
            this.txtEdition.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(103, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 105;
            this.label1.Text = "Book Name";
            // 
            // txtbookName
            // 
            this.txtbookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookName.Location = new System.Drawing.Point(228, 177);
            this.txtbookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbookName.Name = "txtbookName";
            this.txtbookName.Size = new System.Drawing.Size(324, 26);
            this.txtbookName.TabIndex = 3;
            this.txtbookName.Leave += new System.EventHandler(this.txtbookName_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtFound);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.comboBoxSubCategry);
            this.groupBox1.Controls.Add(this.comboBoxcategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxtype);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmboxLanguage);
            this.groupBox1.Controls.Add(this.btnLanguage);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnAddPublisher);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.btnAddAuthor);
            this.groupBox1.Controls.Add(this.txtbookName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.richtextDescription);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEdition);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.groupBox1.Location = new System.Drawing.Point(15, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(648, 623);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label16.Location = new System.Drawing.Point(148, 267);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 21);
            this.label16.TabIndex = 135;
            this.label16.Text = "Funds";
            // 
            // txtFound
            // 
            this.txtFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFound.Location = new System.Drawing.Point(228, 267);
            this.txtFound.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFound.Name = "txtFound";
            this.txtFound.Size = new System.Drawing.Size(325, 26);
            this.txtFound.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(168, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 133;
            this.label6.Text = "Cost";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label15.Location = new System.Drawing.Point(57, 78);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 21);
            this.label15.TabIndex = 132;
            this.label15.Text = "Select Category";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label14.Location = new System.Drawing.Point(27, 128);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 21);
            this.label14.TabIndex = 130;
            this.label14.Text = "Select Sub-Category";
            // 
            // comboBoxSubCategry
            // 
            this.comboBoxSubCategry.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comboBoxSubCategry.FormattingEnabled = true;
            this.comboBoxSubCategry.Location = new System.Drawing.Point(229, 124);
            this.comboBoxSubCategry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSubCategry.Name = "comboBoxSubCategry";
            this.comboBoxSubCategry.Size = new System.Drawing.Size(324, 29);
            this.comboBoxSubCategry.TabIndex = 2;
            // 
            // comboBoxcategory
            // 
            this.comboBoxcategory.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comboBoxcategory.FormattingEnabled = true;
            this.comboBoxcategory.Items.AddRange(new object[] {
            "Technical",
            "Others"});
            this.comboBoxcategory.Location = new System.Drawing.Point(228, 74);
            this.comboBoxcategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxcategory.Name = "comboBoxcategory";
            this.comboBoxcategory.Size = new System.Drawing.Size(325, 29);
            this.comboBoxcategory.TabIndex = 1;
            this.comboBoxcategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxcategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(112, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 128;
            this.label5.Text = "Select Tpe";
            // 
            // comboBoxtype
            // 
            this.comboBoxtype.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.comboBoxtype.FormattingEnabled = true;
            this.comboBoxtype.Items.AddRange(new object[] {
            "Restricted",
            "Non-Restricted"});
            this.comboBoxtype.Location = new System.Drawing.Point(228, 27);
            this.comboBoxtype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxtype.Name = "comboBoxtype";
            this.comboBoxtype.Size = new System.Drawing.Size(324, 29);
            this.comboBoxtype.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label13.Location = new System.Drawing.Point(56, 506);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 21);
            this.label13.TabIndex = 126;
            this.label13.Text = "Select Language";
            // 
            // cmboxLanguage
            // 
            this.cmboxLanguage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmboxLanguage.FormattingEnabled = true;
            this.cmboxLanguage.Location = new System.Drawing.Point(228, 502);
            this.cmboxLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmboxLanguage.Name = "cmboxLanguage";
            this.cmboxLanguage.Size = new System.Drawing.Size(324, 29);
            this.cmboxLanguage.TabIndex = 10;
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.Color.Teal;
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLanguage.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnLanguage.ForeColor = System.Drawing.Color.White;
            this.btnLanguage.Location = new System.Drawing.Point(555, 502);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(63, 31);
            this.btnLanguage.TabIndex = 124;
            this.btnLanguage.Text = "ADD";
            this.btnLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(224, 439);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 17);
            this.label12.TabIndex = 123;
            this.label12.Text = "Press Enter For Search Publisher";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(224, 384);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 17);
            this.label11.TabIndex = 122;
            this.label11.Text = "Press Enter For Search Author";
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.BackColor = System.Drawing.Color.Teal;
            this.btnAddPublisher.FlatAppearance.BorderSize = 0;
            this.btnAddPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPublisher.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAddPublisher.ForeColor = System.Drawing.Color.White;
            this.btnAddPublisher.Location = new System.Drawing.Point(555, 462);
            this.btnAddPublisher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(63, 28);
            this.btnAddPublisher.TabIndex = 121;
            this.btnAddPublisher.Text = "ADD";
            this.btnAddPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPublisher.UseVisualStyleBackColor = false;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.Teal;
            this.btnAddAuthor.FlatAppearance.BorderSize = 0;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAuthor.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthor.Location = new System.Drawing.Point(556, 406);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(61, 28);
            this.btnAddAuthor.TabIndex = 120;
            this.btnAddAuthor.Text = "ADD";
            this.btnAddAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // richtextDescription
            // 
            this.richtextDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.richtextDescription.Location = new System.Drawing.Point(228, 543);
            this.richtextDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richtextDescription.Name = "richtextDescription";
            this.richtextDescription.Size = new System.Drawing.Size(324, 73);
            this.richtextDescription.TabIndex = 11;
            this.richtextDescription.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.Location = new System.Drawing.Point(107, 542);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 21);
            this.label9.TabIndex = 119;
            this.label9.Text = "Description";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(228, 462);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(324, 26);
            this.txtPublisher.TabIndex = 9;
            this.txtPublisher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPublisher_KeyDown);
            this.txtPublisher.Leave += new System.EventHandler(this.txtPublisher_Leave);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(228, 406);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(324, 26);
            this.txtAuthor.TabIndex = 8;
            this.txtAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAuthor_KeyDown);
            this.txtAuthor.Leave += new System.EventHandler(this.txtAuthor_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(128, 463);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 116;
            this.label4.Text = "Publisher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(148, 406);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 113;
            this.label2.Text = "Author";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnSaveBarcode);
            this.groupBox2.Controls.Add(this.addbarodecopy);
            this.groupBox2.Controls.Add(this.dataGridAddmorecopy);
            this.groupBox2.Controls.Add(this.txtnoofCopy);
            this.groupBox2.Controls.Add(this.lblnoofcopies);
            this.groupBox2.Controls.Add(this.lblnoofcopy);
            this.groupBox2.Controls.Add(this.gridBookList);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.groupBox2.Location = new System.Drawing.Point(671, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(592, 618);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barcode Details";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Teal;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(523, 299);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(61, 28);
            this.btnPrint.TabIndex = 120;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(364, 479);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 36);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveBarcode
            // 
            this.btnSaveBarcode.BackColor = System.Drawing.Color.Teal;
            this.btnSaveBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveBarcode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSaveBarcode.ForeColor = System.Drawing.Color.White;
            this.btnSaveBarcode.Location = new System.Drawing.Point(184, 479);
            this.btnSaveBarcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveBarcode.Name = "btnSaveBarcode";
            this.btnSaveBarcode.Size = new System.Drawing.Size(145, 36);
            this.btnSaveBarcode.TabIndex = 13;
            this.btnSaveBarcode.Text = "Save";
            this.btnSaveBarcode.UseVisualStyleBackColor = false;
            this.btnSaveBarcode.Click += new System.EventHandler(this.btnSaveBarcode_Click);
            // 
            // addbarodecopy
            // 
            this.addbarodecopy.BackColor = System.Drawing.Color.Teal;
            this.addbarodecopy.FlatAppearance.BorderSize = 0;
            this.addbarodecopy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbarodecopy.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.addbarodecopy.ForeColor = System.Drawing.Color.White;
            this.addbarodecopy.Location = new System.Drawing.Point(523, 60);
            this.addbarodecopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addbarodecopy.Name = "addbarodecopy";
            this.addbarodecopy.Size = new System.Drawing.Size(61, 28);
            this.addbarodecopy.TabIndex = 12;
            this.addbarodecopy.Text = "ADD";
            this.addbarodecopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbarodecopy.UseVisualStyleBackColor = false;
            this.addbarodecopy.Click += new System.EventHandler(this.addbarodecopy_Click);
            // 
            // dataGridAddmorecopy
            // 
            this.dataGridAddmorecopy.AllowUserToResizeColumns = false;
            this.dataGridAddmorecopy.AllowUserToResizeRows = false;
            this.dataGridAddmorecopy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAddmorecopy.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAddmorecopy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridAddmorecopy.ColumnHeadersHeight = 20;
            this.dataGridAddmorecopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridAddmorecopy.Location = new System.Drawing.Point(184, 299);
            this.dataGridAddmorecopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridAddmorecopy.Name = "dataGridAddmorecopy";
            this.dataGridAddmorecopy.ReadOnly = true;
            this.dataGridAddmorecopy.RowHeadersVisible = false;
            this.dataGridAddmorecopy.RowHeadersWidth = 51;
            this.dataGridAddmorecopy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAddmorecopy.Size = new System.Drawing.Size(325, 172);
            this.dataGridAddmorecopy.TabIndex = 112;
            this.dataGridAddmorecopy.Visible = false;
            // 
            // txtnoofCopy
            // 
            this.txtnoofCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnoofCopy.Location = new System.Drawing.Point(184, 263);
            this.txtnoofCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnoofCopy.Name = "txtnoofCopy";
            this.txtnoofCopy.Size = new System.Drawing.Size(324, 26);
            this.txtnoofCopy.TabIndex = 110;
            this.txtnoofCopy.Visible = false;
            this.txtnoofCopy.TextChanged += new System.EventHandler(this.txtnoofCopy_TextChanged);
            // 
            // lblnoofcopies
            // 
            this.lblnoofcopies.AutoSize = true;
            this.lblnoofcopies.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblnoofcopies.Location = new System.Drawing.Point(41, 267);
            this.lblnoofcopies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnoofcopies.Name = "lblnoofcopies";
            this.lblnoofcopies.Size = new System.Drawing.Size(122, 21);
            this.lblnoofcopies.TabIndex = 111;
            this.lblnoofcopies.Text = "No Of Copies";
            this.lblnoofcopies.Visible = false;
            // 
            // lblnoofcopy
            // 
            this.lblnoofcopy.AutoSize = true;
            this.lblnoofcopy.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblnoofcopy.Location = new System.Drawing.Point(196, 26);
            this.lblnoofcopy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnoofcopy.Name = "lblnoofcopy";
            this.lblnoofcopy.Size = new System.Drawing.Size(21, 21);
            this.lblnoofcopy.TabIndex = 109;
            this.lblnoofcopy.Text = "o";
            this.lblnoofcopy.Visible = false;
            // 
            // gridBookList
            // 
            this.gridBookList.AllowUserToResizeColumns = false;
            this.gridBookList.AllowUserToResizeRows = false;
            this.gridBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBookList.BackgroundColor = System.Drawing.Color.White;
            this.gridBookList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridBookList.ColumnHeadersHeight = 20;
            this.gridBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridBookList.Location = new System.Drawing.Point(184, 60);
            this.gridBookList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridBookList.Name = "gridBookList";
            this.gridBookList.ReadOnly = true;
            this.gridBookList.RowHeadersVisible = false;
            this.gridBookList.RowHeadersWidth = 51;
            this.gridBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBookList.Size = new System.Drawing.Size(325, 172);
            this.gridBookList.TabIndex = 108;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(8, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 21);
            this.label8.TabIndex = 107;
            this.label8.Text = "Total No Of Copies";
            // 
            // frmEditbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 688);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditbook";
            this.Load += new System.EventHandler(this.frmEditbook_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddmorecopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCloses;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbookName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.RichTextBox richtextDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblnoofcopy;
        private System.Windows.Forms.DataGridView gridBookList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridAddmorecopy;
        private System.Windows.Forms.TextBox txtnoofCopy;
        private System.Windows.Forms.Label lblnoofcopies;
        private System.Windows.Forms.Button addbarodecopy;
        private System.Windows.Forms.Button btnSaveBarcode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmboxLanguage;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxtype;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxSubCategry;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxcategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFound;
        private System.Windows.Forms.Button btnPrint;
    }
}