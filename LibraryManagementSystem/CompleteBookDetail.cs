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
    public partial class CompleteBookDetail : Form
    {
        public CompleteBookDetail()
        {
            InitializeComponent();
        }
        private void CompleteBookDetail_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=SEYMA\SQLEXPRESS;Initial Catalog=LibraryManagment;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select*from IssueBook where book_return_date is null", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            SqlCommand cmd2 = new SqlCommand("Select*from IssueBook where book_return_date is not null", con);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd2);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];
        }

    }
}
