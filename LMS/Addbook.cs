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
    public partial class Addbook : Form
    {
        public Addbook()
        {
            InitializeComponent();
        }

        private void Addbook_Load(object sender, EventArgs e)
        {
            lblBookid.Text = GenerateBookId();
        }

        private string GenerateBookId()
        {
            try
            {
                ClassDB myconnection = new ClassDB();
                myconnection.DBConnection();

                string q = "SELECT COUNT(*) FROM Books";
                SqlCommand cmd = new SqlCommand(q, ClassDB.con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                ClassDB.con.Close();

                return "B" + (count + 1).ToString().PadLeft(3, '0');
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }





        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();

               // Dashboard d = new Dashboard();
               // d.Show();
            }
            
            
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == "" || txtBookName.Text == "Book Name")
            {
                MessageBox.Show("Please enter Book Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtAuthorName.Text == "" || txtAuthorName.Text == "Author Name")
            {
                MessageBox.Show("Please enter Author Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPublisher.Text == "" || txtPublisher.Text == "Publisher")
            {
                MessageBox.Show("Please enter Publisher.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtBookPrice.Text == "" || txtBookPrice.Text == "Price")
            {
                MessageBox.Show("Please enter Book Price.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtBookQuantity.Text == "" || txtBookQuantity.Text == "Quantity")
            {
                MessageBox.Show("Please enter Book Quantity.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Connect to database
                ClassDB myconnection = new ClassDB();
                myconnection.DBConnection();

                string q = @"INSERT INTO Books 
             (BookName, AuthorName, Publisher, BookPrice, BookQuantity, DateAdded) 
             VALUES 
             (@bookname, @authorname, @publisher, @bookprice, @bookquantity, @dateadded)";
                SqlCommand cmd = new SqlCommand(q, ClassDB.con);

                cmd.Parameters.AddWithValue("@bookname", txtBookName.Text.Trim());
                cmd.Parameters.AddWithValue("@authorname", txtAuthorName.Text.Trim());
                cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text.Trim());
                cmd.Parameters.AddWithValue("@bookprice", txtBookPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@bookquantity", txtBookQuantity.Text.Trim());
                cmd.Parameters.AddWithValue("@dateadded", dtpBookDate.Value.Date);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Book added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblBookid.Text = GenerateBookId();

                    // Clear all fields after saving
                    txtBookName.Clear();
                    txtAuthorName.Clear();
                    txtPublisher.Clear();
                    txtBookPrice.Clear();
                    txtBookQuantity.Clear();
                    dtpBookDate.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Failed to add book. Try again.", "Error",
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
    }
}
