namespace University_Library_Management
{
    partial class UpdateStudent
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
            CurrentInfoLabel = new Label();
            CurrentTxtBox = new TextBox();
            PhoneNo = new RadioButton();
            Password = new RadioButton();
            StudentID = new RadioButton();
            UpdateTextBox = new Label();
            Submit = new Button();
            UpdateTxtBox = new TextBox();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // CurrentInfoLabel
            // 
            CurrentInfoLabel.AutoSize = true;
            CurrentInfoLabel.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentInfoLabel.ForeColor = Color.WhiteSmoke;
            CurrentInfoLabel.Location = new Point(173, 77);
            CurrentInfoLabel.Name = "CurrentInfoLabel";
            CurrentInfoLabel.Size = new Size(176, 36);
            CurrentInfoLabel.TabIndex = 42;
            CurrentInfoLabel.Text = "Current info";
            // 
            // CurrentTxtBox
            // 
            CurrentTxtBox.Location = new Point(375, 86);
            CurrentTxtBox.Name = "CurrentTxtBox";
            CurrentTxtBox.Size = new Size(125, 27);
            CurrentTxtBox.TabIndex = 41;
            // 
            // PhoneNo
            // 
            PhoneNo.AutoSize = true;
            PhoneNo.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNo.ForeColor = Color.Transparent;
            PhoneNo.Location = new Point(523, 235);
            PhoneNo.Name = "PhoneNo";
            PhoneNo.Size = new Size(104, 24);
            PhoneNo.TabIndex = 40;
            PhoneNo.TabStop = true;
            PhoneNo.Text = "PhoneNO";
            PhoneNo.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ForeColor = Color.Transparent;
            Password.Location = new Point(370, 235);
            Password.Name = "Password";
            Password.Size = new Size(99, 24);
            Password.TabIndex = 39;
            Password.TabStop = true;
            Password.Text = "Password";
            Password.UseVisualStyleBackColor = true;
            // 
            // StudentID
            // 
            StudentID.AutoSize = true;
            StudentID.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            StudentID.ForeColor = Color.Transparent;
            StudentID.Location = new Point(213, 235);
            StudentID.Name = "StudentID";
            StudentID.Size = new Size(103, 24);
            StudentID.TabIndex = 38;
            StudentID.TabStop = true;
            StudentID.Text = "StudentID";
            StudentID.UseVisualStyleBackColor = true;
            // 
            // UpdateTextBox
            // 
            UpdateTextBox.AutoSize = true;
            UpdateTextBox.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateTextBox.ForeColor = Color.WhiteSmoke;
            UpdateTextBox.Location = new Point(173, 146);
            UpdateTextBox.Name = "UpdateTextBox";
            UpdateTextBox.Size = new Size(173, 36);
            UpdateTextBox.TabIndex = 37;
            UpdateTextBox.Text = "Update info";
            // 
            // Submit
            // 
            Submit.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Submit.ForeColor = Color.Black;
            Submit.Location = new Point(264, 344);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 36;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // UpdateTxtBox
            // 
            UpdateTxtBox.Location = new Point(375, 155);
            UpdateTxtBox.Name = "UpdateTxtBox";
            UpdateTxtBox.Size = new Size(125, 27);
            UpdateTxtBox.TabIndex = 35;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.Black;
            ExitButton.Location = new Point(447, 344);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 43;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // UpdateStudent
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
            Controls.Add(StudentID);
            Controls.Add(UpdateTextBox);
            Controls.Add(Submit);
            Controls.Add(UpdateTxtBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CurrentInfoLabel;
        private TextBox CurrentTxtBox;
        private RadioButton PhoneNo;
        private RadioButton Password;
        private RadioButton StudentID;
        private Label UpdateTextBox;
        private Button Submit;
        private TextBox UpdateTxtBox;
        private Button ExitButton;
    }
}