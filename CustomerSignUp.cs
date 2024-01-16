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

namespace DATABASE_Project
{
    public partial class CustomerSignUp : Form
    {
        public CustomerSignUp()
        {
            InitializeComponent();
        }

        private void cuSignUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = cuIDTxt.Text;
                string username = cuNameT.Text;
                string password = cuPasswordT.Text;
                string email = cuEmlT.Text;
                string contact = cuNoT.Text;
                string loyaltyID = loyaltyT.Text;

                // Check for empty fields
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(loyaltyID))
                {
                    MessageBox.Show("Please fill in all the required fields.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    connection.Open();

                    // Insert into Loyalty_Point table
                    string loyaltyInsertQuery = "INSERT INTO Loyalty_Point (id, c_level, points) VALUES (@loyaltyID, @c_level, @points)";
                    using (SqlCommand loyaltyInsertCmd = new SqlCommand(loyaltyInsertQuery, connection))
                    {
                        loyaltyInsertCmd.Parameters.AddWithValue("@loyaltyID", loyaltyID);
                        loyaltyInsertCmd.Parameters.AddWithValue("@c_level", "Initial");
                        loyaltyInsertCmd.Parameters.AddWithValue("@points", 0);

                        loyaltyInsertCmd.ExecuteNonQuery();
                    }

                    // Insert into Customers table
                    string customerInsertQuery = "INSERT INTO Customers (CustID, Username, Password, Email, RoleID, Contact, loyalty_id) VALUES (@id, @username, @password, @email, @roleID, @contact, @loyaltyID)";
                    using (SqlCommand customerInsertCmd = new SqlCommand(customerInsertQuery, connection))
                    {
                        customerInsertCmd.Parameters.AddWithValue("@id", id);
                        customerInsertCmd.Parameters.AddWithValue("@username", username);
                        customerInsertCmd.Parameters.AddWithValue("@password", password);
                        customerInsertCmd.Parameters.AddWithValue("@email", email);
                        customerInsertCmd.Parameters.AddWithValue("@roleID", 1);
                        customerInsertCmd.Parameters.AddWithValue("@contact", contact);
                        customerInsertCmd.Parameters.AddWithValue("@loyaltyID", loyaltyID);

                        customerInsertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Customer and Loyalty data inserted successfully.");
                CustomerLogin cl = new CustomerLogin();
                cl.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



    }
}
