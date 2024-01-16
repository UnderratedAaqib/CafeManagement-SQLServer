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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DATABASE_Project
{
    public partial class MenuItems : Form
    {
        public MenuItems()
        {
            InitializeComponent();
        }

        private void menID_Click(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            SqlConnection co = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");

            try
            {
                co.Open();
                MessageBox.Show("Connected Successfully");

                SqlCommand cm;
                string id = menIDT.Text;
                string name = menNameT.Text;
                string price = menPriceT.Text;
                string description = menDescT.Text;
                string calories = menCaloriesT.Text;

                // Check for null or empty strings
                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(price) ||
                    string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(calories))
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }

                string query = "Insert into Menu(id, name, Price, Description, NuInformation) " +
                               $"values ('{id}', '{name}', '{price}', '{description}', '{calories}')";

                cm = new SqlCommand(query, co);
                cm.ExecuteNonQuery();
                cm.Dispose();

                // Inventory insertion
                SqlConnection co1 = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
                co1.Open();

                string query1 = $"Insert into Inventory(InvId, quantity, MenID) values ('{id}', null, '{id}')";
                SqlCommand cm1;
                cm1 = new SqlCommand(query1, co1);
                cm1.ExecuteNonQuery();
                cm1.Dispose();
                co1.Close();

                ManagerMenu mn = new ManagerMenu();
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

    }
}
