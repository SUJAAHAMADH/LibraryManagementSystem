namespace LMS.WIN.Forms.ManageCategory
{
    partial class ManageCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategory));
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridBook = new System.Windows.Forms.DataGridView();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddNewJournal = new System.Windows.Forms.Button();
            this.picboxrefersh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrefersh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 503);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(908, 10);
            this.panel5.TabIndex = 166;
            // 
            // dataGridBook
            // 
            this.dataGridBook.AllowUserToResizeRows = false;
            this.dataGridBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBook.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridBook.ColumnHeadersHeight = 40;
            this.dataGridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.Name,
            this.ParentName,
            this.View,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(145)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBook.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridBook.EnableHeadersVisualStyles = false;
            this.dataGridBook.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridBook.Location = new System.Drawing.Point(80, 115);
            this.dataGridBook.Name = "dataGridBook";
            this.dataGridBook.ReadOnly = true;
            this.dataGridBook.RowHeadersVisible = false;
            this.dataGridBook.RowHeadersWidth = 60;
            this.dataGridBook.RowTemplate.Height = 30;
            this.dataGridBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBook.Size = new System.Drawing.Size(719, 318);
            this.dataGridBook.TabIndex = 161;
            this.dataGridBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBook_CellContentClick);
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.FillWeight = 82.10664F;
            this.CategoryID.HeaderText = "ID";
            this.CategoryID.MinimumWidth = 6;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.FillWeight = 75.24189F;
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ParentName
            // 
            this.ParentName.DataPropertyName = "ParentName";
            this.ParentName.HeaderText = "Parent";
            this.ParentName.MinimumWidth = 6;
            this.ParentName.Name = "ParentName";
            this.ParentName.ReadOnly = true;
            // 
            // View
            // 
            this.View.DataPropertyName = "View";
            this.View.FillWeight = 16.72041F;
            this.View.HeaderText = "View";
            this.View.Image = ((System.Drawing.Image)(resources.GetObject("View.Image")));
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Visible = false;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.FillWeight = 18.94981F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.FillWeight = 24.63199F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Delete";
            this.dataGridViewImageColumn1.FillWeight = 20F;
            this.dataGridViewImageColumn1.HeaderText = "Delete";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 52;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picboxrefersh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(190, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 60);
            this.panel2.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(129)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnAddNewJournal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 64);
            this.panel1.TabIndex = 164;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(525, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 60);
            this.panel3.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(212, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Add, Edit, Delete Your Category";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(197, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Manage Category";
            // 
            // btnAddNewJournal
            // 
            this.btnAddNewJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewJournal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewJournal.FlatAppearance.BorderSize = 0;
            this.btnAddNewJournal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAddNewJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewJournal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewJournal.ForeColor = System.Drawing.Color.White;
            this.btnAddNewJournal.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewJournal.Image")));
            this.btnAddNewJournal.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewJournal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewJournal.Name = "btnAddNewJournal";
            this.btnAddNewJournal.Size = new System.Drawing.Size(190, 60);
            this.btnAddNewJournal.TabIndex = 15;
            this.btnAddNewJournal.Text = "   Add Category";
            this.btnAddNewJournal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewJournal.UseVisualStyleBackColor = true;
            this.btnAddNewJournal.Click += new System.EventHandler(this.btnAddNewJournal_Click);
            // 
            // picboxrefersh
            // 
            this.picboxrefersh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxrefersh.Image = ((System.Drawing.Image)(resources.GetObject("picboxrefersh.Image")));
            this.picboxrefersh.Location = new System.Drawing.Point(13, 15);
            this.picboxrefersh.Name = "picboxrefersh";
            this.picboxrefersh.Size = new System.Drawing.Size(42, 33);
            this.picboxrefersh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxrefersh.TabIndex = 146;
            this.picboxrefersh.TabStop = false;
            this.picboxrefersh.Click += new System.EventHandler(this.picboxrefersh_Click_1);
            // 
            // ManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 513);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dataGridBook);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageSubject";
            this.Load += new System.EventHandler(this.ManageSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrefersh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridBook;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddNewJournal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentName;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.PictureBox picboxrefersh;
    }
}