namespace LibrabyManagement_2
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            panel1 = new Panel();
            lblError = new Label();
            lblWrong = new Label();
            comboBox1 = new ComboBox();
            btnCancel = new Button();
            btnCreate = new Button();
            txtEnterPass = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtPass = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
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
            panel1.Controls.Add(lblError);
            panel1.Controls.Add(lblWrong);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(txtEnterPass);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(193, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 369);
            panel1.TabIndex = 3;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(45, 297);
            lblError.Name = "lblError";
            lblError.Size = new Size(299, 20);
            lblError.TabIndex = 5;
            lblError.Text = "Please enter your full account and password";
            // 
            // lblWrong
            // 
            lblWrong.AutoSize = true;
            lblWrong.ForeColor = Color.Red;
            lblWrong.Location = new Point(45, 297);
            lblWrong.Name = "lblWrong";
            lblWrong.Size = new Size(280, 20);
            lblWrong.TabIndex = 5;
            lblWrong.Text = "Password is not match. Please try again !..";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Staff", "Manager" });
            comboBox1.Location = new Point(232, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(501, 292);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 39);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(128, 255, 128);
            btnCreate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(369, 292);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(102, 39);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtEnterPass
            // 
            txtEnterPass.Location = new Point(232, 186);
            txtEnterPass.Name = "txtEnterPass";
            txtEnterPass.Size = new Size(335, 27);
            txtEnterPass.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(85, 236);
            label5.Name = "label5";
            label5.Size = new Size(53, 23);
            label5.TabIndex = 1;
            label5.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(85, 186);
            label4.Name = "label4";
            label4.Size = new Size(151, 23);
            label4.TabIndex = 1;
            label4.Text = "Enter Password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(232, 127);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(335, 27);
            txtPass.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 127);
            label3.Name = "label3";
            label3.Size = new Size(98, 23);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(232, 69);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(335, 27);
            txtUsername.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 69);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(232, 14);
            label1.Name = "label1";
            label1.Size = new Size(167, 43);
            label1.TabIndex = 0;
            label1.Text = "SIGN UP";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Library.Properties.Resources.ThuVien;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(999, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 600);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        private Button btnCreate;
        private TextBox txtEnterPass;
        private Label label4;
        private TextBox txtPass;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label5;
        private Label lblError;
        private Label lblWrong;
    }
}