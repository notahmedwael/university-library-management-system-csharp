namespace University_Library_Management
{
    partial class DeleteBook
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
            BookTitleLabel = new Label();
            Delete = new Button();
            TitleTxtBox = new TextBox();
            SuspendLayout();
            // 
            // BookTitleLabel
            // 
            BookTitleLabel.AutoSize = true;
            BookTitleLabel.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BookTitleLabel.ForeColor = Color.WhiteSmoke;
            BookTitleLabel.Location = new Point(53, 82);
            BookTitleLabel.Name = "BookTitleLabel";
            BookTitleLabel.Size = new Size(152, 36);
            BookTitleLabel.TabIndex = 26;
            BookTitleLabel.Text = "Book Title";
            // 
            // Delete
            // 
            Delete.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Delete.ForeColor = Color.Black;
            Delete.Location = new Point(244, 177);
            Delete.Name = "Delete";
            Delete.Size = new Size(94, 29);
            Delete.TabIndex = 25;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // TitleTxtBox
            // 
            TitleTxtBox.Location = new Point(226, 91);
            TitleTxtBox.Name = "TitleTxtBox";
            TitleTxtBox.Size = new Size(125, 27);
            TitleTxtBox.TabIndex = 24;
            // 
            // DeleteBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(576, 285);
            Controls.Add(BookTitleLabel);
            Controls.Add(Delete);
            Controls.Add(TitleTxtBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BookTitleLabel;
        private Button Delete;
        private TextBox TitleTxtBox;
    }
}