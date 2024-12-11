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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SEYMA\SQLEXPRESS;Initial Catalog=LibraryManagment;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtboxUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtboxUsername.Text == "Username")
            {
                txtboxUsername.Clear();
            }
        }

        private void txtboxPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtboxPassword.Text == "Password")
            {
                txtboxPassword.Clear();
            }
            txtboxPassword.PasswordChar = '*';

        }

        private void pictureBoxInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void pictureBoxLinkedln_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tr.linkedin.com/");
        }

        private void pictureBoxGithub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/");
        }

        private void pictureBoxTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/login?lang=tr");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("Select*from Login where username=@p1 and password=@p2", con);
            cmd.Parameters.AddWithValue("p1", txtboxUsername.Text);
            cmd.Parameters.AddWithValue("p2", txtboxPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                dashboard dsa = new dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Usename or Password is wrong.Please try again.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();


        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
        }
    }

}

