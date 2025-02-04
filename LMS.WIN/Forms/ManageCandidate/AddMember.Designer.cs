namespace LMS.WIN.Forms.ManageCandidate
{
    partial class AddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMember));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.tbSContact = new System.Windows.Forms.TextBox();
            this.tbPContact = new System.Windows.Forms.TextBox();
            this.tbPreAddress = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPerAddress = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.cbStream = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbRoleId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblPContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPresentAddress = new System.Windows.Forms.Label();
            this.lblPerAddress = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblStream = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRoleID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLibrary = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.cbPersonType = new System.Windows.Forms.ComboBox();
            this.lblPerson = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibrary)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(254)))));
            this.panel3.Location = new System.Drawing.Point(43, 832);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1026, 23);
            this.panel3.TabIndex = 64;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(8)))), ((int)(((byte)(26)))));
            this.btnCancel.Location = new System.Drawing.Point(798, 651);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(199, 46);
            this.btnCancel.TabIndex = 63;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnClear.Location = new System.Drawing.Point(798, 590);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(199, 46);
            this.btnClear.TabIndex = 62;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnClear_MouseLeave);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(798, 529);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(199, 46);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(831, 350);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(127, 38);
            this.btnUpload.TabIndex = 59;
            this.btnUpload.Text = "Upload Photo";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.BackColor = System.Drawing.Color.Silver;
            this.pbPhoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbPhoto.ErrorImage")));
            this.pbPhoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbPhoto.InitialImage")));
            this.pbPhoto.Location = new System.Drawing.Point(822, 196);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(145, 141);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 58;
            this.pbPhoto.TabStop = false;
            // 
            // tbSContact
            // 
            this.tbSContact.BackColor = System.Drawing.Color.White;
            this.tbSContact.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbSContact.Location = new System.Drawing.Point(294, 771);
            this.tbSContact.Name = "tbSContact";
            this.tbSContact.Size = new System.Drawing.Size(241, 34);
            this.tbSContact.TabIndex = 57;
            // 
            // tbPContact
            // 
            this.tbPContact.BackColor = System.Drawing.Color.White;
            this.tbPContact.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbPContact.Location = new System.Drawing.Point(294, 706);
            this.tbPContact.Name = "tbPContact";
            this.tbPContact.Size = new System.Drawing.Size(241, 34);
            this.tbPContact.TabIndex = 56;
            // 
            // tbPreAddress
            // 
            this.tbPreAddress.BackColor = System.Drawing.Color.White;
            this.tbPreAddress.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbPreAddress.Location = new System.Drawing.Point(294, 551);
            this.tbPreAddress.Multiline = true;
            this.tbPreAddress.Name = "tbPreAddress";
            this.tbPreAddress.Size = new System.Drawing.Size(365, 74);
            this.tbPreAddress.TabIndex = 55;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbEmail.Location = new System.Drawing.Point(294, 648);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(365, 34);
            this.tbEmail.TabIndex = 54;
            // 
            // tbPerAddress
            // 
            this.tbPerAddress.BackColor = System.Drawing.Color.White;
            this.tbPerAddress.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbPerAddress.Location = new System.Drawing.Point(294, 467);
            this.tbPerAddress.Multiline = true;
            this.tbPerAddress.Name = "tbPerAddress";
            this.tbPerAddress.Size = new System.Drawing.Size(365, 74);
            this.tbPerAddress.TabIndex = 53;
            // 
            // tbYear
            // 
            this.tbYear.BackColor = System.Drawing.Color.White;
            this.tbYear.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbYear.Location = new System.Drawing.Point(294, 408);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(241, 34);
            this.tbYear.TabIndex = 52;
            // 
            // cbStream
            // 
            this.cbStream.Font = new System.Drawing.Font("Calibri", 16F);
            this.cbStream.FormattingEnabled = true;
            this.cbStream.Items.AddRange(new object[] {
            "UG",
            "PG"});
            this.cbStream.Location = new System.Drawing.Point(294, 297);
            this.cbStream.Name = "cbStream";
            this.cbStream.Size = new System.Drawing.Size(241, 34);
            this.cbStream.TabIndex = 51;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = " dd/MM/yyyy";
            this.dtpDOB.Font = new System.Drawing.Font("Calibri", 16F);
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(294, 353);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(241, 34);
            this.dtpDOB.TabIndex = 50;
            this.dtpDOB.Value = new System.DateTime(2025, 2, 3, 0, 0, 0, 0);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbName.Location = new System.Drawing.Point(294, 243);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(365, 34);
            this.tbName.TabIndex = 49;
            // 
            // tbRoleId
            // 
            this.tbRoleId.BackColor = System.Drawing.Color.White;
            this.tbRoleId.Font = new System.Drawing.Font("Calibri", 16F);
            this.tbRoleId.Location = new System.Drawing.Point(294, 188);
            this.tbRoleId.Name = "tbRoleId";
            this.tbRoleId.Size = new System.Drawing.Size(241, 34);
            this.tbRoleId.TabIndex = 48;
            this.tbRoleId.MouseHover += new System.EventHandler(this.tbRoleId_MouseHover);
            this.tbRoleId.Validating += new System.ComponentModel.CancelEventHandler(this.tbRoleId_Validating);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(209)))), ((int)(((byte)(254)))));
            this.panel2.Location = new System.Drawing.Point(43, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1026, 4);
            this.panel2.TabIndex = 36;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblContactNo.ForeColor = System.Drawing.Color.Black;
            this.lblContactNo.Location = new System.Drawing.Point(38, 774);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(118, 29);
            this.lblContactNo.TabIndex = 47;
            this.lblContactNo.Text = "Mobile No";
            // 
            // lblPContact
            // 
            this.lblPContact.AutoSize = true;
            this.lblPContact.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblPContact.ForeColor = System.Drawing.Color.Black;
            this.lblPContact.Location = new System.Drawing.Point(38, 709);
            this.lblPContact.Name = "lblPContact";
            this.lblPContact.Size = new System.Drawing.Size(196, 29);
            this.lblPContact.TabIndex = 46;
            this.lblPContact.Text = "Parent Contact No";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(38, 651);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 29);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "Email";
            // 
            // lblPresentAddress
            // 
            this.lblPresentAddress.AutoSize = true;
            this.lblPresentAddress.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblPresentAddress.ForeColor = System.Drawing.Color.Black;
            this.lblPresentAddress.Location = new System.Drawing.Point(38, 551);
            this.lblPresentAddress.Name = "lblPresentAddress";
            this.lblPresentAddress.Size = new System.Drawing.Size(177, 29);
            this.lblPresentAddress.TabIndex = 44;
            this.lblPresentAddress.Text = "Present Address";
            // 
            // lblPerAddress
            // 
            this.lblPerAddress.AutoSize = true;
            this.lblPerAddress.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblPerAddress.ForeColor = System.Drawing.Color.Black;
            this.lblPerAddress.Location = new System.Drawing.Point(38, 467);
            this.lblPerAddress.Name = "lblPerAddress";
            this.lblPerAddress.Size = new System.Drawing.Size(217, 29);
            this.lblPerAddress.TabIndex = 43;
            this.lblPerAddress.Text = "Permanent Address ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(38, 411);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(159, 29);
            this.lblYear.TabIndex = 42;
            this.lblYear.Text = "Acadamic Year";
            // 
            // lblStream
            // 
            this.lblStream.AutoSize = true;
            this.lblStream.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblStream.ForeColor = System.Drawing.Color.Black;
            this.lblStream.Location = new System.Drawing.Point(38, 300);
            this.lblStream.Name = "lblStream";
            this.lblStream.Size = new System.Drawing.Size(85, 29);
            this.lblStream.TabIndex = 41;
            this.lblStream.Text = "Stream";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblDOB.ForeColor = System.Drawing.Color.Black;
            this.lblDOB.Location = new System.Drawing.Point(38, 356);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(140, 29);
            this.lblDOB.TabIndex = 40;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(38, 246);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 29);
            this.lblName.TabIndex = 39;
            this.lblName.Text = "Name";
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
            this.lblTitle.Size = new System.Drawing.Size(146, 29);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Add Member";
            // 
            // lblRoleID
            // 
            this.lblRoleID.AutoSize = true;
            this.lblRoleID.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblRoleID.ForeColor = System.Drawing.Color.Black;
            this.lblRoleID.Location = new System.Drawing.Point(38, 191);
            this.lblRoleID.Name = "lblRoleID";
            this.lblRoleID.Size = new System.Drawing.Size(84, 29);
            this.lblRoleID.TabIndex = 38;
            this.lblRoleID.Text = "Role ID";
            // 
            // groupBox1
            // 
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(767, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 252);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photo";
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
            this.label1.Location = new System.Drawing.Point(446, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 39);
            this.label1.TabIndex = 37;
            this.label1.Text = "Member Details";
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
            this.panelTop.TabIndex = 35;
            // 
            // cbPersonType
            // 
            this.cbPersonType.Font = new System.Drawing.Font("Calibri", 16F);
            this.cbPersonType.FormattingEnabled = true;
            this.cbPersonType.Items.AddRange(new object[] {
            "STUDENT",
            "TEACHER"});
            this.cbPersonType.Location = new System.Drawing.Point(293, 141);
            this.cbPersonType.Name = "cbPersonType";
            this.cbPersonType.Size = new System.Drawing.Size(241, 34);
            this.cbPersonType.TabIndex = 66;
            this.cbPersonType.SelectedIndexChanged += new System.EventHandler(this.cbPersonType_SelectedIndexChanged);
            this.cbPersonType.MouseHover += new System.EventHandler(this.cbPersonType_MouseHover);
            this.cbPersonType.Validating += new System.ComponentModel.CancelEventHandler(this.cbPersonType_Validating);
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblPerson.ForeColor = System.Drawing.Color.Red;
            this.lblPerson.Location = new System.Drawing.Point(37, 144);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(199, 29);
            this.lblPerson.TabIndex = 65;
            this.lblPerson.Text = "Select Person Type";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 861);
            this.Controls.Add(this.cbPersonType);
            this.Controls.Add(this.lblPerson);
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
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbRoleId);
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
            this.Controls.Add(this.lblRoleID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMember";
            this.Load += new System.EventHandler(this.AddMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLibrary)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.TextBox tbSContact;
        private System.Windows.Forms.TextBox tbPContact;
        private System.Windows.Forms.TextBox tbPreAddress;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPerAddress;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.ComboBox cbStream;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbRoleId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblPContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPresentAddress;
        private System.Windows.Forms.Label lblPerAddress;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblStream;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRoleID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLibrary;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox cbPersonType;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}