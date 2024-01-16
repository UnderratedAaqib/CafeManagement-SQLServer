using System;
using System.Collections;
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
    public partial class Customer : Form
    {
        List<Panel> panel = new List<Panel>();
        int index = 0;
        public int currentCustomerID;
        public Customer(string username)
        {
            InitializeComponent();
            currentCustomerID = GetCustomerIdByUsername(username);
        }
        private int GetCustomerIdByUsername(string username)
        {
            using (SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
            {
                sp.Open();

                
                string query = "SELECT CustID FROM Customers WHERE Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, sp))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    
                    object result = cmd.ExecuteScalar();

                   
                    if (result != null && int.TryParse(result.ToString(), out int customerId))
                    {
                        return customerId;
                    }
                }
                sp.Close();
            }
            
            return 0;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            panel.Add(cuWelcPanel);
            panel.Add(cumenPanel);
            panel.Add(loyalPanel);
            panel.Add(feedPanel);
            panel.Add(CartPanel);
            panel[index].BringToFront();
            populateMenu();
            populateCart();
            populateLoyalty();
            populateAmount();
            timer2.Start();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void populateMenu()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
            string quer = $"SELECT * FROM Menu";
            using (SqlCommand cmd = new SqlCommand(quer, sp))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                customerMenu.DataSource = dt;


            }
            sp.Close();

        }
        private void populateLoyalty()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
            string quer = $"SELECT * FROM Loyalty_Point where id=@currentCustomerID";
            using (SqlCommand cmd = new SqlCommand(quer, sp))
            {
                cmd.Parameters.AddWithValue("@currentCustomerID", currentCustomerID);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                loyaPoints.DataSource = dt;


            }
            sp.Close();

        }
        private void populateCart()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
            string quer = $"SELECT id,itemname,quantity,price FROM OrdersItem";
            using (SqlCommand cmd = new SqlCommand(quer, sp))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cartData.DataSource = dt;


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
                    
                    ctAmountT.Text = reader["TotalAmount"].ToString();
                    
                }
                else
                {
                   
                    ctAmountT.Text = "-";
                   
                }
            }
            sp.Close();


        }

        private void cuMenu_Click(object sender, EventArgs e)
        {
            index = 1;
            panel[index].BringToFront();
        }

        private void loyaltyPoints_Click(object sender, EventArgs e)
        {
            index = 2;
            panel[index].BringToFront();
        }

        private void feCustomers_Click(object sender, EventArgs e)
        {
            index = 3;
            panel[index].BringToFront();
        }

        private void cumenPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            populateMenu();
            populateCart();
            populateLoyalty();
            populateAmount();
            timer2.Start();
        }

        private void addCartIt_Click(object sender, EventArgs e)
        {
            string id = ordIDT.Text;
            string qty = quanT.Text;

            using (SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
            {
                try
                {
                    sp.Open();
                    //two table join(1)

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
                    //two table join(2)
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
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (sp.State == ConnectionState.Open)
                        sp.Close();
                }
            }
        }



        private void cartButton_Click(object sender, EventArgs e)
        {
            index = 4;
            panel[index].BringToFront();
        }

        private void cartData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemovalCart_Click(object sender, EventArgs e)
        {
            string id = cdIDT.Text;

            using (SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
            {
                try
                {
                    sp.Open();
                    //Remove item quantity and update in inventory as well
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
                                //nested subquery(1)
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
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (sp.State == ConnectionState.Open)
                        sp.Close();
                }
            }
        }
        private string DetermineLevel(int loyaltyPoints)
        {
            if (loyaltyPoints > 50)
            {
                return "Conqueror";
            }
            else if (loyaltyPoints > 30)
            {
                return "Ace";
            }
            else
            {
                return "Basic";
            }
        }

        private void finalCheckoutButton_Click(object sender, EventArgs e)
        {
            decimal a;
            string balance = cuBalanceT.Text;

            using (SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
            {
                try
                {
                    sp.Open();

                    // Aggregate(1)
                    string calculateTotalQuery = "SELECT ISNULL(SUM(price), 0) AS totalAmount FROM OrdersItem";
                    using (SqlCommand calculateTotalCmd = new SqlCommand(calculateTotalQuery, sp))
                    {
                        decimal totalAmount = Convert.ToDecimal(calculateTotalCmd.ExecuteScalar());
                        a = totalAmount;

                        if (Convert.ToDecimal(balance) < totalAmount)
                        {
                            MessageBox.Show("Payment is less than the total amount. Please enter a sufficient amount.");
                            return; // Exit the method
                        }

                        // Insert into Orders table
                        string insertOrderQuery = "INSERT INTO Orders(status, total_amount, date, Cu_ID, Me_ID, Gu_ID) " +
                                                  "VALUES (@status, @totalAmount, @orderDate, @cuId, @meId, @guId)";
                        using (SqlCommand insertOrderCmd = new SqlCommand(insertOrderQuery, sp))
                        {
                            insertOrderCmd.Parameters.AddWithValue("@status", "Pending"); // Adjust as needed
                            insertOrderCmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                            insertOrderCmd.Parameters.AddWithValue("@orderDate", DateTime.Now.ToString()); // Assuming date is stored as a string
                            insertOrderCmd.Parameters.AddWithValue("@cuId", currentCustomerID); // Replace with actual customer ID
                            insertOrderCmd.Parameters.AddWithValue("@meId", 1); // Replace with actual menu ID
                            insertOrderCmd.Parameters.AddWithValue("@guId", DBNull.Value); // Replace with actual G_Customer ID

                            insertOrderCmd.ExecuteNonQuery();
                            MessageBox.Show("Order placed successfully.");

                            string queryC = "UPDATE Customers SET Money=@balance where CustID=@currentCustomerID";
                            using (SqlCommand updateMo = new SqlCommand(queryC, sp))
                            {
                                updateMo.Parameters.AddWithValue("@balance", balance);
                                updateMo.Parameters.AddWithValue("@currentCustomerID", currentCustomerID);
                                updateMo.ExecuteNonQuery();
                            }

                            // Optionally, you can add additional functionality here.
                            // For example, clearing the OrdersItem table after placing the order:
                            string clearOrdersItemQuery = "DELETE FROM OrdersItem";
                            using (SqlCommand clearOrdersItemCmd = new SqlCommand(clearOrdersItemQuery, sp))
                            {
                                clearOrdersItemCmd.ExecuteNonQuery();
                            }
                        }
                    }
                    MessageBox.Show("Thanks for ordering, your delicious order is preparing. This wait would be worthwile :) ");
                    UpdateLoyaltyPoints(currentCustomerID, a);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (sp.State == ConnectionState.Open)
                        sp.Close();
                }
            }
        }

        private void UpdateLoyaltyPoints(int customerId, decimal totalAmount)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
            {
                try
                {
                    connection.Open();
                    //Aggregate(2)
                    int customerId1 = currentCustomerID;
                    string checkRecordQuery = "SELECT COUNT(*) FROM Loyalty_Point WHERE id = @customerId";
                    using (SqlCommand checkRecordCmd = new SqlCommand(checkRecordQuery, connection))
                    {
                        checkRecordCmd.Parameters.AddWithValue("@customerId", customerId1);
                        int recordCount = Convert.ToInt32(checkRecordCmd.ExecuteScalar());

                        int loyaltyPoints = (int)(totalAmount / 20);

                        if (recordCount > 0)
                        {
                            string updateLoyaltyPointsQuery = "UPDATE Loyalty_Point SET points = points + @pointsToAdd WHERE id = @customerId1";
                            using (SqlCommand updateCmd = new SqlCommand(updateLoyaltyPointsQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@pointsToAdd", loyaltyPoints);
                                updateCmd.Parameters.AddWithValue("@customerId1", customerId1);

                                updateCmd.ExecuteNonQuery();
                            }

                            string updatedLevel = DetermineLevel(GetCurrentPoints(connection, customerId1));
                            UpdateLevel(connection, customerId1, updatedLevel);
                        }
                        else
                        {
                            string insertLoyaltyPointsQuery = "INSERT INTO Loyalty_Point (id, c_level, points) VALUES (@customerId1, @level, @loyaltyPoints)";
                            using (SqlCommand insertCmd = new SqlCommand(insertLoyaltyPointsQuery, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@loyaltyPoints", loyaltyPoints);
                                insertCmd.Parameters.AddWithValue("@level", DetermineLevel(loyaltyPoints));
                                insertCmd.Parameters.AddWithValue("@customerId1", customerId1);

                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred in loyalty points update: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        private int GetCurrentPoints(SqlConnection connection, int customerId)
        {
            string getCurrentPointsQuery = "SELECT points FROM Loyalty_Point WHERE id = @customerId";
            using (SqlCommand getCurrentPointsCmd = new SqlCommand(getCurrentPointsQuery, connection))
            {
                getCurrentPointsCmd.Parameters.AddWithValue("@customerId", customerId);
                return Convert.ToInt32(getCurrentPointsCmd.ExecuteScalar());
            }
        }

        private void UpdateLevel(SqlConnection connection, int customerId, string level)
        {
            string updateLevelQuery = "UPDATE Loyalty_Point SET c_level = @level WHERE id = @customerId";
            using (SqlCommand updateLevelCmd = new SqlCommand(updateLevelQuery, connection))
            {
                updateLevelCmd.Parameters.AddWithValue("@level", level);
                updateLevelCmd.Parameters.AddWithValue("@customerId", customerId);

                updateLevelCmd.ExecuteNonQuery();
            }
        }


        private void subMitFeedBack_Click(object sender, EventArgs e)
        {
            string id = feedBackIDT.Text;
            string rating = feedBackRatingT.Text;
            string date = feedBackDateT.Text;
            string comment = feedBackCommentT.Text;

            // Check for null values
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(rating) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(comment))
            {
                MessageBox.Show("Please fill in all the fields before submitting feedback.");
                return;
            }

            using (SqlConnection co = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
            {
                try
                {
                    co.Open();
                   
                    SqlCommand cm;

                    string query = "Insert into Feedback(ID, Rating, Date_Submit, Comment, Cu_ID) " +
                                   $"values ('{id}', '{rating}', '{date}', '{comment}', '{currentCustomerID}')";

                    cm = new SqlCommand(query, co);
                    cm.ExecuteNonQuery();
                    cm.Dispose();
                    MessageBox.Show("Feedback successfully given!");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            MainMenu cs = new MainMenu();
            cs.Show();
            this.Hide();
        }

        private void CartPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}