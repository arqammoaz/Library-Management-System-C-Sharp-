using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMS
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;

            if (progressBar1.Value >= 100)
            {
                timer1.Stop();
                this.Hide();
                Form1 f = new Form1(); // replace MainForm with your actual main form name
                f.Show();
            }
        }
    }
}
