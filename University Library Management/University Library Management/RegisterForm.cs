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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Enter your data to register.");
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
                    string phoneNO = PhoneNoTxtBox.Text;

                    // Create the parameterized query
                    cmd.CommandText = "INSERT INTO Users (UserID, Password, Phone_No) VALUES (@UserID, @Password, @PhoneNo)";
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@PhoneNo", phoneNO);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student added successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add student");
                    }
                }

                else if (AdminRadio.Checked)
                {
                    string adminID = UserIDTxtBox.Text;
                    string password = PasswordTxtBox.Text;
                    string phoneNO = PhoneNoTxtBox.Text;

                    // Create the parameterized query
                    cmd.CommandText = "INSERT INTO Admin (Password, AdminID, Phone_No) VALUES (@Password, @AdminID, @PhoneNo)";
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@AdminID", adminID);
                    cmd.Parameters.AddWithValue("@PhoneNo", phoneNO);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Admin added successfully");
                    }
                    else
                    {

                        MessageBox.Show("Failed to add Admin");
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
                ClearLoginForm();
                HomePage homePage = new HomePage();
                homePage.ShowDialog();
                connection.Close();
            }
        }
        private void ClearLoginForm()
        {
            // Clear text boxes
            UserIDTxtBox.Clear();
            PasswordTxtBox.Clear();
            PhoneNoTxtBox.Clear();

            // Clear radio buttons
            StudentRadio.Checked = false;
            AdminRadio.Checked = false;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void AdminRadio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Login_Click(object sender, EventArgs e)
        {
        }

        private void PasswordTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Logo_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Register_Click(object sender, EventArgs e)
        {
        }

        private void StudentRadio_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void PhoneNoTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void UserIDTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void UserIDLabel_Click(object sender, EventArgs e)
        {
        }

        private void PhoneNoLabel_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.ShowDialog();
        }
    }
}