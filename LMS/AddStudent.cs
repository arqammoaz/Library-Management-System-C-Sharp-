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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                this.Close();


            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollment.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            //txtEmail.Clear();

            txtEmail.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtName.Text == "Student Name")
            {
                MessageBox.Show("Please enter Student Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (txtEnrollment.Text == "" || txtEnrollment.Text == "Enrollment No")
            {
                MessageBox.Show("Please enter Enrollment Number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnrollment.Focus();
                return;
            }

            if (txtDepartment.Text == "" || txtDepartment.Text == "Department")
            {
                MessageBox.Show("Please enter Department.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDepartment.Focus();
                return;
            }

            if (txtSemester.Text == "" || txtSemester.Text == "Semester")
            {
                MessageBox.Show("Please enter Semester.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSemester.Focus();
                return;
            }

            if (txtContact.Text == "" || txtContact.Text == "Contact No")
            {
                MessageBox.Show("Please enter Contact Number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return;
            }

            if (txtEmail.Text == "" || txtEmail.Text == "Email")
            {
                MessageBox.Show("Please enter Email.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            try
            {
                // Connect to database
                ClassDB myconnection = new ClassDB();
                myconnection.DBConnection();

                string q = @"INSERT INTO Students 
             (Name, Enrollment, Department, Semester, Contact, Email, DateAdded) 
             VALUES 
             (@name, @enrollment, @department, @semester, @contact, @email, @dateadded)";
                SqlCommand cmd = new SqlCommand(q, ClassDB.con);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@enrollment", txtEnrollment.Text.Trim());
                cmd.Parameters.AddWithValue("@department", txtDepartment.Text.Trim());
                cmd.Parameters.AddWithValue("@semester", txtSemester.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@dateadded", DateTime.Now.Date);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Student added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear fields after saving
                    txtName.Clear();
                    txtEnrollment.Clear();
                    txtDepartment.Clear();
                    txtSemester.Clear();
                    txtContact.Clear();
                    txtEmail.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed to add student. Try again.", "Error",
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
    
        

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
