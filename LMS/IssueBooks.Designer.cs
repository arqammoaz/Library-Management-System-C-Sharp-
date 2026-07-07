namespace LMS
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            panel4 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearchStd = new Button();
            txtEntrEnroll = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            label10 = new Label();
            btnIssueBook = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            txtStdEmail = new TextBox();
            txtStdCnt = new TextBox();
            txtStdSmes = new TextBox();
            txtDept = new TextBox();
            txtStdName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 121);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Sienna;
            panel4.Location = new Point(2, 119);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(658, 2);
            panel4.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(236, 121);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(240, 120);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(210, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 32);
            label1.TabIndex = 2;
            label1.Text = "Issue Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(274, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(58, 14);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 92);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnSearchStd);
            panel2.Controls.Add(txtEntrEnroll);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 121);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 402);
            panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Sienna;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(138, 287);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 36);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Sienna;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Transparent;
            btnRefresh.Location = new Point(10, 287);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 36);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearchStd
            // 
            btnSearchStd.BackColor = Color.Sienna;
            btnSearchStd.FlatStyle = FlatStyle.Popup;
            btnSearchStd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchStd.ForeColor = Color.Transparent;
            btnSearchStd.Location = new Point(50, 210);
            btnSearchStd.Margin = new Padding(2);
            btnSearchStd.Name = "btnSearchStd";
            btnSearchStd.Size = new Size(146, 39);
            btnSearchStd.TabIndex = 4;
            btnSearchStd.Text = "Search Student";
            btnSearchStd.UseVisualStyleBackColor = false;
            btnSearchStd.Click += btnSearchStd_Click;
            // 
            // txtEntrEnroll
            // 
            txtEntrEnroll.Location = new Point(30, 164);
            txtEntrEnroll.Margin = new Padding(2);
            txtEntrEnroll.Name = "txtEntrEnroll";
            txtEntrEnroll.Size = new Size(184, 27);
            txtEntrEnroll.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 130);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter Enrollment Number";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SeaShell;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(btnIssueBook);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(txtStdEmail);
            panel3.Controls.Add(txtStdCnt);
            panel3.Controls.Add(txtStdSmes);
            panel3.Controls.Add(txtDept);
            panel3.Controls.Add(txtStdName);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(236, 121);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(404, 400);
            panel3.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(50, 375);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(331, 20);
            label10.TabIndex = 14;
            label10.Text = "Maximum 3 Books can be issued to 1 Student";
            // 
            // btnIssueBook
            // 
            btnIssueBook.BackColor = Color.Sienna;
            btnIssueBook.FlatStyle = FlatStyle.Popup;
            btnIssueBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssueBook.ForeColor = Color.Transparent;
            btnIssueBook.Location = new Point(233, 326);
            btnIssueBook.Margin = new Padding(2);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(146, 39);
            btnIssueBook.TabIndex = 7;
            btnIssueBook.Text = "Issue Book";
            btnIssueBook.UseVisualStyleBackColor = false;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(162, 278);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(162, 230);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 28);
            comboBox1.TabIndex = 12;
            // 
            // txtStdEmail
            // 
            txtStdEmail.Location = new Point(162, 184);
            txtStdEmail.Margin = new Padding(2);
            txtStdEmail.Name = "txtStdEmail";
            txtStdEmail.Size = new Size(233, 27);
            txtStdEmail.TabIndex = 11;
            // 
            // txtStdCnt
            // 
            txtStdCnt.Location = new Point(162, 143);
            txtStdCnt.Margin = new Padding(2);
            txtStdCnt.Name = "txtStdCnt";
            txtStdCnt.Size = new Size(233, 27);
            txtStdCnt.TabIndex = 10;
            // 
            // txtStdSmes
            // 
            txtStdSmes.Location = new Point(162, 102);
            txtStdSmes.Margin = new Padding(2);
            txtStdSmes.Name = "txtStdSmes";
            txtStdSmes.Size = new Size(233, 27);
            txtStdSmes.TabIndex = 9;
            // 
            // txtDept
            // 
            txtDept.Location = new Point(162, 68);
            txtDept.Margin = new Padding(2);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(233, 27);
            txtDept.TabIndex = 8;
            // 
            // txtStdName
            // 
            txtStdName.Location = new Point(162, 30);
            txtStdName.Margin = new Padding(2);
            txtStdName.Name = "txtStdName";
            txtStdName.Size = new Size(233, 27);
            txtStdName.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.Location = new Point(22, 278);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 6;
            label9.Text = "Book Issue Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(22, 68);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 5;
            label8.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(22, 109);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 4;
            label7.Text = "Student Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(22, 150);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 20);
            label6.TabIndex = 3;
            label6.Text = "Student Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(22, 191);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 2;
            label5.Text = "Student Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(22, 236);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 1;
            label4.Text = "Books Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(22, 30);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 0;
            label3.Text = "Student Name";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 523);
            ControlBox = false;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "IssueBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IssueBooks";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btnSearchStd;
        private TextBox txtEntrEnroll;
        private Label label2;
        private Button btnExit;
        private Button btnRefresh;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnIssueBook;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox txtStdEmail;
        private TextBox txtStdCnt;
        private TextBox txtStdSmes;
        private TextBox txtDept;
        private TextBox txtStdName;
        private Label label9;
        private Label label10;
        private Panel panel4;
    }
}