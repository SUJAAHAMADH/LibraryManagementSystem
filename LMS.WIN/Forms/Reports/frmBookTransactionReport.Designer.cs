namespace LMS.WIN.Forms.Reports
{
    partial class frmBookTransactionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookTransactionReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtendDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStartDateDate = new System.Windows.Forms.DateTimePicker();
            this.pbFilter = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridissueBook = new System.Windows.Forms.DataGridView();
            this.IssueBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RollId = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilter)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridissueBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1077, 55);
            this.panel3.TabIndex = 173;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtendDate);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.dtStartDateDate);
            this.panel8.Controls.Add(this.pbFilter);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(560, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(507, 55);
            this.panel8.TabIndex = 2;
            // 
            // dtendDate
            // 
            this.dtendDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtendDate.CustomFormat = "dd-MM-yyyy";
            this.dtendDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtendDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtendDate.Location = new System.Drawing.Point(306, 15);
            this.dtendDate.Name = "dtendDate";
            this.dtendDate.Size = new System.Drawing.Size(186, 26);
            this.dtendDate.TabIndex = 178;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 170;
            this.label4.Text = "From";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(274, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 176;
            this.label1.Text = "To";
            // 
            // dtStartDateDate
            // 
            this.dtStartDateDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtStartDateDate.CustomFormat = "dd-MM-yyyy";
            this.dtStartDateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDateDate.Location = new System.Drawing.Point(67, 15);
            this.dtStartDateDate.Name = "dtStartDateDate";
            this.dtStartDateDate.Size = new System.Drawing.Size(186, 26);
            this.dtStartDateDate.TabIndex = 177;
            // 
            // pbFilter
            // 
            this.pbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFilter.Image = ((System.Drawing.Image)(resources.GetObject("pbFilter.Image")));
            this.pbFilter.Location = new System.Drawing.Point(673, 11);
            this.pbFilter.Name = "pbFilter";
            this.pbFilter.Size = new System.Drawing.Size(29, 26);
            this.pbFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFilter.TabIndex = 174;
            this.pbFilter.TabStop = false;
            this.pbFilter.Click += new System.EventHandler(this.pbFilter_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1067, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 55);
            this.panel7.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSearch);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(560, 55);
            this.panel6.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtSearch.Location = new System.Drawing.Point(256, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 29);
            this.txtSearch.TabIndex = 179;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(514, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 180;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 19);
            this.label5.TabIndex = 181;
            this.label5.Text = "Find not return book by Roll Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(363, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 14);
            this.label3.TabIndex = 142;
            this.label3.Text = "See All Book Transaction Here and Filter as you want.";
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
            this.panel2.Size = new System.Drawing.Size(1077, 54);
            this.panel2.TabIndex = 171;
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
            this.pictureBox2.Location = new System.Drawing.Point(9, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1032, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(45, 54);
            this.panel5.TabIndex = 143;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 26);
            this.label2.TabIndex = 141;
            this.label2.Text = "Books Transaction Report";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 487);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1077, 5);
            this.panel4.TabIndex = 172;
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
            this.btnReset.Location = new System.Drawing.Point(44, 126);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 32);
            this.btnReset.TabIndex = 170;
            this.btnReset.Text = "  Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(173, 126);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(155, 32);
            this.btnExport.TabIndex = 169;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridissueBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridissueBook.ColumnHeadersHeight = 50;
            this.dataGridissueBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridissueBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IssueBookID,
            this.CandidateName,
            this.RollId,
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridissueBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridissueBook.EnableHeadersVisualStyles = false;
            this.dataGridissueBook.GridColor = System.Drawing.Color.White;
            this.dataGridissueBook.Location = new System.Drawing.Point(44, 164);
            this.dataGridissueBook.Name = "dataGridissueBook";
            this.dataGridissueBook.ReadOnly = true;
            this.dataGridissueBook.RowHeadersVisible = false;
            this.dataGridissueBook.RowHeadersWidth = 60;
            this.dataGridissueBook.RowTemplate.Height = 30;
            this.dataGridissueBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridissueBook.Size = new System.Drawing.Size(997, 300);
            this.dataGridissueBook.TabIndex = 178;
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
            this.CandidateName.HeaderText = "Member Name";
            this.CandidateName.MinimumWidth = 6;
            this.CandidateName.Name = "CandidateName";
            this.CandidateName.ReadOnly = true;
            // 
            // RollId
            // 
            this.RollId.DataPropertyName = "RollId";
            this.RollId.HeaderText = "RollId";
            this.RollId.MinimumWidth = 6;
            this.RollId.Name = "RollId";
            this.RollId.ReadOnly = true;
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
            // frmBookTransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 492);
            this.Controls.Add(this.dataGridissueBook);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "frmBookTransactionReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBookTransactionReport_Load);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilter)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridissueBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridissueBook;
        private System.Windows.Forms.DateTimePicker dtendDate;
        private System.Windows.Forms.DateTimePicker dtStartDateDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueBookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RollId;
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
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
    }
}