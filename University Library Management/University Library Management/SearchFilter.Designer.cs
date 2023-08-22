namespace University_Library_Management
{
    partial class SearchFilter
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
            PriceRadio = new RadioButton();
            AuthorRadio = new RadioButton();
            CategoryRadio = new RadioButton();
            SearchLabel = new Label();
            SearchButton = new Button();
            ISBNRadio = new RadioButton();
            PublicationRadio = new RadioButton();
            QuantityRadio = new RadioButton();
            TitleRadio = new RadioButton();
            SearchTxtBox = new TextBox();
            dataGridView1 = new DataGridView();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PriceRadio
            // 
            PriceRadio.AutoSize = true;
            PriceRadio.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PriceRadio.ForeColor = Color.Transparent;
            PriceRadio.Location = new Point(40, 504);
            PriceRadio.Name = "PriceRadio";
            PriceRadio.Size = new Size(64, 24);
            PriceRadio.TabIndex = 40;
            PriceRadio.TabStop = true;
            PriceRadio.Text = "Price";
            PriceRadio.UseVisualStyleBackColor = true;
            // 
            // AuthorRadio
            // 
            AuthorRadio.AutoSize = true;
            AuthorRadio.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AuthorRadio.ForeColor = Color.Transparent;
            AuthorRadio.Location = new Point(40, 410);
            AuthorRadio.Name = "AuthorRadio";
            AuthorRadio.Size = new Size(81, 24);
            AuthorRadio.TabIndex = 39;
            AuthorRadio.TabStop = true;
            AuthorRadio.Text = "Author";
            AuthorRadio.UseVisualStyleBackColor = true;
            // 
            // CategoryRadio
            // 
            CategoryRadio.AutoSize = true;
            CategoryRadio.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryRadio.ForeColor = Color.Transparent;
            CategoryRadio.Location = new Point(40, 308);
            CategoryRadio.Name = "CategoryRadio";
            CategoryRadio.Size = new Size(97, 24);
            CategoryRadio.TabIndex = 38;
            CategoryRadio.TabStop = true;
            CategoryRadio.Text = "Category";
            CategoryRadio.UseVisualStyleBackColor = true;
            // 
            // SearchLabel
            // 
            SearchLabel.AutoSize = true;
            SearchLabel.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SearchLabel.ForeColor = Color.WhiteSmoke;
            SearchLabel.Location = new Point(40, 59);
            SearchLabel.Name = "SearchLabel";
            SearchLabel.Size = new Size(142, 36);
            SearchLabel.TabIndex = 37;
            SearchLabel.Text = "Search By";
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.ForeColor = Color.Black;
            SearchButton.Location = new Point(258, 130);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 36;
            SearchButton.Text = "GO";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // ISBNRadio
            // 
            ISBNRadio.AutoSize = true;
            ISBNRadio.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ISBNRadio.ForeColor = Color.Transparent;
            ISBNRadio.Location = new Point(40, 361);
            ISBNRadio.Name = "ISBNRadio";
            ISBNRadio.Size = new Size(66, 24);
            ISBNRadio.TabIndex = 43;
            ISBNRadio.TabStop = true;
            ISBNRadio.Text = "ISBN";
            ISBNRadio.UseVisualStyleBackColor = true;
            // 
            // PublicationRadio
            // 
            PublicationRadio.AutoSize = true;
            PublicationRadio.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PublicationRadio.ForeColor = Color.Transparent;
            PublicationRadio.Location = new Point(40, 255);
            PublicationRadio.Name = "PublicationRadio";
            PublicationRadio.Size = new Size(151, 24);
            PublicationRadio.TabIndex = 42;
            PublicationRadio.TabStop = true;
            PublicationRadio.Text = "Publication_Year";
            PublicationRadio.UseVisualStyleBackColor = true;
            // 
            // QuantityRadio
            // 
            QuantityRadio.AutoSize = true;
            QuantityRadio.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityRadio.ForeColor = Color.Transparent;
            QuantityRadio.Location = new Point(40, 203);
            QuantityRadio.Name = "QuantityRadio";
            QuantityRadio.Size = new Size(96, 24);
            QuantityRadio.TabIndex = 41;
            QuantityRadio.TabStop = true;
            QuantityRadio.Text = "Quantity";
            QuantityRadio.UseVisualStyleBackColor = true;
            // 
            // TitleRadio
            // 
            TitleRadio.AutoSize = true;
            TitleRadio.Font = new Font("Maiandra GD", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TitleRadio.ForeColor = Color.Transparent;
            TitleRadio.Location = new Point(44, 454);
            TitleRadio.Name = "TitleRadio";
            TitleRadio.Size = new Size(62, 24);
            TitleRadio.TabIndex = 44;
            TitleRadio.TabStop = true;
            TitleRadio.Text = "Title";
            TitleRadio.UseVisualStyleBackColor = true;
            // 
            // SearchTxtBox
            // 
            SearchTxtBox.Location = new Point(40, 130);
            SearchTxtBox.Name = "SearchTxtBox";
            SearchTxtBox.Size = new Size(190, 27);
            SearchTxtBox.TabIndex = 45;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(376, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(522, 537);
            dataGridView1.TabIndex = 46;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(258, 499);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 47;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // SearchFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(903, 596);
            Controls.Add(ExitButton);
            Controls.Add(dataGridView1);
            Controls.Add(SearchTxtBox);
            Controls.Add(TitleRadio);
            Controls.Add(ISBNRadio);
            Controls.Add(PublicationRadio);
            Controls.Add(QuantityRadio);
            Controls.Add(PriceRadio);
            Controls.Add(AuthorRadio);
            Controls.Add(CategoryRadio);
            Controls.Add(SearchLabel);
            Controls.Add(SearchButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchFilter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchFilter";
            Load += SearchFilter_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton PriceRadio;
        private RadioButton AuthorRadio;
        private RadioButton CategoryRadio;
        private Label SearchLabel;
        private Button SearchButton;
        private RadioButton ISBNRadio;
        private RadioButton PublicationRadio;
        private RadioButton QuantityRadio;
        private RadioButton TitleRadio;
        private TextBox SearchTxtBox;
        private DataGridView dataGridView1;
        private Button ExitButton;
    }
}