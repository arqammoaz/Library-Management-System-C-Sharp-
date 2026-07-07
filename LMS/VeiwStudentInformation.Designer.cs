namespace LMS
{
    partial class VeiwStudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeiwStudentInformation));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtSearchEnrollment = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtEmail = new TextBox();
            txtCnt = new TextBox();
            txtSmes = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtDept = new TextBox();
            txtEnrollment = new TextBox();
            txtStudentName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1228, 131);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(701, 66);
            label2.Name = "label2";
            label2.Size = new Size(98, 31);
            label2.TabIndex = 2;
            label2.Text = "Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(701, 30);
            label1.Name = "label1";
            label1.Size = new Size(65, 31);
            label1.TabIndex = 1;
            label1.Text = "Veiw";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(456, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(369, 163);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 1;
            label3.Text = "Enrollment No:";
            // 
            // txtSearchEnrollment
            // 
            txtSearchEnrollment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchEnrollment.Location = new Point(530, 162);
            txtSearchEnrollment.Name = "txtSearchEnrollment";
            txtSearchEnrollment.Size = new Size(162, 30);
            txtSearchEnrollment.TabIndex = 2;
            txtSearchEnrollment.TextChanged += txtSearchEnrollment_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Sienna;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(722, 163);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 203);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1218, 194);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtCnt);
            panel2.Controls.Add(txtSmes);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtDept);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtStudentName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 403);
            panel2.Name = "panel2";
            panel2.Size = new Size(1218, 228);
            panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Sienna;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(1055, 150);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(102, 38);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Sienna;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(1055, 83);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 38);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Sienna;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1055, 16);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(102, 38);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F);
            txtEmail.Location = new Point(738, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 30);
            txtEmail.TabIndex = 11;
            // 
            // txtCnt
            // 
            txtCnt.Font = new Font("Segoe UI", 10.2F);
            txtCnt.Location = new Point(738, 81);
            txtCnt.Name = "txtCnt";
            txtCnt.Size = new Size(246, 30);
            txtCnt.TabIndex = 10;
            // 
            // txtSmes
            // 
            txtSmes.Font = new Font("Segoe UI", 10.2F);
            txtSmes.Location = new Point(738, 28);
            txtSmes.Name = "txtSmes";
            txtSmes.Size = new Size(246, 30);
            txtSmes.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.Location = new Point(541, 133);
            label9.Name = "label9";
            label9.Size = new Size(130, 25);
            label9.TabIndex = 8;
            label9.Text = "Student Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.Location = new Point(541, 83);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 7;
            label8.Text = "Student Contact";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(541, 30);
            label7.Name = "label7";
            label7.Size = new Size(162, 25);
            label7.TabIndex = 6;
            label7.Text = "Student Semester";
            // 
            // txtDept
            // 
            txtDept.Font = new Font("Segoe UI", 10.2F);
            txtDept.Location = new Point(241, 127);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(246, 30);
            txtDept.TabIndex = 5;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Font = new Font("Segoe UI", 10.2F);
            txtEnrollment.Location = new Point(241, 77);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(246, 30);
            txtEnrollment.TabIndex = 4;
            // 
            // txtStudentName
            // 
            txtStudentName.Font = new Font("Segoe UI", 10.2F);
            txtStudentName.Location = new Point(241, 24);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(246, 30);
            txtStudentName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(60, 133);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 2;
            label6.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(60, 83);
            label5.Name = "label5";
            label5.Size = new Size(135, 25);
            label5.TabIndex = 1;
            label5.Text = "Enrollment No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(60, 30);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 0;
            label4.Text = "Student Name";
            // 
            // VeiwStudentInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Bisque;
            ClientSize = new Size(1242, 633);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearchEnrollment);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "VeiwStudentInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VeiwStudentInformation";
            Load += VeiwStudentInformation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtSearchEnrollment;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtEmail;
        private TextBox txtCnt;
        private TextBox txtSmes;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtDept;
        private TextBox txtEnrollment;
        private TextBox txtStudentName;
    }
}