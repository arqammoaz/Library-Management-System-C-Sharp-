namespace LMS
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnSave = new Button();
            btnRefresh = new Button();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtSemester = new TextBox();
            txtDepartment = new TextBox();
            txtEnrollment = new TextBox();
            txtName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 92);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(0, 93);
            panel4.Name = "panel4";
            panel4.Size = new Size(272, 397);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 32);
            label1.Name = "label1";
            label1.Size = new Size(148, 29);
            label1.TabIndex = 1;
            label1.Text = "AddStudent";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(246, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Bisque;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(271, 403);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            panel2.Location = new Point(272, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 403);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Sienna;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(366, 351);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(105, 29);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Sienna;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(212, 351);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save Info";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Sienna;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(72, 351);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 29);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(181, 292);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(290, 30);
            txtEmail.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(181, 243);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(290, 30);
            txtContact.TabIndex = 10;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(181, 187);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(290, 30);
            txtSemester.TabIndex = 9;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(181, 138);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(290, 30);
            txtDepartment.TabIndex = 8;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(181, 90);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(290, 30);
            txtEnrollment.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(181, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(290, 30);
            txtName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.Location = new Point(10, 294);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 5;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new Point(9, 245);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 4;
            label6.Text = "Student Contact ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.Location = new Point(10, 189);
            label5.Name = "label5";
            label5.Size = new Size(162, 25);
            label5.TabIndex = 3;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label4.Location = new Point(9, 140);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 2;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new Point(9, 89);
            label3.Name = "label3";
            label3.Size = new Size(135, 25);
            label3.TabIndex = 1;
            label3.Text = "Enrollment No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 42);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 493);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            Load += AddStudent_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnExit;
        private Button btnSave;
        private Button btnRefresh;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtSemester;
        private TextBox txtDepartment;
        private TextBox txtEnrollment;
        private TextBox txtName;
        private Panel panel3;
        private Panel panel4;
    }
}