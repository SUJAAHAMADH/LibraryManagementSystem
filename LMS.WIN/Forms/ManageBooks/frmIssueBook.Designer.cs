﻿namespace LMS.WIN.Forms.ManageBooks
{
    partial class frmIssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueBook));
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCandidate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtIssuedDate = new System.Windows.Forms.DateTimePicker();
            this.dtReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.richtextRemark = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.Label();
            this.txtSubCategory = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picThumb = new System.Windows.Forms.PictureBox();
            this.txtbookname = new System.Windows.Forms.Label();
            this.groupBoxCandidateDetails = new System.Windows.Forms.GroupBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBoxbookDetails = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.BtnCapture = new System.Windows.Forms.Button();
            this.txtBarcodeSearch = new System.Windows.Forms.TextBox();
            this.lblCandidateBarcode = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtCountLbl = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).BeginInit();
            this.groupBoxCandidateDetails.SuspendLayout();
            this.groupBoxbookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.White;
            this.txtBarcode.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBarcode.Location = new System.Drawing.Point(320, 86);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(329, 27);
            this.txtBarcode.TabIndex = 5;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Arial", 10F);
            this.lblBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(49)))));
            this.lblBarcode.Location = new System.Drawing.Point(29, 90);
            this.lblBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(239, 19);
            this.lblBarcode.TabIndex = 6;
            this.lblBarcode.Text = "Enter Barcode And Press Enter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.label4.Location = new System.Drawing.Point(940, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thumb Impression";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSerialNo.Location = new System.Drawing.Point(1079, 431);
            this.txtSerialNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(329, 27);
            this.txtSerialNo.TabIndex = 16;
            this.txtSerialNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUID_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(49)))));
            this.label9.Location = new System.Drawing.Point(675, 437);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(335, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Press Enter && Search Member  By Serial No";
            // 
            // txtCandidate
            // 
            this.txtCandidate.Font = new System.Drawing.Font("Arial", 10F);
            this.txtCandidate.Location = new System.Drawing.Point(320, 433);
            this.txtCandidate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCandidate.Name = "txtCandidate";
            this.txtCandidate.Size = new System.Drawing.Size(329, 27);
            this.txtCandidate.TabIndex = 14;
            this.txtCandidate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCandidate_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(49)))));
            this.label10.Location = new System.Drawing.Point(17, 437);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Press Enter For Select Member";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(919, 535);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 19);
            this.label16.TabIndex = 24;
            this.label16.Text = "Estimated Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(963, 491);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 19);
            this.label17.TabIndex = 23;
            this.label17.Text = "Issue Date";
            // 
            // dtIssuedDate
            // 
            this.dtIssuedDate.CustomFormat = "dd-MM-yyyy";
            this.dtIssuedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtIssuedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtIssuedDate.Location = new System.Drawing.Point(1076, 485);
            this.dtIssuedDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtIssuedDate.Name = "dtIssuedDate";
            this.dtIssuedDate.Size = new System.Drawing.Size(329, 26);
            this.dtIssuedDate.TabIndex = 25;
            // 
            // dtReturnDate
            // 
            this.dtReturnDate.Checked = false;
            this.dtReturnDate.CustomFormat = "dd-MM-yyyy";
            this.dtReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtReturnDate.Location = new System.Drawing.Point(1076, 530);
            this.dtReturnDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtReturnDate.Name = "dtReturnDate";
            this.dtReturnDate.Size = new System.Drawing.Size(329, 26);
            this.dtReturnDate.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(988, 581);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 19);
            this.label18.TabIndex = 27;
            this.label18.Text = "Remark";
            // 
            // richtextRemark
            // 
            this.richtextRemark.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtextRemark.Location = new System.Drawing.Point(1076, 580);
            this.richtextRemark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richtextRemark.Name = "richtextRemark";
            this.richtextRemark.Size = new System.Drawing.Size(329, 77);
            this.richtextRemark.TabIndex = 28;
            this.richtextRemark.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(1112, 667);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 36);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Issue";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(49)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1271, 667);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 36);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtAuthor
            // 
            this.txtAuthor.AutoSize = true;
            this.txtAuthor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtAuthor.ForeColor = System.Drawing.Color.Black;
            this.txtAuthor.Location = new System.Drawing.Point(311, 175);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(16, 24);
            this.txtAuthor.TabIndex = 31;
            this.txtAuthor.Text = ".";
            // 
            // txtPublisher
            // 
            this.txtPublisher.AutoSize = true;
            this.txtPublisher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtPublisher.ForeColor = System.Drawing.Color.Black;
            this.txtPublisher.Location = new System.Drawing.Point(308, 139);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(16, 24);
            this.txtPublisher.TabIndex = 32;
            this.txtPublisher.Text = ".";
            // 
            // txtSubCategory
            // 
            this.txtSubCategory.AutoSize = true;
            this.txtSubCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtSubCategory.ForeColor = System.Drawing.Color.Black;
            this.txtSubCategory.Location = new System.Drawing.Point(305, 101);
            this.txtSubCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSubCategory.Name = "txtSubCategory";
            this.txtSubCategory.Size = new System.Drawing.Size(16, 24);
            this.txtSubCategory.TabIndex = 33;
            this.txtSubCategory.Text = ".";
            // 
            // txtLanguage
            // 
            this.txtLanguage.AutoSize = true;
            this.txtLanguage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtLanguage.ForeColor = System.Drawing.Color.Black;
            this.txtLanguage.Location = new System.Drawing.Point(309, 209);
            this.txtLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(16, 24);
            this.txtLanguage.TabIndex = 34;
            this.txtLanguage.Text = ".";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(7, 734);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1429, 6);
            this.panel4.TabIndex = 103;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1436, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 740);
            this.panel3.TabIndex = 102;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 740);
            this.panel1.TabIndex = 101;
            // 
            // picThumb
            // 
            this.picThumb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picThumb.Location = new System.Drawing.Point(1151, 94);
            this.picThumb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picThumb.Name = "picThumb";
            this.picThumb.Size = new System.Drawing.Size(255, 233);
            this.picThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThumb.TabIndex = 13;
            this.picThumb.TabStop = false;
            // 
            // txtbookname
            // 
            this.txtbookname.AutoSize = true;
            this.txtbookname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtbookname.ForeColor = System.Drawing.Color.Black;
            this.txtbookname.Location = new System.Drawing.Point(309, 31);
            this.txtbookname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(16, 24);
            this.txtbookname.TabIndex = 105;
            this.txtbookname.Text = ".";
            // 
            // groupBoxCandidateDetails
            // 
            this.groupBoxCandidateDetails.Controls.Add(this.lblRole);
            this.groupBoxCandidateDetails.Controls.Add(this.label3);
            this.groupBoxCandidateDetails.Controls.Add(this.lblContactNo);
            this.groupBoxCandidateDetails.Controls.Add(this.lblName);
            this.groupBoxCandidateDetails.Controls.Add(this.label13);
            this.groupBoxCandidateDetails.Controls.Add(this.label14);
            this.groupBoxCandidateDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCandidateDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.groupBoxCandidateDetails.Location = new System.Drawing.Point(21, 473);
            this.groupBoxCandidateDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCandidateDetails.Name = "groupBoxCandidateDetails";
            this.groupBoxCandidateDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCandidateDetails.Size = new System.Drawing.Size(877, 185);
            this.groupBoxCandidateDetails.TabIndex = 106;
            this.groupBoxCandidateDetails.TabStop = false;
            this.groupBoxCandidateDetails.Text = "Candidate Details";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.Black;
            this.lblRole.Location = new System.Drawing.Point(305, 94);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(16, 24);
            this.lblRole.TabIndex = 48;
            this.lblRole.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(237, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Role:";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.ForeColor = System.Drawing.Color.Black;
            this.lblContactNo.Location = new System.Drawing.Point(307, 59);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(16, 24);
            this.lblContactNo.TabIndex = 44;
            this.lblContactNo.Text = ".";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(307, 28);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(16, 24);
            this.lblName.TabIndex = 43;
            this.lblName.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(188, 59);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 24);
            this.label13.TabIndex = 40;
            this.label13.Text = "Contact No:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(228, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 24);
            this.label14.TabIndex = 39;
            this.label14.Text = "Name:";
            // 
            // groupBoxbookDetails
            // 
            this.groupBoxbookDetails.Controls.Add(this.txtCountLbl);
            this.groupBoxbookDetails.Controls.Add(this.txtCount);
            this.groupBoxbookDetails.Controls.Add(this.label2);
            this.groupBoxbookDetails.Controls.Add(this.txtType);
            this.groupBoxbookDetails.Controls.Add(this.label5);
            this.groupBoxbookDetails.Controls.Add(this.lblLanguage);
            this.groupBoxbookDetails.Controls.Add(this.txtbookname);
            this.groupBoxbookDetails.Controls.Add(this.lblEdition);
            this.groupBoxbookDetails.Controls.Add(this.lblPublisher);
            this.groupBoxbookDetails.Controls.Add(this.lblAuthor);
            this.groupBoxbookDetails.Controls.Add(this.txtPublisher);
            this.groupBoxbookDetails.Controls.Add(this.txtAuthor);
            this.groupBoxbookDetails.Controls.Add(this.txtLanguage);
            this.groupBoxbookDetails.Controls.Add(this.txtSubCategory);
            this.groupBoxbookDetails.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxbookDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.groupBoxbookDetails.Location = new System.Drawing.Point(21, 134);
            this.groupBoxbookDetails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxbookDetails.Name = "groupBoxbookDetails";
            this.groupBoxbookDetails.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxbookDetails.Size = new System.Drawing.Size(877, 276);
            this.groupBoxbookDetails.TabIndex = 107;
            this.groupBoxbookDetails.TabStop = false;
            this.groupBoxbookDetails.Text = "Book Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(243, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 111;
            this.label2.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.AutoSize = true;
            this.txtType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtType.ForeColor = System.Drawing.Color.Black;
            this.txtType.Location = new System.Drawing.Point(307, 69);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(16, 24);
            this.txtType.TabIndex = 110;
            this.txtType.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(240, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 109;
            this.label5.Text = "Book:";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.Color.Black;
            this.lblLanguage.Location = new System.Drawing.Point(204, 209);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(87, 24);
            this.lblLanguage.TabIndex = 108;
            this.lblLanguage.Text = "Language:";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdition.ForeColor = System.Drawing.Color.Black;
            this.lblEdition.Location = new System.Drawing.Point(173, 101);
            this.lblEdition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(116, 24);
            this.lblEdition.TabIndex = 107;
            this.lblEdition.Text = "Sub-Category:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.ForeColor = System.Drawing.Color.Black;
            this.lblPublisher.Location = new System.Drawing.Point(208, 139);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(81, 24);
            this.lblPublisher.TabIndex = 106;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblAuthor.Location = new System.Drawing.Point(232, 175);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(63, 24);
            this.lblAuthor.TabIndex = 105;
            this.lblAuthor.Text = "Author:";
            // 
            // BtnCapture
            // 
            this.BtnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(49)))));
            this.BtnCapture.FlatAppearance.BorderSize = 0;
            this.BtnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCapture.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCapture.ForeColor = System.Drawing.Color.White;
            this.BtnCapture.Location = new System.Drawing.Point(1212, 332);
            this.BtnCapture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCapture.Name = "BtnCapture";
            this.BtnCapture.Size = new System.Drawing.Size(139, 36);
            this.BtnCapture.TabIndex = 108;
            this.BtnCapture.Text = "Capture";
            this.BtnCapture.UseVisualStyleBackColor = false;
            this.BtnCapture.Click += new System.EventHandler(this.BtnCapture_Click_1);
            // 
            // txtBarcodeSearch
            // 
            this.txtBarcodeSearch.Font = new System.Drawing.Font("Arial", 10F);
            this.txtBarcodeSearch.Location = new System.Drawing.Point(1079, 378);
            this.txtBarcodeSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarcodeSearch.Name = "txtBarcodeSearch";
            this.txtBarcodeSearch.Size = new System.Drawing.Size(271, 27);
            this.txtBarcodeSearch.TabIndex = 109;
            this.txtBarcodeSearch.Enter += new System.EventHandler(this.txtBarcodeSearch_Enter);
            this.txtBarcodeSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcodeSearch_KeyDown);
            // 
            // lblCandidateBarcode
            // 
            this.lblCandidateBarcode.AutoSize = true;
            this.lblCandidateBarcode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateBarcode.Location = new System.Drawing.Point(932, 380);
            this.lblCandidateBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCandidateBarcode.Name = "lblCandidateBarcode";
            this.lblCandidateBarcode.Size = new System.Drawing.Size(123, 19);
            this.lblCandidateBarcode.TabIndex = 0;
            this.lblCandidateBarcode.Text = "Enter Barcode";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 141;
            this.label1.Text = "Issue Book";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(279, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 142;
            this.label6.Text = "Add  a Issue Book";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(7, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1429, 66);
            this.panel2.TabIndex = 165;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(95, 66);
            this.panel5.TabIndex = 144;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1369, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(60, 66);
            this.panel6.TabIndex = 143;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(659, 74);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 166;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1357, 369);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 167;
            this.pictureBox4.TabStop = false;
            // 
            // txtCountLbl
            // 
            this.txtCountLbl.AutoSize = true;
            this.txtCountLbl.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountLbl.ForeColor = System.Drawing.Color.Black;
            this.txtCountLbl.Location = new System.Drawing.Point(187, 243);
            this.txtCountLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCountLbl.Name = "txtCountLbl";
            this.txtCountLbl.Size = new System.Drawing.Size(105, 24);
            this.txtCountLbl.TabIndex = 113;
            this.txtCountLbl.Text = "Stock Count:";
            // 
            // txtCount
            // 
            this.txtCount.AutoSize = true;
            this.txtCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.txtCount.ForeColor = System.Drawing.Color.Black;
            this.txtCount.Location = new System.Drawing.Point(310, 243);
            this.txtCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(16, 24);
            this.txtCount.TabIndex = 112;
            this.txtCount.Text = ".";
            // 
            // frmIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1443, 740);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCandidateBarcode);
            this.Controls.Add(this.txtBarcodeSearch);
            this.Controls.Add(this.BtnCapture);
            this.Controls.Add(this.groupBoxbookDetails);
            this.Controls.Add(this.groupBoxCandidateDetails);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.richtextRemark);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtReturnDate);
            this.Controls.Add(this.dtIssuedDate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCandidate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.picThumb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmIssueBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIssueBook";
            this.Load += new System.EventHandler(this.frmIssueBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).EndInit();
            this.groupBoxCandidateDetails.ResumeLayout(false);
            this.groupBoxCandidateDetails.PerformLayout();
            this.groupBoxbookDetails.ResumeLayout(false);
            this.groupBoxbookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picThumb;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCandidate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtIssuedDate;
        private System.Windows.Forms.DateTimePicker dtReturnDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox richtextRemark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label txtAuthor;
        private System.Windows.Forms.Label txtPublisher;
        private System.Windows.Forms.Label txtSubCategory;
        private System.Windows.Forms.Label txtLanguage;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtbookname;
        private System.Windows.Forms.GroupBox groupBoxCandidateDetails;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBoxbookDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button BtnCapture;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.TextBox txtBarcodeSearch;
        private System.Windows.Forms.Label lblCandidateBarcode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label txtCountLbl;
        private System.Windows.Forms.Label txtCount;
    }
}