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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void ent_log_Click(object sender, EventArgs e)
        {
            string username =unamee.Text;
            string password = upass.Text;
            int roleId = GetRoleId(username, password);
            
            if (roleId != -1)
            {
                if (roleId == 2)
                {
                    ManagerMenu ms = new ManagerMenu();
                    ms.Show();
                    this.Hide();
                }
                else if (roleId == 1)
                {
                    Customer customer = new Customer(username);
                    customer.Show();
                    this.Hide();
                }
                else if (roleId == 3)
                {
                    Cashmenu cash = new Cashmenu();
                    cash.Show();
                    this.Hide();

                }
                // Authentication successful, perform actions based on role ID
                // For example, open a new form or grant access
                MessageBox.Show($"Login successful for role ID: {roleId}");
            }
            else
            {
                // Authentication failed
                MessageBox.Show("Invalid username or password");
            }
        }
        private int GetRoleId(string username, string password)
        {
            // Check Admins table
            int adminRoleId = CheckTable("Customers", username, password);
            if (adminRoleId != -1)
            {
                return adminRoleId;
            }

            // Check Managers table
            int managerRoleId = CheckTable("Managers", username, password);
            if (managerRoleId != -1)
            {
                return managerRoleId;
            }

            // Check Employees table
            int employeeRoleId = CheckTable("Cashier", username, password);
            if (employeeRoleId != -1)
            {
                return employeeRoleId;
            }

            // No match found in any table
            return -1;
        }
        private int CheckTable(string tableName, string username, string password)
        {
            int roleId = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    connection.Open();

                    string query = $"SELECT RoleID FROM {tableName} WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            roleId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (display, log, etc.)
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return roleId;
        }

        private void lgna(object sender, EventArgs e)
        {

        }

        private void lg_pass_Click(object sender, EventArgs e)
        {

        }

        private void utextbox(object sender, EventArgs e)
        {

        }

        private void unamee_Click(object sender, EventArgs e)
        {

        }

        private void upasscode(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu cs = new MainMenu();
            cs.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
