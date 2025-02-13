namespace LMS.WIN.Forms.Reports
{
    partial class ManageReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageReport));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlManageReports = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCandidateReport = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            //this.dataGridViewImageColumn2.Image = global::LMS.WIN.Properties.Resources.delete;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Visible = false;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // pnlManageReports
            // 
            this.pnlManageReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManageReports.Location = new System.Drawing.Point(0, 49);
            this.pnlManageReports.Margin = new System.Windows.Forms.Padding(4);
            this.pnlManageReports.Name = "pnlManageReports";
            this.pnlManageReports.Size = new System.Drawing.Size(1433, 667);
            this.pnlManageReports.TabIndex = 114;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnBook);
            this.panel2.Controls.Add(this.btnCandidateReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1433, 49);
            this.panel2.TabIndex = 113;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.Teal;
            this.btnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBook.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Location = new System.Drawing.Point(224, 5);
            this.btnBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(200, 41);
            this.btnBook.TabIndex = 121;
            this.btnBook.Text = "Book Report";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.BtnBook_Click);
            // 
            // btnCandidateReport
            // 
            this.btnCandidateReport.BackColor = System.Drawing.Color.Teal;
            this.btnCandidateReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCandidateReport.FlatAppearance.BorderSize = 0;
            this.btnCandidateReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCandidateReport.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnCandidateReport.ForeColor = System.Drawing.Color.White;
            this.btnCandidateReport.Location = new System.Drawing.Point(16, 5);
            this.btnCandidateReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnCandidateReport.Name = "btnCandidateReport";
            this.btnCandidateReport.Size = new System.Drawing.Size(200, 41);
            this.btnCandidateReport.TabIndex = 120;
            this.btnCandidateReport.Text = "Candidate Report";
            this.btnCandidateReport.UseVisualStyleBackColor = false;
            this.btnCandidateReport.Click += new System.EventHandler(this.btnCandidateReport_Click);
            // 
            // ManageReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 716);
            this.Controls.Add(this.pnlManageReports);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageReport";
            this.Text = "ManageReport";
            this.Load += new System.EventHandler(this.ManageReport_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel pnlManageReports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCandidateReport;
        private System.Windows.Forms.Button btnBook;
    }
}