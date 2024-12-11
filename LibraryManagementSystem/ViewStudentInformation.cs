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
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }
        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            SqlConnection con = new SqlConnection(@"Data Source=SEYMA\SQLEXPRESS;Initial Catalog=LibraryManagment;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select*from AddStudent", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FUSBKT5;Initial Catalog=DbLibrary;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select*from AddStudent where enroll LIKE '" + txtSearchEnrollment.Text + "'%", con);
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
            SqlCommand cmd = new SqlCommand("Select*from AddStudent where sid=" + bid + "", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtSName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtER.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDep.Text = ds.Tables[0].Rows[0][3].ToString();
            txtSSem.Text = ds.Tables[0].Rows[0][4].ToString();
            txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtSName.Text;
            string enrollment = txtER.Text;
            string dep = txtDep.Text;
            string semester = txtSSem.Text;
            Int64 contact = Int64.Parse(txtContact.Text);
            string email = txtEmail.Text;

            if (MessageBox.Show("Data will be updated.Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FUSBKT5;Initial Catalog=DbLibrary;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Update AddStudent set sname=" + name + ",enroll=" + enrollment + ",dep=" + dep + ",sem=" + semester + ",contact=" + contact + ",emai=" + email + " where sid=" + rowid + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
            ViewStudentInformation_Load(this, null);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewStudentInformation_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted.Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FUSBKT5;Initial Catalog=DbLibrary;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Delete from AddStudent where sid=" + rowid + "", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
            ViewStudentInformation_Load(this, null);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved data will be lost.Confirm?", "Are you Sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }

    }
}
