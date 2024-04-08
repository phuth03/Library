using LibrabyManagement_2;
using LibraryManagement3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class BooksView : Form
    {
        public BooksView()
        {
            InitializeComponent();
            txtType.Enabled = false;

        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        private string _message;
        private string _message2;
        public BooksView(string Message, string message2) : this()
        {
            _message = Message;
            txtType.Text = _message;
            _message2 = message2;

        }
        private void GetTK()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BookID", "");
            cmd.Parameters.AddWithValue("@BookName", "");
            cmd.Parameters.AddWithValue("@Company", "");
            cmd.Parameters.AddWithValue("@Year", "");
            cmd.Parameters.AddWithValue("@Status", "");
            cmd.Parameters.AddWithValue("@Writer", "");
            cmd.Parameters.AddWithValue("@Type", "");
            cmd.Parameters.AddWithValue("@Storage", "");
            da = new SqlDataAdapter("SELECT * FROM Book WHERE TypeID LIKE '" + _message + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgBooks.DataSource = dt;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != String.Empty && txtName.Text != String.Empty && txtCompany.Text != String.Empty && dtpYear.Text != String.Empty
                    && txtStatus.Text != String.Empty && txtWriter.Text != String.Empty && txtType.Text != String.Empty && txtStorage.Text != String.Empty)
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Book VALUES (@ID, @Name, @Comp, @Year, @Status, @Writer, @Type, @Storage)";

                    SqlParameter parID = new SqlParameter("@ID", SqlDbType.VarChar);
                    SqlParameter parName = new SqlParameter("@Name", SqlDbType.Char);
                    SqlParameter parComp = new SqlParameter("@Comp", SqlDbType.NVarChar);
                    SqlParameter parYear = new SqlParameter("@Year", SqlDbType.VarChar);
                    SqlParameter parStatus = new SqlParameter("@Status", SqlDbType.Char);
                    SqlParameter parWriter = new SqlParameter("@Writer", SqlDbType.VarChar);
                    SqlParameter parType = new SqlParameter("@Type", SqlDbType.NVarChar);
                    SqlParameter parStorage = new SqlParameter("@Storage", SqlDbType.Char);


                    parID.Value = txtID.Text.Trim();
                    parName.Value = txtName.Text.Trim();
                    parComp.Value = txtCompany.Text.Trim();
                    parYear.Value = Convert.ToString(dtpYear.Text.Trim());
                    parStatus.Value = txtStatus.Text.Trim();
                    parWriter.Value = txtWriter.Text.Trim();
                    parType.Value = txtType.Text.Trim();
                    parStorage.Value = txtStorage.Text.Trim();

                    cmd.Parameters.Add(parID);
                    cmd.Parameters.Add(parName);
                    cmd.Parameters.Add(parComp);
                    cmd.Parameters.Add(parYear);
                    cmd.Parameters.Add(parStatus);
                    cmd.Parameters.Add(parWriter);
                    cmd.Parameters.Add(parType);
                    cmd.Parameters.Add(parStorage);

                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save information successful!!...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetTK();
                    txtID.Text = "";
                    txtName.Text = "";
                    txtCompany.Text = "";
                    txtStatus.Text = "";
                    txtWriter.Text = "";
                    txtType.Text = "";
                    txtStorage.Text = "";

                    con.Close();

                }
                else
                    MessageBox.Show("Please enter information!!...", "Enter information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch
            {
                MessageBox.Show("This ID of book is exist. Please enter information again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
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
                    cmd.CommandText = "DELETE FROM Book WHERE BookID=@ID OR BookName=@Name";

                    SqlParameter parID = new SqlParameter("@ID", SqlDbType.VarChar);
                    SqlParameter parName = new SqlParameter("@Name", SqlDbType.Char);
                    SqlParameter parComp = new SqlParameter("@Comp", SqlDbType.NVarChar);
                    SqlParameter parYear = new SqlParameter("@Year", SqlDbType.VarChar);
                    SqlParameter parStatus = new SqlParameter("@Status", SqlDbType.Char);
                    SqlParameter parWriter = new SqlParameter("@Writer", SqlDbType.VarChar);
                    SqlParameter parType = new SqlParameter("@Type", SqlDbType.NVarChar);
                    SqlParameter parStorage = new SqlParameter("@Storage", SqlDbType.Char);


                    parID.Value = txtID.Text.Trim();
                    parName.Value = txtName.Text.Trim();
                    parComp.Value = txtCompany.Text.Trim();
                    parYear.Value = Convert.ToString(dtpYear.Text.Trim());
                    parStatus.Value = txtStatus.Text.Trim();
                    parWriter.Value = txtWriter.Text.Trim();
                    parType.Value = txtType.Text.Trim();
                    parStorage.Value = txtStorage.Text.Trim();

                    cmd.Parameters.Add(parID);
                    cmd.Parameters.Add(parName);
                    cmd.Parameters.Add(parComp);
                    cmd.Parameters.Add(parYear);
                    cmd.Parameters.Add(parStatus);
                    cmd.Parameters.Add(parWriter);
                    cmd.Parameters.Add(parType);
                    cmd.Parameters.Add(parStorage);

                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetTK();
                    txtID.Text = "";
                    txtName.Text = "";
                    txtCompany.Text = "";
                    txtStatus.Text = "";
                    txtWriter.Text = "";
                    txtType.Text = "";
                    txtStorage.Text = "";

                    con.Close();
                }
                else
                    MessageBox.Show("Please enter information!!...", "Enter information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void BooksView_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-5S19KHU;Initial Catalog=LibraryManagement;Integrated Security=True");
            cmd = new SqlCommand();

            GetTK();
            if (txtType.Text == _message)
                lblList.Text = "List of " + _message2 + ":";
        }

        private void dtgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtID.Text = dtgBooks.Rows[numrow].Cells[1].Value.ToString();
            txtName.Text = dtgBooks.Rows[numrow].Cells[2].Value.ToString();
            txtCompany.Text = dtgBooks.Rows[numrow].Cells[3].Value.ToString();
            dtpYear.Text = dtgBooks.Rows[numrow].Cells[4].Value.ToString();
            txtStatus.Text = dtgBooks.Rows[numrow].Cells[5].Value.ToString();
            txtWriter.Text = dtgBooks.Rows[numrow].Cells[6].Value.ToString();
            txtType.Text = dtgBooks.Rows[numrow].Cells[7].Value.ToString();
            txtStorage.Text = dtgBooks.Rows[numrow].Cells[8].Value.ToString();
        }

        private void dtgBooks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dtgBooks.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != String.Empty && txtName.Text != String.Empty && txtStatus.Text != String.Empty)
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Book Set BookName=@Name, PublishCompany=@Comp, PublishYear=@Year, Status=@Status, WriterID=@Writer, TypeID=@Type, StorageID=@Storage WHERE BookID=@ID";

                    SqlParameter parID = new SqlParameter("@ID", SqlDbType.VarChar);
                    SqlParameter parName = new SqlParameter("@Name", SqlDbType.Char);
                    SqlParameter parComp = new SqlParameter("@Comp", SqlDbType.NVarChar);
                    SqlParameter parYear = new SqlParameter("@Year", SqlDbType.VarChar);
                    SqlParameter parStatus = new SqlParameter("@Status", SqlDbType.Char);
                    SqlParameter parWriter = new SqlParameter("@Writer", SqlDbType.VarChar);
                    SqlParameter parType = new SqlParameter("@Type", SqlDbType.NVarChar);
                    SqlParameter parStorage = new SqlParameter("@Storage", SqlDbType.Char);

                    parID.Value = txtID.Text.Trim();
                    parName.Value = txtName.Text.Trim();
                    parComp.Value = txtCompany.Text.Trim();
                    parYear.Value = Convert.ToString(dtpYear.Text.Trim());
                    parStatus.Value = txtStatus.Text.Trim();
                    parWriter.Value = txtWriter.Text.Trim();
                    parType.Value = txtType.Text.Trim();
                    parStorage.Value = txtStorage.Text.Trim();

                    cmd.Parameters.Add(parID);
                    cmd.Parameters.Add(parName);
                    cmd.Parameters.Add(parComp);
                    cmd.Parameters.Add(parYear);
                    cmd.Parameters.Add(parStatus);
                    cmd.Parameters.Add(parWriter);
                    cmd.Parameters.Add(parType);
                    cmd.Parameters.Add(parStorage); ;

                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update information successful!!...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetTK();
                    txtID.Text = "";
                    txtName.Text = "";
                    txtCompany.Text = "";
                    txtStatus.Text = "";
                    txtWriter.Text = "";
                    txtType.Text = "";
                    txtStorage.Text = "";

                    con.Close();

                }
                else
                    MessageBox.Show("Please enter information!!...", "Enter information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch
            {
                MessageBox.Show("This ID of book is exist. Please enter information again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmBooks frmBooks = new frmBooks();
            frmBooks.Show();
            this.Hide();
        }

        private void llbMembers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Member member = new Member();
            member.Show();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            BorrowReturn borrowReturn = new BorrowReturn();
            borrowReturn.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Book WHERE BookID LIKE '" + txtSearch.Text + "%' OR BookName LIKE '" + txtSearch.Text + "%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgBooks.DataSource = dt;
            con.Close();
        }
    }
}
