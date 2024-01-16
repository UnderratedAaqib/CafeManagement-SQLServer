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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DATABASE_Project
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void RLogin_Click(object sender, EventArgs e)
        {
            string username = c_usernameT.Text;
            string password = c_passT.Text;
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
            string query = "SELECT Username, Password FROM Customers WHERE username = @username AND Password = @password";

            using (SqlCommand cmd = new SqlCommand(query, sp))
            {

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Credentials Matched.");
                    Customer cs = new Customer(username);
                    this.Hide();
                    cs.Show();


                }
                else
                {
                    MessageBox.Show("Data not matched.");
                }

                sp.Close();
            }
            
           

        }

        private void reAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerSignUp csp=new CustomerSignUp();
            csp.Show();
            this.Hide();

        }

        private void gLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    connection.Open();
                      
                    // Insert into G_Customers and capture the generated ID
                    string insertQuery = "INSERT INTO G_Customer (name) OUTPUT INSERTED.id VALUES (@customerName)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@customerName", "Guest"); // Replace with the actual customer name

                        int generatedID = (int)insertCommand.ExecuteScalar();

                        // Load a new form with the generated ID parameter
                        GuestForm newForm = new GuestForm(generatedID);
                        newForm.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form1 p=new Form1();
            p.Show();
            this.Hide();
        }
    }
}
