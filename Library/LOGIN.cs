using LibraryManagement3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Quic;
using Microsoft.VisualBasic.ApplicationServices;

namespace LibrabyManagement_2
{
    public partial class LOGIN : Form
    {
        string constr = @"Data Source=DESKTOP-5S19KHU;Initial Catalog=LibraryManagement;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        public LOGIN()
        {
            InitializeComponent();
            btnCreate.Enabled = false;
            lblError.Visible = false;
            txtPass.PasswordChar = '*';
            
        }
        public LOGIN(string a) : this()
        {
            txtStaffID.Text = a;
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string getID(string username, string pass)
        {
            string id = "";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    string query = "SELECT StaffID FROM Account WHERE StaffID = @Username AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", pass);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id = reader["StaffID"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while querying data or connecting to the server: " + ex.Message);
            }
            return id;
        }
        public static string ID_USER = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtStaffID.Text;
            string password = txtPass.Text;
            string userID = getID(username, password);
            /*cmd = new SqlCommand("SELECT * FROM Account WHERE StaffID ='" + username + "' and Password='" + password + "'", con);*/
            try
            {
                if (!string.IsNullOrEmpty(userID))
                {
                    // Successful login
                    lblError.Visible = false;
                    frmBooks fbooks = new frmBooks();
                    fbooks.Show();
                    this.Hide();
                }
                else
                {
                    // Invalid username or password
                    lblError.Visible = true;
                    MessageBox.Show("Invalid username or password!");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }


        private void LOGIN_Load(object sender, EventArgs e)
        {
            txtStaffID.Focus();

        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {


        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {


            string username = txtStaffID.Text;
            string password = txtPass.Text;
            string userID = getID(username, password);
            string ql = "ql";
            try
            {
                if (!string.IsNullOrEmpty(userID) && ql.Contains(username))
                {
                    // Successful login
                    btnCreate.Enabled = true;
                }
                else
                {
                    // Invalid username or password
                    btnCreate.Enabled = false;
                    MessageBox.Show("You are not manager!");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái của ô văn bản mật khẩu
            if (txtPass.PasswordChar == '*')
            {
                // Nếu mật khẩu đang ẩn, hiển thị mật khẩu
                txtPass.PasswordChar = '\0';
                btnShow.Text = "Hide password";
            }
            else
            {
                // Nếu mật khẩu đang được hiển thị, ẩn mật khẩu
                txtPass.PasswordChar = '*';
                btnShow.Text = "Show password";
            }
        }
    }
}
