namespace University_Library_Management
{
    partial class AddBook
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
            ISBNTxtBox = new TextBox();
            CategoryTxtBox = new TextBox();
            QuantityTxtBox = new TextBox();
            PublicationTxtBox = new TextBox();
            PriceTxtBox = new TextBox();
            AuthorTxtBox = new TextBox();
            TitleTxtBox = new TextBox();
            Add = new Button();
            addCategory = new Label();
            addISBN = new Label();
            addQuantity = new Label();
            addPublicationYear = new Label();
            addPrice = new Label();
            addAuthor = new Label();
            addTitle = new Label();
            SuspendLayout();
            // 
            // ISBNTxtBox
            // 
            ISBNTxtBox.Location = new Point(153, 182);
            ISBNTxtBox.Name = "ISBNTxtBox";
            ISBNTxtBox.Size = new Size(125, 27);
            ISBNTxtBox.TabIndex = 0;
            ISBNTxtBox.TextChanged += ISBNTxtBox_TextChanged;
            // 
            // CategoryTxtBox
            // 
            CategoryTxtBox.Location = new Point(153, 260);
            CategoryTxtBox.Name = "CategoryTxtBox";
            CategoryTxtBox.Size = new Size(125, 27);
            CategoryTxtBox.TabIndex = 1;
            CategoryTxtBox.TextChanged += CategoryTxtBox_TextChanged;
            // 
            // QuantityTxtBox
            // 
            QuantityTxtBox.Location = new Point(153, 103);
            QuantityTxtBox.Name = "QuantityTxtBox";
            QuantityTxtBox.Size = new Size(125, 27);
            QuantityTxtBox.TabIndex = 2;
            QuantityTxtBox.TextChanged += QuantityTxtBox_TextChanged;
            // 
            // PublicationTxtBox
            // 
            PublicationTxtBox.Location = new Point(497, 103);
            PublicationTxtBox.Name = "PublicationTxtBox";
            PublicationTxtBox.Size = new Size(125, 27);
            PublicationTxtBox.TabIndex = 3;
            PublicationTxtBox.TextChanged += PublicationTxtBox_TextChanged;
            // 
            // PriceTxtBox
            // 
            PriceTxtBox.Location = new Point(497, 182);
            PriceTxtBox.Name = "PriceTxtBox";
            PriceTxtBox.Size = new Size(125, 27);
            PriceTxtBox.TabIndex = 4;
            PriceTxtBox.TextChanged += PriceTxtBox_TextChanged;
            // 
            // AuthorTxtBox
            // 
            AuthorTxtBox.Location = new Point(497, 260);
            AuthorTxtBox.Name = "AuthorTxtBox";
            AuthorTxtBox.Size = new Size(125, 27);
            AuthorTxtBox.TabIndex = 5;
            AuthorTxtBox.TextChanged += AuthorTxtBox_TextChanged;
            // 
            // TitleTxtBox
            // 
            TitleTxtBox.Location = new Point(296, 350);
            TitleTxtBox.Name = "TitleTxtBox";
            TitleTxtBox.Size = new Size(125, 27);
            TitleTxtBox.TabIndex = 6;
            TitleTxtBox.TextChanged += TitleTxtBox_TextChanged;
            // 
            // Add
            // 
            Add.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Add.ForeColor = Color.Black;
            Add.Location = new Point(661, 368);
            Add.Name = "Add";
            Add.Size = new Size(94, 29);
            Add.TabIndex = 7;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // addCategory
            // 
            addCategory.AutoSize = true;
            addCategory.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addCategory.ForeColor = Color.WhiteSmoke;
            addCategory.Location = new Point(12, 250);
            addCategory.Name = "addCategory";
            addCategory.Size = new Size(135, 36);
            addCategory.TabIndex = 17;
            addCategory.Text = "Category";
            addCategory.Click += addCategory_Click;
            // 
            // addISBN
            // 
            addISBN.AutoSize = true;
            addISBN.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addISBN.ForeColor = Color.WhiteSmoke;
            addISBN.Location = new Point(29, 172);
            addISBN.Name = "addISBN";
            addISBN.Size = new Size(79, 36);
            addISBN.TabIndex = 18;
            addISBN.Text = "ISBN";
            addISBN.Click += addISBN_Click;
            // 
            // addQuantity
            // 
            addQuantity.AutoSize = true;
            addQuantity.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addQuantity.ForeColor = Color.WhiteSmoke;
            addQuantity.Location = new Point(29, 93);
            addQuantity.Name = "addQuantity";
            addQuantity.Size = new Size(132, 36);
            addQuantity.TabIndex = 19;
            addQuantity.Text = "Quantity";
            addQuantity.Click += addQuantity_Click;
            // 
            // addPublicationYear
            // 
            addPublicationYear.AutoSize = true;
            addPublicationYear.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addPublicationYear.ForeColor = Color.WhiteSmoke;
            addPublicationYear.Location = new Point(321, 79);
            addPublicationYear.Name = "addPublicationYear";
            addPublicationYear.Size = new Size(161, 72);
            addPublicationYear.TabIndex = 20;
            addPublicationYear.Text = "Publication\r\n Year";
            addPublicationYear.Click += addPublicationYear_Click;
            // 
            // addPrice
            // 
            addPrice.AutoSize = true;
            addPrice.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addPrice.ForeColor = Color.WhiteSmoke;
            addPrice.Location = new Point(342, 173);
            addPrice.Name = "addPrice";
            addPrice.Size = new Size(78, 36);
            addPrice.TabIndex = 21;
            addPrice.Text = "Price";
            addPrice.Click += addPrice_Click;
            // 
            // addAuthor
            // 
            addAuthor.AutoSize = true;
            addAuthor.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addAuthor.ForeColor = Color.WhiteSmoke;
            addAuthor.Location = new Point(342, 250);
            addAuthor.Name = "addAuthor";
            addAuthor.Size = new Size(107, 36);
            addAuthor.TabIndex = 22;
            addAuthor.Text = "Author";
            addAuthor.Click += addAuthor_Click;
            // 
            // addTitle
            // 
            addTitle.AutoSize = true;
            addTitle.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            addTitle.ForeColor = Color.WhiteSmoke;
            addTitle.Location = new Point(173, 341);
            addTitle.Name = "addTitle";
            addTitle.Size = new Size(74, 36);
            addTitle.TabIndex = 23;
            addTitle.Text = "Title";
            addTitle.Click += addTitle_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(800, 450);
            Controls.Add(addTitle);
            Controls.Add(addAuthor);
            Controls.Add(addPrice);
            Controls.Add(addPublicationYear);
            Controls.Add(addQuantity);
            Controls.Add(addISBN);
            Controls.Add(addCategory);
            Controls.Add(Add);
            Controls.Add(TitleTxtBox);
            Controls.Add(AuthorTxtBox);
            Controls.Add(PriceTxtBox);
            Controls.Add(PublicationTxtBox);
            Controls.Add(QuantityTxtBox);
            Controls.Add(CategoryTxtBox);
            Controls.Add(ISBNTxtBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            Load += AddBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ISBNTxtBox;
        private TextBox CategoryTxtBox;
        private TextBox QuantityTxtBox;
        private TextBox PublicationTxtBox;
        private TextBox PriceTxtBox;
        private TextBox AuthorTxtBox;
        private TextBox TitleTxtBox;
        private Button Add;
        private Label addCategory;
        private Label addISBN;
        private Label addQuantity;
        private Label addPublicationYear;
        private Label addPrice;
        private Label addAuthor;
        private Label addTitle;
    }
}