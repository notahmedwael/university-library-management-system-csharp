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
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Connect to the database
            string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // Open the database connection
                connection.Open();

                // Get the book title to delete
                string bookTitle = TitleTxtBox.Text;

                // Create a SqlCommand to delete the record with the given book title
                string query = "DELETE FROM Book WHERE Title = @BookTitle";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookTitle", bookTitle);

                // Execute the query
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book deleted successfully");
                }
                else
                {
                    MessageBox.Show("No book found with the given title");
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
    }
}
