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
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }


        private void IssueBooks_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            LoadBooksInComboBox();
            
        }

        // ✅ Fill comboBox1 with book names from Books table
        private void LoadBooksInComboBox()
        {
            try
            {
                ClassDB myconnection = new ClassDB();
                myconnection.DBConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = ClassDB.con;
                cmd.CommandText = "SELECT BookName FROM Books WHERE BookQuantity > 0";

                SqlDataReader dr = cmd.ExecuteReader();
                comboBox1.Items.Clear();

                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["BookName"].ToString());
                }

                dr.Close();
                ClassDB.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

     

        private void btnSearchStd_Click(object sender, EventArgs e)
        {
            if (txtEntrEnroll.Text == "")
            {
                MessageBox.Show("Please enter Enrollment Number.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ClassDB myconnection = new ClassDB();
                myconnection.DBConnection();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE Enrollment = @enrollment", ClassDB.con);
                cmd.Parameters.AddWithValue("@enrollment", txtEntrEnroll.Text.Trim());

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    txtStdName.Text = dr["Name"].ToString();   // Student Name
                    txtDept.Text = dr["Department"].ToString();         // Department
                    txtStdSmes.Text = dr["Semester"].ToString();       // Student Semester
                    txtStdCnt.Text = dr["Contact"].ToString();      // Contact
                    txtStdEmail.Text = dr["Email"].ToString();    // Email
                }
                else
                {
                    MessageBox.Show("Student not found! Please check Enrollment Number.", "Not Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Clear fields
                    txtStdName.Clear();
                    txtDept.Clear();
                    txtStdSmes.Clear();
                    txtStdCnt.Clear();
                    txtStdEmail.Clear();
                }

                dr.Close();
                ClassDB.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            LoadBooksInComboBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
            
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            if (txtEntrEnroll.Text == "")
            {
                MessageBox.Show("Please search a student first.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a book.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ClassDB myconnection = new ClassDB();
                myconnection.DBConnection();

                // Check how many books already issued to this student
                SqlCommand checkCmd = new SqlCommand();
                checkCmd.Connection = ClassDB.con;
                checkCmd.CommandText = "SELECT COUNT(*) FROM IssuedBooks WHERE EnrollmentNo = @enrollment AND Status = 'Issued'";
                checkCmd.Parameters.AddWithValue("@enrollment", txtEntrEnroll.Text.Trim());
                int issuedCount = (int)checkCmd.ExecuteScalar();

                if (issuedCount >= 3)
                {
                    MessageBox.Show("This student already has 3 books issued. Maximum limit reached!", "Limit Exceeded",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClassDB.con.Close();
                    return;
                }

                // Insert issued book record
                SqlCommand cmd = new SqlCommand(@"INSERT INTO IssuedBooks 
                                  (EnrollmentNo, StudentName, StudentEmail, StudentContact, 
                                   Semester, Department, BookName, IssueDate, Status)
                                  VALUES 
                                  (@enrollment, @studentname, @email, @contact,
                                   @semester, @department, @bookname, @issuedate, 'Issued')", ClassDB.con);

                cmd.Parameters.AddWithValue("@enrollment", txtEntrEnroll.Text.Trim());
                cmd.Parameters.AddWithValue("@studentname", txtStdName.Text.Trim());
                cmd.Parameters.AddWithValue("@department", txtDept.Text.Trim());
                cmd.Parameters.AddWithValue("@semester", txtStdSmes.Text.Trim());
                cmd.Parameters.AddWithValue("@Contact", txtStdCnt.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtStdEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@bookname", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@issuedate", dateTimePicker1.Value.Date);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    // Reduce book quantity by 1
                    SqlCommand updateBook = new SqlCommand("UPDATE Books SET BookQuantity = BookQuantity - 1 WHERE BookName = @bookname", ClassDB.con);
                    updateBook.Parameters.AddWithValue("@bookname", comboBox1.SelectedItem.ToString());
                    updateBook.ExecuteNonQuery();

                    MessageBox.Show("Book issued successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh
                    
                    LoadBooksInComboBox();
                    comboBox1.SelectedIndex = -1;
                }

                ClassDB.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
