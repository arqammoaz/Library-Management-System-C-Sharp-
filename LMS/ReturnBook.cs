using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LMS
{
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                string bookName = row.Cells["Book Name"].Value.ToString();

                // Parse issue date — clean format dd-MM-yyyy only
                string issueDate = "";
                if (DateTime.TryParse(row.Cells["Book Issue Date"].Value.ToString(), out DateTime parsedDate))
                    issueDate = parsedDate.ToString("dd-MM-yyyy");
                else
                    issueDate = row.Cells["Book Issue Date"].Value.ToString();

                txtBkName.Text = bookName;
                txtBkISSDate.Text = issueDate;
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEntEnroll.Text == "")
            {
                MessageBox.Show("Please enter Enrollment Number.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ClassDB myconnection = new ClassDB();
                myconnection.DBConnection();

                string q = @"SELECT BookName AS 'Book Name', 
                             CONVERT(VARCHAR(10), IssueDate, 105) AS 'Book Issue Date',
                             ISNULL(CONVERT(VARCHAR(10), ReturnDate, 105), 'Not Returned') AS 'Book Return Date',
                             Status AS 'Status'
                             FROM IssuedBooks 
                             WHERE EnrollmentNo = @enrollment
                             AND Status = 'Issued'
                             ORDER BY IssueDate DESC";
                SqlCommand cmd = new SqlCommand(q, ClassDB.con);
                cmd.Parameters.AddWithValue("@enrollment", txtEntEnroll.Text.Trim());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No issued books found for this student.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClassDB.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtBkName.Text = "";
            txtBkISSDate.Text = "";

            if (txtEntEnroll.Text != "")
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (txtEntEnroll.Text == "")
            {
                MessageBox.Show("Please search a student first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtBkName.Text == "")
            {
                MessageBox.Show("Please double click a book from the list to select it.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ClassDB myconnection = new ClassDB();
                myconnection.DBConnection();

                string q = @"UPDATE IssuedBooks 
                             SET Status = 'Returned',
                             ReturnDate = @returndate
                             WHERE EnrollmentNo = @enrollment 
                             AND BookName = @bookname 
                             AND Status = 'Issued'";
                SqlCommand cmd = new SqlCommand(q, ClassDB.con);

                cmd.Parameters.AddWithValue("@returndate", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@enrollment", txtEntEnroll.Text.Trim());
                cmd.Parameters.AddWithValue("@bookname", txtBkName.Text.Trim());

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    string q2 = "UPDATE Books SET BookQuantity = BookQuantity + 1 WHERE BookName = @bookname";
                    SqlCommand updateBook = new SqlCommand(q2, ClassDB.con);
                    updateBook.Parameters.AddWithValue("@bookname", txtBkName.Text.Trim());
                    updateBook.ExecuteNonQuery();

                    MessageBox.Show("Book returned successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtBkName.Text = "";
                    txtBkISSDate.Text = "";

                    btnSearch_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Return failed. Book may already be returned.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ClassDB.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEntEnroll.Text = "";
            txtBkName.Text = "";
            txtBkISSDate.Text = "";
            dataGridView1.DataSource = null;
            if (MessageBox.Show("This will delete your unsaved data", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            Dashboard d = new Dashboard();
            d.Show();
        }
    }
}