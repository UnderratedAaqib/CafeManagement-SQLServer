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
    public partial class CashierInformation : Form
    {
        public CashierInformation()
        {
            InitializeComponent();
        }

        private void CashierInformation_Load(object sender, EventArgs e)
        {
            populateCashier();
        }
        private void populateCashier()
        {
            try
            {
                using (SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    sp.Open();

                    string query = @"SELECT TOP 1 c.EmployeeID,c.Username, OrderCount FROM Cashier c JOIN ( SELECT Cu_ID, COUNT(OrderID) AS OrderCount  FROM Orders GROUP BY Cu_ID) o ON c.EmployeeID = o.Cu_ID ORDER BY OrderCount DESC;
            ";

                    using (SqlCommand cmd = new SqlCommand(query, sp))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        // Assuming that 'caInformation' is your DataGridView
                        caInformation.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions or log errors as needed
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void CasBack_Click(object sender, EventArgs e)
        {
            ManagerMenu mn = new ManagerMenu();
            mn.Show();
            this.Hide();
        }
    }
}
