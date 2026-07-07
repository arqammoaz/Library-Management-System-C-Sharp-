using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMS
{
    public partial class BookDetails : Form
    {
        public BookDetails()
        {
            InitializeComponent();
        }

        private void BookDetails_Load(object sender, EventArgs e)
        {
            LoadBookDetails();
        }

        private void LoadBookDetails()
        {
            try
            {
                ClassDB myConnection = new ClassDB();
                myConnection.DBConnection();

                SqlCommand cmd = new SqlCommand("SELECT IssueId, EnrollmentNo, StudentName, Department, Semester, BookName, IssueDate, ReturnDate FROM IssuedBooks", ClassDB.con);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;

                ClassDB.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
                ClassDB.con.Close();
            }
        }
    }
}