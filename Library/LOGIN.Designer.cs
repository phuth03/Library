namespace LibrabyManagement_2
{
    partial class LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGIN));
            panel1 = new Panel();
            btnShow = new Button();
            btnCheck = new Button();
            lblError = new Label();
            btnCancel = new Button();
            btnCreate = new Button();
            btnLogin = new Button();
            txtPass = new TextBox();
            label3 = new Label();
            txtStaffID = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(btnShow);
            panel1.Controls.Add(btnCheck);
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtStaffID);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(183, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 369);
            panel1.TabIndex = 3;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(478, 258);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(125, 29);
            btnShow.TabIndex = 5;
            btnShow.Text = "Show password";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(209, 257);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(131, 29);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Check Infor";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(369, 235);
            lblError.Name = "lblError";
            lblError.Size = new Size(187, 20);
            lblError.TabIndex = 6;
            lblError.Text = "Wrong StaffID or Password";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Location = new Point(478, 292);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 39);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(128, 255, 128);
            btnCreate.Location = new Point(209, 292);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(131, 39);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create Account";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 128);
            btnLogin.Location = new Point(355, 292);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 39);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(232, 200);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(335, 27);
            txtPass.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 200);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new Point(232, 142);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(335, 27);
            txtStaffID.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 142);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 1;
            label2.Text = "StaffID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(267, 58);
            label1.Name = "label1";
            label1.Size = new Size(146, 43);
            label1.TabIndex = 0;
            label1.Text = "LOG IN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Library.Properties.Resources.ThuVien;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1000, 604);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // LOGIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 604);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LOGIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            Load += LOGIN_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnLogin;
        private TextBox txtPass;
        private Label label3;
        private TextBox txtStaffID;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblError;
        private Button btnCreate;
        private Button btnCheck;
        private Button btnShow;
    }
}