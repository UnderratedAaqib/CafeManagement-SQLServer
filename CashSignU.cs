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
    public partial class CashSignU : Form
    {
        public CashSignU()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ep_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");

            try
            {
                co.Open();
                MessageBox.Show("Connected Successfully");

                SqlCommand cm;
                string id = id12.Text;
                string username = unm1.Text;
                string password = paso.Text;
                string email = emil.Text;
                string number = no.Text;
                string experience = expr.Text;
                string salary = sl.Text;
                string date = hde.Text;

                // Check for empty strings
                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(number) || string.IsNullOrWhiteSpace(experience) ||
                    string.IsNullOrWhiteSpace(salary) || string.IsNullOrWhiteSpace(date))
                {
                    MessageBox.Show("Please fill in all the fields before adding a cashier.");
                    return;
                }

                string query = "Insert into Cashier(EmployeeID, Username, Password, Email, RoleID, Contact, Experience, HireDate, Salary) " +
                               $"values ('{id}', '{username}', '{password}', '{email}', '{3}', '{number}', '{experience}', '{date}', '{salary}')";

                cm = new SqlCommand(query, co);
                cm.ExecuteNonQuery();
                cm.Dispose();

                MessageBox.Show("Cashier added successfully!");

                ManagerMenu mp = new ManagerMenu();
                this.Hide();
                mp.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (co.State == ConnectionState.Open)
                    co.Close();
            }
        }

    }
}
