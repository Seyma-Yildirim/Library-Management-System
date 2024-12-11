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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSName.Clear();
            txtER.Clear();
            txtDep.Clear();
            txtSSem.Clear();
            txtSCont.Clear();

            txtEmail.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSName.Text != "" && txtER.Text != "" && txtDep.Text != "" && txtSSem.Text != "" && txtEmail.Text != "" && txtSCont.Text != "")
            {
                string name = txtSName.Text;
                string enroll = txtER.Text;
                string dep = txtDep.Text;
                string semester = txtSSem.Text;
                string email = txtEmail.Text;
                Int64 mobile = Int64.Parse(txtSCont.Text);

                SqlConnection con = new SqlConnection(@"Data Source=SEYMA\SQLEXPRESS;Initial Catalog=LibraryManagment;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into AddStudent(sname,enroll,dep,sem,contact,email) values('" + name + "','" + enroll + "','" + dep + "','" + semester + "','" + email + "','" + mobile + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill empty fields.", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
