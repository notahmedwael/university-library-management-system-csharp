namespace University_Library_Management
{
    partial class UpdateAdmin
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
            UpdateTextBox = new Label();
            Submit = new Button();
            UpdateTxtBox = new TextBox();
            AdminID = new RadioButton();
            Password = new RadioButton();
            PhoneNo = new RadioButton();
            CurrentTxtBox = new TextBox();
            CurrentInfoLabel = new Label();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // UpdateTextBox
            // 
            UpdateTextBox.AutoSize = true;
            UpdateTextBox.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateTextBox.ForeColor = Color.WhiteSmoke;
            UpdateTextBox.Location = new Point(148, 163);
            UpdateTextBox.Name = "UpdateTextBox";
            UpdateTextBox.Size = new Size(173, 36);
            UpdateTextBox.TabIndex = 29;
            UpdateTextBox.Text = "Update info";
            UpdateTextBox.Click += BookTitleLabel_Click;
            // 
            // Submit
            // 
            Submit.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Submit.ForeColor = Color.Black;
            Submit.Location = new Point(250, 379);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 28;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // UpdateTxtBox
            // 
            UpdateTxtBox.Location = new Point(350, 172);
            UpdateTxtBox.Name = "UpdateTxtBox";
            UpdateTxtBox.Size = new Size(125, 27);
            UpdateTxtBox.TabIndex = 27;
            UpdateTxtBox.TextChanged += UpdateTxtBox_TextChanged;
            // 
            // AdminID
            // 
            AdminID.AutoSize = true;
            AdminID.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AdminID.ForeColor = Color.Transparent;
            AdminID.Location = new Point(188, 252);
            AdminID.Name = "AdminID";
            AdminID.Size = new Size(96, 24);
            AdminID.TabIndex = 30;
            AdminID.TabStop = true;
            AdminID.Text = "AdminID";
            AdminID.UseVisualStyleBackColor = true;
            AdminID.CheckedChanged += AdminID_CheckedChanged;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = Color.Transparent;
            Password.Location = new Point(345, 252);
            Password.Name = "Password";
            Password.Size = new Size(99, 24);
            Password.TabIndex = 31;
            Password.TabStop = true;
            Password.Text = "Password";
            Password.UseVisualStyleBackColor = true;
            Password.CheckedChanged += Password_CheckedChanged;
            // 
            // PhoneNo
            // 
            PhoneNo.AutoSize = true;
            PhoneNo.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNo.ForeColor = Color.Transparent;
            PhoneNo.Location = new Point(498, 252);
            PhoneNo.Name = "PhoneNo";
            PhoneNo.Size = new Size(104, 24);
            PhoneNo.TabIndex = 32;
            PhoneNo.TabStop = true;
            PhoneNo.Text = "PhoneNO";
            PhoneNo.UseVisualStyleBackColor = true;
            PhoneNo.CheckedChanged += PhoneNo_CheckedChanged;
            // 
            // CurrentTxtBox
            // 
            CurrentTxtBox.Location = new Point(350, 103);
            CurrentTxtBox.Name = "CurrentTxtBox";
            CurrentTxtBox.Size = new Size(125, 27);
            CurrentTxtBox.TabIndex = 33;
            CurrentTxtBox.TextChanged += CurrentTxtBox_TextChanged;
            // 
            // CurrentInfoLabel
            // 
            CurrentInfoLabel.AutoSize = true;
            CurrentInfoLabel.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentInfoLabel.ForeColor = Color.WhiteSmoke;
            CurrentInfoLabel.Location = new Point(148, 94);
            CurrentInfoLabel.Name = "CurrentInfoLabel";
            CurrentInfoLabel.Size = new Size(176, 36);
            CurrentInfoLabel.TabIndex = 34;
            CurrentInfoLabel.Text = "Current info";
            CurrentInfoLabel.Click += CurrentInfoLabel_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.Black;
            ExitButton.Location = new Point(427, 379);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 35;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += button1_Click;
            // 
            // UpdateAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(CurrentInfoLabel);
            Controls.Add(CurrentTxtBox);
            Controls.Add(PhoneNo);
            Controls.Add(Password);
            Controls.Add(AdminID);
            Controls.Add(UpdateTextBox);
            Controls.Add(Submit);
            Controls.Add(UpdateTxtBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UpdateTextBox;
        private Button Submit;
        private TextBox UpdateTxtBox;
        private RadioButton AdminID;
        private RadioButton Password;
        private RadioButton PhoneNo;
        private TextBox CurrentTxtBox;
        private Label CurrentInfoLabel;
        private Button ExitButton;
    }
}