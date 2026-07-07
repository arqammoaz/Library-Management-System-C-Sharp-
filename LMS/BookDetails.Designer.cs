namespace LMS
{
    partial class BookDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDetails));
            panel1 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Bookid = new DataGridViewTextBoxColumn();
            stu_id = new DataGridViewTextBoxColumn();
            stu_name = new DataGridViewTextBoxColumn();
            Stu_dep = new DataGridViewTextBoxColumn();
            Stu_smest = new DataGridViewTextBoxColumn();
            Book_Name = new DataGridViewTextBoxColumn();
            issueDate = new DataGridViewTextBoxColumn();
            returndate = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 138);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Sienna;
            panel5.Location = new Point(2, 136);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1321, 2);
            panel5.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(352, 49);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 38);
            label1.TabIndex = 3;
            label1.Text = "Book Details";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(552, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Bookid, stu_id, stu_name, Stu_dep, Stu_smest, Book_Name, issueDate, returndate });
            dataGridView1.Location = new Point(2, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1310, 301);
            dataGridView1.TabIndex = 3;
            // 
            // Bookid
            // 
            Bookid.DataPropertyName = "IssueId";
            Bookid.HeaderText = "Book ID";
            Bookid.MinimumWidth = 8;
            Bookid.Name = "Bookid";
            Bookid.Width = 150;
            // 
            // stu_id
            // 
            stu_id.DataPropertyName = "EnrollmentNo";
            stu_id.HeaderText = "Student ID";
            stu_id.MinimumWidth = 8;
            stu_id.Name = "stu_id";
            stu_id.Width = 150;
            // 
            // stu_name
            // 
            stu_name.DataPropertyName = "StudentName";
            stu_name.HeaderText = "Student Name";
            stu_name.MinimumWidth = 8;
            stu_name.Name = "stu_name";
            stu_name.Width = 220;
            // 
            // Stu_dep
            // 
            Stu_dep.DataPropertyName = "Department";
            Stu_dep.HeaderText = "Department";
            Stu_dep.MinimumWidth = 8;
            Stu_dep.Name = "Stu_dep";
            Stu_dep.Width = 140;
            // 
            // Stu_smest
            // 
            Stu_smest.DataPropertyName = "Semester";
            Stu_smest.HeaderText = "Semester";
            Stu_smest.MinimumWidth = 8;
            Stu_smest.Name = "Stu_smest";
            Stu_smest.Width = 90;
            // 
            // Book_Name
            // 
            Book_Name.DataPropertyName = "BookName";
            Book_Name.HeaderText = "Book Name";
            Book_Name.MinimumWidth = 8;
            Book_Name.Name = "Book_Name";
            Book_Name.Width = 155;
            // 
            // issueDate
            // 
            issueDate.DataPropertyName = "IssueDate";
            issueDate.HeaderText = "Issue Date";
            issueDate.MinimumWidth = 8;
            issueDate.Name = "issueDate";
            issueDate.Width = 170;
            // 
            // returndate
            // 
            returndate.DataPropertyName = "ReturnDate";
            returndate.HeaderText = "Return Date";
            returndate.MinimumWidth = 8;
            returndate.Name = "returndate";
            returndate.Width = 170;
            // 
            // BookDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1312, 486);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "BookDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookDetails";
            Load += BookDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Bookid;
        private DataGridViewTextBoxColumn stu_id;
        private DataGridViewTextBoxColumn stu_name;
        private DataGridViewTextBoxColumn Stu_dep;
        private DataGridViewTextBoxColumn Stu_smest;
        private DataGridViewTextBoxColumn Book_Name;
        private DataGridViewTextBoxColumn issueDate;
        private DataGridViewTextBoxColumn returndate;
    }
}