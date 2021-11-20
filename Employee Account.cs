using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Donation_System
{
    public partial class Employee_Account : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NADA\\SQLEXPRESS;Initial Catalog=projectIS;Integrated Security=True");
        public Employee_Account()
        {
            InitializeComponent();
            ByCategory.Hide();
            con.Open();
            DisplayData();
            con.Close();
            Welcome.Text = "Welcome," + Form1.Log;
        }
        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
        }
        //Showing data by category name 
        private void DisplayDataByCategory()
        {
            DataTable dt = new DataTable();
            //Using two tables in database so we use inner join
            SqlDataAdapter adapt = new SqlDataAdapter("Select Donations.Description,RecievingTime,Date from Donations inner join Category on Donations.Cat_ID = Category.Cat_ID where Name = @name", con);
            string id = Category.Text;
            adapt.SelectCommand.Parameters.AddWithValue("@name", Category.Text);
            adapt.Fill(dt);
            ByCategory.DataSource = dt;
        }

        private void Show_Click(object sender, EventArgs e)
        {
            AllDonationsGrid.Hide();
            con.Open();
            DisplayDataByCategory();
            ByCategory.Show();
            con.Close();
        }
        //Showing all donations
        private void DisplayData()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select Description,RecievingTime,Date from Donations", con);
            adapt.Fill(dt);
            AllDonationsGrid.DataSource = dt;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            ByCategory.Hide();
            AllDonationsGrid.Show();
        }
    }
}
