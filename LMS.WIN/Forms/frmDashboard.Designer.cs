namespace LMS.WIN.Forms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtuserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManageLibrarian = new System.Windows.Forms.Button();
            this.btnCandidate = new System.Windows.Forms.Button();
            this.btnAlerts = new System.Windows.Forms.Button();
            this.btnManageBook = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnbookhistory = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnPublisher = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlControl = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.txtuserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(260, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1433, 80);
            this.panel2.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimize.Location = new System.Drawing.Point(1132, 14);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(55, 43);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(1244, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "|";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1193, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 43);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtuserName
            // 
            this.txtuserName.AutoSize = true;
            this.txtuserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtuserName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserName.Location = new System.Drawing.Point(1269, 25);
            this.txtuserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(88, 21);
            this.txtuserName.TabIndex = 0;
            this.txtuserName.Text = "Smith John";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnManageLibrarian);
            this.panel1.Controls.Add(this.btnCandidate);
            this.panel1.Controls.Add(this.btnAlerts);
            this.panel1.Controls.Add(this.btnManageBook);
            this.panel1.Controls.Add(this.btnCourse);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnbookhistory);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnChangePassword);
            this.panel1.Controls.Add(this.btnAuthor);
            this.panel1.Controls.Add(this.btnPublisher);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 796);
            this.panel1.TabIndex = 1;
            // 
            // btnManageLibrarian
            // 
            this.btnManageLibrarian.BackColor = System.Drawing.Color.Transparent;
            this.btnManageLibrarian.FlatAppearance.BorderSize = 0;
            this.btnManageLibrarian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnManageLibrarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageLibrarian.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageLibrarian.ForeColor = System.Drawing.Color.White;
            this.btnManageLibrarian.Location = new System.Drawing.Point(25, 692);
            this.btnManageLibrarian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageLibrarian.Name = "btnManageLibrarian";
            this.btnManageLibrarian.Size = new System.Drawing.Size(221, 52);
            this.btnManageLibrarian.TabIndex = 13;
            this.btnManageLibrarian.Text = "Librarian";
            this.btnManageLibrarian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageLibrarian.UseVisualStyleBackColor = false;
            this.btnManageLibrarian.Click += new System.EventHandler(this.btnManageLibrarian_Click);
            // 
            // btnCandidate
            // 
            this.btnCandidate.BackColor = System.Drawing.Color.Transparent;
            this.btnCandidate.FlatAppearance.BorderSize = 0;
            this.btnCandidate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandidate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidate.ForeColor = System.Drawing.Color.White;
            this.btnCandidate.Location = new System.Drawing.Point(25, 288);
            this.btnCandidate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCandidate.Name = "btnCandidate";
            this.btnCandidate.Size = new System.Drawing.Size(227, 52);
            this.btnCandidate.TabIndex = 12;
            this.btnCandidate.Text = "Candidate";
            this.btnCandidate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCandidate.UseVisualStyleBackColor = false;
            this.btnCandidate.Click += new System.EventHandler(this.btnCandidate_Click);
            // 
            // btnAlerts
            // 
            this.btnAlerts.BackColor = System.Drawing.Color.Transparent;
            this.btnAlerts.FlatAppearance.BorderSize = 0;
            this.btnAlerts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAlerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlerts.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlerts.ForeColor = System.Drawing.Color.White;
            this.btnAlerts.Location = new System.Drawing.Point(25, 578);
            this.btnAlerts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlerts.Name = "btnAlerts";
            this.btnAlerts.Size = new System.Drawing.Size(227, 52);
            this.btnAlerts.TabIndex = 17;
            this.btnAlerts.Text = "Alerts";
            this.btnAlerts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlerts.UseVisualStyleBackColor = false;
            this.btnAlerts.Click += new System.EventHandler(this.btnAlerts_Click);
            // 
            // btnManageBook
            // 
            this.btnManageBook.BackColor = System.Drawing.Color.Transparent;
            this.btnManageBook.FlatAppearance.BorderSize = 0;
            this.btnManageBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnManageBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBook.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBook.ForeColor = System.Drawing.Color.White;
            this.btnManageBook.Location = new System.Drawing.Point(25, 346);
            this.btnManageBook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnManageBook.Name = "btnManageBook";
            this.btnManageBook.Size = new System.Drawing.Size(227, 52);
            this.btnManageBook.TabIndex = 7;
            this.btnManageBook.Text = "Book";
            this.btnManageBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBook.UseVisualStyleBackColor = false;
            this.btnManageBook.Click += new System.EventHandler(this.btnManageBook_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.BackColor = System.Drawing.Color.Transparent;
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.Color.White;
            this.btnCourse.Location = new System.Drawing.Point(25, 636);
            this.btnCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(227, 50);
            this.btnCourse.TabIndex = 16;
            this.btnCourse.Text = "Course";
            this.btnCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourse.UseVisualStyleBackColor = false;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(25, 519);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(227, 52);
            this.btnReports.TabIndex = 15;
            this.btnReports.Text = "Report";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnbookhistory
            // 
            this.btnbookhistory.BackColor = System.Drawing.Color.Transparent;
            this.btnbookhistory.FlatAppearance.BorderSize = 0;
            this.btnbookhistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnbookhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbookhistory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbookhistory.ForeColor = System.Drawing.Color.White;
            this.btnbookhistory.Location = new System.Drawing.Point(25, 462);
            this.btnbookhistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbookhistory.Name = "btnbookhistory";
            this.btnbookhistory.Size = new System.Drawing.Size(227, 52);
            this.btnbookhistory.TabIndex = 14;
            this.btnbookhistory.Text = "Book History";
            this.btnbookhistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbookhistory.UseVisualStyleBackColor = false;
            this.btnbookhistory.Click += new System.EventHandler(this.btnbookhistory_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(25, 404);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(227, 52);
            this.btnReport.TabIndex = 11;
            this.btnReport.Text = "Book Management";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(25, 750);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(225, 38);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Settings";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.Color.Transparent;
            this.btnAuthor.FlatAppearance.BorderSize = 0;
            this.btnAuthor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAuthor.Location = new System.Drawing.Point(25, 172);
            this.btnAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(227, 52);
            this.btnAuthor.TabIndex = 9;
            this.btnAuthor.Text = "Author";
            this.btnAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.UseVisualStyleBackColor = false;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnPublisher
            // 
            this.btnPublisher.BackColor = System.Drawing.Color.Transparent;
            this.btnPublisher.FlatAppearance.BorderSize = 0;
            this.btnPublisher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublisher.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublisher.ForeColor = System.Drawing.Color.White;
            this.btnPublisher.Location = new System.Drawing.Point(25, 230);
            this.btnPublisher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.Size = new System.Drawing.Size(227, 52);
            this.btnPublisher.TabIndex = 8;
            this.btnPublisher.Text = "Publisher";
            this.btnPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPublisher.UseVisualStyleBackColor = false;
            this.btnPublisher.Click += new System.EventHandler(this.btnPublisher_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(25, 114);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(227, 52);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Teal;
            this.SidePanel.Location = new System.Drawing.Point(4, 117);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 49);
            this.SidePanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management";
            // 
            // PnlControl
            // 
            this.PnlControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlControl.Location = new System.Drawing.Point(260, 80);
            this.PnlControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlControl.Name = "PnlControl";
            this.PnlControl.Size = new System.Drawing.Size(1433, 716);
            this.PnlControl.TabIndex = 3;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 796);
            this.Controls.Add(this.PnlControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCandidate;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnPublisher;
        private System.Windows.Forms.Button btnManageBook;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label txtuserName;
        private System.Windows.Forms.Panel PnlControl;
        private System.Windows.Forms.Button btnManageLibrarian;
        private System.Windows.Forms.Button btnbookhistory;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnAlerts;
        private System.Windows.Forms.Button btnMinimize;
    }
}