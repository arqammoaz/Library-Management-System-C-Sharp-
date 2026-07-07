using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LMS
{
    internal class ClassDB
    {
        public static SqlConnection con = null;

        public void DBConnection()
        {
            try
            {
                con = new SqlConnection("Data Source=Arqam\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True;TrustServerCertificate=True");

                con.Open();

                if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
                {
                    MessageBox.Show("Fail to open database");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CloseConnection()
      {
            if (con != null && con.State == ConnectionState.Open)
           {
                con.Close();
            }
        }
    }
}