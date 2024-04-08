namespace Library
{
    partial class BooksView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksView));
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            dtpYear = new DateTimePicker();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            txtStorage = new TextBox();
            txtWriter = new TextBox();
            txtType = new TextBox();
            txtStatus = new TextBox();
            txtCompany = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label1 = new Label();
            txtSearch = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            NO = new DataGridViewTextBoxColumn();
            lblList = new Label();
            dtgBooks = new DataGridView();
            panel1 = new Panel();
            lblLogout = new Label();
            llbMembers = new LinkLabel();
            linkLabel3 = new LinkLabel();
            llbBooks = new LinkLabel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pnlBooks = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBooks).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 112);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 8;
            label6.Text = "Publish Company";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 61);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 8;
            label5.Text = "Book Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(599, 183);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 3;
            label3.Text = "Information";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dtpYear);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtStorage);
            panel3.Controls.Add(txtWriter);
            panel3.Controls.Add(txtType);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(txtCompany);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(txtID);
            panel3.Location = new Point(599, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(614, 382);
            panel3.TabIndex = 1;
            // 
            // dtpYear
            // 
            dtpYear.CustomFormat = "dd-MM-yyyy";
            dtpYear.Format = DateTimePickerFormat.Custom;
            dtpYear.Location = new Point(145, 155);
            dtpYear.Name = "dtpYear";
            dtpYear.Size = new Size(250, 27);
            dtpYear.TabIndex = 3;
            dtpYear.Value = new DateTime(2024, 4, 2, 0, 0, 0, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 343);
            label11.Name = "label11";
            label11.Size = new Size(80, 20);
            label11.TabIndex = 8;
            label11.Text = "Storage ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 254);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 8;
            label9.Text = "Writer ID";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 300);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 8;
            label10.Text = "Type ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 202);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 8;
            label8.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 160);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 8;
            label7.Text = "Publish year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 14);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 8;
            label4.Text = "BookID";
            // 
            // txtStorage
            // 
            txtStorage.Location = new Point(145, 336);
            txtStorage.Name = "txtStorage";
            txtStorage.Size = new Size(447, 27);
            txtStorage.TabIndex = 7;
            // 
            // txtWriter
            // 
            txtWriter.Location = new Point(145, 247);
            txtWriter.Name = "txtWriter";
            txtWriter.Size = new Size(447, 27);
            txtWriter.TabIndex = 5;
            // 
            // txtType
            // 
            txtType.Location = new Point(145, 297);
            txtType.Name = "txtType";
            txtType.Size = new Size(447, 27);
            txtType.TabIndex = 6;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(145, 199);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(447, 27);
            txtStatus.TabIndex = 4;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(145, 105);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(447, 27);
            txtCompany.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(447, 27);
            txtName.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(145, 14);
            txtID.Name = "txtID";
            txtID.Size = new Size(447, 27);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(611, 122);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 19;
            label1.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(611, 153);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1014, 588);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(900, 588);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(777, 588);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            lblList.Size = new Size(34, 20);
            lblList.TabIndex = 2;
            lblList.Text = "List";
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
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblList);
            panel1.Controls.Add(dtgBooks);
            panel1.Location = new Point(13, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 460);
            panel1.TabIndex = 11;
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
            llbMembers.Font = new Font("Arial", 13.8F);
            llbMembers.ForeColor = SystemColors.ActiveCaptionText;
            llbMembers.LinkColor = Color.Black;
            llbMembers.Location = new Point(406, 76);
            llbMembers.Name = "llbMembers";
            llbMembers.Size = new Size(107, 26);
            llbMembers.TabIndex = 2;
            llbMembers.TabStop = true;
            llbMembers.Text = "Members";
            llbMembers.LinkClicked += llbMembers_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Arial", 13.8F);
            linkLabel3.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(541, 76);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(172, 26);
            linkLabel3.TabIndex = 2;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Borrow - Return";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // llbBooks
            // 
            llbBooks.AutoSize = true;
            llbBooks.BackColor = Color.Lime;
            llbBooks.Font = new Font("Arial", 13.8F);
            llbBooks.ForeColor = SystemColors.ActiveCaptionText;
            llbBooks.LinkColor = Color.Black;
            llbBooks.Location = new Point(264, 76);
            llbBooks.Name = "llbBooks";
            llbBooks.Size = new Size(76, 26);
            llbBooks.TabIndex = 2;
            llbBooks.TabStop = true;
            llbBooks.Text = "Books";
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
            pictureBox2.BackColor = Color.Lime;
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
            pnlBooks.Location = new Point(251, 0);
            pnlBooks.Name = "pnlBooks";
            pnlBooks.Size = new Size(103, 109);
            pnlBooks.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Turquoise;
            panel2.Controls.Add(lblLogout);
            panel2.Controls.Add(llbMembers);
            panel2.Controls.Add(linkLabel3);
            panel2.Controls.Add(llbBooks);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pnlBooks);
            panel2.ForeColor = SystemColors.Control;
            panel2.Location = new Point(2, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1222, 108);
            panel2.TabIndex = 12;
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
            // btnBack
            // 
            btnBack.Location = new Point(1119, 588);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // BooksView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 629);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BooksView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BooksView";
            Load += BooksView_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private TextBox txtCompany;
        private TextBox txtName;
        private TextBox txtID;
        private Label label1;
        private TextBox txtSearch;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridViewTextBoxColumn NO;
        private Label lblList;
        private DataGridView dtgBooks;
        private Panel panel1;
        private Label lblLogout;
        private LinkLabel llbMembers;
        private LinkLabel linkLabel3;
        private LinkLabel llbBooks;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel pnlBooks;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label9;
        private Label label10;
        private Label label8;
        private Label label7;
        private TextBox txtStorage;
        private TextBox txtWriter;
        private TextBox txtType;
        private TextBox txtStatus;
        private Button btnBack;
        private DateTimePicker dtpYear;
    }
}