namespace LMS.WIN.Forms.ManageCandidate
{
    partial class ManageCandidates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCandidates));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridCandidate = new System.Windows.Forms.DataGridView();
            this.CandidateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOSDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOSDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThumbImpression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddCandidate = new System.Windows.Forms.Button();
            this.picboxrefersh = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboxCandidateType = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddNewBooks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCandidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrefersh)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(796, 158);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(335, 30);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1184, 176);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 34);
            this.button3.TabIndex = 25;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(849, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Add, Edit, Delete your Candidate through manage Candidate.";
            // 
            // dataGridCandidate
            // 
            this.dataGridCandidate.AllowUserToResizeColumns = false;
            this.dataGridCandidate.AllowUserToResizeRows = false;
            this.dataGridCandidate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCandidate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCandidate.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCandidate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCandidate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridCandidate.ColumnHeadersHeight = 45;
            this.dataGridCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridCandidate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidateID,
            this.Name,
            this.ContactNumber,
            this.Role,
            this.ServiceNo,
            this.CourseID,
            this.CourseName,
            this.FromDate,
            this.ToDate,
            this.TOSDate,
            this.SOSDate,
            this.Barcode,
            this.ThumbImpression,
            this.View,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCandidate.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridCandidate.EnableHeadersVisualStyles = false;
            this.dataGridCandidate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(129)))));
            this.dataGridCandidate.Location = new System.Drawing.Point(31, 258);
            this.dataGridCandidate.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridCandidate.MultiSelect = false;
            this.dataGridCandidate.Name = "dataGridCandidate";
            this.dataGridCandidate.ReadOnly = true;
            this.dataGridCandidate.RowHeadersVisible = false;
            this.dataGridCandidate.RowHeadersWidth = 60;
            this.dataGridCandidate.RowTemplate.Height = 30;
            this.dataGridCandidate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCandidate.Size = new System.Drawing.Size(1392, 310);
            this.dataGridCandidate.TabIndex = 22;
            this.dataGridCandidate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCandidate_CellContentClick);
            this.dataGridCandidate.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridCandidate_CellFormatting);
            this.dataGridCandidate.SelectionChanged += new System.EventHandler(this.dataGridCandidate_SelectionChanged);
            this.dataGridCandidate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridCandidate_KeyDown);
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
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "ContactNumber";
            this.ContactNumber.HeaderText = "ContactNumber";
            this.ContactNumber.MinimumWidth = 6;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // ServiceNo
            // 
            this.ServiceNo.DataPropertyName = "ServiceNo";
            this.ServiceNo.HeaderText = "ServiceNo";
            this.ServiceNo.MinimumWidth = 6;
            this.ServiceNo.Name = "ServiceNo";
            this.ServiceNo.ReadOnly = true;
            // 
            // CourseID
            // 
            this.CourseID.DataPropertyName = "CourseID";
            this.CourseID.HeaderText = "CourseID";
            this.CourseID.MinimumWidth = 6;
            this.CourseID.Name = "CourseID";
            this.CourseID.ReadOnly = true;
            this.CourseID.Visible = false;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "CourseName";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Visible = false;
            // 
            // FromDate
            // 
            this.FromDate.DataPropertyName = "FromDate";
            this.FromDate.HeaderText = "FromDate";
            this.FromDate.MinimumWidth = 6;
            this.FromDate.Name = "FromDate";
            this.FromDate.ReadOnly = true;
            this.FromDate.Visible = false;
            // 
            // ToDate
            // 
            this.ToDate.DataPropertyName = "ToDate";
            this.ToDate.HeaderText = "ToDate";
            this.ToDate.MinimumWidth = 6;
            this.ToDate.Name = "ToDate";
            this.ToDate.ReadOnly = true;
            this.ToDate.Visible = false;
            // 
            // TOSDate
            // 
            this.TOSDate.DataPropertyName = "TOSDate";
            this.TOSDate.HeaderText = "TOSDate";
            this.TOSDate.MinimumWidth = 6;
            this.TOSDate.Name = "TOSDate";
            this.TOSDate.ReadOnly = true;
            this.TOSDate.Visible = false;
            // 
            // SOSDate
            // 
            this.SOSDate.DataPropertyName = "SOSDate";
            this.SOSDate.HeaderText = "SOSDate";
            this.SOSDate.MinimumWidth = 6;
            this.SOSDate.Name = "SOSDate";
            this.SOSDate.ReadOnly = true;
            this.SOSDate.Visible = false;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MinimumWidth = 6;
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Visible = false;
            // 
            // ThumbImpression
            // 
            this.ThumbImpression.DataPropertyName = "ThumbImpression";
            this.ThumbImpression.HeaderText = "ThumbImpression";
            this.ThumbImpression.MinimumWidth = 6;
            this.ThumbImpression.Name = "ThumbImpression";
            this.ThumbImpression.ReadOnly = true;
            this.ThumbImpression.Visible = false;
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
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.FillWeight = 30F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.FillWeight = 30F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnAddCandidate
            // 
            this.btnAddCandidate.BackColor = System.Drawing.Color.Teal;
            this.btnAddCandidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCandidate.FlatAppearance.BorderSize = 0;
            this.btnAddCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCandidate.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnAddCandidate.ForeColor = System.Drawing.Color.White;
            this.btnAddCandidate.Location = new System.Drawing.Point(1248, 178);
            this.btnAddCandidate.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCandidate.Name = "btnAddCandidate";
            this.btnAddCandidate.Size = new System.Drawing.Size(176, 32);
            this.btnAddCandidate.TabIndex = 21;
            this.btnAddCandidate.Text = "Add Candidate";
            this.btnAddCandidate.UseVisualStyleBackColor = false;
            this.btnAddCandidate.Visible = false;
            this.btnAddCandidate.Click += new System.EventHandler(this.btnAddCandidate_Click);
            // 
            // picboxrefersh
            // 
            this.picboxrefersh.Image = ((System.Drawing.Image)(resources.GetObject("picboxrefersh.Image")));
            this.picboxrefersh.Location = new System.Drawing.Point(545, 195);
            this.picboxrefersh.Margin = new System.Windows.Forms.Padding(4);
            this.picboxrefersh.Name = "picboxrefersh";
            this.picboxrefersh.Size = new System.Drawing.Size(41, 32);
            this.picboxrefersh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picboxrefersh.TabIndex = 145;
            this.picboxrefersh.TabStop = false;
            this.picboxrefersh.Click += new System.EventHandler(this.picboxrefersh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(623, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 146;
            this.label1.Text = "Search Candidate";
            // 
            // cmboxCandidateType
            // 
            this.cmboxCandidateType.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmboxCandidateType.FormattingEnabled = true;
            this.cmboxCandidateType.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.cmboxCandidateType.Location = new System.Drawing.Point(250, 158);
            this.cmboxCandidateType.Margin = new System.Windows.Forms.Padding(4);
            this.cmboxCandidateType.Name = "cmboxCandidateType";
            this.cmboxCandidateType.Size = new System.Drawing.Size(336, 29);
            this.cmboxCandidateType.TabIndex = 147;
            this.cmboxCandidateType.SelectedValueChanged += new System.EventHandler(this.cmboxCandidateType_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label13.Location = new System.Drawing.Point(43, 158);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 21);
            this.label13.TabIndex = 148;
            this.label13.Text = "Select Candidate Role";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.Teal;
            this.btnExportExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(1282, 222);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(143, 34);
            this.btnExportExcel.TabIndex = 149;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Visible = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.BackColor = System.Drawing.Color.Teal;
            this.btnImportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportExcel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnImportExcel.ForeColor = System.Drawing.Color.White;
            this.btnImportExcel.Location = new System.Drawing.Point(1126, 222);
            this.btnImportExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.Size = new System.Drawing.Size(143, 34);
            this.btnImportExcel.TabIndex = 150;
            this.btnImportExcel.Text = "Import Excel";
            this.btnImportExcel.UseVisualStyleBackColor = false;
            this.btnImportExcel.Visible = false;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(129)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnAddNewBooks);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1436, 97);
            this.panel1.TabIndex = 151;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(429, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 93);
            this.button2.TabIndex = 17;
            this.button2.Text = "   Export Excel";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(224, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 93);
            this.button4.TabIndex = 16;
            this.button4.Text = "   Import Excel";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAddNewBooks
            // 
            this.btnAddNewBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewBooks.FlatAppearance.BorderSize = 0;
            this.btnAddNewBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAddNewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBooks.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewBooks.Image")));
            this.btnAddNewBooks.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewBooks.Name = "btnAddNewBooks";
            this.btnAddNewBooks.Size = new System.Drawing.Size(224, 93);
            this.btnAddNewBooks.TabIndex = 15;
            this.btnAddNewBooks.Text = "   Add New Student";
            this.btnAddNewBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewBooks.UseVisualStyleBackColor = true;
            this.btnAddNewBooks.Click += new System.EventHandler(this.btnAddNewBooks_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(844, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "Manage Students";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(129)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(737, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(42)))), ((int)(((byte)(129)))));
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 575);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1436, 30);
            this.panel5.TabIndex = 152;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(466, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(322, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Copyrights © 2025. All rights Reserved ";
            // 
            // ManageCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1436, 605);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnImportExcel);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmboxCandidateType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picboxrefersh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridCandidate);
            this.Controls.Add(this.btnAddCandidate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
          
            this.Text = "ManageCandidates";
            this.Load += new System.EventHandler(this.ManageCandidates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCandidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrefersh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridCandidate;
        private System.Windows.Forms.Button btnAddCandidate;
        private System.Windows.Forms.PictureBox picboxrefersh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboxCandidateType;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddNewBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOSDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOSDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThumbImpression;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}