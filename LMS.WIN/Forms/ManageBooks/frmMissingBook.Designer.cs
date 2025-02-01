namespace LMS.WIN.Forms.ManageBooks
{
    partial class frmMissingBook
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
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.Label();
            this.txtEdition = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtBarcode.Location = new System.Drawing.Point(160, 58);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(308, 25);
            this.txtBarcode.TabIndex = 2;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblBarcode.Location = new System.Drawing.Point(72, 61);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(77, 20);
            this.lblBarcode.TabIndex = 92;
            this.lblBarcode.Text = "Barcode:";
            // 
            // txtLanguage
            // 
            this.txtLanguage.AutoSize = true;
            this.txtLanguage.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtLanguage.Location = new System.Drawing.Point(158, 277);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(13, 20);
            this.txtLanguage.TabIndex = 101;
            this.txtLanguage.Text = ".";
            // 
            // txtEdition
            // 
            this.txtEdition.AutoSize = true;
            this.txtEdition.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtEdition.Location = new System.Drawing.Point(158, 241);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(13, 20);
            this.txtEdition.TabIndex = 100;
            this.txtEdition.Text = ".";
            // 
            // txtPublisher
            // 
            this.txtPublisher.AutoSize = true;
            this.txtPublisher.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPublisher.Location = new System.Drawing.Point(158, 205);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(13, 20);
            this.txtPublisher.TabIndex = 99;
            this.txtPublisher.Text = ".";
            // 
            // txtAuthor
            // 
            this.txtAuthor.AutoSize = true;
            this.txtAuthor.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtAuthor.Location = new System.Drawing.Point(158, 169);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(13, 20);
            this.txtAuthor.TabIndex = 98;
            this.txtAuthor.Text = ".";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblLanguage.Location = new System.Drawing.Point(61, 277);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(88, 20);
            this.lblLanguage.TabIndex = 97;
            this.lblLanguage.Text = "Language:";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblEdition.Location = new System.Drawing.Point(88, 241);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(61, 20);
            this.lblEdition.TabIndex = 96;
            this.lblEdition.Text = "Edition:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblPublisher.Location = new System.Drawing.Point(72, 205);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(77, 20);
            this.lblPublisher.TabIndex = 95;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblAuthor.Location = new System.Drawing.Point(87, 169);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(62, 20);
            this.lblAuthor.TabIndex = 94;
            this.lblAuthor.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(21, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Book Details:";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtRemark.Location = new System.Drawing.Point(517, 133);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(308, 216);
            this.txtRemark.TabIndex = 4;
            this.txtRemark.Text = "";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblRemark.Location = new System.Drawing.Point(514, 97);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(68, 20);
            this.lblRemark.TabIndex = 102;
            this.lblRemark.Text = "Remark:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(574, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(705, 371);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 29);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtName.Location = new System.Drawing.Point(158, 133);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(13, 20);
            this.txtName.TabIndex = 104;
            this.txtName.Text = ".";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblName.Location = new System.Drawing.Point(92, 133);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 20);
            this.lblName.TabIndex = 103;
            this.lblName.Text = "Name:";
            // 
            // txtIsbn
            // 
            this.txtIsbn.AutoSize = true;
            this.txtIsbn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtIsbn.Location = new System.Drawing.Point(158, 349);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(13, 20);
            this.txtIsbn.TabIndex = 108;
            this.txtIsbn.Text = ".";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPrice.Location = new System.Drawing.Point(158, 313);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(13, 20);
            this.txtPrice.TabIndex = 107;
            this.txtPrice.Text = ".";
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblIsbn.Location = new System.Drawing.Point(104, 349);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(45, 20);
            this.lblIsbn.TabIndex = 106;
            this.lblIsbn.Text = "ISBN:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblPrice.Location = new System.Drawing.Point(99, 313);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(50, 20);
            this.lblPrice.TabIndex = 105;
            this.lblPrice.Text = "Price:";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtDescription.Location = new System.Drawing.Point(158, 382);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(13, 20);
            this.txtDescription.TabIndex = 110;
            this.txtDescription.Text = ".";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lblDescription.Location = new System.Drawing.Point(54, 385);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(95, 20);
            this.lblDescription.TabIndex = 109;
            this.lblDescription.Text = "Description:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 442);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(850, 5);
            this.panel4.TabIndex = 153;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(855, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 407);
            this.panel3.TabIndex = 152;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 407);
            this.panel1.TabIndex = 151;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.btnCloses);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 40);
            this.panel2.TabIndex = 150;
            // 
            // btnCloses
            // 
            this.btnCloses.BackColor = System.Drawing.Color.Teal;
            this.btnCloses.FlatAppearance.BorderSize = 0;
            this.btnCloses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloses.ForeColor = System.Drawing.Color.White;
            this.btnCloses.Location = new System.Drawing.Point(822, 7);
            this.btnCloses.Name = "btnCloses";
            this.btnCloses.Size = new System.Drawing.Size(31, 26);
            this.btnCloses.TabIndex = 24;
            this.btnCloses.Text = "X";
            this.btnCloses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloses.UseVisualStyleBackColor = false;
            this.btnCloses.Click += new System.EventHandler(this.btnCloses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Missing Book Here";
            // 
            // frmMissingBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 447);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblEdition);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblBarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMissingBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMissingBook";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label txtLanguage;
        private System.Windows.Forms.Label txtEdition;
        private System.Windows.Forms.Label txtPublisher;
        private System.Windows.Forms.Label txtAuthor;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label txtIsbn;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCloses;
        private System.Windows.Forms.Label label1;
    }
}