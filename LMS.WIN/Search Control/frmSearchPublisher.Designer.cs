namespace LMS.WIN.Search_Control
{
    partial class frmSearchPublisher
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
            this.gridPublisherList = new System.Windows.Forms.DataGridView();
            this.PublisherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearchPublisherName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisherList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPublisherList
            // 
            this.gridPublisherList.BackgroundColor = System.Drawing.Color.White;
            this.gridPublisherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublisherList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PublisherID,
            this.Name,
            this.Select});
            this.gridPublisherList.Location = new System.Drawing.Point(10, 41);
            this.gridPublisherList.Name = "gridPublisherList";
            this.gridPublisherList.ReadOnly = true;
            this.gridPublisherList.Size = new System.Drawing.Size(530, 377);
            this.gridPublisherList.TabIndex = 93;
            this.gridPublisherList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPublisherList_CellContentClick);
            this.gridPublisherList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridPublisherList_KeyDown);
            // 
            // PublisherID
            // 
            this.PublisherID.DataPropertyName = "PublisherID";
            this.PublisherID.HeaderText = "PublisherID";
            this.PublisherID.Name = "PublisherID";
            this.PublisherID.ReadOnly = true;
            this.PublisherID.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 415;
            // 
            // Select
            // 
            this.Select.DataPropertyName = "Select";
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Text = "Select";
            this.Select.UseColumnTextForButtonValue = true;
            this.Select.Width = 70;
            // 
            // txtSearchPublisherName
            // 
            this.txtSearchPublisherName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPublisherName.Location = new System.Drawing.Point(12, 13);
            this.txtSearchPublisherName.Name = "txtSearchPublisherName";
            this.txtSearchPublisherName.Size = new System.Drawing.Size(529, 26);
            this.txtSearchPublisherName.TabIndex = 94;
            this.txtSearchPublisherName.TextChanged += new System.EventHandler(this.txtSearchPublisherName_TextChanged);
            this.txtSearchPublisherName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchPublisherName_KeyDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 418);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(532, 10);
            this.panel4.TabIndex = 92;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(542, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 418);
            this.panel3.TabIndex = 91;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(542, 10);
            this.panel2.TabIndex = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 428);
            this.panel1.TabIndex = 89;
            // 
            // frmSearchPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 428);
            this.Controls.Add(this.gridPublisherList);
            this.Controls.Add(this.txtSearchPublisherName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSearchPublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisherList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPublisherList;
        private System.Windows.Forms.TextBox txtSearchPublisherName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
    }
}