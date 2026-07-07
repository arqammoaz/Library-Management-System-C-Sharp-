namespace LMS
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtvbBookN = new TextBox();
            lblBookvbN = new Label();
            btnvbRefresh = new Button();
            dgvt = new DataGridView();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            btnvbDelete = new Button();
            btnvbCancel = new Button();
            btnvbUpdate = new Button();
            txtvbBookQuantity = new TextBox();
            txtvbBookPrice = new TextBox();
            txtvbBookPublication = new TextBox();
            txtvbBookAuthor = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvt).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(954, 110);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Sienna;
            panel5.Location = new Point(2, 109);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(957, 2);
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
            label1.Size = new Size(145, 32);
            label1.TabIndex = 3;
            label1.Text = "View Books";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(442, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtvbBookN
            // 
            txtvbBookN.Location = new Point(367, 124);
            txtvbBookN.Margin = new Padding(2);
            txtvbBookN.Name = "txtvbBookN";
            txtvbBookN.Size = new Size(168, 27);
            txtvbBookN.TabIndex = 2;
            // 
            // lblBookvbN
            // 
            lblBookvbN.AutoSize = true;
            lblBookvbN.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookvbN.Location = new Point(252, 125);
            lblBookvbN.Margin = new Padding(2, 0, 2, 0);
            lblBookvbN.Name = "lblBookvbN";
            lblBookvbN.Size = new Size(112, 25);
            lblBookvbN.TabIndex = 3;
            lblBookvbN.Text = "Book Name";
            // 
            // btnvbRefresh
            // 
            btnvbRefresh.BackColor = Color.Sienna;
            btnvbRefresh.FlatStyle = FlatStyle.Flat;
            btnvbRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnvbRefresh.ForeColor = Color.White;
            btnvbRefresh.Location = new Point(546, 122);
            btnvbRefresh.Margin = new Padding(2);
            btnvbRefresh.Name = "btnvbRefresh";
            btnvbRefresh.Size = new Size(90, 27);
            btnvbRefresh.TabIndex = 4;
            btnvbRefresh.Text = "Refresh";
            btnvbRefresh.UseVisualStyleBackColor = false;
            btnvbRefresh.Click += btnvbRefresh_Click;
            // 
            // dgvt
            // 
            dgvt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvt.Location = new Point(0, 162);
            dgvt.Margin = new Padding(2);
            dgvt.Name = "dgvt";
            dgvt.RowHeadersWidth = 62;
            dgvt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvt.Size = new Size(954, 160);
            dgvt.TabIndex = 5;
            dgvt.CellDoubleClick += dgvt_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(btnvbDelete);
            panel2.Controls.Add(btnvbCancel);
            panel2.Controls.Add(btnvbUpdate);
            panel2.Controls.Add(txtvbBookQuantity);
            panel2.Controls.Add(txtvbBookPrice);
            panel2.Controls.Add(txtvbBookPublication);
            panel2.Controls.Add(txtvbBookAuthor);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(2, 322);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(952, 199);
            panel2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(588, 33);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // btnvbDelete
            // 
            btnvbDelete.BackColor = Color.Sienna;
            btnvbDelete.FlatStyle = FlatStyle.Flat;
            btnvbDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnvbDelete.ForeColor = Color.White;
            btnvbDelete.Location = new Point(845, 89);
            btnvbDelete.Margin = new Padding(2);
            btnvbDelete.Name = "btnvbDelete";
            btnvbDelete.Size = new Size(90, 27);
            btnvbDelete.TabIndex = 14;
            btnvbDelete.Text = "Delete";
            btnvbDelete.UseVisualStyleBackColor = false;
            btnvbDelete.Click += btnvbDelete_Click;
            // 
            // btnvbCancel
            // 
            btnvbCancel.BackColor = Color.Sienna;
            btnvbCancel.FlatStyle = FlatStyle.Flat;
            btnvbCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnvbCancel.ForeColor = Color.White;
            btnvbCancel.Location = new Point(845, 145);
            btnvbCancel.Margin = new Padding(2);
            btnvbCancel.Name = "btnvbCancel";
            btnvbCancel.Size = new Size(90, 27);
            btnvbCancel.TabIndex = 13;
            btnvbCancel.Text = "Cancel";
            btnvbCancel.UseVisualStyleBackColor = false;
            btnvbCancel.Click += btnvbCancel_Click;
            // 
            // btnvbUpdate
            // 
            btnvbUpdate.BackColor = Color.Sienna;
            btnvbUpdate.FlatStyle = FlatStyle.Flat;
            btnvbUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnvbUpdate.ForeColor = Color.White;
            btnvbUpdate.Location = new Point(845, 30);
            btnvbUpdate.Margin = new Padding(2);
            btnvbUpdate.Name = "btnvbUpdate";
            btnvbUpdate.Size = new Size(90, 27);
            btnvbUpdate.TabIndex = 12;
            btnvbUpdate.Text = "Update";
            btnvbUpdate.UseVisualStyleBackColor = false;
            btnvbUpdate.Click += btnvbUpdate_Click;
            // 
            // txtvbBookQuantity
            // 
            txtvbBookQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            txtvbBookQuantity.Location = new Point(588, 146);
            txtvbBookQuantity.Margin = new Padding(2);
            txtvbBookQuantity.Name = "txtvbBookQuantity";
            txtvbBookQuantity.Size = new Size(233, 30);
            txtvbBookQuantity.TabIndex = 11;
            // 
            // txtvbBookPrice
            // 
            txtvbBookPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            txtvbBookPrice.Location = new Point(588, 86);
            txtvbBookPrice.Margin = new Padding(2);
            txtvbBookPrice.Name = "txtvbBookPrice";
            txtvbBookPrice.Size = new Size(233, 30);
            txtvbBookPrice.TabIndex = 10;
            // 
            // txtvbBookPublication
            // 
            txtvbBookPublication.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            txtvbBookPublication.Location = new Point(161, 144);
            txtvbBookPublication.Margin = new Padding(2);
            txtvbBookPublication.Name = "txtvbBookPublication";
            txtvbBookPublication.Size = new Size(233, 30);
            txtvbBookPublication.TabIndex = 8;
            // 
            // txtvbBookAuthor
            // 
            txtvbBookAuthor.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            txtvbBookAuthor.Location = new Point(161, 84);
            txtvbBookAuthor.Margin = new Padding(2);
            txtvbBookAuthor.Name = "txtvbBookAuthor";
            txtvbBookAuthor.Size = new Size(233, 30);
            txtvbBookAuthor.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            textBox1.Location = new Point(161, 30);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 30);
            textBox1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(422, 149);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 5;
            label7.Text = "Book Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(422, 89);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 4;
            label6.Text = "Book Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(422, 33);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 3;
            label5.Text = "Book Purcahse Date ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 148);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 2;
            label4.Text = "Book Publication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 88);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 1;
            label3.Text = "Book Author Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(954, 522);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(dgvt);
            Controls.Add(btnvbRefresh);
            Controls.Add(lblBookvbN);
            Controls.Add(txtvbBookN);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvt).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtvbBookN;
        private Label lblBookvbN;
        private Button btnvbRefresh;
        private DataGridView dgvt;
        private Panel panel2;
        private Button btnvbDelete;
        private Button btnvbCancel;
        private Button btnvbUpdate;
        private TextBox txtvbBookQuantity;
        private TextBox txtvbBookPrice;
        private TextBox txtvbBookPublication;
        private TextBox txtvbBookAuthor;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}