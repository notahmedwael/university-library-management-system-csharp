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
    public partial class AdminPanel : Form
    {
        private DataGridView dataGridView1;
        private Panel tablePanel;

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            // Create a panel to hold the table
            tablePanel = new Panel();
            tablePanel.Dock = DockStyle.Fill;

            // Connect to the database
            string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // Open the database connection
                connection.Open();

                // Create a SqlCommand to select all records from the table
                string query = "SELECT * FROM Book";
                SqlCommand command = new SqlCommand(query, connection);

                // Create a DataTable to hold the retrieved data
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable with data from the database
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                // Create a DataGridView control and set its properties
                dataGridView1 = new DataGridView();
                dataGridView1.DataSource = dataTable;
                dataGridView1.Dock = DockStyle.Fill;

                // Add the DataGridView control to the table panel
                tablePanel.Controls.Add(dataGridView1);

                // Add the table panel to the form
                Controls.Add(tablePanel);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Connect to the database
            string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                // Open the database connection
                connection.Open();

                // Create a SqlCommand to select all records from the table
                string query = "SELECT * FROM Book";
                SqlCommand command = new SqlCommand(query, connection);

                // Create a DataTable to hold the retrieved data
                DataTable dataTable = new DataTable();

                // Use a SqlDataAdapter to fill the DataTable with data from the database
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                // Update the DataGridView control with the new data
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }
        }

        private void UpdateBook_Click(object sender, EventArgs e)
        {
            UpdateBook updateBook = new UpdateBook();
            updateBook.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

            HomePage homePage = new HomePage();
            homePage.ShowDialog();
        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            DeleteBook deleteBook = new DeleteBook();
            deleteBook.ShowDialog();
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            UpdateAdmin updateUser = new UpdateAdmin();
            updateUser.ShowDialog();
        }

        private void SearchFilter_Click(object sender, EventArgs e)
        {
            SearchFilter searchFilter = new SearchFilter();
            searchFilter.ShowDialog();
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {
                string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();

                try
                {
                    // Count of users
                    cmd.CommandText = "SELECT COUNT(*) FROM Users";
                    int userCount = (int)cmd.ExecuteScalar();

                    // Count of books
                    cmd.CommandText = "SELECT COUNT(*) FROM Book";
                    int bookCount = (int)cmd.ExecuteScalar();

                    // Most expensive book name and price
                    cmd.CommandText = "SELECT TOP 1 Title, Price FROM Book ORDER BY Price DESC";
                    SqlDataReader reader = cmd.ExecuteReader();
                    string bookName = string.Empty;
                    decimal bookPrice = 0;

                    if (reader.Read())
                    {
                        bookName = reader.GetString(0);
                        bookPrice = Convert.ToDecimal(reader.GetValue(1));
                    }
                    reader.Close();

                    // Display the results in a MessageBox
                    string message = $"Number of Users: {userCount}\n" +
                                     $"Number of Books: {bookCount}\n" +
                                     $"Most Expensive Book: {bookName} (Price: {bookPrice:C})";
                    MessageBox.Show(message, "Statistics");
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

        }
    }
