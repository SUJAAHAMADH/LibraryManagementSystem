namespace LMS.WIN.Forms.ManageBooks
{
    partial class ManageIssuebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageIssuebook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnissue = new System.Windows.Forms.Button();
            this.btnMissingbook = new System.Windows.Forms.Button();
            this.btnManageReturnbook = new System.Windows.Forms.Button();
            this.btnrenewbook = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridissueBook = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAvailableBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookBarcodeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalReturnBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.picboxrefersh = new System.Windows.Forms.PictureBox();
            this.pnlManageBook = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridissueBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrefersh)).BeginInit();
            this.pnlManageBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.btnissue);
            this.panel2.Controls.Add(this.btnMissingbook);
            this.panel2.Controls.Add(this.btnManageReturnbook);
            this.panel2.Controls.Add(this.btnrenewbook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1436, 49);
            this.panel2.TabIndex = 99;
            // 
            // btnissue
            // 
            this.btnissue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnissue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnissue.FlatAppearance.BorderSize = 0;
            this.btnissue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnissue.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnissue.ForeColor = System.Drawing.Color.White;
            this.btnissue.Location = new System.Drawing.Point(16, 5);
            this.btnissue.Margin = new System.Windows.Forms.Padding(4);
            this.btnissue.Name = "btnissue";
            this.btnissue.Size = new System.Drawing.Size(131, 41);
            this.btnissue.TabIndex = 120;
            this.btnissue.Text = "Issue Book";
            this.btnissue.UseVisualStyleBackColor = false;
            this.btnissue.Click += new System.EventHandler(this.btnissue_Click);
            // 
            // btnMissingbook
            // 
            this.btnMissingbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnMissingbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMissingbook.FlatAppearance.BorderSize = 0;
            this.btnMissingbook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMissingbook.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnMissingbook.ForeColor = System.Drawing.Color.White;
            this.btnMissingbook.Location = new System.Drawing.Point(432, 4);
            this.btnMissingbook.Margin = new System.Windows.Forms.Padding(4);
            this.btnMissingbook.Name = "btnMissingbook";
            this.btnMissingbook.Size = new System.Drawing.Size(131, 41);
            this.btnMissingbook.TabIndex = 119;
            this.btnMissingbook.Text = "Missing Book";
            this.btnMissingbook.UseVisualStyleBackColor = false;
            this.btnMissingbook.Visible = false;
            this.btnMissingbook.Click += new System.EventHandler(this.btnMissingbook_Click);
            // 
            // btnManageReturnbook
            // 
            this.btnManageReturnbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnManageReturnbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageReturnbook.FlatAppearance.BorderSize = 0;
            this.btnManageReturnbook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManageReturnbook.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnManageReturnbook.ForeColor = System.Drawing.Color.White;
            this.btnManageReturnbook.Location = new System.Drawing.Point(293, 5);
            this.btnManageReturnbook.Margin = new System.Windows.Forms.Padding(4);
            this.btnManageReturnbook.Name = "btnManageReturnbook";
            this.btnManageReturnbook.Size = new System.Drawing.Size(131, 41);
            this.btnManageReturnbook.TabIndex = 118;
            this.btnManageReturnbook.Text = "Return Book";
            this.btnManageReturnbook.UseVisualStyleBackColor = false;
            this.btnManageReturnbook.Click += new System.EventHandler(this.btnManageReturnbook_Click);
            // 
            // btnrenewbook
            // 
            this.btnrenewbook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnrenewbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrenewbook.FlatAppearance.BorderSize = 0;
            this.btnrenewbook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrenewbook.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnrenewbook.ForeColor = System.Drawing.Color.White;
            this.btnrenewbook.Location = new System.Drawing.Point(155, 5);
            this.btnrenewbook.Margin = new System.Windows.Forms.Padding(4);
            this.btnrenewbook.Name = "btnrenewbook";
            this.btnrenewbook.Size = new System.Drawing.Size(131, 41);
            this.btnrenewbook.TabIndex = 113;
            this.btnrenewbook.Text = "Renew Book";
            this.btnrenewbook.UseVisualStyleBackColor = false;
            this.btnrenewbook.Click += new System.EventHandler(this.btnrenewbook_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "View";
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "View";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 49;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Delete";
            this.dataGridViewImageColumn2.FillWeight = 26.21115F;
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Visible = false;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 32);
            this.label4.TabIndex = 113;
            this.label4.Text = "Manage Total Available Book";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(29, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 18);
            this.label3.TabIndex = 114;
            this.label3.Text = "Total Available Books  Quantity Here";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(939, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(335, 30);
            this.txtSearch.TabIndex = 116;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridissueBook
            // 
            this.dataGridissueBook.AllowUserToResizeColumns = false;
            this.dataGridissueBook.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridissueBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridissueBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridissueBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridissueBook.BackgroundColor = System.Drawing.Color.White;
            this.dataGridissueBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridissueBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridissueBook.ColumnHeadersHeight = 35;
            this.dataGridissueBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridissueBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Author,
            this.Language,
            this.Edition,
            this.TotalQuantity,
            this.TotalAvailableBook,
            this.IssueBookID,
            this.BookBarcodeID,
            this.BookBarcode,
            this.Price,
            this.ISBN,
            this.TotalReturnBook,
            this.Remark,
            this.BookID,
            this.View,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridissueBook.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridissueBook.EnableHeadersVisualStyles = false;
            this.dataGridissueBook.GridColor = System.Drawing.Color.White;
            this.dataGridissueBook.Location = new System.Drawing.Point(32, 70);
            this.dataGridissueBook.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridissueBook.Name = "dataGridissueBook";
            this.dataGridissueBook.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridissueBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridissueBook.RowHeadersVisible = false;
            this.dataGridissueBook.RowHeadersWidth = 60;
            this.dataGridissueBook.RowTemplate.Height = 30;
            this.dataGridissueBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridissueBook.Size = new System.Drawing.Size(1388, 526);
            this.dataGridissueBook.TabIndex = 117;
            this.dataGridissueBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridissueBook_CellContentClick);
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Book Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Language
            // 
            this.Language.DataPropertyName = "Language";
            this.Language.HeaderText = "Language";
            this.Language.MinimumWidth = 6;
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            // 
            // Edition
            // 
            this.Edition.DataPropertyName = "Edition";
            this.Edition.HeaderText = "Edition";
            this.Edition.MinimumWidth = 6;
            this.Edition.Name = "Edition";
            this.Edition.ReadOnly = true;
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.DataPropertyName = "TotalQuantity";
            this.TotalQuantity.HeaderText = "TotalQuantity";
            this.TotalQuantity.MinimumWidth = 6;
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.ReadOnly = true;
            // 
            // TotalAvailableBook
            // 
            this.TotalAvailableBook.DataPropertyName = "TotalAvailableBook";
            this.TotalAvailableBook.HeaderText = "TotalAvailableBook";
            this.TotalAvailableBook.MinimumWidth = 6;
            this.TotalAvailableBook.Name = "TotalAvailableBook";
            this.TotalAvailableBook.ReadOnly = true;
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
            this.BookBarcode.FillWeight = 87.37048F;
            this.BookBarcode.HeaderText = "BookBarcode";
            this.BookBarcode.MinimumWidth = 6;
            this.BookBarcode.Name = "BookBarcode";
            this.BookBarcode.ReadOnly = true;
            this.BookBarcode.Visible = false;
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
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.MinimumWidth = 6;
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Visible = false;
            // 
            // TotalReturnBook
            // 
            this.TotalReturnBook.DataPropertyName = "TotalReturnBook";
            this.TotalReturnBook.HeaderText = "TotalReturnBook";
            this.TotalReturnBook.MinimumWidth = 6;
            this.TotalReturnBook.Name = "TotalReturnBook";
            this.TotalReturnBook.ReadOnly = true;
            this.TotalReturnBook.Visible = false;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.FillWeight = 87.37048F;
            this.Remark.HeaderText = "Remark";
            this.Remark.MinimumWidth = 6;
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Visible = false;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.MinimumWidth = 6;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Visible = false;
            // 
            // View
            // 
            this.View.DataPropertyName = "View";
            this.View.FillWeight = 30F;
            this.View.HeaderText = "View";
            this.View.Image = ((System.Drawing.Image)(resources.GetObject("View.Image")));
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(795, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 118;
            this.label1.Text = "Serach Book";
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
            this.button3.Location = new System.Drawing.Point(1331, 26);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 42);
            this.button3.TabIndex = 122;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // picboxrefersh
            // 
            this.picboxrefersh.Image = ((System.Drawing.Image)(resources.GetObject("picboxrefersh.Image")));
            this.picboxrefersh.Location = new System.Drawing.Point(291, 34);
            this.picboxrefersh.Margin = new System.Windows.Forms.Padding(4);
            this.picboxrefersh.Name = "picboxrefersh";
            this.picboxrefersh.Size = new System.Drawing.Size(41, 32);
            this.picboxrefersh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxrefersh.TabIndex = 123;
            this.picboxrefersh.TabStop = false;
            this.picboxrefersh.Click += new System.EventHandler(this.picboxrefersh_Click);
            // 
            // pnlManageBook
            // 
            this.pnlManageBook.AutoSize = true;
            this.pnlManageBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlManageBook.Controls.Add(this.picboxrefersh);
            this.pnlManageBook.Controls.Add(this.button3);
            this.pnlManageBook.Controls.Add(this.label1);
            this.pnlManageBook.Controls.Add(this.dataGridissueBook);
            this.pnlManageBook.Controls.Add(this.txtSearch);
            this.pnlManageBook.Controls.Add(this.label3);
            this.pnlManageBook.Controls.Add(this.label4);
            this.pnlManageBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManageBook.Location = new System.Drawing.Point(0, 49);
            this.pnlManageBook.Margin = new System.Windows.Forms.Padding(4);
            this.pnlManageBook.Name = "pnlManageBook";
            this.pnlManageBook.Size = new System.Drawing.Size(1436, 634);
            this.pnlManageBook.TabIndex = 112;
            this.pnlManageBook.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlManageBook_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 671);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1436, 12);
            this.panel5.TabIndex = 153;
            // 
            // ManageIssuebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1436, 683);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlManageBook);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
          
            this.Text = "ManageIssuebook";
            this.Load += new System.EventHandler(this.ManageIssuebook_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridissueBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrefersh)).EndInit();
            this.pnlManageBook.ResumeLayout(false);
            this.pnlManageBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnrenewbook;
        private System.Windows.Forms.Button btnManageReturnbook;
        private System.Windows.Forms.Button btnMissingbook;
        private System.Windows.Forms.Button btnissue;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridissueBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAvailableBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookBarcodeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalReturnBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox picboxrefersh;
        private System.Windows.Forms.Panel pnlManageBook;
        private System.Windows.Forms.Panel panel5;
    }
}