namespace LibraryManagement3
{
    partial class frmBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblLogout = new Label();
            llbMembers = new LinkLabel();
            linkLabel3 = new LinkLabel();
            llbBooks = new LinkLabel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pnlBooks = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            dtgBooks = new DataGridView();
            NO = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnView = new Button();
            txtID = new TextBox();
            txtName = new TextBox();
            txtStatus = new TextBox();
            panel3 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBooks).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Library.Properties.Resources.images;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 109);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1224, 109);
            panel2.TabIndex = 5;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.BackColor = Color.Red;
            lblLogout.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLogout.Location = new Point(1064, 32);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(148, 41);
            lblLogout.TabIndex = 0;
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
            llbMembers.LinkClicked += linkLabel1_LinkClicked;
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
            pictureBox2.Image = Library.Properties.Resources.Book;
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtgBooks);
            panel1.Location = new Point(12, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 440);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(133, 27);
            label2.TabIndex = 2;
            label2.Text = "Categories";
            // 
            // dtgBooks
            // 
            dtgBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBooks.Columns.AddRange(new DataGridViewColumn[] { NO });
            dtgBooks.Location = new Point(32, 37);
            dtgBooks.Name = "dtgBooks";
            dtgBooks.RowHeadersWidth = 51;
            dtgBooks.Size = new Size(542, 402);
            dtgBooks.TabIndex = 1;
            dtgBooks.CellClick += dtgBooks_CellClick;
            dtgBooks.CellContentClick += dtgBooks_CellContentClick;
            dtgBooks.RowPostPaint += dtgBooks_RowPostPaint;
            // 
            // NO
            // 
            NO.HeaderText = "#";
            NO.MinimumWidth = 6;
            NO.Name = "NO";
            NO.Width = 125;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(610, 147);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(275, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(610, 116);
            label1.Name = "label1";
            label1.Size = new Size(91, 31);
            label1.TabIndex = 8;
            label1.Text = "Search:";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial Narrow", 13.8F);
            btnAdd.Location = new Point(743, 579);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 38);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial Narrow", 13.8F);
            btnDelete.Location = new Point(866, 579);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial Narrow", 13.8F);
            btnUpdate.Location = new Point(980, 579);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 38);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnView
            // 
            btnView.Font = new Font("Arial Narrow", 13.8F);
            btnView.Location = new Point(1096, 579);
            btnView.Name = "btnView";
            btnView.Size = new Size(117, 38);
            btnView.TabIndex = 4;
            btnView.Text = "View/Edit";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(116, 64);
            txtID.Name = "txtID";
            txtID.Size = new Size(314, 27);
            txtID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(116, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(314, 27);
            txtName.TabIndex = 1;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(116, 230);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(314, 27);
            txtStatus.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtStatus);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(txtID);
            panel3.Location = new Point(598, 194);
            panel3.Name = "panel3";
            panel3.Size = new Size(615, 362);
            panel3.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 13.8F);
            label6.Location = new Point(12, 233);
            label6.Name = "label6";
            label6.Size = new Size(64, 27);
            label6.TabIndex = 8;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 13.8F);
            label5.Location = new Point(7, 146);
            label5.Name = "label5";
            label5.Size = new Size(103, 27);
            label5.TabIndex = 8;
            label5.Text = "TypeName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F);
            label4.Location = new Point(7, 67);
            label4.Name = "label4";
            label4.Size = new Size(71, 27);
            label4.TabIndex = 8;
            label4.Text = "TypeID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(139, 27);
            label3.TabIndex = 3;
            label3.Text = "Information";
            // 
            // frmBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 629);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnView);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            Load += frmBooks_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBooks).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private LinkLabel llbBooks;
        private PictureBox pictureBox2;
        private Panel panel1;
        private LinkLabel linkLabel3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label lblLogout;
        private Panel pnlBooks;
        private DataGridView dtgBooks;
        private DataGridViewTextBoxColumn NO;
        private TextBox txtSearch;
        private Label label1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnView;
        private Label label2;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtStatus;
        private Panel panel3;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private LinkLabel llbMembers;
    }
}