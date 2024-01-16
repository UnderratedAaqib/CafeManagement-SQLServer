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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Signup_button(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");

            try
            {
                co.Open();
                MessageBox.Show("Connected Successfully");

                SqlCommand cm;
                string id = id1.Text;
                string username = unm.Text;
                string password = paso.Text;
                string email = eml.Text;
                string number = no.Text;
                string experience = expr.Text;
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)
            || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(number) || string.IsNullOrEmpty(experience))
                {
                    MessageBox.Show("All fields must be filled.");
                    return;
                }
                string query = "INSERT INTO Managers(ManagerID, Username, Password, Email, RoleID, Contact, Experience) " +
                               $"VALUES ('{id}', '{username}', '{password}', '{email}', '{2}', '{number}', '{experience}')";

                cm = new SqlCommand(query, co);
                cm.ExecuteNonQuery();
                cm.Dispose();
                MainMenu mn = new MainMenu();
                mn.Show();
                this.Hide();
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


        private void Name1(object sender, EventArgs e)
        {

        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void id21(object sender, EventArgs e)
        {

        }

        private void ema(object sender, EventArgs e)
        {

        }

        private void passw(object sender, EventArgs e)
        {

        }

        private void nm(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void id1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
