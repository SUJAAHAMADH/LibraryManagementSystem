namespace LMS.WIN.Forms.Reports
{
    partial class frmBookWiseReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookWiseReport));
            this.dataGridBook = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRestricted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbPublication = new System.Windows.Forms.PictureBox();
            this.pbAuthor = new System.Windows.Forms.PictureBox();
            this.pbCategory = new System.Windows.Forms.PictureBox();
            this.cbPublication = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAuther = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPublication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridBook
            // 
            this.dataGridBook.AllowUserToResizeRows = false;
            this.dataGridBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBook.BackgroundColor = System.Drawing.Color.White;
            this.dataGridBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBook.ColumnHeadersHeight = 20;
            this.dataGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.BookID,
            this.Category,
            this.Author,
            this.Publisher,
            this.Edition,
            this.Language,
            this.ISBN,
            this.Price,
            this.Description,
            this.Funds,
            this.IsRestricted,
            this.CategoryID,
            this.TotalQuantity,
            this.AuthorID,
            this.PublisherID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBook.GridColor = System.Drawing.Color.White;
            this.dataGridBook.Location = new System.Drawing.Point(23, 157);
            this.dataGridBook.Name = "dataGridBook";
            this.dataGridBook.ReadOnly = true;
            this.dataGridBook.RowHeadersVisible = false;
            this.dataGridBook.RowHeadersWidth = 60;
            this.dataGridBook.RowTemplate.Height = 30;
            this.dataGridBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBook.Size = new System.Drawing.Size(1093, 393);
            this.dataGridBook.TabIndex = 142;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // BookID
            // 
            this.BookID.DataPropertyName = "BookID";
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Visible = false;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.FillWeight = 67.88091F;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.FillWeight = 67.88091F;
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.FillWeight = 67.88091F;
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // Edition
            // 
            this.Edition.DataPropertyName = "Edition";
            this.Edition.FillWeight = 71.26904F;
            this.Edition.HeaderText = "Edition";
            this.Edition.Name = "Edition";
            this.Edition.ReadOnly = true;
            this.Edition.Visible = false;
            // 
            // Language
            // 
            this.Language.DataPropertyName = "Language";
            this.Language.FillWeight = 50F;
            this.Language.HeaderText = "Language";
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Visible = false;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 48.37807F;
            this.Price.HeaderText = "Cost";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.FillWeight = 67.88091F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Funds
            // 
            this.Funds.DataPropertyName = "Funds";
            this.Funds.HeaderText = "Funds";
            this.Funds.Name = "Funds";
            this.Funds.ReadOnly = true;
            this.Funds.Visible = false;
            // 
            // IsRestricted
            // 
            this.IsRestricted.DataPropertyName = "IsRestricted";
            this.IsRestricted.HeaderText = "IsRestricted";
            this.IsRestricted.Name = "IsRestricted";
            this.IsRestricted.ReadOnly = true;
            this.IsRestricted.Visible = false;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            this.CategoryID.Visible = false;
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.DataPropertyName = "TotalQuantity";
            this.TotalQuantity.FillWeight = 48.37807F;
            this.TotalQuantity.HeaderText = "TotalQuantity";
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.ReadOnly = true;
            // 
            // AuthorID
            // 
            this.AuthorID.DataPropertyName = "AuthorID";
            this.AuthorID.HeaderText = "AuthorID";
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.ReadOnly = true;
            this.AuthorID.Visible = false;
            // 
            // PublisherID
            // 
            this.PublisherID.DataPropertyName = "PublisherID";
            this.PublisherID.HeaderText = "PublisherID";
            this.PublisherID.Name = "PublisherID";
            this.PublisherID.ReadOnly = true;
            this.PublisherID.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(993, 119);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 32);
            this.btnReset.TabIndex = 150;
            this.btnReset.Text = "  Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(812, 119);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(155, 32);
            this.btnExport.TabIndex = 149;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 141;
            this.label2.Text = "Books Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(260, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 14);
            this.label3.TabIndex = 142;
            this.label3.Text = "See All Books Here and Filter as you want.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1132, 54);
            this.panel2.TabIndex = 164;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 54);
            this.panel1.TabIndex = 144;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1087, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(45, 54);
            this.panel5.TabIndex = 143;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 577);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1132, 5);
            this.panel4.TabIndex = 166;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.pbPublication);
            this.panel3.Controls.Add(this.pbAuthor);
            this.panel3.Controls.Add(this.pbCategory);
            this.panel3.Controls.Add(this.cbPublication);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cbSubject);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbAuther);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1132, 55);
            this.panel3.TabIndex = 167;
            // 
            // pbPublication
            // 
            this.pbPublication.Image = ((System.Drawing.Image)(resources.GetObject("pbPublication.Image")));
            this.pbPublication.Location = new System.Drawing.Point(1087, 15);
            this.pbPublication.Name = "pbPublication";
            this.pbPublication.Size = new System.Drawing.Size(29, 26);
            this.pbPublication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPublication.TabIndex = 176;
            this.pbPublication.TabStop = false;
            this.pbPublication.Click += new System.EventHandler(this.pbPublication_Click);
            // 
            // pbAuthor
            // 
            this.pbAuthor.Image = ((System.Drawing.Image)(resources.GetObject("pbAuthor.Image")));
            this.pbAuthor.Location = new System.Drawing.Point(668, 15);
            this.pbAuthor.Name = "pbAuthor";
            this.pbAuthor.Size = new System.Drawing.Size(29, 26);
            this.pbAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAuthor.TabIndex = 175;
            this.pbAuthor.TabStop = false;
            this.pbAuthor.Click += new System.EventHandler(this.pbAuthor_Click);
            // 
            // pbCategory
            // 
            this.pbCategory.Image = ((System.Drawing.Image)(resources.GetObject("pbCategory.Image")));
            this.pbCategory.Location = new System.Drawing.Point(335, 15);
            this.pbCategory.Name = "pbCategory";
            this.pbCategory.Size = new System.Drawing.Size(29, 26);
            this.pbCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCategory.TabIndex = 174;
            this.pbCategory.TabStop = false;
            this.pbCategory.Click += new System.EventHandler(this.pbCategory_Click);
            // 
            // cbPublication
            // 
            this.cbPublication.BackColor = System.Drawing.Color.White;
            this.cbPublication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPublication.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPublication.FormattingEnabled = true;
            this.cbPublication.Location = new System.Drawing.Point(821, 15);
            this.cbPublication.Name = "cbPublication";
            this.cbPublication.Size = new System.Drawing.Size(262, 26);
            this.cbPublication.TabIndex = 173;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.label5.Location = new System.Drawing.Point(728, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 172;
            this.label5.Text = "Publication";
            // 
            // cbSubject
            // 
            this.cbSubject.BackColor = System.Drawing.Color.White;
            this.cbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSubject.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(105, 15);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(223, 26);
            this.cbSubject.TabIndex = 171;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.label4.Location = new System.Drawing.Point(27, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 170;
            this.label4.Text = "Category";
            // 
            // cbAuther
            // 
            this.cbAuther.BackColor = System.Drawing.Color.White;
            this.cbAuther.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAuther.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuther.FormattingEnabled = true;
            this.cbAuther.Location = new System.Drawing.Point(444, 15);
            this.cbAuther.Name = "cbAuther";
            this.cbAuther.Size = new System.Drawing.Size(218, 26);
            this.cbAuther.TabIndex = 169;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(383, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 168;
            this.label1.Text = "Auther";
            // 
            // frmBookWiseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 582);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dataGridBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookWiseReport";
            this.Load += new System.EventHandler(this.FrmBookWiseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPublication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridBook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPublication;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAuther;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funds;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRestricted;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherID;
        private System.Windows.Forms.PictureBox pbPublication;
        private System.Windows.Forms.PictureBox pbAuthor;
        private System.Windows.Forms.PictureBox pbCategory;
    }
}