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
    public partial class StudentPanel : Form
    {
        private DataGridView dataGridView1;
        private Panel tablePanel;
        public StudentPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentPanel_Load(object sender, EventArgs e)
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

        private void SearchFilter_Click(object sender, EventArgs e)
        {
            SearchFilter searchFilter = new SearchFilter();
            searchFilter.ShowDialog();
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            UpdateStudent updateStudent = new UpdateStudent();
            updateStudent.ShowDialog();
        }
    }
}
