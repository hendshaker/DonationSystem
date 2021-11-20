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
    public partial class Donor_Account : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NADA\\SQLEXPRESS;Initial Catalog=projectIS;Integrated Security=True");
        public Donor_Account()
        {
            InitializeComponent();
            panelEditInfo.Hide();
            EditPanel.Hide();
            panelDonationRequest.Hide();
            DonorDonationsGrid.Show();
            con.Open();
            DisplayDonations();
            con.Close();
            Welcome.Text = "Welcome," + Form1.Log;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DonationRequest", con);
            cmd.CommandType = CommandType.StoredProcedure;

            string Cate = CategoryText.Text.ToString();
            string Desc = DescriptionText.Text;
            string Date = Day.Text.ToString()+"/"+Month.Text.ToString() + "/"+"2018";
            string RecievingTime = RecievingTimeText.Text.ToString();
            
            SqlParameter Des = new SqlParameter("@Description",Desc);
            SqlParameter Cat = new SqlParameter("@CategoryName", Cate);
            SqlParameter date = new SqlParameter("@Date", Convert.ToDateTime(Date));
            SqlParameter Time = new SqlParameter("@RecievingTime", RecievingTime);
            SqlParameter ID = new SqlParameter("@ID", Form1.id);
            
            cmd.Parameters.Add(Des);
            cmd.Parameters.Add(Time);
            cmd.Parameters.Add(date);
            cmd.Parameters.Add(Cat);
            cmd.Parameters.Add(ID);
            MessageBox.Show("Request added successfully");

            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Delete donation using stored procedure
        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete_donation", con);
            cmd.CommandType = CommandType.StoredProcedure;
            int DonID = Convert.ToInt32(IDText.Text);
            cmd.Parameters.Add(new SqlParameter("DonationID", DonID));
            MessageBox.Show("Deleted successfully");
            cmd.ExecuteNonQuery();
            DisplayDonations();
            con.Close();
        }
        //Edit request using stored procedure
        private void EDITREQUEST_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update_request", con);
            cmd.CommandType = CommandType.StoredProcedure;
            string Desc = DescText.Text;
            string Date = DayText.Text + "/" + MonthText.Text + "/" + "2018";
            string RecievingTime = RecievingText.Text;
            SqlParameter description = new SqlParameter("@descripion", Desc);
            SqlParameter date = new SqlParameter("@date", Convert.ToDateTime(Date));
            SqlParameter recievingTime = new SqlParameter("@RecievingTime", RecievingTime);
            SqlParameter ID = new SqlParameter("@DonID", IDText.Text);

            cmd.Parameters.Add(description);
            cmd.Parameters.Add(date);
            cmd.Parameters.Add(recievingTime);
            cmd.Parameters.Add(ID);
            MessageBox.Show("Edited successfully");

            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Show current info of the donor in the textboxes
        private void EditInfo_Click(object sender, EventArgs e)
        {
            panelEditInfo.Hide();
            EditPanel.Hide();
            panelDonationRequest.Hide();
            DonorDonationsGrid.Hide();
            panelEditInfo.Show();
            con.Open();
            string EDIT = "select Name,UserName,Email,Password,Address,Gender from Donor where Donor_ID = " + Form1.id;
            SqlCommand cmnd = new SqlCommand(EDIT, con);
            cmnd.CommandType = CommandType.Text;
            SqlDataReader reader = cmnd.ExecuteReader();
            while (reader.Read())
            {
                DonorNameText.Text = (string)reader["Name"];
                DonorUsernameText.Text = (string)reader["UserName"];
                DonorEmailText.Text = (string)reader["Email"];
                DonorPasswordText.Text = (string)reader["Password"];
                DonorAddressText.Text = (string)reader["Address"];
                DonorGenderText.Text = (string)reader["Gender"];
            }
            reader.Close();
            con.Close();
        }
        //Edit info using stored procedure
        private void EditButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DonorInfo", con);
            cmd.CommandType = CommandType.StoredProcedure;
            string Name = DonorNameText.Text;
            string UserName = DonorUsernameText.Text;
            string Email = DonorEmailText.Text;
            string Password = DonorPasswordText.Text;
            string Address = DonorAddressText.Text;
            string Gender = DonorGenderText.Text;
            
            SqlParameter lsname = new SqlParameter("@name", Name);
            SqlParameter username = new SqlParameter("@username", UserName);
            SqlParameter email = new SqlParameter("@email", Email);
            SqlParameter pass = new SqlParameter("@password", Password);
            SqlParameter gender = new SqlParameter("@Gender", Gender);
            SqlParameter address = new SqlParameter("@address", Address);
            SqlParameter ID = new SqlParameter("@ID", Form1.id);
            cmd.Parameters.Add(username);
            cmd.Parameters.Add(lsname);
            cmd.Parameters.Add(email);
            cmd.Parameters.Add(pass);
            cmd.Parameters.Add(address);
            cmd.Parameters.Add(gender);
            cmd.Parameters.Add(ID);
            MessageBox.Show("Edited successfully");

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void DonationRequest_Click(object sender, EventArgs e)
        {
            panelEditInfo.Hide();
            EditPanel.Hide();
            panelDonationRequest.Hide();
            DonorDonationsGrid.Hide();
            panelDonationRequest.Show();
        }
        //Show current data of chosen donation in textboxes
        private void Edit_Click(object sender, EventArgs e)
        {
            panelEditInfo.Hide();
            EditPanel.Hide();
            panelDonationRequest.Hide();
            DonorDonationsGrid.Hide();
            EditPanel.Show();
            con.Open();
            string EDIT = "select Description,RecievingTime,Date from Donations where Don_ID = " + IDText.Text;
            SqlCommand cmnd = new SqlCommand(EDIT, con);
            cmnd.CommandType = CommandType.Text;
            SqlDataReader reader = cmnd.ExecuteReader();
            
            while (reader.Read())
            { 
                DescText.Text = (string)reader["Description"];
                
                DateTime date = (DateTime)reader["Date"];
                string Date = Convert.ToString(date);
                string Day = Date.Substring(1,2);
                string Month = Date.Substring(4,2);
                DayText.Text = Day;
                MonthText.Text = Month;

                RecievingText.Text = (string)reader["RecievingTime"];
            }
            reader.Close();
            con.Close();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Show();
        }
        //Filling table dt with the data from our database
        private void DisplayDonations()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select Don_ID,Description,RecievingTime,Date from Donations where Donor_ID = @id", con);
            adapt.SelectCommand.Parameters.AddWithValue("@id", Form1.id);
            adapt.Fill(dt);
            //Filling data in the grid
            DonorDonationsGrid.DataSource = dt;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            panelDonationRequest.Hide();
            panelEditInfo.Hide();
            EditPanel.Hide();
            con.Open();
            DisplayDonations();
            con.Close();
            DonorDonationsGrid.Show();
        }
    }
}

