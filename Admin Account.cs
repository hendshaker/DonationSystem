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
    public partial class Admin_Account : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NADA\\SQLEXPRESS;Initial Catalog=projectIS;Integrated Security=True");
        public Admin_Account()
        {
            InitializeComponent();
            DisplayData();
            Welcome.Text = "Welcome," + Form1.Log;
        }
        //Delete donor with given donor id
        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete_Donor", con);
            cmd.CommandType = CommandType.StoredProcedure;

            string delete = DeleteText.Text;
            cmd.Parameters.Add(new SqlParameter("@Donor_ID", delete));
            MessageBox.Show("Deleted successfully");
            cmd.ExecuteNonQuery();
            DisplayData();
            con.Close();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
        }
        //Filling table dt with the data from our database
        private void DisplayData()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select Donor_ID,UserName,Name,Email,Password,Address,Gender from Donor", con);
            adapt.Fill(dt);
            //Showing it in the grid
            donor_info.DataSource = dt;
        }
    }
}
