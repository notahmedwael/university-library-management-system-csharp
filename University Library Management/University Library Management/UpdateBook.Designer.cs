namespace University_Library_Management
{
    partial class UpdateBook
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
            addTitle = new Label();
            addAuthor = new Label();
            addPrice = new Label();
            addPublicationYear = new Label();
            addQuantity = new Label();
            addCategory = new Label();
            Update = new Button();
            TitleTxtBox = new TextBox();
            AuthorTxtBox = new TextBox();
            PriceTxtBox = new TextBox();
            PublicationTxtBox = new TextBox();
            QuantityTxtBox = new TextBox();
            CategoryTxtBox = new TextBox();
            ISBNTxtBox = new TextBox();
            BookISBNTxtBox = new TextBox();
            BookISBNLabel = new Label();
            addISBN = new Label();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // addTitle
            // 
            addTitle.AutoSize = true;
            addTitle.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addTitle.ForeColor = Color.WhiteSmoke;
            addTitle.Location = new Point(222, 361);
            addTitle.Name = "addTitle";
            addTitle.Size = new Size(74, 36);
            addTitle.TabIndex = 38;
            addTitle.Text = "Title";
            addTitle.Click += addTitle_Click;
            // 
            // addAuthor
            // 
            addAuthor.AutoSize = true;
            addAuthor.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addAuthor.ForeColor = Color.WhiteSmoke;
            addAuthor.Location = new Point(391, 270);
            addAuthor.Name = "addAuthor";
            addAuthor.Size = new Size(107, 36);
            addAuthor.TabIndex = 37;
            addAuthor.Text = "Author";
            addAuthor.Click += addAuthor_Click;
            // 
            // addPrice
            // 
            addPrice.AutoSize = true;
            addPrice.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addPrice.ForeColor = Color.WhiteSmoke;
            addPrice.Location = new Point(391, 193);
            addPrice.Name = "addPrice";
            addPrice.Size = new Size(78, 36);
            addPrice.TabIndex = 36;
            addPrice.Text = "Price";
            addPrice.Click += addPrice_Click;
            // 
            // addPublicationYear
            // 
            addPublicationYear.AutoSize = true;
            addPublicationYear.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addPublicationYear.ForeColor = Color.WhiteSmoke;
            addPublicationYear.Location = new Point(370, 99);
            addPublicationYear.Name = "addPublicationYear";
            addPublicationYear.Size = new Size(161, 72);
            addPublicationYear.TabIndex = 35;
            addPublicationYear.Text = "Publication\r\n Year";
            addPublicationYear.Click += addPublicationYear_Click;
            // 
            // addQuantity
            // 
            addQuantity.AutoSize = true;
            addQuantity.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addQuantity.ForeColor = Color.WhiteSmoke;
            addQuantity.Location = new Point(78, 113);
            addQuantity.Name = "addQuantity";
            addQuantity.Size = new Size(132, 36);
            addQuantity.TabIndex = 34;
            addQuantity.Text = "Quantity";
            addQuantity.Click += addQuantity_Click;
            // 
            // addCategory
            // 
            addCategory.AutoSize = true;
            addCategory.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addCategory.ForeColor = Color.WhiteSmoke;
            addCategory.Location = new Point(61, 270);
            addCategory.Name = "addCategory";
            addCategory.Size = new Size(135, 36);
            addCategory.TabIndex = 32;
            addCategory.Text = "Category";
            addCategory.Click += addCategory_Click;
            // 
            // Update
            // 
            Update.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Update.ForeColor = Color.Black;
            Update.Location = new Point(668, 344);
            Update.Name = "Update";
            Update.Size = new Size(94, 29);
            Update.TabIndex = 31;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // TitleTxtBox
            // 
            TitleTxtBox.Location = new Point(345, 370);
            TitleTxtBox.Name = "TitleTxtBox";
            TitleTxtBox.Size = new Size(125, 27);
            TitleTxtBox.TabIndex = 30;
            TitleTxtBox.TextChanged += TitleTxtBox_TextChanged;
            // 
            // AuthorTxtBox
            // 
            AuthorTxtBox.Location = new Point(546, 280);
            AuthorTxtBox.Name = "AuthorTxtBox";
            AuthorTxtBox.Size = new Size(125, 27);
            AuthorTxtBox.TabIndex = 29;
            AuthorTxtBox.TextChanged += AuthorTxtBox_TextChanged;
            // 
            // PriceTxtBox
            // 
            PriceTxtBox.Location = new Point(546, 202);
            PriceTxtBox.Name = "PriceTxtBox";
            PriceTxtBox.Size = new Size(125, 27);
            PriceTxtBox.TabIndex = 28;
            PriceTxtBox.TextChanged += PriceTxtBox_TextChanged;
            // 
            // PublicationTxtBox
            // 
            PublicationTxtBox.Location = new Point(546, 123);
            PublicationTxtBox.Name = "PublicationTxtBox";
            PublicationTxtBox.Size = new Size(125, 27);
            PublicationTxtBox.TabIndex = 27;
            PublicationTxtBox.TextChanged += PublicationTxtBox_TextChanged;
            // 
            // QuantityTxtBox
            // 
            QuantityTxtBox.Location = new Point(202, 123);
            QuantityTxtBox.Name = "QuantityTxtBox";
            QuantityTxtBox.Size = new Size(125, 27);
            QuantityTxtBox.TabIndex = 26;
            QuantityTxtBox.TextChanged += QuantityTxtBox_TextChanged;
            // 
            // CategoryTxtBox
            // 
            CategoryTxtBox.Location = new Point(202, 280);
            CategoryTxtBox.Name = "CategoryTxtBox";
            CategoryTxtBox.Size = new Size(125, 27);
            CategoryTxtBox.TabIndex = 25;
            CategoryTxtBox.TextChanged += CategoryTxtBox_TextChanged;
            // 
            // ISBNTxtBox
            // 
            ISBNTxtBox.Location = new Point(202, 202);
            ISBNTxtBox.Name = "ISBNTxtBox";
            ISBNTxtBox.Size = new Size(125, 27);
            ISBNTxtBox.TabIndex = 24;
            ISBNTxtBox.TextChanged += ISBNTxtBox_TextChanged;
            // 
            // BookISBNTxtBox
            // 
            BookISBNTxtBox.Location = new Point(324, 37);
            BookISBNTxtBox.Name = "BookISBNTxtBox";
            BookISBNTxtBox.Size = new Size(125, 27);
            BookISBNTxtBox.TabIndex = 39;
            BookISBNTxtBox.TextChanged += textBox1_TextChanged;
            // 
            // BookISBNLabel
            // 
            BookISBNLabel.AutoSize = true;
            BookISBNLabel.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BookISBNLabel.ForeColor = Color.WhiteSmoke;
            BookISBNLabel.Location = new Point(146, 28);
            BookISBNLabel.Name = "BookISBNLabel";
            BookISBNLabel.Size = new Size(172, 36);
            BookISBNLabel.TabIndex = 40;
            BookISBNLabel.Text = "Book's ISBN";
            BookISBNLabel.Click += label1_Click;
            // 
            // addISBN
            // 
            addISBN.AutoSize = true;
            addISBN.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addISBN.ForeColor = Color.WhiteSmoke;
            addISBN.Location = new Point(78, 192);
            addISBN.Name = "addISBN";
            addISBN.Size = new Size(79, 36);
            addISBN.TabIndex = 33;
            addISBN.Text = "ISBN";
            addISBN.Click += addISBN_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.ForeColor = Color.Black;
            ExitButton.Location = new Point(668, 395);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 41;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // UpdateBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(BookISBNLabel);
            Controls.Add(BookISBNTxtBox);
            Controls.Add(addTitle);
            Controls.Add(addAuthor);
            Controls.Add(addPrice);
            Controls.Add(addPublicationYear);
            Controls.Add(addQuantity);
            Controls.Add(addISBN);
            Controls.Add(addCategory);
            Controls.Add(Update);
            Controls.Add(TitleTxtBox);
            Controls.Add(AuthorTxtBox);
            Controls.Add(PriceTxtBox);
            Controls.Add(PublicationTxtBox);
            Controls.Add(QuantityTxtBox);
            Controls.Add(CategoryTxtBox);
            Controls.Add(ISBNTxtBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addTitle;
        private Label addAuthor;
        private Label addPrice;
        private Label addPublicationYear;
        private Label addQuantity;
        private Label addCategory;
        private Button Update;
        private TextBox TitleTxtBox;
        private TextBox AuthorTxtBox;
        private TextBox PriceTxtBox;
        private TextBox PublicationTxtBox;
        private TextBox QuantityTxtBox;
        private TextBox CategoryTxtBox;
        private TextBox ISBNTxtBox;
        private TextBox BookISBNTxtBox;
        private Label BookISBNLabel;
        private Label addISBN;
        private Button ExitButton;
    }
}