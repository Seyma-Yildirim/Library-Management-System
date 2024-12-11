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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=SEYMA\SQLEXPRESS;Initial Catalog=LibraryManagment;Integrated Security=True");
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBN.Text != "" && txtBAN.Text != "" && txtBPub.Text != "" && txtBPrice.Text != "" && txtBQ.Text != "" && txtBPrice.Text != "")
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into NewBook(bName,bAuthor,bPub,bPDate,bPrice,bQuantity) Values(@p1,@p2,@p3,@p4,@p5,@p6)", con);
                cmd.Parameters.AddWithValue("@p1", txtBN.Text);
                cmd.Parameters.AddWithValue("@p2", txtBAN.Text);
                cmd.Parameters.AddWithValue("@p3", txtBPub.Text);
                cmd.Parameters.AddWithValue("@p4", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@p5", Int64.Parse(txtBPrice.Text));
                cmd.Parameters.AddWithValue("@p6", Int64.Parse(txtBQ.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBN.Clear();
                txtBAN.Clear();
                txtBPub.Clear();
                txtBPrice.Clear();
                txtBQ.Clear();
                con.Close();

            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?This will delete your unsaved data.", "Are You Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
