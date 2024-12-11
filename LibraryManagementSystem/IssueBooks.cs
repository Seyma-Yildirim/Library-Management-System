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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }
        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SEYMA\SQLEXPRESS;Initial Catalog=LibraryManagment;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select bname from NewBook", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox1.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();

        }
        int count;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEnrollmentNo.Text != "")
            {
                string eid = txtEnrollmentNo.Text;
                SqlConnection con = new SqlConnection(@"Data Source=SEYMA\SQLEXPRESS;Initial Catalog=LibraryManagment;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Select*from AddStudent where enroll='" + eid + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtDep.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSem.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtCont.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtDep.Clear();
                    txtSem.Clear();
                    txtCont.Clear();
                    txtEmail.Clear();

                    MessageBox.Show("Invalid enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // code to count how many book has been issued on this enrollment
                SqlCommand cmd2 = new SqlCommand("Select count(std_enroll) from IssueBook where std_enroll='" + eid + "' and book_return_date is null", con);
                SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
                DataSet ds2 = new DataSet();
                da1.Fill(ds2);

                count = int.Parse(ds2.Tables[0].Rows[0][0].ToString());
            }


        }
        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if (comboBox1.SelectedIndex != -1 && count <= 2)
                {
                    string enroll = txtEnrollmentNo.Text;
                    string name = txtName.Text;
                    string dep = txtDep.Text;
                    string sem = txtSem.Text;
                    Int64 cont = Int64.Parse(txtCont.Text);
                    string email = txtEmail.Text;
                    string bookName = comboBox1.Text;
                    string bookIssueDate = dateTimePicker1.Text;
                    string eid = txtEnrollmentNo.Text;

                    SqlConnection con = new SqlConnection(@"Data Source=SEYMA\SQLEXPRESS;Initial Catalog=LibraryManagment;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into IssueBook(std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date) values('" + enroll + "','" + name + "','" + dep + "','" + sem + "','" + cont + "','" + email + "','" + bookName + "','" + bookIssueDate + "')", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    con.Close();
                    MessageBox.Show("Book Issued", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select Book or Maximum Number of Book has been issued.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnrollmentNo_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollmentNo.Text == "")
            {
                txtName.Clear();
                txtDep.Clear();
                txtSem.Clear();
                txtCont.Clear();
                txtEmail.Clear();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtEnrollmentNo.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }

    }
}
