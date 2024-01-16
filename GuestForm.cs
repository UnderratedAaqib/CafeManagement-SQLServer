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
    public partial class GuestForm : Form
    {
        List<Panel> panel = new List<Panel>();
        int index = 0;
        public int currentCustomerID;
        public GuestForm(int ID)
        {
            InitializeComponent();
            currentCustomerID = ID;
        }

        private void cumenPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            panel.Add(GcumenPanel);
            panel.Add(GCartPanel);
            populateGMenu();
            populateGCart();
            populateAmount();
            panel[index].BringToFront();
            timer3.Start();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            index = 1;
            panel[index].BringToFront();
        }
        private void populateGMenu()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
            string quer = $"SELECT * FROM Menu";
            using (SqlCommand cmd = new SqlCommand(quer, sp))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                GcustomerMenu.DataSource = dt;


            }
            sp.Close();

        }
        private void populateGCart()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
            string quer = $"SELECT id,itemname,quantity FROM OrdersItem";
            using (SqlCommand cmd = new SqlCommand(quer, sp))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                GcartData.DataSource = dt;


            }
            sp.Close();


        }
        private void populateAmount()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
            string quer = $"SELECT ISNULL(SUM(price), 0) AS totalAmount FROM OrdersItem";
            using (SqlCommand sc = new SqlCommand(quer, sp))
            {
                SqlDataReader reader = sc.ExecuteReader();
                if (reader.Read())
                {

                    GctAmountT.Text = reader["TotalAmount"].ToString();

                }
                else
                {

                    GctAmountT.Text = "-";

                }
            }
            sp.Close();


        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            populateGMenu();
            populateGCart();
            populateAmount();
            timer3.Start();
        }

        private void GaddCart_Click(object sender, EventArgs e)
        {
            string id = GordIDT.Text;
            string qty = GquanT.Text;

            using (SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
            {
                sp.Open();

                //two table join(6)
                string checkInventoryQuery = "SELECT Inventory.quantity FROM Menu " +
                                             "JOIN Inventory ON Menu.id = Inventory.MenID " +
                                             "WHERE Inventory.InvID = @id";

                using (SqlCommand checkInventoryCmd = new SqlCommand(checkInventoryQuery, sp))
                {
                    checkInventoryCmd.Parameters.AddWithValue("@id", id);
                    int inventoryQuantity = Convert.ToInt32(checkInventoryCmd.ExecuteScalar());

                    if (inventoryQuantity <= 0 || inventoryQuantity < int.Parse(qty))
                    {
                        MessageBox.Show("Insufficient quantity left in the inventory.");
                        return;
                    }
                }
                //two table join (5)
                string query = "SELECT Menu.id, name, quantity, price FROM Menu " +
                               "JOIN Inventory ON Menu.id = Inventory.MenID " +
                               "WHERE Inventory.InvID = @id";

                using (SqlCommand scp = new SqlCommand(query, sp))
                {
                    scp.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader rdr = scp.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            int menuId = rdr.GetInt32(rdr.GetOrdinal("id"));
                            string name = rdr.GetString(rdr.GetOrdinal("name"));
                            int inventoryQuantity = rdr.GetInt32(rdr.GetOrdinal("quantity"));

                            // Convert price from varchar to decimal
                            string priceAsString = rdr.GetString(rdr.GetOrdinal("price"));
                            decimal price;
                            if (decimal.TryParse(priceAsString, out price))
                            {
                                rdr.Close();

                                if (inventoryQuantity >= int.Parse(qty))
                                {
                                    decimal totalPrice = int.Parse(qty) * price;

                                    string insertQuery = "INSERT INTO OrdersItem(itemname, quantity, price) VALUES (@name, @quantity, @price)";
                                    using (SqlCommand insert = new SqlCommand(insertQuery, sp))
                                    {
                                        insert.Parameters.AddWithValue("@name", name);
                                        insert.Parameters.AddWithValue("@quantity", qty);
                                        insert.Parameters.AddWithValue("@price", totalPrice);

                                        insert.ExecuteNonQuery();
                                        MessageBox.Show("Item added to the cart.");

                                        string updateQuery = "UPDATE Inventory SET Quantity = Quantity - @quantity " +
                                                            "WHERE MenID = @id";

                                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, sp))
                                        {
                                            updateCmd.Parameters.AddWithValue("@id", menuId);
                                            updateCmd.Parameters.AddWithValue("@quantity", qty);

                                            updateCmd.ExecuteNonQuery();
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Insufficient quantity left in the inventory.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid price format in the Menu table.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No item found with this ID.");
                        }
                    }
                }
            }
        }

        private void RemovalCart_Click(object sender, EventArgs e)
        {
            string id = GcdIDT.Text;

            using (SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
            {
                sp.Open();


                string getOrderItemQuery = "SELECT itemname, quantity FROM OrdersItem WHERE id = @id";
                using (SqlCommand getOrderItemCmd = new SqlCommand(getOrderItemQuery, sp))
                {
                    getOrderItemCmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader rdr = getOrderItemCmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            string itemName = rdr.GetString(rdr.GetOrdinal("itemname"));
                            int quantity = rdr.GetInt32(rdr.GetOrdinal("quantity"));
                            rdr.Close();


                            string deleteOrderItemQuery = "DELETE FROM OrdersItem WHERE id = @id";
                            using (SqlCommand deleteOrderItemCmd = new SqlCommand(deleteOrderItemQuery, sp))
                            {
                                deleteOrderItemCmd.Parameters.AddWithValue("@id", id);
                                deleteOrderItemCmd.ExecuteNonQuery();
                            }

                            //nested subquery (7)
                            string updateInventoryQuery = "UPDATE Inventory SET quantity = quantity + @quantity " +
                                                          "WHERE MenID = (SELECT id FROM Menu WHERE name = @itemName)";
                            using (SqlCommand updateInventoryCmd = new SqlCommand(updateInventoryQuery, sp))
                            {
                                updateInventoryCmd.Parameters.AddWithValue("@quantity", quantity);
                                updateInventoryCmd.Parameters.AddWithValue("@itemName", itemName);

                                updateInventoryCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Item removed from the cart and quantity updated in the inventory.");
                        }
                        else
                        {
                            MessageBox.Show("No item found in the cart with this ID.");
                        }
                    }
                }
            }
        }

        private void GfinalCheckoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the balance field is empty
                if (string.IsNullOrWhiteSpace(GcuBalanceT.Text))
                {
                    MessageBox.Show("Please enter a valid balance.");
                    return;
                }

                decimal a;
                string balance = GcuBalanceT.Text;

                // Check if the balance is a valid decimal
                if (!decimal.TryParse(balance, out a))
                {
                    MessageBox.Show("Please enter a valid numeric balance.");
                    return;
                }

                using (SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    sp.Open();

                    // Aggregate function (3)
                    string calculateTotalQuery = "SELECT ISNULL(SUM(price), 0) AS totalAmount FROM OrdersItem";
                    using (SqlCommand calculateTotalCmd = new SqlCommand(calculateTotalQuery, sp))
                    {
                        decimal totalAmount = Convert.ToDecimal(calculateTotalCmd.ExecuteScalar());
                        a = totalAmount;

                        // Check if the balance is less than the total amount
                        if (Convert.ToDecimal(balance) < totalAmount)
                        {
                            MessageBox.Show("Payment is less than the total amount. Please enter a sufficient amount.");
                            return; // Exit the method
                        }

                        string insertOrderQuery = "INSERT INTO Orders(status, total_amount, date, Cu_ID, Me_ID, Gu_ID) " +
                                                  "VALUES (@status, @totalAmount, @orderDate, @cuId, @meId, @guId)";
                        using (SqlCommand insertOrderCmd = new SqlCommand(insertOrderQuery, sp))
                        {
                            insertOrderCmd.Parameters.AddWithValue("@status", "Pending");
                            insertOrderCmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                            insertOrderCmd.Parameters.AddWithValue("@orderDate", DateTime.Now.ToString());
                            insertOrderCmd.Parameters.AddWithValue("@cuId", DBNull.Value);
                            insertOrderCmd.Parameters.AddWithValue("@meId", 1);
                            insertOrderCmd.Parameters.AddWithValue("@guId", currentCustomerID);

                            insertOrderCmd.ExecuteNonQuery();
                            MessageBox.Show("Order placed successfully.");

                            string queryC = "UPDATE G_Customer SET Money=@balance where id=@currentCustomerID";
                            using (SqlCommand updateMo = new SqlCommand(queryC, sp))
                            {
                                updateMo.Parameters.AddWithValue("@balance", balance);
                                updateMo.Parameters.AddWithValue("@currentCustomerID", currentCustomerID);
                                updateMo.ExecuteNonQuery();
                            }

                            string clearOrdersItemQuery = "DELETE FROM OrdersItem";
                            using (SqlCommand clearOrdersItemCmd = new SqlCommand(clearOrdersItemQuery, sp))
                            {
                                clearOrdersItemCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                // Log the exception or perform additional error handling as needed
            }
        }

        private void GMenButton_Click(object sender, EventArgs e)
        {
            index = 0;
            panel[index].BringToFront();
        }

        private void GlogOutButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
