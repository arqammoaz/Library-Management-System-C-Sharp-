namespace LMS
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            panel1 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            btnExit = new Button();
            BtnRefresh = new Button();
            btnSearch = new Button();
            txtEntEnroll = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            lblReturn = new Label();
            lblBookIssue = new Label();
            lblBookName = new Label();
            btnCancel = new Button();
            btnReturn = new Button();
            txtBkISSDate = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtBkName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
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
            panel1.Size = new Size(895, 110);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Sienna;
            panel5.Location = new Point(2, 109);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(913, 2);
            panel5.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(282, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 3;
            label1.Text = "Return Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(360, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(BtnRefresh);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtEntEnroll);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 110);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 376);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(237, 226);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(544, 120);
            panel3.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Sienna;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(126, 308);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(101, 38);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.BackColor = Color.Sienna;
            BtnRefresh.FlatStyle = FlatStyle.Popup;
            BtnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRefresh.ForeColor = Color.Transparent;
            BtnRefresh.Location = new Point(10, 308);
            BtnRefresh.Margin = new Padding(2);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(98, 38);
            BtnRefresh.TabIndex = 4;
            BtnRefresh.Text = "Refresh";
            BtnRefresh.UseVisualStyleBackColor = false;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Sienna;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Transparent;
            btnSearch.Location = new Point(56, 239);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 38);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Student";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtEntEnroll
            // 
            txtEntEnroll.Location = new Point(25, 195);
            txtEntEnroll.Margin = new Padding(2);
            txtEntEnroll.Name = "txtEntEnroll";
            txtEntEnroll.Size = new Size(184, 27);
            txtEntEnroll.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 154);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 1;
            label2.Text = "Enter Enrollment Number";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(55, 20);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 102);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(237, 110);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(658, 226);
            dataGridView1.TabIndex = 2;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SeaShell;
            panel4.Controls.Add(lblReturn);
            panel4.Controls.Add(lblBookIssue);
            panel4.Controls.Add(lblBookName);
            panel4.Controls.Add(btnCancel);
            panel4.Controls.Add(btnReturn);
            panel4.Controls.Add(txtBkISSDate);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(txtBkName);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(240, 339);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(655, 147);
            panel4.TabIndex = 3;
            // 
            // lblReturn
            // 
            lblReturn.AutoSize = true;
            lblReturn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblReturn.Location = new Point(50, 110);
            lblReturn.Margin = new Padding(2, 0, 2, 0);
            lblReturn.Name = "lblReturn";
            lblReturn.Size = new Size(130, 20);
            lblReturn.TabIndex = 10;
            lblReturn.Text = "Book Return Date";
            // 
            // lblBookIssue
            // 
            lblBookIssue.AutoSize = true;
            lblBookIssue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBookIssue.Location = new Point(59, 67);
            lblBookIssue.Margin = new Padding(2, 0, 2, 0);
            lblBookIssue.Name = "lblBookIssue";
            lblBookIssue.Size = new Size(117, 20);
            lblBookIssue.TabIndex = 9;
            lblBookIssue.Text = "Book Issue Date";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblBookName.Location = new Point(77, 29);
            lblBookName.Margin = new Padding(2, 0, 2, 0);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(89, 20);
            lblBookName.TabIndex = 8;
            lblBookName.Text = "Book Name";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Sienna;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Transparent;
            btnCancel.Location = new Point(484, 110);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.Sienna;
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.Transparent;
            btnReturn.Location = new Point(484, 65);
            btnReturn.Margin = new Padding(2);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(90, 27);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // txtBkISSDate
            // 
            txtBkISSDate.Location = new Point(198, 62);
            txtBkISSDate.Margin = new Padding(2);
            txtBkISSDate.Name = "txtBkISSDate";
            txtBkISSDate.Size = new Size(241, 27);
            txtBkISSDate.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(198, 106);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // txtBkName
            // 
            txtBkName.Location = new Point(198, 24);
            txtBkName.Margin = new Padding(2);
            txtBkName.Name = "txtBkName";
            txtBkName.Size = new Size(241, 27);
            txtBkName.TabIndex = 3;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(895, 486);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBook";
            Load += ReturnBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox txtEntEnroll;
        private Button btnSearch;
        private Button btnExit;
        private Button BtnRefresh;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel panel4;
        private DateTimePicker dateTimePicker1;
        private TextBox txtBkName;
        private Button btnCancel;
        private Button btnReturn;
        private TextBox txtBkISSDate;
        private Panel panel5;
        private Label lblReturn;
        private Label lblBookIssue;
        private Label lblBookName;
    }
}