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
    public partial class SearchFilter : Form
    {
        public SearchFilter()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();

            try
            {
                string searchTerm = SearchTxtBox.Text;

                if (TitleRadio.Checked)
                {
                    // Create the parameterized query
                    cmd.CommandText = "SELECT * FROM Book WHERE Title LIKE @searchTerm";

                    // Add the search term as a parameter
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }
                else if (AuthorRadio.Checked)
                {
                    // Create the parameterized query
                    cmd.CommandText = "SELECT * FROM Book WHERE Author LIKE @searchTerm";

                    // Add the search term as a parameter
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }
                else if (QuantityRadio.Checked)
                {
                    // Create the parameterized query
                    cmd.CommandText = "SELECT * FROM Book WHERE Quantity LIKE @searchTerm";

                    // Add the search term as a parameter
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }
                else if (CategoryRadio.Checked)
                {
                    // Create the parameterized query
                    cmd.CommandText = "SELECT * FROM Book WHERE Category LIKE @searchTerm";

                    // Add the search term as a parameter
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }
                else if (PublicationRadio.Checked)
                {
                    // Create the parameterized query
                    cmd.CommandText = "SELECT * FROM Book WHERE PublicationYear LIKE @searchTerm";

                    // Add the search term as a parameter
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }
                else if (PriceRadio.Checked)
                {
                    // Create the parameterized query
                    cmd.CommandText = "SELECT * FROM Book WHERE Price LIKE @searchTerm";

                    // Add the search term as a parameter
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }
                else if (ISBNRadio.Checked)
                {
                    // Create the parameterized query
                    cmd.CommandText = "SELECT * FROM Book WHERE ISBN LIKE @searchTerm";

                    // Add the search term as a parameter
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }
                else
                {
                    // No radio button selected
                    MessageBox.Show("Please select a search category");
                    return; // Exit the method early
                }

                // Create a DataTable to hold the retrieved data
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable with data from the database
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);

                // Set the DataTable as the data source for the DataGridView on the same form
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // An error occurred while connecting to the database or executing the query
                MessageBox.Show("Failed to process: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchFilter_Load(object sender, EventArgs e)
        {

        }
    }
}