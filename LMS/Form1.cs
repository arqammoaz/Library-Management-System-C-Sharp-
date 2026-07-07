using Microsoft.Data.SqlClient;
using System.Data;

namespace LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Clear();
            }
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Validate input
            if (txtUsername.Text == "" || txtUsername.Text == "Username")
            {
                MessageBox.Show("Please enter your username.");
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text == "" || txtPassword.Text == "Password")
            {
                MessageBox.Show("Please enter your password.");
                txtPassword.Focus();
                return;
            }

            // Connect to database
            ClassDB myconnection = new ClassDB();
            myconnection.DBConnection();

            // SqlCommand with constructor (query + connection passed directly)
            SqlCommand cmd = new SqlCommand("SELECT * FROM login WHERE Name=@name AND Pass=@pass", ClassDB.con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@name", txtUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                // Login successful
                Dashboard Admin = new Dashboard();
                Admin.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }

            dr.Close();
            ClassDB.con.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}