using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASE_Project
{
    public partial class ReceiptForm : Form
    {
        string forderID;
        public ReceiptForm(string orderID)
        {
            InitializeComponent();
            forderID = orderID;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            populateOrderID(forderID);
        }
        private void populateOrderID(string forderID)
        {
            try
            {
                using (SqlConnection sr = new SqlConnection("Data Source=DESKTOP-61MK1GI\\SQLEXPRESS;Initial Catalog=pr;Integrated Security=True"))
                {
                    sr.Open();
                    string id = forderID;
                    string query = $"SELECT OrderID, TotalAmount, PaidAmount, Change FROM Receipt WHERE OrderID = '{id}'";
                    using (SqlCommand sc = new SqlCommand(query, sr))
                    {
                        SqlDataReader reader = sc.ExecuteReader();
                        if (reader.Read())
                        {
                            reIDT.Text = reader["OrderID"].ToString();
                            tAmountT.Text = reader["TotalAmount"].ToString();
                            pAmountT.Text = reader["PaidAmount"].ToString();
                            cAmountT.Text = reader["Change"].ToString();
                        }
                        else
                        {
                            reIDT.Text = "-";
                            tAmountT.Text = "-";
                            pAmountT.Text = "-";
                            cAmountT.Text = "-";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void exButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cashmenu f = new Cashmenu(); ;
            f.Show();
            this.Hide();
        }

        private void reIDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cAmountT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
