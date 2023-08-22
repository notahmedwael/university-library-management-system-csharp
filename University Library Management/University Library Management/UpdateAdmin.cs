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
    public partial class UpdateAdmin : Form
    {
        public UpdateAdmin()
        {
            InitializeComponent();
        }

        private void BookTitleLabel_Click(object sender, EventArgs e)
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
                if (AdminID.Checked)
                {
                    string adminID = UpdateTxtBox.Text;
                    string existingAdminID = CurrentTxtBox.Text;

                    // Create the parameterized query
                    cmd.CommandText = "UPDATE Admin SET AdminID = @adminID WHERE AdminID = @existingAdminID";

                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@adminID", adminID);
                    cmd.Parameters.AddWithValue("@existingAdminID", existingAdminID);
                }
                else if (Password.Checked)
                {
                    string password = UpdateTxtBox.Text;
                    string existingPassword = CurrentTxtBox.Text;

                    // Create the parameterized query
                    cmd.CommandText = "UPDATE Admin SET Password = @password WHERE Password = @existingPassword";

                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@existingPassword", existingPassword);
                }
                else if (PhoneNo.Checked)
                {
                    string phoneNo = UpdateTxtBox.Text;
                    string existingPhoneNo = CurrentTxtBox.Text;

                    // Create the parameterized query
                    cmd.CommandText = "UPDATE Admin SET Phone_No = @phoneNo WHERE Phone_No = @existingPhoneNo";

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

        private void CurrentTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneNo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Password_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void AdminID_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CurrentInfoLabel_Click(object sender, EventArgs e)
        {
        }

        private void UpdateTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
