namespace University_Library_Management
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            StudentRadio = new RadioButton();
            Logo = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            Register = new Button();
            Login = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            BackButton = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            Submit = new Button();
            UserIDLabel = new Label();
            PasswordLabel = new Label();
            PhoneNoLabel = new Label();
            UserIDTxtBox = new TextBox();
            PasswordTxtBox = new TextBox();
            PhoneNoTxtBox = new TextBox();
            AdminRadio = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // StudentRadio
            // 
            StudentRadio.AutoSize = true;
            StudentRadio.Font = new Font("Maiandra GD", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            StudentRadio.ForeColor = Color.WhiteSmoke;
            StudentRadio.Location = new Point(789, 501);
            StudentRadio.Name = "StudentRadio";
            StudentRadio.Size = new Size(127, 38);
            StudentRadio.TabIndex = 23;
            StudentRadio.TabStop = true;
            StudentRadio.Text = "Student";
            StudentRadio.UseVisualStyleBackColor = true;
            StudentRadio.CheckedChanged += StudentRadio_CheckedChanged;
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
            Logo.Click += Logo_Click;
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
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(323, 190);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
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
            Register.Click += Register_Click;
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
            panel1.Size = new Size(236, 754);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
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
            panel2.Size = new Size(236, 754);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // BackButton
            // 
            BackButton.BackgroundImageLayout = ImageLayout.None;
            BackButton.Font = new Font("Maiandra GD", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.ForeColor = Color.Black;
            BackButton.Location = new Point(44, 676);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(125, 50);
            BackButton.TabIndex = 15;
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
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(24, 224);
            label2.Name = "label2";
            label2.Size = new Size(215, 48);
            label2.TabIndex = 1;
            label2.Text = "Library Management \r\n       System";
            label2.Click += label2_Click;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Submit
            // 
            Submit.Font = new Font("Maiandra GD", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Submit.ForeColor = Color.Black;
            Submit.Location = new Point(890, 578);
            Submit.Name = "Submit";
            Submit.Size = new Size(125, 50);
            Submit.TabIndex = 15;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // UserIDLabel
            // 
            UserIDLabel.AutoSize = true;
            UserIDLabel.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UserIDLabel.ForeColor = Color.WhiteSmoke;
            UserIDLabel.Location = new Point(523, 205);
            UserIDLabel.Name = "UserIDLabel";
            UserIDLabel.Size = new Size(105, 36);
            UserIDLabel.TabIndex = 16;
            UserIDLabel.Text = "UserID";
            UserIDLabel.Click += UserIDLabel_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.WhiteSmoke;
            PasswordLabel.Location = new Point(514, 309);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(137, 36);
            PasswordLabel.TabIndex = 17;
            PasswordLabel.Text = "Password";
            PasswordLabel.Click += PasswordLabel_Click;
            // 
            // PhoneNoLabel
            // 
            PhoneNoLabel.AutoSize = true;
            PhoneNoLabel.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNoLabel.ForeColor = Color.WhiteSmoke;
            PhoneNoLabel.Location = new Point(503, 414);
            PhoneNoLabel.Name = "PhoneNoLabel";
            PhoneNoLabel.Size = new Size(158, 36);
            PhoneNoLabel.TabIndex = 18;
            PhoneNoLabel.Text = "Phone No ";
            PhoneNoLabel.Click += PhoneNoLabel_Click;
            // 
            // UserIDTxtBox
            // 
            UserIDTxtBox.Location = new Point(789, 214);
            UserIDTxtBox.Name = "UserIDTxtBox";
            UserIDTxtBox.Size = new Size(307, 27);
            UserIDTxtBox.TabIndex = 19;
            UserIDTxtBox.TextChanged += UserIDTxtBox_TextChanged;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new Point(789, 319);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(307, 27);
            PasswordTxtBox.TabIndex = 20;
            PasswordTxtBox.TextChanged += PasswordTxtBox_TextChanged;
            // 
            // PhoneNoTxtBox
            // 
            PhoneNoTxtBox.Location = new Point(789, 423);
            PhoneNoTxtBox.Name = "PhoneNoTxtBox";
            PhoneNoTxtBox.Size = new Size(307, 27);
            PhoneNoTxtBox.TabIndex = 21;
            PhoneNoTxtBox.TextChanged += PhoneNoTxtBox_TextChanged;
            // 
            // AdminRadio
            // 
            AdminRadio.AutoSize = true;
            AdminRadio.Font = new Font("Maiandra GD", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AdminRadio.ForeColor = Color.WhiteSmoke;
            AdminRadio.Location = new Point(978, 501);
            AdminRadio.Name = "AdminRadio";
            AdminRadio.Size = new Size(118, 38);
            AdminRadio.TabIndex = 22;
            AdminRadio.TabStop = true;
            AdminRadio.Text = "Admin";
            AdminRadio.UseVisualStyleBackColor = true;
            AdminRadio.CheckedChanged += AdminRadio_CheckedChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1506, 754);
            Controls.Add(StudentRadio);
            Controls.Add(AdminRadio);
            Controls.Add(PhoneNoTxtBox);
            Controls.Add(PasswordTxtBox);
            Controls.Add(UserIDTxtBox);
            Controls.Add(PhoneNoLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(UserIDLabel);
            Controls.Add(Submit);
            Controls.Add(panel1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            WindowState = FormWindowState.Maximized;
            Load += RegisterForm_Load;
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton StudentRadio;
        private PictureBox Logo;
        private Label label1;
        private TextBox textBox1;
        private Button Register;
        private Button Login;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Button Submit;
        private Label UserIDLabel;
        private Label PasswordLabel;
        private Label PhoneNoLabel;
        private TextBox UserIDTxtBox;
        private TextBox PasswordTxtBox;
        private TextBox PhoneNoTxtBox;
        private RadioButton AdminRadio;
        private Button BackButton;
    }
}