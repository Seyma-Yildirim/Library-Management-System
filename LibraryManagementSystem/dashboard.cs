using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentSystem
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook ab = new AddBook();
            ab.Show();

        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent adds = new AddStudent();
            adds.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks isb = new IssueBooks();
            isb.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooks rb = new ReturnBooks();
            rb.Show();
        }

        private void completeBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetail cbd = new CompleteBookDetail();
            cbd.Show();
        }

        private void viewStudentInformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudentInformation vsi = new ViewStudentInformation();
            vsi.Show();
        }
    }

}

