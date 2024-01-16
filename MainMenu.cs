using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATABASE_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Sign_Up(object sender, EventArgs e)
        {
            
            SignUp sg = new SignUp();
            
            sg.Show();
            this.Hide();
        }

        private void Login(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void custButton_Click(object sender, EventArgs e)
        {
            CustomerLogin clk=new CustomerLogin();
            clk.Show();
            this.Hide();
        }

        private void menImage_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
           // pictureBox1.Load();

         //  gunaPictureBox1.LoadAsync();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
