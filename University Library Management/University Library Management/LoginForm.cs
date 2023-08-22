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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Enter your data to login.");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();

            try
            {
                if (StudentRadio.Checked)
                {
                    string userID = UserIDTxtBox.Text;
                    string password = PasswordTxtBox.Text;

                    string query = "SELECT COUNT(*) FROM Users WHERE UserID = @UserID AND Password = @Password";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        // Successful login for a student
                        ClearLoginForm();
                        MessageBox.Show("Login successful for student");
                        StudentPanel studentPanel = new StudentPanel();
                        studentPanel.ShowDialog();
                    }
                    else
                    {
                        // Invalid login for a student
                        MessageBox.Show("Invalid login for student");
                        this.Close();
                        HomePage homePage = new HomePage();
                        homePage.Show();
                    }
                }
                else if (AdminRadio.Checked)
                {
                    string userID = UserIDTxtBox.Text;
                    string password = PasswordTxtBox.Text;

                    string query = "SELECT COUNT(*) FROM Admin WHERE AdminID = @AdminID AND Password = @Password";
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@AdminID", userID);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        // Successful login for an admin
                        ClearLoginForm();
                        MessageBox.Show("Login successful for admin.");
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.ShowDialog();

                    }
                    else
                    {
                        // Invalid login for an admin
                        MessageBox.Show("Invalid login for admin.");
                        this.Close();
                        HomePage homePage = new HomePage();
                        homePage.Show();
                    }
                }
                else
                {
                    // No radio button selected
                    MessageBox.Show("Please select a user type");
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
            }
        }
        private void ClearLoginForm()
        {
            // Clear text boxes
            UserIDTxtBox.Clear();
            PasswordTxtBox.Clear();

            // Clear radio buttons
            StudentRadio.Checked = false;
            AdminRadio.Checked = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.ShowDialog();
        }
    }
}