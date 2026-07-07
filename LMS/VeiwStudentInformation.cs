using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LMS
{
    public partial class VeiwStudentInformation : Form
    {
        public VeiwStudentInformation()
        {
            InitializeComponent();
        }

        private void VeiwStudentInformation_Load(object sender, EventArgs e)
        {
            LoadAllStudents("");
        }

        private void LoadAllStudents(string searchEnrollment)
        {
            try
            {
                ClassDB myconnection = new ClassDB();
                myconnection.DBConnection();

                string q;
                if (searchEnrollment == "")
                {
                    q = "SELECT StudentID, Name, Enrollment, Department, Semester, Contact, Email FROM Students";
                }
                else
                {
                    q = "SELECT StudentID, Name, Enrollment, Department, Semester, Contact, Email FROM Students WHERE Enrollment LIKE @search";
                }

                SqlCommand cmd = new SqlCommand(q, ClassDB.con);
                if (searchEnrollment != "")
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchEnrollment + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                // ✅ Set column widths after DataSource is assigned
                dataGridView1.Columns["StudentID"].Width = 150;
                dataGridView1.Columns["Name"].Width = 250;
                dataGridView1.Columns["Enrollment"].Width = 220;
                dataGridView1.Columns["Department"].Width = 200;
                dataGridView1.Columns["Semester"].Width = 150;
                dataGridView1.Columns["Contact"].Width = 220;
                dataGridView1.Columns["Email"].Width = 280;

                ClassDB.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchEnrollment_TextChanged(object sender, EventArgs e)
        {
            LoadAllStudents(txtSearchEnrollment.Text.Trim());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtStudentName.Text = row.Cells["Name"].Value.ToString().Trim();
                txtEnrollment.Text = row.Cells["Enrollment"].Value.ToString().Trim();
                txtDept.Text = row.Cells["Department"].Value.ToString().Trim();
                txtSmes.Text = row.Cells["Semester"].Value.ToString().Trim();
                txtCnt.Text = row.Cells["Contact"].Value.ToString().Trim();
                txtEmail.Text = row.Cells["Email"].Value.ToString().Trim();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEnrollment.Text == "")
            {
                MessageBox.Show("Please select a student from the grid first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (ClassDB.con != null && ClassDB.con.State != System.Data.ConnectionState.Closed)
                    ClassDB.con.Close();

                ClassDB myconnection = new ClassDB();
                myconnection.DBConnection();

                SqlCommand cmd = new SqlCommand(@"UPDATE Students SET 
                                  Name       = @name,
                                  Department = @department,
                                  Semester   = @semester,
                                  Contact    = @contact,
                                  Email      = @email
                                  WHERE Enrollment = @enrollment", ClassDB.con);

                cmd.Parameters.AddWithValue("@name", txtStudentName.Text.Trim());
                cmd.Parameters.AddWithValue("@department", txtDept.Text.Trim());
                cmd.Parameters.AddWithValue("@semester", txtSmes.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", txtCnt.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@enrollment", txtEnrollment.Text.Trim());
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Student updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStudents("");
                    ClearTextBoxes();
                }

                ClassDB.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEnrollment.Text == "")
            {
                MessageBox.Show("Please select a student from the grid first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    if (ClassDB.con != null && ClassDB.con.State != System.Data.ConnectionState.Closed)
                        ClassDB.con.Close();

                    ClassDB myconnection = new ClassDB();
                    myconnection.DBConnection();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE Enrollment = @enrollment", ClassDB.con);
                    cmd.Parameters.AddWithValue("@enrollment", txtEnrollment.Text.Trim());

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Student deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllStudents("");
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("No student found with Enrollment: " + txtEnrollment.Text.Trim(), "Not Found",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    ClassDB.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete Error: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchEnrollment.Clear();
            ClearTextBoxes();
            LoadAllStudents("");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Cancel?", "Alert",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ClearTextBoxes()
        {
            txtStudentName.Clear();
            txtEnrollment.Clear();
            txtDept.Clear();
            txtSmes.Clear();
            txtCnt.Clear();
            txtEmail.Clear();
        }
    }
}