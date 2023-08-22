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
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
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
                if (StudentID.Checked)
                {
                    string studentID = UpdateTxtBox.Text;
                    string existingStudentID = CurrentTxtBox.Text;

                    // Create the parameterized query
                    cmd.CommandText = "UPDATE Users SET UserID = @userID WHERE UserID = @existinguserID";

                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@userID", studentID);
                    cmd.Parameters.AddWithValue("@existinguserID", existingStudentID);
                }
                else if (Password.Checked)
                {
                    string password = UpdateTxtBox.Text;
                    string existingPassword = CurrentTxtBox.Text;

                    // Create the parameterized query
                    cmd.CommandText = "UPDATE Users SET Password = @password WHERE Password = @existingPassword";

                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@existingPassword", existingPassword);
                }
                else if (PhoneNo.Checked)
                {
                    string phoneNo = UpdateTxtBox.Text;
                    string existingPhoneNo = CurrentTxtBox.Text;

                    // Create the parameterized query
                    cmd.CommandText = "UPDATE Users SET Phone_No = @phoneNo WHERE Phone_No = @existingPhoneNo";

                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
                    cmd.Parameters.AddWithValue("@existingPhoneNo", existingPhoneNo);
                }
                else
                {
                    // No radio button selected
                    MessageBox.Show("Please select a type.");
                }

                // Execute the query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Info updated successfully.");
                }
                else
                {
                    MessageBox.Show("No info was updated.");
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
