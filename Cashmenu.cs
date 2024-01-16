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
    public partial class Cashmenu : Form
    {
        List<Panel> panel = new List<Panel>();
        int index = 0;
        public Cashmenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cashmenu_Load(object sender, EventArgs e)
        {
            populateOrders();
            panel.Add(orderPanel);
            panel[index].BringToFront();
            timer3.Start();
        }
        private void populateOrders()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
            //three table join(1)
            // Use a LEFT JOIN to retrieve all orders regardless of the presence of Gu_ID
            string query = "SELECT c.Username, o.OrderID, o.status, o.total_amount " +
                           "FROM Orders o " +
                           "LEFT JOIN Customers c ON o.Cu_ID = c.CustID " +
                           "LEFT JOIN G_Customer g ON o.Gu_ID = g.id";

            using (SqlCommand cmd = new SqlCommand(query, sp))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                orderData.DataSource = dt;
            }

            sp.Close();
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            populateOrders();
            timer3.Start();
        }

        private void finReciept_Click(object sender, EventArgs e)
        {
            try
            {
                string orderId = orderIDT.Text;

                // Check for null or empty string
                if (string.IsNullOrEmpty(orderId))
                {
                    MessageBox.Show("Please enter a valid Order ID.");
                    return;
                }

                if (IsOrderCompleted(orderId))
                {
                    MessageBox.Show("Order is already completed.");
                    return;
                }

                bool isRegularCustomer = IsRegularCustomer(orderId);

                decimal paidAmount = isRegularCustomer ? GetPaidAmountRegular(orderId) : GetPaidAmountGuest(orderId);

                UpdateCustomerMoney(orderId, paidAmount, isRegularCustomer);

                InsertReceipt(orderId, paidAmount);

                UpdateOrderStatus(orderId, "Completed");

                DisplayReceipt(orderId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private bool IsOrderCompleted(string orderId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    connection.Open();

                    string checkOrderStatusQuery = "SELECT status FROM Orders WHERE OrderID = @orderId";
                    using (SqlCommand checkOrderStatusCmd = new SqlCommand(checkOrderStatusQuery, connection))
                    {
                        checkOrderStatusCmd.Parameters.AddWithValue("@orderId", orderId);

                        object result = checkOrderStatusCmd.ExecuteScalar();
                        return result != null && result.ToString() == "Completed";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error occurred in IsOrderCompleted: {sqlEx.Message}");
                return false; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred in IsOrderCompleted: {ex.Message}");
                return false; // Handle the error by returning a default value or taking appropriate action
            }
        }

        private bool IsRegularCustomer(string orderId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    connection.Open();

                    string checkRegularCustomerQuery = "SELECT Cu_ID FROM Orders WHERE OrderID = @orderId AND Cu_ID IS NOT NULL";
                    using (SqlCommand checkRegularCustomerCmd = new SqlCommand(checkRegularCustomerQuery, connection))
                    {
                        checkRegularCustomerCmd.Parameters.AddWithValue("@orderId", orderId);
                        return checkRegularCustomerCmd.ExecuteScalar() != null;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error occurred in IsRegularCustomer: {sqlEx.Message}");
                return false; // Handle the error by returning a default value or taking appropriate action
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred in IsRegularCustomer: {ex.Message}");
                return false; // Handle the error by returning a default value or taking appropriate action
            }
        }


        private decimal GetPaidAmountRegular(string orderId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    connection.Open();
                    //Nested subquery(5)
                    string getPaidAmountQuery = "SELECT Money FROM Customers WHERE CustID IN (SELECT Cu_ID FROM Orders WHERE OrderID = @orderId)";
                    using (SqlCommand getPaidAmountCmd = new SqlCommand(getPaidAmountQuery, connection))
                    {
                        getPaidAmountCmd.Parameters.AddWithValue("@orderId", orderId);

                        object result = getPaidAmountCmd.ExecuteScalar();
                        return (result != null && result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error occurred in GetPaidAmountRegular: {sqlEx.Message}");
                return 0; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred in GetPaidAmountRegular: {ex.Message}");
                return 0; 
            }
        }

        private decimal GetPaidAmountGuest(string orderId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    connection.Open();
                    //Nested subquery (6)
                    string getPaidAmountQuery = "SELECT Money FROM G_Customer WHERE id IN (SELECT Gu_ID FROM Orders WHERE OrderID = @orderId)";
                    using (SqlCommand getPaidAmountCmd = new SqlCommand(getPaidAmountQuery, connection))
                    {
                        getPaidAmountCmd.Parameters.AddWithValue("@orderId", orderId);

                        object result = getPaidAmountCmd.ExecuteScalar();
                        return (result != null && result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error occurred in GetPaidAmountGuest: {sqlEx.Message}");
                return 0; // Handle the error by returning a default value or taking appropriate action
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred in GetPaidAmountGuest: {ex.Message}");
                return 0; // Handle the error by returning a default value or taking appropriate action
            }
        }



        private void UpdateCustomerMoney(string orderId, decimal paidAmount, bool isRegularCustomer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    connection.Open();

                    string updateMoneyQuery = isRegularCustomer
                        ? "UPDATE Customers SET Money = Money - @paidAmount WHERE CustID IN (SELECT Cu_ID FROM Orders WHERE OrderID = @orderId)"
                        : "UPDATE G_Customer SET Money = Money - @paidAmount WHERE id IN (SELECT Gu_ID FROM Orders WHERE OrderID = @orderId)";

                    using (SqlCommand updateMoneyCmd = new SqlCommand(updateMoneyQuery, connection))
                    {
                        updateMoneyCmd.Parameters.AddWithValue("@orderId", orderId);
                        updateMoneyCmd.Parameters.AddWithValue("@paidAmount", paidAmount);

                        updateMoneyCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error occurred in UpdateCustomerMoney: {sqlEx.Message}");
                // Handle the error by logging, displaying a message, or taking appropriate action
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred in UpdateCustomerMoney: {ex.Message}");
                // Handle the error by logging, displaying a message, or taking appropriate action
            }
        }

        private void InsertReceipt(string orderId, decimal paidAmount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    connection.Open();

                    decimal change = paidAmount - GetTotalAmount(orderId);
                    string insertReceiptQuery = "INSERT INTO Receipt (OrderID, TotalAmount, PaidAmount, Change, ReceiptDate) " +
                                                "VALUES (@orderId, @totalAmount, @paidAmount, @change, @receiptDate)";
                    using (SqlCommand insertReceiptCmd = new SqlCommand(insertReceiptQuery, connection))
                    {
                        insertReceiptCmd.Parameters.AddWithValue("@orderId", orderId);
                        insertReceiptCmd.Parameters.AddWithValue("@totalAmount", GetTotalAmount(orderId));
                        insertReceiptCmd.Parameters.AddWithValue("@paidAmount", paidAmount);
                        insertReceiptCmd.Parameters.AddWithValue("@change", change);
                        insertReceiptCmd.Parameters.AddWithValue("@receiptDate", DateTime.Now);

                        insertReceiptCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error occurred in InsertReceipt: {sqlEx.Message}");
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred in InsertReceipt: {ex.Message}");
                // Handle the error by logging, displaying a message, or taking appropriate action
            }
        }

        private decimal GetTotalAmount(string orderId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    connection.Open();

                    string getTotalAmountQuery = "SELECT total_amount FROM Orders WHERE OrderID = @orderId";
                    using (SqlCommand getTotalAmountCmd = new SqlCommand(getTotalAmountQuery, connection))
                    {
                        getTotalAmountCmd.Parameters.AddWithValue("@orderId", orderId);

                        object result = getTotalAmountCmd.ExecuteScalar();
                        return (result != null && result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error occurred in GetTotalAmount: {sqlEx.Message}");
                
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred in GetTotalAmount: {ex.Message}");
               
                return 0; 
            }
        }

        private void UpdateOrderStatus(string orderId, string status)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    connection.Open();

                    string updateOrderStatusQuery = "UPDATE Orders SET status = @status WHERE OrderID = @orderId";
                    using (SqlCommand updateOrderStatusCmd = new SqlCommand(updateOrderStatusQuery, connection))
                    {
                        updateOrderStatusCmd.Parameters.AddWithValue("@orderId", orderId);
                        updateOrderStatusCmd.Parameters.AddWithValue("@status", status);

                        updateOrderStatusCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL error occurred in UpdateOrderStatus: {sqlEx.Message}");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred in UpdateOrderStatus: {ex.Message}");
               
            }
        }



        private void DisplayReceipt(string orderId)
        {
            ReceiptForm rf = new ReceiptForm(orderId);
            rf.Show();
            this.Close();
        }

        private void ClogOutButton_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
