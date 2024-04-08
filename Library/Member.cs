using LibrabyManagement_2;
using LibraryManagement3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library
{
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        private void GetTK()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ReaderID", "");
            cmd.Parameters.AddWithValue("@ReaderName", "");
            cmd.Parameters.AddWithValue("@DateOfBirth", "");
            cmd.Parameters.AddWithValue("@Email", "");
            cmd.Parameters.AddWithValue("@CardCreattionDate", "");
            cmd.Parameters.AddWithValue("@PhoneNumber", "");
            cmd.Parameters.AddWithValue("@Gender", "");
            cmd.Parameters.AddWithValue("@Type", "");

            da = new SqlDataAdapter("SELECT * FROM Reader", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgBooks.DataSource = dt;

        }
        private void lblLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure Log out?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                LOGIN lOGIN = new LOGIN();
                lOGIN.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text != String.Empty && txtName.Text != String.Empty && dtpBirth.Text != String.Empty && txtEmail.Text != String.Empty
                && dtpCard.Text != String.Empty && txtPhone.Text != String.Empty && cmbGender.Text != String.Empty)
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Reader VALUES (@ID, @Name, @Birth, @Email, @Card, @Phone, @Gender)";

                SqlParameter parID = new SqlParameter("@ID", SqlDbType.VarChar);
                SqlParameter parName = new SqlParameter("@Name", SqlDbType.Char);
                SqlParameter parBirth = new SqlParameter("@Birth", SqlDbType.NVarChar);
                SqlParameter parEmail = new SqlParameter("@Email", SqlDbType.VarChar);
                SqlParameter parCard = new SqlParameter("@Card", SqlDbType.Char);
                SqlParameter parPhone = new SqlParameter("@Phone", SqlDbType.VarChar);
                SqlParameter parGender = new SqlParameter("@Gender", SqlDbType.NVarChar);

                parID.Value = txtID.Text.Trim();
                parName.Value = txtName.Text.Trim();
                parBirth.Value = Convert.ToString(dtpBirth.Text.Trim());
                parEmail.Value = txtEmail.Text.Trim();
                parCard.Value = Convert.ToString(dtpCard.Text.Trim());
                parPhone.Value = txtPhone.Text.Trim();
                parGender.Value = cmbGender.Text.Trim();

                cmd.Parameters.Add(parID);
                cmd.Parameters.Add(parName);
                cmd.Parameters.Add(parBirth);
                cmd.Parameters.Add(parEmail);
                cmd.Parameters.Add(parCard);
                cmd.Parameters.Add(parPhone);
                cmd.Parameters.Add(parGender);

                cmd.Connection = con;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Save information successful!!...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTK();
                txtID.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                dtpCard.Text = "";
                txtPhone.Text = "";
                cmbGender.Text = "";

                con.Close();

            }
            else
                MessageBox.Show("Please enter information!!...", "Enter information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != String.Empty && txtName.Text != String.Empty)
            {
                DialogResult dialog = MessageBox.Show("Are you sure delete?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM Reader WHERE ReaderID=@ID OR ReaderName=@Name";

                    SqlParameter parID = new SqlParameter("@ID", SqlDbType.VarChar);
                    SqlParameter parName = new SqlParameter("@Name", SqlDbType.Char);
                    SqlParameter parBirth = new SqlParameter("@Birth", SqlDbType.NVarChar);
                    SqlParameter parEmail = new SqlParameter("@Email", SqlDbType.VarChar);
                    SqlParameter parCard = new SqlParameter("@Card", SqlDbType.Char);
                    SqlParameter parPhone = new SqlParameter("@Phone", SqlDbType.VarChar);
                    SqlParameter parGender = new SqlParameter("@Gender", SqlDbType.NVarChar);

                    parID.Value = txtID.Text.Trim();
                    parName.Value = txtName.Text.Trim();
                    parBirth.Value = Convert.ToString(dtpBirth.Text.Trim());
                    parEmail.Value = txtEmail.Text.Trim();
                    parCard.Value = Convert.ToString(dtpCard.Text.Trim());
                    parPhone.Value = txtPhone.Text.Trim();
                    parGender.Value = cmbGender.Text.Trim();

                    cmd.Parameters.Add(parID);
                    cmd.Parameters.Add(parName);
                    cmd.Parameters.Add(parBirth);
                    cmd.Parameters.Add(parEmail);
                    cmd.Parameters.Add(parCard);
                    cmd.Parameters.Add(parPhone);
                    cmd.Parameters.Add(parGender);

                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetTK();
                    txtID.Text = "";
                    txtName.Text = "";
                    txtEmail.Text = "";
                    dtpCard.Text = "";
                    txtPhone.Text = "";
                    cmbGender.Text = "";
                    con.Close();
                }
                else
                    MessageBox.Show("Please enter information!!...", "Enter information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != String.Empty && txtName.Text != String.Empty && txtEmail.Text != String.Empty && txtPhone.Text != String.Empty && cmbGender.Text != String.Empty)
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Reader Set ReaderName=@Name, DateOfBirth=@Birth, Email=@Email, CardCreattionDate=@Card, PhoneNumber=@Phone, Gender=@Gender WHERE ReaderID=@ID";

                SqlParameter parID = new SqlParameter("@ID", SqlDbType.VarChar);
                SqlParameter parName = new SqlParameter("@Name", SqlDbType.Char);
                SqlParameter parBirth = new SqlParameter("@Birth", SqlDbType.NVarChar);
                SqlParameter parEmail = new SqlParameter("@Email", SqlDbType.VarChar);
                SqlParameter parCard = new SqlParameter("@Card", SqlDbType.Char);
                SqlParameter parPhone = new SqlParameter("@Phone", SqlDbType.VarChar);
                SqlParameter parGender = new SqlParameter("@Gender", SqlDbType.NVarChar);

                parID.Value = txtID.Text.Trim();
                parName.Value = txtName.Text.Trim();
                parBirth.Value = Convert.ToString(dtpBirth.Text.Trim());
                parEmail.Value = txtEmail.Text.Trim();
                parCard.Value = Convert.ToString(dtpCard.Text.Trim());
                parPhone.Value = txtPhone.Text.Trim();
                parGender.Value = cmbGender.Text.Trim();

                cmd.Parameters.Add(parID);
                cmd.Parameters.Add(parName);
                cmd.Parameters.Add(parBirth);
                cmd.Parameters.Add(parEmail);
                cmd.Parameters.Add(parCard);
                cmd.Parameters.Add(parPhone);
                cmd.Parameters.Add(parGender);

                cmd.Connection = con;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Update information successful!!...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTK();
                txtID.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                dtpCard.Text = "";
                txtPhone.Text = "";
                cmbGender.Text = "";

                con.Close();

            }
            else
                MessageBox.Show("Please enter information!!...", "Enter information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Member_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-5S19KHU;Initial Catalog=LibraryManagement;Integrated Security=True");
            cmd = new SqlCommand();

            GetTK();
        }

        private void dtgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtID.Text = dtgBooks.Rows[numrow].Cells[1].Value.ToString();
            txtName.Text = dtgBooks.Rows[numrow].Cells[2].Value.ToString();
            dtpBirth.Text = dtgBooks.Rows[numrow].Cells[3].Value.ToString();
            txtEmail.Text = dtgBooks.Rows[numrow].Cells[4].Value.ToString();
            dtpCard.Text = dtgBooks.Rows[numrow].Cells[5].Value.ToString();
            txtPhone.Text = dtgBooks.Rows[numrow].Cells[6].Value.ToString();
            cmbGender.Text = dtgBooks.Rows[numrow].Cells[7].Value.ToString();
        }

        private void dtgBooks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dtgBooks.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void llbBooks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmBooks frmBooks = new frmBooks();
            frmBooks.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Reader WHERE ReaderID LIKE '" + txtSearch.Text + "%' OR ReaderName LIKE '" + txtSearch.Text + "%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgBooks.DataSource = dt;
            con.Close();
        }

        private void lblBorrow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            BorrowReturn borrowReturn = new BorrowReturn();
            borrowReturn.ShowDialog();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length > 0)
            {
                if (txtPhone.Text[0] != '0')
                {
                    MessageBox.Show("Phone number must be start with number 0.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPhone.Text = "";
                    txtPhone.Focus();
                }
                if (txtPhone.Text.Length > 10)
                {
                    MessageBox.Show("Length of phone number must be below 10 charactor.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPhone.Text = "";
                    txtPhone.Focus();
                }
            }
        }
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Kiểm tra định dạng email
                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email không hợp lệ. Vui lòng nhập đúng định dạng email.", "Thông báo");
                    // Xóa nội dung textbox và đưa con trỏ về vị trí đầu tiên
                    txtEmail.Text = "";
                    txtEmail.Focus();
                }
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                Regex regex = new Regex(pattern);
                return regex.IsMatch(email);
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email not valid.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Text = "";
                txtEmail.Focus();
            }
        }

        private void cmbGender_Leave(object sender, EventArgs e)
        {
            if (cmbGender.Text != "Man" || cmbGender.Text != "Women" || cmbGender.Text != "Other")
            {
                MessageBox.Show("Gender not valid.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbGender.Text = "";
                cmbGender.Focus();
            }
        }
    }
}
