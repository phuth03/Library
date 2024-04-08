using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibrabyManagement_2
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            lblWrong.Visible = false;
            lblError.Visible = false;
        }
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN form = new LOGIN();
            form.ShowDialog();
            
        }
        private void GetTK()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StaffID", 0);
            cmd.Parameters.AddWithValue("@Password", "");
            cmd.Parameters.AddWithValue("@Type", 0);
            da = new SqlDataAdapter("SELECT * FROM Account", con);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPass.Text == "" || txtEnterPass.Text == "" || comboBox1.SelectedItem.ToString() == "")
            {
                lblWrong.Visible = false;
                lblError.Visible = true;

            }
            else if (txtPass.Text != txtEnterPass.Text)
            {
                lblError.Visible = false;
                lblWrong.Visible = true;
            }
            else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Account VALUES (@StaffID, @Password, @Type)";

                    SqlParameter parTK = new SqlParameter("@StaffID", SqlDbType.VarChar);
                    SqlParameter parMK = new SqlParameter("@Password", SqlDbType.Char);
                    SqlParameter parLoaiTK = new SqlParameter("@Type", SqlDbType.NVarChar);

                    parTK.Value = txtUsername.Text.Trim();
                    parMK.Value = txtPass.Text.Trim();
                    parLoaiTK.Value = comboBox1.Text.Trim();

                    cmd.Parameters.Add(parTK);
                    cmd.Parameters.Add(parMK);
                    cmd.Parameters.Add(parLoaiTK);

                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Create successful!!...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetTK();
                    txtUsername.Text = "";
                    txtPass.Text = "";
                    txtEnterPass.Text = "";
                    comboBox1.Text = "";
                    Reset();
                    con.Close();
                    lblError.Visible = false;
                    LOGIN signIn = new LOGIN(txtUsername.Text);
                    signIn.ShowDialog();
                    this.Hide();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("This this acount is exist. Please enter information again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Text = "";
                    txtPass.Text = "";
                    txtEnterPass.Text = "";
                    comboBox1.Text = "";
                }

                

            }

        }
        private void Reset()
        {
            comboBox1.SelectedIndex = -1;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-5S19KHU;Initial Catalog=LibraryManagement;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StaffID", 0);
            cmd.Parameters.AddWithValue("@Password", "");
            cmd.Parameters.AddWithValue("@Type", 0);
            da = new SqlDataAdapter("SELECT * FROM Account", con);
        }
    }
}
