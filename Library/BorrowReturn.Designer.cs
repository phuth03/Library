namespace Library
{
    partial class BorrowReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowReturn));
            txtSearch = new TextBox();
            panel2 = new Panel();
            llbMembers = new LinkLabel();
            lblLogout = new Label();
            lblBorrow = new LinkLabel();
            llbBooks = new LinkLabel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlBooks = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            lblList = new Label();
            dtgBooks = new DataGridView();
            NO = new DataGridViewTextBoxColumn();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            dtpBorrowDate = new DateTimePicker();
            label9 = new Label();
            label6 = new Label();
            label8 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtStaff = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            panel3 = new Panel();
            dtpReturnDate = new DateTimePicker();
            btnBill = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBooks).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearch.Location = new Point(612, 165);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Turquoise;
            panel2.Controls.Add(llbMembers);
            panel2.Controls.Add(lblLogout);
            panel2.Controls.Add(lblBorrow);
            panel2.Controls.Add(llbBooks);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pnlBooks);
            panel2.ForeColor = SystemColors.Control;
            panel2.Location = new Point(3, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1228, 109);
            panel2.TabIndex = 33;
            // 
            // llbMembers
            // 
            llbMembers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            llbMembers.AutoSize = true;
            llbMembers.BackColor = Color.Turquoise;
            llbMembers.Font = new Font("Arial", 13.8F);
            llbMembers.ForeColor = SystemColors.ActiveCaptionText;
            llbMembers.LinkColor = Color.Black;
            llbMembers.Location = new Point(408, 76);
            llbMembers.Name = "llbMembers";
            llbMembers.Size = new Size(107, 26);
            llbMembers.TabIndex = 2;
            llbMembers.TabStop = true;
            llbMembers.Text = "Members";
            llbMembers.LinkClicked += llbMembers_LinkClicked;
            // 
            // lblLogout
            // 
            lblLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLogout.AutoSize = true;
            lblLogout.BackColor = Color.Red;
            lblLogout.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogout.Location = new Point(1063, 32);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(148, 41);
            lblLogout.TabIndex = 3;
            lblLogout.Text = "LOG OUT";
            lblLogout.Click += lblLogout_Click_1;
            // 
            // lblBorrow
            // 
            lblBorrow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBorrow.AutoSize = true;
            lblBorrow.BackColor = Color.Lime;
            lblBorrow.Font = new Font("Arial", 13.8F);
            lblBorrow.ForeColor = SystemColors.ActiveCaptionText;
            lblBorrow.LinkColor = Color.Black;
            lblBorrow.Location = new Point(541, 76);
            lblBorrow.Name = "lblBorrow";
            lblBorrow.Size = new Size(172, 26);
            lblBorrow.TabIndex = 2;
            lblBorrow.TabStop = true;
            lblBorrow.Text = "Borrow - Return";
            // 
            // llbBooks
            // 
            llbBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            llbBooks.AutoSize = true;
            llbBooks.BackColor = Color.Turquoise;
            llbBooks.Font = new Font("Arial", 13.8F);
            llbBooks.ForeColor = SystemColors.ActiveCaptionText;
            llbBooks.LinkColor = Color.Black;
            llbBooks.Location = new Point(264, 76);
            llbBooks.Name = "llbBooks";
            llbBooks.Size = new Size(76, 26);
            llbBooks.TabIndex = 2;
            llbBooks.TabStop = true;
            llbBooks.Text = "Books";
            llbBooks.LinkClicked += llbBooks_LinkClicked;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Lime;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(594, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(79, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Turquoise;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(423, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(79, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Turquoise;
            pictureBox2.Image = Properties.Resources.Book;
            pictureBox2.Location = new Point(264, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 109);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlBooks
            // 
            pnlBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBooks.BackColor = Color.Lime;
            pnlBooks.Location = new Point(541, 0);
            pnlBooks.Name = "pnlBooks";
            pnlBooks.Size = new Size(172, 109);
            pnlBooks.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(600, 195);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 31;
            label3.Text = "Information";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblList);
            panel1.Controls.Add(dtgBooks);
            panel1.Location = new Point(14, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 460);
            panel1.TabIndex = 32;
            // 
            // lblList
            // 
            lblList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblList.AutoSize = true;
            lblList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblList.Location = new Point(3, 7);
            lblList.Name = "lblList";
            lblList.Size = new Size(164, 20);
            lblList.TabIndex = 2;
            lblList.Text = "List of book borrowed";
            // 
            // dtgBooks
            // 
            dtgBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dtgBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dtgBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBooks.Columns.AddRange(new DataGridViewColumn[] { NO });
            dtgBooks.Location = new Point(32, 31);
            dtgBooks.Name = "dtgBooks";
            dtgBooks.RowHeadersWidth = 51;
            dtgBooks.Size = new Size(545, 429);
            dtgBooks.TabIndex = 1;
            dtgBooks.CellClick += dtgBooks_CellClick;
            dtgBooks.RowPostPaint += dtgBooks_RowPostPaint;
            // 
            // NO
            // 
            NO.HeaderText = "#";
            NO.MinimumWidth = 6;
            NO.Name = "NO";
            NO.Width = 47;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.Font = new Font("Arial Narrow", 13.8F);
            btnUpdate.Location = new Point(1015, 593);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 36);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.Font = new Font("Arial Narrow", 13.8F);
            btnAdd.Location = new Point(778, 593);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Font = new Font("Arial Narrow", 13.8F);
            btnDelete.Location = new Point(901, 593);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 36);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpBorrowDate.CustomFormat = "dd-MM-yyyy";
            dtpBorrowDate.Format = DateTimePickerFormat.Custom;
            dtpBorrowDate.Location = new Point(145, 133);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(250, 27);
            dtpBorrowDate.TabIndex = 2;
            dtpBorrowDate.Value = new DateTime(2024, 5, 16, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Location = new Point(3, 249);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 8;
            label9.Text = "Staff lend";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 138);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 8;
            label6.Text = "Borrow date";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(3, 197);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 8;
            label8.Text = "Return date";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(612, 134);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 38;
            label1.Text = "Search:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 77);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 8;
            label5.Text = "Book name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 21);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 8;
            label4.Text = "Borrow ID";
            // 
            // txtStaff
            // 
            txtStaff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStaff.Location = new Point(145, 242);
            txtStaff.Name = "txtStaff";
            txtStaff.Size = new Size(447, 27);
            txtStaff.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(145, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(447, 27);
            txtName.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtID.Location = new Point(145, 21);
            txtID.Name = "txtID";
            txtID.Size = new Size(447, 27);
            txtID.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Control;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dtpReturnDate);
            panel3.Controls.Add(dtpBorrowDate);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtStaff);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(txtID);
            panel3.Location = new Point(600, 212);
            panel3.Name = "panel3";
            panel3.Size = new Size(614, 382);
            panel3.TabIndex = 1;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtpReturnDate.CustomFormat = "dd-MM-yyyy";
            dtpReturnDate.Format = DateTimePickerFormat.Custom;
            dtpReturnDate.Location = new Point(145, 192);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(250, 27);
            dtpReturnDate.TabIndex = 3;
            dtpReturnDate.Value = new DateTime(2024, 4, 2, 0, 0, 0, 0);
            // 
            // btnBill
            // 
            btnBill.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnBill.Font = new Font("Arial Narrow", 13.8F);
            btnBill.Location = new Point(1123, 593);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(94, 36);
            btnBill.TabIndex = 5;
            btnBill.Text = "Print bill";
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // BorrowReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 636);
            Controls.Add(txtSearch);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnBill);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BorrowReturn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowReturn";
            Load += BorrowReturn_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBooks).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Panel panel2;
        private Label lblLogout;
        private LinkLabel lblBorrow;
        private LinkLabel llbBooks;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel pnlBooks;
        private LinkLabel llbMembers;
        private Label label3;
        private Panel panel1;
        private Label lblList;
        private DataGridView dtgBooks;
        private DataGridViewTextBoxColumn NO;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnDelete;
        private ComboBox cmbGender;
        private DateTimePicker dtpCard;
        private DateTimePicker dtpBorrowDate;
        private Label label9;
        private Label label6;
        private Label label10;
        private Label label8;
        private Label label1;
        private Label label5;
        private Label label7;
        private Label label4;
        private TextBox txtStaff;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtID;
        private Panel panel3;
        private DateTimePicker dtpReturnDate;
        private Button btnBill;
    }
}