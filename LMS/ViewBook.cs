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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            LoadBooks("");
        }

        private void LoadBooks(string searchName)
        {
            try
            {
                ClassDB myconnection = new ClassDB();
                myconnection.DBConnection();

                string q;
                if (searchName == "")
                {
                    q = "SELECT BookId AS RawId, 'B' + RIGHT('000' + CAST(BookId AS VARCHAR), 3) AS BookId, BookName, AuthorName, Publisher, BookPrice, BookQuantity, DateAdded FROM Books";
                }
                else
                {
                    q = "SELECT BookId AS RawId, 'B' + RIGHT('000' + CAST(BookId AS VARCHAR), 3) AS BookId, BookName, AuthorName, Publisher, BookPrice, BookQuantity, DateAdded FROM Books WHERE BookName LIKE @bookname";
                }

                SqlCommand cmd = new SqlCommand(q, ClassDB.con);
                if (searchName != "")
                {
                    cmd.Parameters.AddWithValue("@bookname", "%" + searchName + "%");
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvt.DataSource = dt;
                dgvt.Columns["RawId"].Visible = false;

                ClassDB.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvt.Rows[e.RowIndex];

                // ✅ FIX: textBox1 is the Book Name edit field in the bottom panel
                //         txtvbBookN is the SEARCH box at the top — do NOT use it here
                textBox1.Text = row.Cells["BookName"].Value.ToString();
                txtvbBookAuthor.Text = row.Cells["AuthorName"].Value.ToString();
                txtvbBookPublication.Text = row.Cells["Publisher"].Value.ToString();
                txtvbBookPrice.Text = row.Cells["BookPrice"].Value.ToString();
                txtvbBookQuantity.Text = row.Cells["BookQuantity"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["DateAdded"].Value);
            }
        }

        // Search box TextChanged — live search as user types
        private void txtvbBookN_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(txtvbBookN.Text.Trim());
        }

        private void btnvbRefresh_Click(object sender, EventArgs e)
        {
            LoadBooks("");
            txtvbBookN.Clear();          // clear search box
            textBox1.Clear();            // ✅ FIX: clear Book Name edit box (was txtvbBookN before)
            txtvbBookAuthor.Clear();
            txtvbBookPublication.Clear();
            txtvbBookPrice.Clear();
            txtvbBookQuantity.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnvbCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data", "Are you Sure?",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                
            }
        }

        private void btnvbUpdate_Click(object sender, EventArgs e)
        {
            if (dgvt.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to update.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ FIX: validate textBox1 (Book Name edit box), not txtvbBookN (search box)
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Book Name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedBookId = Convert.ToInt32(dgvt.SelectedRows[0].Cells["RawId"].Value);

                ClassDB myconnection = new ClassDB();
                myconnection.DBConnection();

                string q = "UPDATE Books SET BookName = @bookname, AuthorName = @authorname, " +
                           "Publisher = @publisher, BookPrice = @bookprice, " +
                           "BookQuantity = @bookquantity, DateAdded = @dateadded " +
                           "WHERE BookId = @bookid";

                SqlCommand cmd = new SqlCommand(q, ClassDB.con);

                // ✅ FIX: read Book Name from textBox1, not txtvbBookN
                cmd.Parameters.AddWithValue("@bookname", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@authorname", txtvbBookAuthor.Text.Trim());
                cmd.Parameters.AddWithValue("@publisher", txtvbBookPublication.Text.Trim());
                cmd.Parameters.AddWithValue("@bookprice", txtvbBookPrice.Text.Trim());
                cmd.Parameters.AddWithValue("@bookquantity", txtvbBookQuantity.Text.Trim());
                cmd.Parameters.AddWithValue("@dateadded", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@bookid", selectedBookId);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Book updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadBooks("");

                    // Re-select the same row after reload
                    foreach (DataGridViewRow r in dgvt.Rows)
                    {
                        if (r.Cells["RawId"].Value != null &&
                            Convert.ToInt32(r.Cells["RawId"].Value) == selectedBookId)
                        {
                            dgvt.ClearSelection();
                            r.Selected = true;
                            dgvt.FirstDisplayedScrollingRowIndex = r.Index;
                            break;
                        }
                    }

                    // Clear all edit fields
                    textBox1.Clear();
                    txtvbBookAuthor.Clear();
                    txtvbBookPublication.Clear();
                    txtvbBookPrice.Clear();
                    txtvbBookQuantity.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Failed to update book. Try again.", "Error",
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

        private void btnvbDelete_Click(object sender, EventArgs e)
        {
            if (dgvt.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this book?", "Are you Sure?",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    ClassDB myconnection = new ClassDB();
                    myconnection.DBConnection();

                    string q = "DELETE FROM Books WHERE BookId = @bookid";
                    SqlCommand cmd = new SqlCommand(q, ClassDB.con);
                    cmd.Parameters.AddWithValue("@bookid", dgvt.SelectedRows[0].Cells["RawId"].Value);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Book deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadBooks("");
                        textBox1.Clear();
                        txtvbBookAuthor.Clear();
                        txtvbBookPublication.Clear();
                        txtvbBookPrice.Clear();
                        txtvbBookQuantity.Clear();
                        dateTimePicker1.Value = DateTime.Now;
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete book. Try again.", "Error",
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
}