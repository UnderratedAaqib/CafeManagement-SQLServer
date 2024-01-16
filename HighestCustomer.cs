using Microsoft.VisualBasic;
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
    public partial class HighestCustomer : Form
    {
        public HighestCustomer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HighestCustomer_Load(object sender, EventArgs e)
        {
            populateHighestCustomer();
        }
        private void populateHighestCustomer()
        {
            try
            {
                using (SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    sp.Open();
                    //nested subquery 2
                    string query = @"SELECT TOP 1
    CustID,
    Username,
    TotalPurchaseAmount
FROM Customers c
JOIN (
    SELECT   Cu_ID,  SUM(total_amount) AS TotalPurchaseAmount FROM Orders GROUP BY Cu_ID) o ON c.CustID = o.Cu_ID ORDER BY TotalPurchaseAmount DESC;
";

                    using (SqlCommand cmd = new SqlCommand(query, sp))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Assuming that 'caInformation' is your DataGridView
                        highestCus.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions or log errors as needed
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void HCasBack_Click(object sender, EventArgs e)
        {
            ManagerMenu mnp = new ManagerMenu();
            mnp.Show();
            this.Hide();
        }
    }
}
