namespace University_Library_Management
{
    partial class StudentPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPanel));
            panel1 = new Panel();
            button1 = new Button();
            UpdateUser = new Button();
            SearchFilter = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(UpdateUser);
            panel1.Controls.Add(SearchFilter);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1292, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(236, 749);
            panel1.TabIndex = 25;
            // 
            // button1
            // 
            button1.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(68, 573);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 32;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateUser
            // 
            UpdateUser.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateUser.ForeColor = Color.Black;
            UpdateUser.Location = new Point(56, 461);
            UpdateUser.Name = "UpdateUser";
            UpdateUser.Size = new Size(116, 41);
            UpdateUser.TabIndex = 31;
            UpdateUser.Text = "Update User";
            UpdateUser.UseVisualStyleBackColor = true;
            UpdateUser.Click += UpdateUser_Click;
            // 
            // SearchFilter
            // 
            SearchFilter.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SearchFilter.Location = new Point(56, 358);
            SearchFilter.Name = "SearchFilter";
            SearchFilter.Size = new Size(116, 48);
            SearchFilter.TabIndex = 28;
            SearchFilter.Text = "Search Filter";
            SearchFilter.UseVisualStyleBackColor = true;
            SearchFilter.Click += SearchFilter_Click;
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
            // StudentPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1528, 749);
            Controls.Add(panel1);
            Name = "StudentPanel";
            Text = "StudentPanel";
            WindowState = FormWindowState.Maximized;
            Load += StudentPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button UpdateUser;
        private Button SearchFilter;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
    }
}