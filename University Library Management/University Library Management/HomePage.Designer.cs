namespace University_Library_Management
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            panel1 = new Panel();
            Login = new Button();
            Register = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            Logo = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(Login);
            panel1.Controls.Add(Register);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Logo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 817);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Login
            // 
            Login.ForeColor = Color.MidnightBlue;
            Login.Location = new Point(44, 543);
            Login.Name = "Login";
            Login.Size = new Size(125, 50);
            Login.TabIndex = 4;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Register
            // 
            Register.ForeColor = Color.MidnightBlue;
            Register.Location = new Point(44, 447);
            Register.Name = "Register";
            Register.Size = new Size(125, 46);
            Register.TabIndex = 3;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(323, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 224);
            label1.Name = "label1";
            label1.Size = new Size(215, 48);
            label1.TabIndex = 1;
            label1.Text = "Library Management \r\n       System";
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(12, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(206, 221);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 1;
            Logo.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1327, 817);
            Controls.Add(panel1);
            Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox Logo;
        private Label label1;
        private TextBox textBox1;
        private Button Register;
        private Button Login;
    }
}