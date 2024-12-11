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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }
        private void ViewBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SEYMA\SQLEXPRESS;Initial Catalog=LibraryManagment;Integrated Security=True");
            panel1.Visible = false;
            SqlCommand cmd = new SqlCommand("Select*from NewBook", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel1.Visible = true;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FUSBKT5;Initial Catalog=DbLibrary;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select*from NewBook where bid=" + bid + "", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            txtBN.Text = ds.Tables[0].Rows[0][1].ToString();
            txtBAN.Text = ds.Tables[0].Rows[0][2].ToString();
            txtBPub.Text = ds.Tables[0].Rows[0][3].ToString();
            txtBPDate.Text = ds.Tables[0].Rows[0][4].ToString();
            txtBPrice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtBQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void txtSBName_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FUSBKT5;Initial Catalog=DbLibrary;Integrated Security=True");
            if (txtSBName.Text != " ")
            {
                SqlCommand cmd = new SqlCommand("Select*from NewBook where bName like '" + txtSBName.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select*from NewBook", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSBName.Clear();
            panel1.Visible = true;
            ViewBook_Load(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will updated.Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bName = txtBN.Text;
                string bAName = txtBAN.Text;
                string bPub = txtBPub.Text;
                string dTime = txtBPDate.Text;
                Int64 bPrice = Int64.Parse(txtBPrice.Text);
                Int64 bQuantity = Int64.Parse(txtBQuantity.Text);

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FUSBKT5;Initial Catalog=DbLibrary;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Update NewBook set bName=@p1,bAuthor=@p2,bPub=@p3,bPDate=@p4,bPrice=@p5,bQuantity=@p6 where bid=@p7", con);
                cmd.Parameters.AddWithValue("@p1", bName);
                cmd.Parameters.AddWithValue("@p2", bAName);
                cmd.Parameters.AddWithValue("@p3", bPub);
                cmd.Parameters.AddWithValue("@p4", dTime);
                cmd.Parameters.AddWithValue("@p5", bPrice);
                cmd.Parameters.AddWithValue("@p6", bQuantity);
                cmd.Parameters.AddWithValue("@p7", bid);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will deleted.Are you sure?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FUSBKT5;Initial Catalog=DbLibrary;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Delete from NewBook where bid='" + rowid + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
