namespace University_Library_Management
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            StudentRadio = new RadioButton();
            AdminRadio = new RadioButton();
            UserIDLabel = new Label();
            PasswordTxtBox = new TextBox();
            UserIDTxtBox = new TextBox();
            PasswordLabel = new Label();
            Logo = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            Register = new Button();
            Login = new Button();
            panel2 = new Panel();
            BackButton = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            Submit = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // StudentRadio
            // 
            StudentRadio.AutoSize = true;
            StudentRadio.Font = new Font("Maiandra GD", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            StudentRadio.ForeColor = Color.WhiteSmoke;
            StudentRadio.Location = new Point(742, 398);
            StudentRadio.Name = "StudentRadio";
            StudentRadio.Size = new Size(127, 38);
            StudentRadio.TabIndex = 13;
            StudentRadio.TabStop = true;
            StudentRadio.Text = "Student";
            StudentRadio.UseVisualStyleBackColor = true;
            // 
            // AdminRadio
            // 
            AdminRadio.AutoSize = true;
            AdminRadio.Font = new Font("Maiandra GD", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AdminRadio.ForeColor = Color.WhiteSmoke;
            AdminRadio.Location = new Point(922, 398);
            AdminRadio.Name = "AdminRadio";
            AdminRadio.Size = new Size(118, 38);
            AdminRadio.TabIndex = 11;
            AdminRadio.TabStop = true;
            AdminRadio.Text = "Admin";
            AdminRadio.UseVisualStyleBackColor = true;
            // 
            // UserIDLabel
            // 
            UserIDLabel.AutoSize = true;
            UserIDLabel.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UserIDLabel.ForeColor = Color.WhiteSmoke;
            UserIDLabel.Location = new Point(528, 214);
            UserIDLabel.Name = "UserIDLabel";
            UserIDLabel.Size = new Size(105, 36);
            UserIDLabel.TabIndex = 5;
            UserIDLabel.Text = "UserID";
            UserIDLabel.Click += label3_Click;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new Point(733, 329);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(307, 27);
            PasswordTxtBox.TabIndex = 9;
            // 
            // UserIDTxtBox
            // 
            UserIDTxtBox.Location = new Point(733, 224);
            UserIDTxtBox.Name = "UserIDTxtBox";
            UserIDTxtBox.Size = new Size(307, 27);
            UserIDTxtBox.TabIndex = 8;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.WhiteSmoke;
            PasswordLabel.Location = new Point(508, 319);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(137, 36);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
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
            // textBox1
            // 
            textBox1.Location = new Point(323, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(BackButton);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 735);
            panel2.TabIndex = 5;
            // 
            // BackButton
            // 
            BackButton.BackgroundImageLayout = ImageLayout.None;
            BackButton.Font = new Font("Maiandra GD", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.ForeColor = Color.Black;
            BackButton.Location = new Point(44, 657);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(125, 50);
            BackButton.TabIndex = 14;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(323, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 224);
            label2.Name = "label2";
            label2.Size = new Size(215, 48);
            label2.TabIndex = 1;
            label2.Text = "Library Management \r\n       System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(Login);
            panel1.Controls.Add(Register);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Logo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 735);
            panel1.TabIndex = 1;
            // 
            // Submit
            // 
            Submit.BackgroundImageLayout = ImageLayout.None;
            Submit.Font = new Font("Maiandra GD", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Submit.ForeColor = Color.Black;
            Submit.Location = new Point(822, 527);
            Submit.Name = "Submit";
            Submit.Size = new Size(125, 50);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1500, 735);
            Controls.Add(StudentRadio);
            Controls.Add(AdminRadio);
            Controls.Add(PasswordTxtBox);
            Controls.Add(UserIDTxtBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UserIDLabel);
            Controls.Add(Submit);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            WindowState = FormWindowState.Maximized;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Login;
        private Button Register;
        private TextBox textBox1;
        private Label label1;
        private PictureBox Logo;
        private Panel panel2;
        private Button Submit;
        private TextBox textBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label UserIDLabel;
        private Label PasswordLabel;
        private TextBox UserIDTxtBox;
        private TextBox PasswordTxtBox;
        private RadioButton AdminRadio;
        private RadioButton StudentRadio;
        private Button BackButton;
    }
}