namespace LMS.WIN.Forms.ManageAuthor
{
    partial class ManageAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAuthor));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridAuthor = new System.Windows.Forms.DataGridView();
            this.AuthorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picboxrefersh = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrefersh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 14F);
            this.txtSearch.Location = new System.Drawing.Point(638, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(252, 29);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(898, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 26);
            this.button3.TabIndex = 19;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(63)))), ((int)(((byte)(129)))));
            this.label3.Location = new System.Drawing.Point(63, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 14);
            this.label3.TabIndex = 18;
            this.label3.Text = "Add, Edit, Delete your Author through manage Author.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(63)))), ((int)(((byte)(129)))));
            this.label4.Location = new System.Drawing.Point(60, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Manage Author";
            // 
            // dataGridAuthor
            // 
            this.dataGridAuthor.AllowUserToResizeRows = false;
            this.dataGridAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAuthor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAuthor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridAuthor.ColumnHeadersHeight = 20;
            this.dataGridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuthorID,
            this.Name,
            this.Description,
            this.Edit,
            this.Delete});
            this.dataGridAuthor.GridColor = System.Drawing.Color.White;
            this.dataGridAuthor.Location = new System.Drawing.Point(16, 69);
            this.dataGridAuthor.Name = "dataGridAuthor";
            this.dataGridAuthor.ReadOnly = true;
            this.dataGridAuthor.RowHeadersVisible = false;
            this.dataGridAuthor.RowHeadersWidth = 60;
            this.dataGridAuthor.RowTemplate.Height = 30;
            this.dataGridAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAuthor.Size = new System.Drawing.Size(1055, 478);
            this.dataGridAuthor.TabIndex = 16;
            this.dataGridAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAuthor_CellContentClick);
            this.dataGridAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridAuthor_KeyDown);
            // 
            // AuthorID
            // 
            this.AuthorID.DataPropertyName = "AuthorID";
            this.AuthorID.FillWeight = 71.26904F;
            this.AuthorID.HeaderText = "AuthorID";
            this.AuthorID.MinimumWidth = 6;
            this.AuthorID.Name = "AuthorID";
            this.AuthorID.ReadOnly = true;
            this.AuthorID.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.FillWeight = 20F;
            this.Edit.HeaderText = "      Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.FillWeight = 20F;
            this.Delete.HeaderText = "     Delete";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(63)))), ((int)(((byte)(129)))));
            this.btnAddAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAuthor.FlatAppearance.BorderSize = 0;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthor.Location = new System.Drawing.Point(946, 19);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(120, 29);
            this.btnAddAuthor.TabIndex = 15;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(63)))), ((int)(((byte)(129)))));
            this.label1.Location = new System.Drawing.Point(503, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search Author";
            // 
            // picboxrefersh
            // 
            this.picboxrefersh.Image = ((System.Drawing.Image)(resources.GetObject("picboxrefersh.Image")));
            this.picboxrefersh.Location = new System.Drawing.Point(356, 19);
            this.picboxrefersh.Name = "picboxrefersh";
            this.picboxrefersh.Size = new System.Drawing.Size(38, 31);
            this.picboxrefersh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxrefersh.TabIndex = 124;
            this.picboxrefersh.TabStop = false;
            this.picboxrefersh.Click += new System.EventHandler(this.picboxrefersh_Click);
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
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 39);
            this.button1.TabIndex = 125;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManageAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picboxrefersh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridAuthor);
            this.Controls.Add(this.btnAddAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "ManageAuthor";
            this.Load += new System.EventHandler(this.ManageAuthor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxrefersh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridAuthor;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picboxrefersh;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Button button1;
    }
}