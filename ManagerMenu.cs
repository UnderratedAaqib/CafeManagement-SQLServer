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
using static Guna.UI.WinForms.ShadowForm;

namespace DATABASE_Project
{
    public partial class ManagerMenu : Form
    {
        List<Panel> listPanel=new List<Panel> ();

        //#pragma warning disable CS0169 // The field 'ManagerMenu.index' is never used
        int index = 0;

        public ManagerMenu()
        {
            InitializeComponent();
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ManagerMenu_Load(object sender, EventArgs e)
        {

            listPanel.Add(welc);
            listPanel.Add(caMenu);
            listPanel.Add(meP);
            listPanel.Add(inPanel);
            listPanel.Add(fedP);
            listPanel.Add(reP);
            listPanel.Add(upDatePanel);
            listPanel.Add(SalesPanel);
            listPanel.Add(shCustomerPanel);
            listPanel[index].BringToFront();
            
            populateData();
            populateData1();
            populateData3();
            populateData4();
            populateData5();
            populateData6();
            populateData7();
            timer1.Start();
            //listPanel[index].BringToFront();
        }

        private void Cashier_Click(object sender, EventArgs e)
        {
            index = 1;
            listPanel[index].BringToFront();
        }

        private void Men(object sender, EventArgs e)
        {
            index = 2;
            listPanel[index].BringToFront();
            
        }

        private void CashierDetails_Click(object sender, EventArgs e)
        {

        }

        private void Ad_Click(object sender, EventArgs e)
        {

        }

        private void Re_Click(object sender, EventArgs e)
        {

        }

        private void FooItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void populateData()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
            string quer = $"SELECT * FROM Cashier";
            using (SqlCommand cmd = new SqlCommand(quer, sp))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cashierTable.DataSource = dt;


            }
            sp.Close();

        }
        private void populateData1()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
            string quer = $"SELECT * FROM Menu";
            using (SqlCommand cmd = new SqlCommand(quer, sp))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                menData.DataSource = dt;


            }
            sp.Close();

        }

        private void PopulateData2(string k)
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
//            int i = k;
            string quer = $"SELECT * FROM Menu where id=@k";
            using (SqlCommand cmd = new SqlCommand(quer, sp))
            {
                cmd.Parameters.AddWithValue("@k", k);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                upDatedMen.DataSource = dt;
                


            }
            sp.Close();


        }
        private void populateData3()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open(); //Two table join(3)
            string quer = $"SELECT i.InvId,m.name,i.quantity FROM Inventory i join Menu m on i.MenID=m.id";
            using (SqlCommand cmd = new SqlCommand(quer, sp))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                inventoryData.DataSource = dt;


            }
            sp.Close();

        }
        private void populateData4()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();//three table join(2)
            string quer = $"SELECT c.Username,f.Rating,f.Date_Submit,f.Comment,l.points FROM Customers c join Feedback f on c.CustID=f.Cu_ID join Loyalty_Point l on c.loyalty_id=l.id";
            using (SqlCommand cmd = new SqlCommand(quer, sp))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                feedBackData.DataSource = dt;


            }
            sp.Close();

        }
        private void populateData5()
        {
            try
            {
                using (SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    sp.Open();

                    string query = "SELECT COALESCE(c.Username, g.name) AS CustomerName, o.OrderID, o.total_amount, o.status AS OrderTotalAmount, r.ReceiptDate, r.TotalAmount AS ReceiptTotalAmount " +
                                   "FROM Orders o " +
                                   "LEFT JOIN Customers c ON o.Cu_ID = c.CustID " +
                                   "LEFT JOIN G_Customer g ON o.Gu_ID = g.id " +
                                   "LEFT JOIN Receipt r ON o.OrderID = r.OrderID";

                    using (SqlCommand cmd = new SqlCommand(query, sp))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        reportTable.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions or log errors as needed
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void populateData6()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
            //Aggregate Function(3)
            string query = "SELECT CONVERT(date, o.date) AS OrderDate, " +
                   "       COUNT(o.OrderID) AS TotalOrders, " +
                   "       SUM(o.total_amount) AS TotalSales " +
                   "FROM Orders o " +
                   "GROUP BY CONVERT(date, o.date)";


            using (SqlCommand cmd = new SqlCommand(query, sp))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                salesData.DataSource = dt;
            }

            sp.Close();
        }
        private void populateData7()
        {
            SqlConnection sp = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sp.Open();
            //Three Table join(2)
            string query = "SELECT O.OrderID,O.date,Customers.Username,G_Customer.name,O.total_amount FROM Orders O JOIN Customers ON O.Cu_ID = Customers.CustID LEFT JOIN G_Customer ON O.Gu_ID = G_Customer.id";
            ;


            using (SqlCommand cmd = new SqlCommand(query, sp))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cuData.DataSource = dt;
            }

            sp.Close();
        }

        private void InBu_Click(object sender, EventArgs e)
        {
            index = 3;
            listPanel[index].BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Fe_Click(object sender, EventArgs e)
        {
            //listPanel[3].BringToFront();
            index = 4;
            listPanel[index].BringToFront();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //reportPanel.Visible = true;
            index = 5;
            listPanel[index].BringToFront();
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void WelMen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ad_Click_1(object sender, EventArgs e)
        {
            CashSignU cs=new CashSignU();
            cs.Show();
            this.Hide();
        }

        private void Re_Click_1(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");

            try
            {
                sq.Open();
                string rmID = rmbox.Text;

                
                if (string.IsNullOrWhiteSpace(rmID))
                {
                    MessageBox.Show("Please enter a Cashier ID to delete.");
                    return;
                }
                //Nested subquery(2)
                string deleteQuery = "DELETE FROM CASHIER WHERE EmployeeID = (SELECT EmployeeID FROM Cashier WHERE EmployeeID = @rmID)";

                using (SqlCommand sc = new SqlCommand(deleteQuery, sq))
                {
                    sc.Parameters.AddWithValue("@rmID", rmID);
                    int rowsAffected = sc.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cashier successfully deleted!");
                    }
                    else
                    {
                        MessageBox.Show("No cashier found with this ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (sq.State == ConnectionState.Open)
                    sq.Close();
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            populateData();
            populateData1();
            populateData3();
            populateData4();
            populateData5();
            populateData6();
            populateData7();
            timer1.Start();
        }

        private void rmbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void seBu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sr = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
                sr.Open();
                string id = srID.Text;
                string quer1 = $"Select name from Menu where id=@id";
                using (SqlCommand sc = new SqlCommand(quer1, sr))
                {
                    sc.Parameters.AddWithValue("@id", id);
                    object result = sc.ExecuteScalar();
                    if (result != null)
                    {
                        searchedITEM.Text = result.ToString();
                       

                    }
                    else
                    {
                        searchedITEM.Text = "-";
                    }
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void seLb_Click(object sender, EventArgs e)
        {

        }

        private void adBu_Click(object sender, EventArgs e)
        {
            MenuItems ms = new MenuItems();
            ms.Show();
            this.Hide();
        }

        private void menData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void upPrice_Click(object sender, EventArgs e)
        {
            string result = updID.Text;
            PopulateData2(result);
            index = 6;
            listPanel[index].BringToFront();

        }

        private void rmvIt_Click(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");

            try
            {
                sq.Open();
                string rmID = rmvID.Text;

                // Check for empty string
                if (string.IsNullOrEmpty(rmID))
                {
                    MessageBox.Show("Please enter a valid ID.");
                    return;
                }
                //nested subquery(3)
                string deleteQuery = "DELETE FROM Menu WHERE id = (SELECT ID FROM MENU WHERE id = @rmID)";

                using (SqlCommand sc = new SqlCommand(deleteQuery, sq))
                {
                    sc.Parameters.AddWithValue("@rmID", rmID);
                    int rowsAffected = sc.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item successfully deleted!");
                    }
                    else
                    {
                        MessageBox.Show("No menu with this ID");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (sq.State == ConnectionState.Open)
                    sq.Close();
            }
        }


        private void upIt_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string pr = itPrice.Text;
            string id = updID.Text;
            string name = upITName.Text;
            string description = itDpT.Text;
            string calories = itCaloriesT.Text;

            // Check if ID is empty
            if(string.IsNullOrEmpty(pr) && string.IsNullOrEmpty(name) && string.IsNullOrEmpty(description) && string.IsNullOrEmpty(calories))
            {
                MessageBox.Show("Nothing is updated");
                return;
                
            }
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter the ID to update.");
                return;
            }

            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True");
            sq.Open();

            string query = "Update Menu SET";

            
            if (!string.IsNullOrEmpty(pr))
            {
                query += " Price=@pr,";
            }

           
            if (!string.IsNullOrEmpty(name))
            {
                query += " name=@name,";
            }

           
            if (!string.IsNullOrEmpty(description))
            {
                query += " Description=@description,";
            }

           
            if (!string.IsNullOrEmpty(calories))
            {
                query += " NuInformation=@calories,";
            }

           
            query = query.TrimEnd(',');

            
            query += " WHERE id=@id";

            using (SqlCommand sc = new SqlCommand(query, sq))
            {
               
                if (!string.IsNullOrEmpty(pr))
                {
                    sc.Parameters.AddWithValue("@pr", pr);
                }

                if (!string.IsNullOrEmpty(name))
                {
                    sc.Parameters.AddWithValue("@name", name);
                }

                if (!string.IsNullOrEmpty(description))
                {
                    sc.Parameters.AddWithValue("@description", description);
                }

                if (!string.IsNullOrEmpty(calories))
                {
                    sc.Parameters.AddWithValue("@calories", calories);
                }

                sc.Parameters.AddWithValue("@id", id);

                int rowsAffected = sc.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item successfully updated!");
                }
                else
                {
                    MessageBox.Show("No item found with the specified ID.");
                }
            }
            PopulateData2(id) ;
            sq.Close();
        }

        private void idLab_Click(object sender, EventArgs e)
        {

        }

        private void upDateLabel_Click(object sender, EventArgs e)
        {
            string id = upT.Text;
            string amount = amountT.Text;

            // Check if either ID or amount is empty
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(amount))
            {
                MessageBox.Show("Please enter both ID and amount before updating.");
                return;
            }

            try
            {
                using (SqlConnection sq = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    sq.Open();
                    string query = $"UPDATE Inventory SET quantity=@amount where InvId=@id";

                    using (SqlCommand sc = new SqlCommand(query, sq))
                    {
                        sc.Parameters.AddWithValue("@id", id);
                        sc.Parameters.AddWithValue("@amount", amount);

                        int rowsAffected = sc.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item successfully updated!");
                        }
                        else
                        {
                            MessageBox.Show("No item found with the specified ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void meP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            index = 7;
            listPanel[index].BringToFront();
        }

        private void MlogOutButton_Click(object sender, EventArgs e)
        {
            Form1 mn = new Form1();
            mn.Show();
            this.Hide();
        }

        private void fedP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void custButton_Click(object sender, EventArgs e)
        {
            index = 8;
            listPanel[index].BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CashierInformation cashier = new CashierInformation();
            cashier.Show();
            this.Hide();
        }

        private void highestCustomer_Click(object sender, EventArgs e)
        {
            HighestCustomer hs = new HighestCustomer();
            hs.Show();
            this.Hide();
        }
    }
}
