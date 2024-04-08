using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Drawing.Printing;
using Microsoft.Win32;
using System.Data.SqlClient;
using LibrabyManagement_2;
using LibraryManagement3;

namespace Library
{
    public partial class BorrowReturn : Form
    {

        public BorrowReturn()
        {
            InitializeComponent();
            txtName.Enabled = false;
        }
        private string _message;

        public BorrowReturn(string message) : this()
        {
            _message = message;
            txtName.Text = _message;
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        private void GetTK()
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BorrowID", "");
            cmd.Parameters.AddWithValue("@BorrowDate", "");
            cmd.Parameters.AddWithValue("@ReturnDate", "");
            cmd.Parameters.AddWithValue("@StaffID", "");

            da = new SqlDataAdapter("SELECT * FROM BorrowReturnSlip", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgBooks.DataSource = dt;

        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            this.Hide();

            Bill bill = new Bill(txtID.Text,txtName.Text,dtpBorrowDate.Text, dtpReturnDate.Text, txtStaff.Text);
            bill.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text != String.Empty && dtpBorrowDate.Text != String.Empty
                && dtpReturnDate.Text != String.Empty && txtStaff.Text != String.Empty)
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO BorrowReturnSlip VALUES (@ID, @BDate, @RDate, @StaffID)";

                SqlParameter parID = new SqlParameter("@ID", SqlDbType.VarChar);
                SqlParameter parBDate = new SqlParameter("@BDate", SqlDbType.NVarChar);
                SqlParameter parRDate = new SqlParameter("@RDate", SqlDbType.VarChar);
                SqlParameter parStaff = new SqlParameter("@StaffID", SqlDbType.Char);

                parID.Value = txtID.Text.Trim();
                parBDate.Value = Convert.ToString(dtpBorrowDate.Text.Trim());
                parRDate.Value = Convert.ToString(dtpReturnDate.Text.Trim());
                parStaff.Value = txtStaff.Text.Trim();

                cmd.Parameters.Add(parID);
                cmd.Parameters.Add(parBDate);
                cmd.Parameters.Add(parRDate);
                cmd.Parameters.Add(parStaff);

                cmd.Connection = con;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Save information successful!!...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTK();
                txtID.Text = "";
                txtStaff.Text = "";
                dtpBorrowDate.Text = "";
                dtpReturnDate.Text = "";

                con.Close();
            }
            else
                MessageBox.Show("Please enter information!!...", "Enter information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dtgBooks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dtgBooks.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dtgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-5S19KHU;Initial Catalog=LibraryManagement;Integrated Security=True"))
            {
                connection.Open();

                int numrow;
                numrow = e.RowIndex;
                txtID.Text = dtgBooks.Rows[numrow].Cells[1].Value.ToString();
                dtpBorrowDate.Text = dtgBooks.Rows[numrow].Cells[2].Value.ToString();
                dtpReturnDate.Text = dtgBooks.Rows[numrow].Cells[3].Value.ToString();
                txtStaff.Text = dtgBooks.Rows[numrow].Cells[4].Value.ToString();
                string query = "SELECT BookName " +
                        "FROM BorrowSlip AS BS " +
                        "INNER JOIN BorrowReturnSlip AS BRS " +
                        "ON BS.BorrowID = BRS.BorrowID " +
                        "INNER JOIN Book AS B " +
                        "ON BS.BookID = B.BookID " +
                        "WHERE BRS.BorrowID = @ID";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtName.Text = dr["BookName"].ToString();
                }
                else
                {
                    txtName.Text = "";
                }
                dr.Close();
            }
        }

        private void BorrowReturn_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-5S19KHU;Initial Catalog=LibraryManagement;Integrated Security=True");
            cmd = new SqlCommand();

            GetTK();

        }

        private void lblLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure Log out?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                this.Hide();
                LOGIN lOGIN = new LOGIN();
                lOGIN.ShowDialog();
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
                    cmd.CommandText = "DELETE FROM BorrowReturnSlip WHERE BorrowID=@ID";

                    SqlParameter parID = new SqlParameter("@ID", SqlDbType.VarChar);

                    parID.Value = txtID.Text.Trim();

                    cmd.Parameters.Add(parID);

                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetTK();
                    txtID.Text = "";
                    txtStaff.Text = "";
                    con.Close();
                }
                else
                    MessageBox.Show("Please enter information!!...", "Enter information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != String.Empty && dtpBorrowDate.Text != String.Empty && dtpReturnDate.Text != String.Empty)
            {
                con.Open();
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Reader Set BorrowDate=@BDate, ReturnDate=@RDate, StaffID=@StaffID WHERE BorrowID=@ID";

                SqlParameter parID = new SqlParameter("@ID", SqlDbType.VarChar);
                SqlParameter parBDate = new SqlParameter("@BDate", SqlDbType.NVarChar);
                SqlParameter parRDate = new SqlParameter("@RDate", SqlDbType.VarChar);
                SqlParameter parStaff = new SqlParameter("@StaffID", SqlDbType.Char);

                parID.Value = txtID.Text.Trim();
                parBDate.Value = Convert.ToString(dtpBorrowDate.Text.Trim());
                parRDate.Value = Convert.ToString(dtpReturnDate.Text.Trim());
                parStaff.Value = txtStaff.Text.Trim();

                cmd.Parameters.Add(parID);
                cmd.Parameters.Add(parBDate);
                cmd.Parameters.Add(parRDate);
                cmd.Parameters.Add(parStaff);

                cmd.Connection = con;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Update information successful!!...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetTK();
                txtID.Text = "";
                dtpBorrowDate.Text = "";
                dtpReturnDate.Text = "";
                txtStaff.Text = "";

                con.Close();

            }
            else
                MessageBox.Show("Please enter information!!...", "Enter information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BorrowReturnSlip WHERE BorrowID LIKE '" + txtSearch.Text + "%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgBooks.DataSource = dt;
            con.Close();
        }

        private void llbBooks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmBooks frmBooks = new frmBooks();
            frmBooks.ShowDialog();
        }

        private void llbMembers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Member member = new Member();
            member.Show();
        }
    }
}
