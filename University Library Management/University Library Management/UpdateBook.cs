using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Library_Management
{
    public partial class UpdateBook : Form
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void addTitle_Click(object sender, EventArgs e)
        {
        }

        private void addAuthor_Click(object sender, EventArgs e)
        {
        }

        private void addPrice_Click(object sender, EventArgs e)
        {
        }

        private void addPublicationYear_Click(object sender, EventArgs e)
        {
        }

        private void addQuantity_Click(object sender, EventArgs e)
        {
        }

        private void addISBN_Click(object sender, EventArgs e)
        {
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            try
            {
                string BookISBN = BookISBNTxtBox.Text;
                string quantity = QuantityTxtBox.Text;
                string publicationYear = PublicationTxtBox.Text;
                string ISBN = ISBNTxtBox.Text;
                string price = PriceTxtBox.Text;
                string category = CategoryTxtBox.Text;
                string author = AuthorTxtBox.Text;
                string title = TitleTxtBox.Text;

                // Create the parameterized query
                cmd.CommandText = "UPDATE Book SET Quantity = @quantity, PublicationYear = @publicationYear, ISBN = @ISBN, Price = @price, Category = @category, Author = @author WHERE ISBN = @BookISBN";
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@PublicationYear", publicationYear);
                cmd.Parameters.AddWithValue("@ISBN", ISBN);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@BookISBN", BookISBN);

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book updated successfully");
                }
                else
                {
                    MessageBox.Show("Failed to update book");
                }
            }
            catch (Exception ex)
            {
                // An error occurred while connecting to the database or executing the query
                MessageBox.Show("Failed to process: " + ex.Message);
            }
            finally
            {
                connection.Close();
                this.Close();
            }
        }

        private void TitleTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void AuthorTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PriceTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void PublicationTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void QuantityTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void CategoryTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ISBNTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
