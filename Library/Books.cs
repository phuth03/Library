using LibrabyManagement_2;
using Library;
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



namespace LibraryManagement3
{
    public partial class frmBooks : Form
    {
        public frmBooks()
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
            cmd.Parameters.AddWithValue("@TypeID", 0);
            cmd.Parameters.AddWithValue("@TypeName", "");
            cmd.Parameters.AddWithValue("@Status", 0);
            da = new SqlDataAdapter("SELECT * FROM BookType ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgBooks.DataSource = dt;

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Member member = new Member();
            member.Show();
        }


        private void frmBooks_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-5S19KHU;Initial Catalog=LibraryManagement;Integrated Security=True");
            cmd = new SqlCommand();


            GetTK();
        }

        private void dtgBooks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dtgBooks.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksView booksView = new BooksView(txtID.Text, txtName.Text);
            booksView.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != String.Empty && txtName.Text != String.Empty && txtStatus.Text != String.Empty)
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO BookType VALUES (@ID, @Name, @Status)";

                    SqlParameter parID = new SqlParameter("@ID", SqlDbType.VarChar);
                    SqlParameter parName = new SqlParameter("@Name", SqlDbType.Char);
                    SqlParameter parStatus = new SqlParameter("@Status", SqlDbType.NVarChar);

                    parID.Value = txtID.Text.Trim();
                    parName.Value = txtName.Text.Trim();
                    parStatus.Value = txtStatus.Text.Trim();

                    cmd.Parameters.Add(parID);
                    cmd.Parameters.Add(parName);
                    cmd.Parameters.Add(parStatus);

                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Save information successful!!...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetTK();
                    txtID.Text = "";
                    txtName.Text = "";
                    txtStatus.Text = "";

                    con.Close();

                }
                else
                    MessageBox.Show("Please enter information!!...", "Enter information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("This type of book is exist. Please enter another type", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != string.Empty || txtName.Text != String.Empty)
            {
                DialogResult dialog = MessageBox.Show("Are you sure delete?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM BookType WHERE TypeID=@ID OR TypeName=@Name";

                    SqlParameter parID = new SqlParameter("@ID", SqlDbType.VarChar);
                    SqlParameter parName = new SqlParameter("@Name", SqlDbType.Char);

                    parID.Value = txtID.Text.Trim();
                    parName.Value = txtName.Text.Trim();

                    cmd.Parameters.Add(parID);
                    cmd.Parameters.Add(parName);

                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete successful.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetTK();
                    txtID.Text = "";
                    txtName.Text = "";
                    txtStatus.Text = "";
                    con.Close();
                }
                else
                    MessageBox.Show("Please enter information!!...", "Enter information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    cmd.CommandText = "UPDATE BookType Set TypeID=@ID, TypeName=@TypeName, Status=@Status WHERE TypeID=@ID";

                    SqlParameter parID = new SqlParameter("@ID", SqlDbType.VarChar);
                    SqlParameter parName = new SqlParameter("@TypeName", SqlDbType.Char);
                    SqlParameter parType = new SqlParameter("@Status", SqlDbType.NVarChar);

                    parID.Value = txtID.Text.Trim();
                    parName.Value = txtName.Text.Trim();
                    parType.Value = txtStatus.Text.Trim();

                    cmd.Parameters.Add(parID);
                    cmd.Parameters.Add(parName);
                    cmd.Parameters.Add(parType);

                    cmd.Connection = con;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update information successful!!...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetTK();
                    txtID.Text = "";
                    txtName.Text = "";
                    txtStatus.Text = "";

                    con.Close();

                }
                else
                    MessageBox.Show("Please enter information!!...", "Enter information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch
            {
                MessageBox.Show("This ID type of book can not edit. Please enter information again!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

        private void dtgBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BookType WHERE TypeName LIKE '" + txtSearch.Text + "%' OR TypeID LIKE '" + txtSearch.Text + "%'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgBooks.DataSource = dt;
            con.Close();
        }

        private void dtgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtID.Text = dtgBooks.Rows[numrow].Cells[1].Value.ToString();
            txtName.Text = dtgBooks.Rows[numrow].Cells[2].Value.ToString();
            txtStatus.Text = dtgBooks.Rows[numrow].Cells[3].Value.ToString();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            BorrowReturn borrowReturn = new BorrowReturn();
            borrowReturn.Show();
        }


    }
}
