namespace LMS.WIN.Forms.ManageCandidate
{
    partial class frmAddCandidte
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceNo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloses = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCapture = new System.Windows.Forms.Button();
            this.picThumb = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmboxCandidateType = new System.Windows.Forms.ComboBox();
            this.pnlcommanfields = new System.Windows.Forms.Panel();
            this.pnlTrainee = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtFormDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlPosted = new System.Windows.Forms.Panel();
            this.dtTosDate = new System.Windows.Forms.DateTimePicker();
            this.dtSosDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBattalion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).BeginInit();
            this.pnlcommanfields.SuspendLayout();
            this.pnlTrainee.SuspendLayout();
            this.pnlPosted.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(709, 270);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 29);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(585, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 29);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(444, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Full Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(528, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 23);
            this.txtName.TabIndex = 2;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(4, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Contact Number";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.Location = new System.Drawing.Point(136, 55);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(244, 23);
            this.txtContactNumber.TabIndex = 3;
            this.txtContactNumber.Leave += new System.EventHandler(this.txtContactNumber_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Service No";
            // 
            // txtServiceNo
            // 
            this.txtServiceNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceNo.Location = new System.Drawing.Point(135, 16);
            this.txtServiceNo.Name = "txtServiceNo";
            this.txtServiceNo.Size = new System.Drawing.Size(245, 23);
            this.txtServiceNo.TabIndex = 1;
            this.txtServiceNo.Leave += new System.EventHandler(this.txtFullName_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1028, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 278);
            this.panel3.TabIndex = 104;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 311);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1028, 5);
            this.panel4.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 283);
            this.panel1.TabIndex = 102;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnCloses);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 33);
            this.panel2.TabIndex = 101;
            // 
            // btnCloses
            // 
            this.btnCloses.BackColor = System.Drawing.Color.Teal;
            this.btnCloses.FlatAppearance.BorderSize = 0;
            this.btnCloses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloses.ForeColor = System.Drawing.Color.White;
            this.btnCloses.Location = new System.Drawing.Point(1002, 3);
            this.btnCloses.Name = "btnCloses";
            this.btnCloses.Size = new System.Drawing.Size(28, 26);
            this.btnCloses.TabIndex = 7;
            this.btnCloses.Text = "X";
            this.btnCloses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloses.UseVisualStyleBackColor = false;
            this.btnCloses.Click += new System.EventHandler(this.btnCloses_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Add Candidate Here";
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.Teal;
            this.btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapture.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCapture.ForeColor = System.Drawing.Color.White;
            this.btnCapture.Location = new System.Drawing.Point(885, 270);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(83, 29);
            this.btnCapture.TabIndex = 16;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.BtnCapture_Click);
            // 
            // picThumb
            // 
            this.picThumb.BackColor = System.Drawing.Color.White;
            this.picThumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picThumb.Location = new System.Drawing.Point(832, 84);
            this.picThumb.Name = "picThumb";
            this.picThumb.Size = new System.Drawing.Size(192, 176);
            this.picThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThumb.TabIndex = 107;
            this.picThumb.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label13.Location = new System.Drawing.Point(180, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 19);
            this.label13.TabIndex = 112;
            this.label13.Text = "Select Candidate Type";
            // 
            // cmboxCandidateType
            // 
            this.cmboxCandidateType.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmboxCandidateType.FormattingEnabled = true;
            this.cmboxCandidateType.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.cmboxCandidateType.Location = new System.Drawing.Point(355, 47);
            this.cmboxCandidateType.Name = "cmboxCandidateType";
            this.cmboxCandidateType.Size = new System.Drawing.Size(337, 25);
            this.cmboxCandidateType.TabIndex = 0;
            this.cmboxCandidateType.SelectedValueChanged += new System.EventHandler(this.cmboxCandidateType_SelectedValueChanged);
            // 
            // pnlcommanfields
            // 
            this.pnlcommanfields.Controls.Add(this.pnlTrainee);
            this.pnlcommanfields.Controls.Add(this.txtServiceNo);
            this.pnlcommanfields.Controls.Add(this.label1);
            this.pnlcommanfields.Controls.Add(this.txtName);
            this.pnlcommanfields.Controls.Add(this.label2);
            this.pnlcommanfields.Controls.Add(this.txtContactNumber);
            this.pnlcommanfields.Controls.Add(this.label3);
            this.pnlcommanfields.Location = new System.Drawing.Point(7, 84);
            this.pnlcommanfields.Name = "pnlcommanfields";
            this.pnlcommanfields.Size = new System.Drawing.Size(822, 176);
            this.pnlcommanfields.TabIndex = 113;
            // 
            // pnlTrainee
            // 
            this.pnlTrainee.Controls.Add(this.label15);
            this.pnlTrainee.Controls.Add(this.dtEndDate);
            this.pnlTrainee.Controls.Add(this.txtCourse);
            this.pnlTrainee.Controls.Add(this.label9);
            this.pnlTrainee.Controls.Add(this.dtFormDate);
            this.pnlTrainee.Controls.Add(this.label17);
            this.pnlTrainee.Controls.Add(this.label8);
            this.pnlTrainee.Location = new System.Drawing.Point(0, 86);
            this.pnlTrainee.Name = "pnlTrainee";
            this.pnlTrainee.Size = new System.Drawing.Size(805, 90);
            this.pnlTrainee.TabIndex = 114;
            this.pnlTrainee.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(132, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 15);
            this.label15.TabIndex = 122;
            this.label15.Text = "Press Enter For Search Course";
            // 
            // dtEndDate
            // 
            this.dtEndDate.CustomFormat = "dd-MM-yyyy";
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEndDate.Location = new System.Drawing.Point(529, 52);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(243, 23);
            this.dtEndDate.TabIndex = 13;
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(135, 23);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(244, 23);
            this.txtCourse.TabIndex = 11;
            this.txtCourse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCourse_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label9.Location = new System.Drawing.Point(445, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 118;
            this.label9.Text = "End Date";
            // 
            // dtFormDate
            // 
            this.dtFormDate.CustomFormat = "dd-MM-yyyy";
            this.dtFormDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtFormDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFormDate.Location = new System.Drawing.Point(136, 52);
            this.dtFormDate.Name = "dtFormDate";
            this.dtFormDate.Size = new System.Drawing.Size(245, 23);
            this.dtFormDate.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label17.Location = new System.Drawing.Point(50, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 19);
            this.label17.TabIndex = 116;
            this.label17.Text = "Form Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label8.Location = new System.Drawing.Point(28, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 19);
            this.label8.TabIndex = 115;
            this.label8.Text = "Course Name";
            // 
            // pnlPosted
            // 
            this.pnlPosted.Controls.Add(this.dtTosDate);
            this.pnlPosted.Controls.Add(this.dtSosDate);
            this.pnlPosted.Controls.Add(this.label11);
            this.pnlPosted.Controls.Add(this.label12);
            this.pnlPosted.Controls.Add(this.txtBattalion);
            this.pnlPosted.Controls.Add(this.label10);
            this.pnlPosted.Location = new System.Drawing.Point(5, 172);
            this.pnlPosted.Name = "pnlPosted";
            this.pnlPosted.Size = new System.Drawing.Size(821, 86);
            this.pnlPosted.TabIndex = 115;
            this.pnlPosted.Visible = false;
            // 
            // dtTosDate
            // 
            this.dtTosDate.CustomFormat = "dd-MM-yyyy";
            this.dtTosDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtTosDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTosDate.Location = new System.Drawing.Point(139, 37);
            this.dtTosDate.Name = "dtTosDate";
            this.dtTosDate.Size = new System.Drawing.Size(244, 23);
            this.dtTosDate.TabIndex = 134;
            // 
            // dtSosDate
            // 
            this.dtSosDate.CustomFormat = "dd-MM-yyyy";
            this.dtSosDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtSosDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSosDate.Location = new System.Drawing.Point(528, 38);
            this.dtSosDate.Name = "dtSosDate";
            this.dtSosDate.Size = new System.Drawing.Size(244, 23);
            this.dtSosDate.TabIndex = 135;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label11.Location = new System.Drawing.Point(409, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 19);
            this.label11.TabIndex = 122;
            this.label11.Text = "Likely SOS Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label12.Location = new System.Drawing.Point(60, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 19);
            this.label12.TabIndex = 120;
            this.label12.Text = "TOS Date";
            // 
            // txtBattalion
            // 
            this.txtBattalion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBattalion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBattalion.Location = new System.Drawing.Point(138, 5);
            this.txtBattalion.Name = "txtBattalion";
            this.txtBattalion.Size = new System.Drawing.Size(244, 23);
            this.txtBattalion.TabIndex = 7;
            this.txtBattalion.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label10.Location = new System.Drawing.Point(62, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "Battalion";
            this.label10.Visible = false;
            // 
            // frmAddCandidte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 316);
            this.Controls.Add(this.pnlPosted);
            this.Controls.Add(this.pnlcommanfields);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmboxCandidateType);
            this.Controls.Add(this.picThumb);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddCandidte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddCandidte";
            this.Load += new System.EventHandler(this.frmAddCandidte_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumb)).EndInit();
            this.pnlcommanfields.ResumeLayout(false);
            this.pnlcommanfields.PerformLayout();
            this.pnlTrainee.ResumeLayout(false);
            this.pnlTrainee.PerformLayout();
            this.pnlPosted.ResumeLayout(false);
            this.pnlPosted.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCloses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox picThumb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmboxCandidateType;
        private System.Windows.Forms.Panel pnlcommanfields;
        private System.Windows.Forms.Panel pnlTrainee;
        private System.Windows.Forms.DateTimePicker dtFormDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlPosted;
        private System.Windows.Forms.TextBox txtBattalion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtTosDate;
        private System.Windows.Forms.DateTimePicker dtSosDate;
    }
}