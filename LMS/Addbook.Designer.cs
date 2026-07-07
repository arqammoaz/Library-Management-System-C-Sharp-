namespace LMS
{
    partial class Addbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addbook));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            lblBookid = new Label();
            btnCancelBook = new Button();
            btnSaveBook = new Button();
            dtpBookDate = new DateTimePicker();
            txtBookQuantity = new TextBox();
            txtBookPrice = new TextBox();
            txtPublisher = new TextBox();
            txtAuthorName = new TextBox();
            txtBookName = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.motivation1;
            pictureBox1.Location = new Point(1, 80);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 417);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 82);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 38);
            label1.TabIndex = 3;
            label1.Text = "Add Books";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 12);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(300, 80);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 371);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(311, 80);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(489, 374);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 255, 192);
            panel4.Controls.Add(lblBookid);
            panel4.Controls.Add(btnCancelBook);
            panel4.Controls.Add(btnSaveBook);
            panel4.Controls.Add(dtpBookDate);
            panel4.Controls.Add(txtBookQuantity);
            panel4.Controls.Add(txtBookPrice);
            panel4.Controls.Add(txtPublisher);
            panel4.Controls.Add(txtAuthorName);
            panel4.Controls.Add(txtBookName);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(304, 80);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(574, 417);
            panel4.TabIndex = 2;
            // 
            // lblBookid
            // 
            lblBookid.AutoSize = true;
            lblBookid.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblBookid.Location = new Point(71, 24);
            lblBookid.Margin = new Padding(2, 0, 2, 0);
            lblBookid.Name = "lblBookid";
            lblBookid.Size = new Size(90, 29);
            lblBookid.TabIndex = 19;
            lblBookid.Text = "Book ID";
            // 
            // btnCancelBook
            // 
            btnCancelBook.FlatStyle = FlatStyle.Popup;
            btnCancelBook.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelBook.Location = new Point(424, 367);
            btnCancelBook.Margin = new Padding(2);
            btnCancelBook.Name = "btnCancelBook";
            btnCancelBook.Size = new Size(112, 40);
            btnCancelBook.TabIndex = 17;
            btnCancelBook.Text = "Cancel";
            btnCancelBook.UseVisualStyleBackColor = true;
            btnCancelBook.Click += btnCancelBook_Click;
            // 
            // btnSaveBook
            // 
            btnSaveBook.FlatStyle = FlatStyle.Popup;
            btnSaveBook.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveBook.Location = new Point(282, 367);
            btnSaveBook.Margin = new Padding(2);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(112, 40);
            btnSaveBook.TabIndex = 16;
            btnSaveBook.Text = "Save";
            btnSaveBook.UseVisualStyleBackColor = true;
            btnSaveBook.Click += btnSaveBook_Click;
            // 
            // dtpBookDate
            // 
            dtpBookDate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dtpBookDate.Location = new Point(262, 217);
            dtpBookDate.Margin = new Padding(2);
            dtpBookDate.Name = "dtpBookDate";
            dtpBookDate.Size = new Size(286, 37);
            dtpBookDate.TabIndex = 15;
            // 
            // txtBookQuantity
            // 
            txtBookQuantity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtBookQuantity.Location = new Point(262, 313);
            txtBookQuantity.Margin = new Padding(2);
            txtBookQuantity.Name = "txtBookQuantity";
            txtBookQuantity.Size = new Size(286, 37);
            txtBookQuantity.TabIndex = 14;
            // 
            // txtBookPrice
            // 
            txtBookPrice.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtBookPrice.Location = new Point(262, 265);
            txtBookPrice.Margin = new Padding(2);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Size = new Size(286, 37);
            txtBookPrice.TabIndex = 13;
            // 
            // txtPublisher
            // 
            txtPublisher.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtPublisher.Location = new Point(262, 170);
            txtPublisher.Margin = new Padding(2);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(286, 37);
            txtPublisher.TabIndex = 11;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtAuthorName.Location = new Point(262, 122);
            txtAuthorName.Margin = new Padding(2);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(286, 37);
            txtAuthorName.TabIndex = 10;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtBookName.Location = new Point(262, 74);
            txtBookName.Margin = new Padding(2);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(286, 37);
            txtBookName.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.Location = new Point(42, 321);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(156, 29);
            label7.TabIndex = 8;
            label7.Text = "Book Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.Location = new Point(42, 271);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 29);
            label6.TabIndex = 7;
            label6.Text = "Book Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.Location = new Point(42, 223);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(213, 29);
            label5.TabIndex = 6;
            label5.Text = "Book Purchase Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.Location = new Point(42, 174);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 29);
            label4.TabIndex = 5;
            label4.Text = "Book Publisher";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.Location = new Point(42, 125);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(205, 29);
            label3.TabIndex = 4;
            label3.Text = "Book Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.Location = new Point(42, 76);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 29);
            label2.TabIndex = 3;
            label2.Text = "Book Name";
            // 
            // Addbook
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 497);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            Name = "Addbook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Addbook";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpBookDate;
        private TextBox txtBookQuantity;
        private TextBox txtBookPrice;
        private TextBox txtPublisher;
        private TextBox txtAuthorName;
        private TextBox txtBookName;
        private Button btnCancelBook;
        private Button btnSaveBook;
        private Label lblBookid;
    }
}