namespace University_Library_Management
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            AddBook = new Button();
            panel1 = new Panel();
            UpdateUser = new Button();
            LogoutButton = new Button();
            RefreshButton = new Button();
            SearchFilter = new Button();
            DeleteBook = new Button();
            UpdateBook = new Button();
            StatsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 254);
            label2.Name = "label2";
            label2.Size = new Size(215, 48);
            label2.TabIndex = 1;
            label2.Text = "Library Management \r\n       System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AddBook
            // 
            AddBook.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddBook.Location = new Point(59, 324);
            AddBook.Name = "AddBook";
            AddBook.Size = new Size(113, 40);
            AddBook.TabIndex = 25;
            AddBook.Text = "Add book";
            AddBook.UseVisualStyleBackColor = true;
            AddBook.Click += AddBook_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(StatsButton);
            panel1.Controls.Add(UpdateUser);
            panel1.Controls.Add(LogoutButton);
            panel1.Controls.Add(RefreshButton);
            panel1.Controls.Add(SearchFilter);
            panel1.Controls.Add(DeleteBook);
            panel1.Controls.Add(UpdateBook);
            panel1.Controls.Add(AddBook);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1310, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(236, 747);
            panel1.TabIndex = 24;
            // 
            // UpdateUser
            // 
            UpdateUser.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateUser.ForeColor = Color.Black;
            UpdateUser.Location = new Point(56, 550);
            UpdateUser.Name = "UpdateUser";
            UpdateUser.Size = new Size(116, 41);
            UpdateUser.TabIndex = 31;
            UpdateUser.Text = "Update User";
            UpdateUser.UseVisualStyleBackColor = true;
            UpdateUser.Click += UpdateUser_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutButton.Location = new Point(78, 706);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(94, 29);
            LogoutButton.TabIndex = 30;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            RefreshButton.Location = new Point(9, 629);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(94, 29);
            RefreshButton.TabIndex = 29;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += button4_Click;
            // 
            // SearchFilter
            // 
            SearchFilter.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SearchFilter.Location = new Point(56, 477);
            SearchFilter.Name = "SearchFilter";
            SearchFilter.Size = new Size(116, 48);
            SearchFilter.TabIndex = 28;
            SearchFilter.Text = "Search Filter";
            SearchFilter.UseVisualStyleBackColor = true;
            SearchFilter.Click += SearchFilter_Click;
            // 
            // DeleteBook
            // 
            DeleteBook.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBook.Location = new Point(56, 428);
            DeleteBook.Name = "DeleteBook";
            DeleteBook.Size = new Size(119, 31);
            DeleteBook.TabIndex = 27;
            DeleteBook.Text = "Delete Book";
            DeleteBook.UseVisualStyleBackColor = true;
            DeleteBook.Click += DeleteBook_Click;
            // 
            // UpdateBook
            // 
            UpdateBook.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateBook.ForeColor = Color.Black;
            UpdateBook.Location = new Point(56, 370);
            UpdateBook.Name = "UpdateBook";
            UpdateBook.Size = new Size(116, 41);
            UpdateBook.TabIndex = 26;
            UpdateBook.Text = "Update Book";
            UpdateBook.UseVisualStyleBackColor = true;
            UpdateBook.Click += UpdateBook_Click;
            // 
            // StatsButton
            // 
            StatsButton.Location = new Point(109, 629);
            StatsButton.Name = "StatsButton";
            StatsButton.Size = new Size(103, 29);
            StatsButton.TabIndex = 32;
            StatsButton.Text = "Stats";
            StatsButton.UseVisualStyleBackColor = true;
            StatsButton.Click += StatsButton_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1546, 747);
            Controls.Add(panel1);
            Name = "AdminPanel";
            Text = "AdminPanel";
            WindowState = FormWindowState.Maximized;
            Load += AdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private PictureBox pictureBox1;
        private Button AddBook;
        private DataGridView dataGridView2;
        private Panel panel1;
        private Button LogoutButton;
        private Button RefreshButton;
        private Button SearchFilter;
        private Button DeleteBook;
        private Button UpdateBook;
        private Button UpdateUser;
        private Button StatsButton;
    }
}