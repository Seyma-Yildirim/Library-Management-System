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

namespace LibraryManagmentSystem
{
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtEnrollmentNo.Clear();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SEYMA\SQLEXPRESS;Initial Catalog=LibraryManagment;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select*from IssueBook where std_enroll='" + txtEnrollmentNo.Text + "' and book_return_date is null", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid No or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string bName;
        string bDate;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bName = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bDate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtBookName.Text = bName;
            txtBookIssueDate.Text = bDate;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SEYMA\SQLEXPRESS;Initial Catalog=LibraryManagment;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update IssueBook set book_return_date='" + dateTimePicker1.Text + "' where std_enroll='" + txtEnrollmentNo.Text + "' and id='" + rowid + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Return Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ReturnBooks_Load(this, null);
        }

        private void txtEnrollmentNo_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollmentNo.Text == "")
            {
                panel2.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollmentNo.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
