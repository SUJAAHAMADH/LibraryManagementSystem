namespace LMS.WIN.Forms.Reports
{
    partial class frmCandidatesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCandidatesReport));
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.datagridReportList = new System.Windows.Forms.DataGridView();
            this.CandidateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stream = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcademicYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PermanentAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOSDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOSDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbPersonType = new System.Windows.Forms.ComboBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.datagridReportList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1195, 112);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(117, 32);
            this.btnExport.TabIndex = 10;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1320, 112);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 32);
            this.btnReset.TabIndex = 139;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // datagridReportList
            // 
            this.datagridReportList.AllowUserToResizeColumns = false;
            this.datagridReportList.AllowUserToResizeRows = false;
            this.datagridReportList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridReportList.BackgroundColor = System.Drawing.Color.White;
            this.datagridReportList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridReportList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridReportList.ColumnHeadersHeight = 20;
            this.datagridReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridReportList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidateID,
            this.Name,
            this.ContactNumber,
            this.Role,
            this.ServiceNo,
            this.DOB,
            this.Stream,
            this.AcademicYear,
            this.PermanentAddress,
            this.Email,
            this.CourseID,
            this.CourseName,
            this.FromDate,
            this.ToDate,
            this.TOSDate,
            this.SOSDate});
            this.datagridReportList.GridColor = System.Drawing.Color.White;
            this.datagridReportList.Location = new System.Drawing.Point(23, 151);
            this.datagridReportList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datagridReportList.MultiSelect = false;
            this.datagridReportList.Name = "datagridReportList";
            this.datagridReportList.ReadOnly = true;
            this.datagridReportList.RowHeadersVisible = false;
            this.datagridReportList.RowHeadersWidth = 60;
            this.datagridReportList.RowTemplate.Height = 30;
            this.datagridReportList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridReportList.Size = new System.Drawing.Size(1392, 484);
            this.datagridReportList.TabIndex = 140;
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
            this.ServiceNo.DataPropertyName = "RoleID";
            this.ServiceNo.HeaderText = "Role ID";
            this.ServiceNo.MinimumWidth = 6;
            this.ServiceNo.Name = "ServiceNo";
            this.ServiceNo.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.HeaderText = "DOB";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Stream
            // 
            this.Stream.DataPropertyName = "Stream";
            this.Stream.HeaderText = "Stream";
            this.Stream.MinimumWidth = 6;
            this.Stream.Name = "Stream";
            this.Stream.ReadOnly = true;
            // 
            // AcademicYear
            // 
            this.AcademicYear.DataPropertyName = "AcademicYear";
            this.AcademicYear.HeaderText = "Academic Year";
            this.AcademicYear.MinimumWidth = 6;
            this.AcademicYear.Name = "AcademicYear";
            this.AcademicYear.ReadOnly = true;
            // 
            // PermanentAddress
            // 
            this.PermanentAddress.DataPropertyName = "PermanentAddress";
            this.PermanentAddress.HeaderText = "Address";
            this.PermanentAddress.MinimumWidth = 6;
            this.PermanentAddress.Name = "PermanentAddress";
            this.PermanentAddress.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 710);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1427, 6);
            this.panel4.TabIndex = 165;
            // 
            // cbPersonType
            // 
            this.cbPersonType.Font = new System.Drawing.Font("Calibri", 16F);
            this.cbPersonType.FormattingEnabled = true;
            this.cbPersonType.Items.AddRange(new object[] {
            "STUDENT",
            "TEACHER"});
            this.cbPersonType.Location = new System.Drawing.Point(265, 87);
            this.cbPersonType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPersonType.Name = "cbPersonType";
            this.cbPersonType.Size = new System.Drawing.Size(320, 41);
            this.cbPersonType.TabIndex = 168;
            this.cbPersonType.SelectedIndexChanged += new System.EventHandler(this.cbPersonType_SelectedIndexChanged);
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Calibri", 16F);
            this.lblPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.lblPerson.Location = new System.Drawing.Point(16, 87);
            this.lblPerson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(216, 33);
            this.lblPerson.TabIndex = 167;
            this.lblPerson.Text = "Select Person Type";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 32);
            this.label2.TabIndex = 141;
            this.label2.Text = "Member Report";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(335, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 16);
            this.label3.TabIndex = 142;
            this.label3.Text = "See All Member Details Here and Filter as you want.";
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1427, 66);
            this.panel2.TabIndex = 169;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 66);
            this.panel1.TabIndex = 144;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1367, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 66);
            this.panel5.TabIndex = 143;
            // 
            // frmCandidatesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbPersonType);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.datagridReportList);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         
            this.Text = "frmCandidatesReport";
            this.Load += new System.EventHandler(this.FrmCandidatesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridReportList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView datagridReportList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbPersonType;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stream;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcademicYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn PermanentAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOSDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOSDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
    }
}