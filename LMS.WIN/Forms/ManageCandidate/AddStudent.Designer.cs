namespace LMS.WIN.Forms.ManageCandidate
{
    partial class AddStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbLibrary = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblStream = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPerAddress = new System.Windows.Forms.Label();
            this.lblPresentAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPContact = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbStudentId = new System.Windows.Forms.TextBox();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cbStream = new System.Windows.Forms.ComboBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbPerAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPreAddress = new System.Windows.Forms.TextBox();
            this.tbPContact = new System.Windows.Forms.TextBox();
            this.tbSContact = new System.Windows.Forms.TextBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibrary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.pbLibrary);
            this.panelTop.Controls.Add(this.pbClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1114, 50);
            this.panelTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(241, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 4);
            this.panel1.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(65, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 29);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Add Student";
            // 
            // pbLibrary
            // 
            this.pbLibrary.BackColor = System.Drawing.Color.White;
            this.pbLibrary.Image = ((System.Drawing.Image)(resources.GetObject("pbLibrary.Image")));
            this.pbLibrary.Location = new System.Drawing.Point(10, 5);
            this.pbLibrary.Name = "pbLibrary";
            this.pbLibrary.Size = new System.Drawing.Size(45, 40);
            this.pbLibrary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLibrary.TabIndex = 2;
            this.pbLibrary.TabStop = false;
            // 
            // pbClose
            // 
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(1072, 10);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(30, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClose.TabIndex = 3;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(446, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student Details";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblStudentID.ForeColor = System.Drawing.Color.Black;
            this.lblStudentID.Location = new System.Drawing.Point(38, 161);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(117, 29);
            this.lblStudentID.TabIndex = 7;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(38, 215);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(156, 29);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Student Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblDOB.ForeColor = System.Drawing.Color.Black;
            this.lblDOB.Location = new System.Drawing.Point(38, 273);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(140, 29);
            this.lblDOB.TabIndex = 9;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblStream
            // 
            this.lblStream.AutoSize = true;
            this.lblStream.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblStream.ForeColor = System.Drawing.Color.Black;
            this.lblStream.Location = new System.Drawing.Point(38, 329);
            this.lblStream.Name = "lblStream";
            this.lblStream.Size = new System.Drawing.Size(85, 29);
            this.lblStream.TabIndex = 10;
            this.lblStream.Text = "Stream";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(38, 385);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(159, 29);
            this.lblYear.TabIndex = 11;
            this.lblYear.Text = "Acadamic Year";
            // 
            // lblPerAddress
            // 
            this.lblPerAddress.AutoSize = true;
            this.lblPerAddress.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblPerAddress.ForeColor = System.Drawing.Color.Black;
            this.lblPerAddress.Location = new System.Drawing.Point(38, 441);
            this.lblPerAddress.Name = "lblPerAddress";
            this.lblPerAddress.Size = new System.Drawing.Size(217, 29);
            this.lblPerAddress.TabIndex = 12;
            this.lblPerAddress.Text = "Permanent Address ";
            // 
            // lblPresentAddress
            // 
            this.lblPresentAddress.AutoSize = true;
            this.lblPresentAddress.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblPresentAddress.ForeColor = System.Drawing.Color.Black;
            this.lblPresentAddress.Location = new System.Drawing.Point(38, 525);
            this.lblPresentAddress.Name = "lblPresentAddress";
            this.lblPresentAddress.Size = new System.Drawing.Size(177, 29);
            this.lblPresentAddress.TabIndex = 13;
            this.lblPresentAddress.Text = "Present Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(38, 625);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 29);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // lblPContact
            // 
            this.lblPContact.AutoSize = true;
            this.lblPContact.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblPContact.ForeColor = System.Drawing.Color.Black;
            this.lblPContact.Location = new System.Drawing.Point(38, 683);
            this.lblPContact.Name = "lblPContact";
            this.lblPContact.Size = new System.Drawing.Size(196, 29);
            this.lblPContact.TabIndex = 15;
            this.lblPContact.Text = "Parent Contact No";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblContactNo.ForeColor = System.Drawing.Color.Black;
            this.lblContactNo.Location = new System.Drawing.Point(38, 748);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(207, 29);
            this.lblContactNo.TabIndex = 16;
            this.lblContactNo.Text = "Student Contact No";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(254)))));
            this.panel2.Location = new System.Drawing.Point(43, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 4);
            this.panel2.TabIndex = 6;
            // 
            // tbStudentId
            // 
            this.tbStudentId.BackColor = System.Drawing.Color.White;
            this.tbStudentId.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbStudentId.Location = new System.Drawing.Point(294, 158);
            this.tbStudentId.Name = "tbStudentId";
            this.tbStudentId.Size = new System.Drawing.Size(241, 34);
            this.tbStudentId.TabIndex = 18;
            // 
            // tbStudentName
            // 
            this.tbStudentName.BackColor = System.Drawing.Color.White;
            this.tbStudentName.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbStudentName.Location = new System.Drawing.Point(294, 212);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(365, 34);
            this.tbStudentName.TabIndex = 19;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = " dd/MM/yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Calibri", 16F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(294, 270);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(241, 34);
            this.dtpDOB.TabIndex = 20;
            this.dtpDOB.Value = new System.DateTime(2025, 2, 3, 0, 0, 0, 0);
            // 
            // cbStream
            // 
            this.cbStream.Font = new System.Drawing.Font("Calibri", 16F);
            this.cbStream.FormattingEnabled = true;
            this.cbStream.Items.AddRange(new object[] {
            "UG",
            "PG"});
            this.cbStream.Location = new System.Drawing.Point(294, 326);
            this.cbStream.Name = "cbStream";
            this.cbStream.Size = new System.Drawing.Size(241, 34);
            this.cbStream.TabIndex = 21;
            // 
            // tbYear
            // 
            this.tbYear.BackColor = System.Drawing.Color.White;
            this.tbYear.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbYear.Location = new System.Drawing.Point(294, 382);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(241, 34);
            this.tbYear.TabIndex = 22;
            // 
            // tbPerAddress
            // 
            this.tbPerAddress.BackColor = System.Drawing.Color.White;
            this.tbPerAddress.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbPerAddress.Location = new System.Drawing.Point(294, 441);
            this.tbPerAddress.Multiline = true;
            this.tbPerAddress.Name = "tbPerAddress";
            this.tbPerAddress.Size = new System.Drawing.Size(365, 74);
            this.tbPerAddress.TabIndex = 23;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbEmail.Location = new System.Drawing.Point(294, 622);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(365, 34);
            this.tbEmail.TabIndex = 24;
            // 
            // tbPreAddress
            // 
            this.tbPreAddress.BackColor = System.Drawing.Color.White;
            this.tbPreAddress.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbPreAddress.Location = new System.Drawing.Point(294, 525);
            this.tbPreAddress.Multiline = true;
            this.tbPreAddress.Name = "tbPreAddress";
            this.tbPreAddress.Size = new System.Drawing.Size(365, 74);
            this.tbPreAddress.TabIndex = 25;
            // 
            // tbPContact
            // 
            this.tbPContact.BackColor = System.Drawing.Color.White;
            this.tbPContact.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbPContact.Location = new System.Drawing.Point(294, 680);
            this.tbPContact.Name = "tbPContact";
            this.tbPContact.Size = new System.Drawing.Size(241, 34);
            this.tbPContact.TabIndex = 26;
            // 
            // tbSContact
            // 
            this.tbSContact.BackColor = System.Drawing.Color.White;
            this.tbSContact.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbSContact.Location = new System.Drawing.Point(294, 743);
            this.tbSContact.Name = "tbSContact";
            this.tbSContact.Size = new System.Drawing.Size(241, 34);
            this.tbSContact.TabIndex = 27;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.Color.Silver;
            this.pbPhoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbPhoto.ErrorImage")));
            this.pbPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPhoto.InitialImage")));
            this.pbPhoto.Location = new System.Drawing.Point(822, 190);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(145, 141);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 28;
            this.pbPhoto.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(831, 344);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(127, 38);
            this.btnUpload.TabIndex = 29;
            this.btnUpload.Text = "Upload Photo";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(767, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 252);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photo";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(798, 523);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 46);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnClear.Location = new System.Drawing.Point(798, 584);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(199, 46);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(8)))), ((int)(((byte)(26)))));
            this.btnCancel.Location = new System.Drawing.Point(798, 645);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(199, 46);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(254)))));
            this.panel3.Location = new System.Drawing.Point(43, 811);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1026, 38);
            this.panel3.TabIndex = 34;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 861);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.tbSContact);
            this.Controls.Add(this.tbPContact);
            this.Controls.Add(this.tbPreAddress);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPerAddress);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.cbStream);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.tbStudentId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblPContact);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPresentAddress);
            this.Controls.Add(this.lblPerAddress);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblStream);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibrary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbLibrary;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblStream;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPerAddress;
        private System.Windows.Forms.Label lblPresentAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPContact;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbStudentId;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cbStream;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbPerAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPreAddress;
        private System.Windows.Forms.TextBox tbPContact;
        private System.Windows.Forms.TextBox tbSContact;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}