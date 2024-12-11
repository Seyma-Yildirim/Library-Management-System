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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "") 
            {
                SqlConnection con = new SqlConnection(@"Data Source=SEYMA\SQLEXPRESS;Initial Catalog=LibraryManagment;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Login(username,password) values('" + txtUsername.Text + "','" + txtPassword.Text + "')", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                MessageBox.Show("Registerion Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Please Fill Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

    }
}
