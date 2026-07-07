using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ,You want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Addbook abs = new Addbook();
            abs.Show();
            

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent ast = new AddStudent();
            ast.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeiwStudentInformation vsi = new VeiwStudentInformation();
            vsi.Show();
        }

        private void issuesBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueBooks ib = new IssueBooks();
            ib.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookDetails bd=new BookDetails();
            bd.Show();
        }
    }
}
