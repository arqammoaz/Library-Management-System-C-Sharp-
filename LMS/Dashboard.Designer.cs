namespace LMS
{
    partial class Dashboard
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
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBookToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentInfoToolStripMenuItem = new ToolStripMenuItem();
            issuesBooksToolStripMenuItem = new ToolStripMenuItem();
            returnBooksToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Bisque;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, studentsToolStripMenuItem, issuesBooksToolStripMenuItem, returnBooksToolStripMenuItem, cToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1274, 58);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBookToolStripMenuItem, viewBooksToolStripMenuItem });
            booksToolStripMenuItem.Image = Properties.Resources.icons8_books_50;
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(127, 54);
            booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBookToolStripMenuItem
            // 
            addNewBookToolStripMenuItem.Image = Properties.Resources.icons8_add_book_48;
            addNewBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            addNewBookToolStripMenuItem.Size = new Size(260, 60);
            addNewBookToolStripMenuItem.Text = "Add New Book";
            addNewBookToolStripMenuItem.Click += addNewBookToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Image = Properties.Resources.icons8_view_50;
            viewBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(260, 60);
            viewBooksToolStripMenuItem.Text = "View Books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.BackColor = Color.Transparent;
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentInfoToolStripMenuItem });
            studentsToolStripMenuItem.Image = Properties.Resources.icons8_student_male_50;
            studentsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(147, 54);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Image = Properties.Resources.icons8_add_user_male_50;
            addStudentToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(285, 60);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewStudentInfoToolStripMenuItem
            // 
            viewStudentInfoToolStripMenuItem.Image = Properties.Resources.icons8_view_501;
            viewStudentInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
            viewStudentInfoToolStripMenuItem.Size = new Size(285, 60);
            viewStudentInfoToolStripMenuItem.Text = "View Student Info ";
            viewStudentInfoToolStripMenuItem.Click += viewStudentInfoToolStripMenuItem_Click;
            // 
            // issuesBooksToolStripMenuItem
            // 
            issuesBooksToolStripMenuItem.Image = Properties.Resources.icons8_book_philosophy_50;
            issuesBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issuesBooksToolStripMenuItem.Name = "issuesBooksToolStripMenuItem";
            issuesBooksToolStripMenuItem.Size = new Size(180, 54);
            issuesBooksToolStripMenuItem.Text = "Issues Books";
            issuesBooksToolStripMenuItem.Click += issuesBooksToolStripMenuItem_Click;
            // 
            // returnBooksToolStripMenuItem
            // 
            returnBooksToolStripMenuItem.BackColor = Color.Transparent;
            returnBooksToolStripMenuItem.Image = Properties.Resources.icons8_return_book_50;
            returnBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            returnBooksToolStripMenuItem.Name = "returnBooksToolStripMenuItem";
            returnBooksToolStripMenuItem.Size = new Size(183, 54);
            returnBooksToolStripMenuItem.Text = "Return Books";
            returnBooksToolStripMenuItem.Click += returnBooksToolStripMenuItem_Click;
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.Image = Properties.Resources.icons8_books_50;
            cToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(259, 54);
            cToolStripMenuItem.Text = "Complete Book Details";
            cToolStripMenuItem.Click += cToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.Transparent;
            exitToolStripMenuItem.Image = Properties.Resources.icons8_exit_sign_50;
            exitToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(105, 54);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 58);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1274, 1);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.books_library_shelves_138556_1920x1080;
            pictureBox1.Location = new Point(0, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1920, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1274, 752);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Dashboard";
            Text = "Library Management System";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBookToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentInfoToolStripMenuItem;
        private ToolStripMenuItem issuesBooksToolStripMenuItem;
        private ToolStripMenuItem returnBooksToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}