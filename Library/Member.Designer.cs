namespace Library
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            label1 = new Label();
            NO = new DataGridViewTextBoxColumn();
            lblList = new Label();
            dtgBooks = new DataGridView();
            lblLogout = new Label();
            llbMembers = new LinkLabel();
            lblBorrow = new LinkLabel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            cmbGender = new ComboBox();
            dtpCard = new DateTimePicker();
            dtpBirth = new DateTimePicker();
            label9 = new Label();
            label6 = new Label();
            label10 = new Label();
            label8 = new Label();
            label5 = new Label();
            label7 = new Label();
            label4 = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            llbBooks = new LinkLabel();
            pictureBox2 = new PictureBox();
            pnlBooks = new Panel();
            txtSearch = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlBooks.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(607, 126);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 29;
            label1.Text = "Search:";
            // 
            // NO
            // 
            NO.HeaderText = "#";
            NO.MinimumWidth = 6;
            NO.Name = "NO";
            NO.Width = 125;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblList.Location = new Point(3, 7);
            lblList.Name = "lblList";
            lblList.Size = new Size(116, 20);
            lblList.TabIndex = 2;
            lblList.Text = "List of member";
            // 
            // dtgBooks
            // 
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
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.BackColor = Color.Red;
            lblLogout.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogout.Location = new Point(1063, 32);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(148, 41);
            lblLogout.TabIndex = 3;
            lblLogout.Text = "LOG OUT";
            lblLogout.Click += lblLogout_Click;
            // 
            // llbMembers
            // 
            llbMembers.AutoSize = true;
            llbMembers.BackColor = Color.Lime;
            llbMembers.Font = new Font("Arial", 13.8F);
            llbMembers.ForeColor = SystemColors.ActiveCaptionText;
            llbMembers.LinkColor = Color.Black;
            llbMembers.Location = new Point(0, 76);
            llbMembers.Name = "llbMembers";
            llbMembers.Size = new Size(107, 26);
            llbMembers.TabIndex = 2;
            llbMembers.TabStop = true;
            llbMembers.Text = "Members";
            // 
            // lblBorrow
            // 
            lblBorrow.AutoSize = true;
            lblBorrow.Font = new Font("Arial", 13.8F);
            lblBorrow.ForeColor = SystemColors.ActiveCaptionText;
            lblBorrow.LinkColor = Color.Black;
            lblBorrow.Location = new Point(541, 76);
            lblBorrow.Name = "lblBorrow";
            lblBorrow.Size = new Size(172, 26);
            lblBorrow.TabIndex = 2;
            lblBorrow.TabStop = true;
            lblBorrow.Text = "Borrow - Return";
            lblBorrow.LinkClicked += lblBorrow_LinkClicked;
            // 
            // pictureBox4
            // 
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
            pictureBox3.BackColor = Color.Lime;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(423, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(79, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 109);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(cmbGender);
            panel3.Controls.Add(dtpCard);
            panel3.Controls.Add(dtpBirth);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(txtID);
            panel3.Location = new Point(595, 204);
            panel3.Name = "panel3";
            panel3.Size = new Size(614, 382);
            panel3.TabIndex = 0;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Man", "Women", "Other" });
            cmbGender.Location = new Point(145, 337);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(151, 28);
            cmbGender.TabIndex = 7;
            cmbGender.Leave += cmbGender_Leave;
            // 
            // dtpCard
            // 
            dtpCard.CustomFormat = "dd-MM-yyyy";
            dtpCard.Format = DateTimePickerFormat.Custom;
            dtpCard.Location = new Point(145, 236);
            dtpCard.Name = "dtpCard";
            dtpCard.Size = new Size(250, 27);
            dtpCard.TabIndex = 5;
            dtpCard.Value = new DateTime(2024, 4, 2, 0, 0, 0, 0);
            // 
            // dtpBirth
            // 
            dtpBirth.CustomFormat = "dd-MM-yyyy";
            dtpBirth.Format = DateTimePickerFormat.Custom;
            dtpBirth.Location = new Point(145, 138);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(250, 27);
            dtpBirth.TabIndex = 3;
            dtpBirth.Value = new DateTime(2024, 4, 2, 0, 0, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.Control;
            label9.Location = new Point(3, 293);
            label9.Name = "label9";
            label9.Size = new Size(105, 20);
            label9.TabIndex = 8;
            label9.Text = "Phone number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 138);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 8;
            label6.Text = "Date Of Birth";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 345);
            label10.Name = "label10";
            label10.Size = new Size(57, 20);
            label10.TabIndex = 8;
            label10.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 241);
            label8.Name = "label8";
            label8.Size = new Size(145, 20);
            label8.TabIndex = 8;
            label8.Text = "Card createtion date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 77);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 8;
            label5.Text = "Reader Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 188);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 8;
            label7.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 21);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Reader ID";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(145, 286);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(447, 27);
            txtPhone.TabIndex = 6;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 185);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(447, 27);
            txtEmail.TabIndex = 4;
            txtEmail.KeyDown += txtEmail_KeyDown;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 74);
            txtName.Name = "txtName";
            txtName.Size = new Size(447, 27);
            txtName.TabIndex = 2;
            // 
            // txtID
            // 
            txtID.Location = new Point(145, 21);
            txtID.Name = "txtID";
            txtID.Size = new Size(447, 27);
            txtID.TabIndex = 1;
            // 
            // llbBooks
            // 
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
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Turquoise;
            pictureBox2.Image = Properties.Resources.Book;
            pictureBox2.Location = new Point(264, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pnlBooks
            // 
            pnlBooks.BackColor = Color.Lime;
            pnlBooks.Controls.Add(llbMembers);
            pnlBooks.Location = new Point(406, 0);
            pnlBooks.Name = "pnlBooks";
            pnlBooks.Size = new Size(110, 109);
            pnlBooks.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(607, 157);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Turquoise;
            panel2.Controls.Add(lblLogout);
            panel2.Controls.Add(lblBorrow);
            panel2.Controls.Add(llbBooks);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pnlBooks);
            panel2.ForeColor = SystemColors.Control;
            panel2.Location = new Point(-2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1222, 109);
            panel2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(595, 187);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 21;
            label3.Text = "Information";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblList);
            panel1.Controls.Add(dtgBooks);
            panel1.Location = new Point(9, 126);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 460);
            panel1.TabIndex = 22;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial Narrow", 13.8F);
            btnUpdate.Location = new Point(1116, 592);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 45);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial Narrow", 13.8F);
            btnDelete.Location = new Point(1002, 592);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 45);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial Narrow", 13.8F);
            btnAdd.Location = new Point(879, 592);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 45);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 633);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(txtSearch);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member";
            Load += Member_Load;
            ((System.ComponentModel.ISupportInitialize)dtgBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlBooks.ResumeLayout(false);
            pnlBooks.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridViewTextBoxColumn NO;
        private Label lblList;
        private DataGridView dtgBooks;
        private Label lblLogout;
        private LinkLabel llbMembers;
        private LinkLabel lblBorrow;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel panel3;
        private DateTimePicker dtpBirth;
        private Label label9;
        private Label label6;
        private Label label10;
        private Label label8;
        private Label label5;
        private Label label7;
        private Label label4;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtID;
        private LinkLabel llbBooks;
        private PictureBox pictureBox2;
        private Panel pnlBooks;
        private TextBox txtSearch;
        private Panel panel2;
        private Label label3;
        private Panel panel1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DateTimePicker dtpCard;
        private ComboBox cmbGender;
    }
}