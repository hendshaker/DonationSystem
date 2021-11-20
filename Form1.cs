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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NADA\\SQLEXPRESS;Initial Catalog=projectIS;Integrated Security=True");
        public static int id;
        public static string Log;
        public Form1()
        {
            InitializeComponent();
            panelAdmin.Hide();
            panelDonor.Hide();
            panelEmployee.Hide();
        }
        //Show panel according to specific user
        private void Go_Click(object sender, EventArgs e)
        {
            string Choice = SignUpChoice.Text.ToString();

            if (Choice == "Donor")
            {
                panelAdmin.Hide();
                panelDonor.Hide();
                panelEmployee.Hide();
                panelDonor.Show();
            }
            else if (Choice == "Employee")
            {
                panelAdmin.Hide();
                panelEmployee.Hide();
                panelDonor.Hide();
                panelEmployee.Show();
            }
            else if (Choice == "Admin")
            {
                panelDonor.Hide();
                panelAdmin.Hide();
                panelEmployee.Hide();
                panelAdmin.Show();
            }
        }
        //Sign up as an admin
        private void AdminSignUp_Click(object sender, EventArgs e)
        {
            con.Open();
            //Checking wether the username in our database or not
            string selectString = "select UserName from Admin";
            SqlCommand cmnd = new SqlCommand(selectString, con);

            cmnd.CommandType = CommandType.Text;
            SqlDataReader rdr = cmnd.ExecuteReader();
            bool isExist = false;
            while (rdr.Read())
            {
                string userName = (string)rdr["UserName"];
                userName = userName.Replace(" ","");

                if (userName == AdminUsernameText.Text)
                {
                    MessageBox.Show("Username already exists,Try another one");
                    isExist = true;
                }
            }
            rdr.Close();
            //Signing up if the username is unique
            if (isExist == false)
            {
                SqlCommand cmd = new SqlCommand("insertAdmin", con);
                cmd.CommandType = CommandType.StoredProcedure;

                string name = AdminNameText.Text;
                string username = AdminUsernameText.Text;
                string email = AdminEmailText.Text;
                string password = AdminPasswordText.Text;
                string confirmPassword = AdminConfirmpassText.Text;
                string phone = AdminPhoneText.Text;
                string gender = AdminGenderText.Text.ToString();
                //confirm that the password is correct 
                if (password == confirmPassword)
                {
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@userName", username));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@password", password));
                    cmd.Parameters.Add(new SqlParameter("@phone", phone));
                    cmd.Parameters.Add(new SqlParameter("@gender", gender));
                    MessageBox.Show("Signed up successfully, You can log in now");
                    cmd.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("Password Does not match.");
            }
            con.Close();
        }
        //Sign up employee
        private void EmpSignUp_Click(object sender, EventArgs e)
        {
            con.Open();
            //Checking wether the username in our database or not
            string selectString = "select UserName from Employee";
            SqlCommand cmnd = new SqlCommand(selectString, con);

            cmnd.CommandType = CommandType.Text;
            SqlDataReader rdr = cmnd.ExecuteReader();
            bool isExist = false;
            while (rdr.Read())
            {
                string userName = (string)rdr["UserName"];
                userName = userName.Replace(" ", "");
                
                if (userName == EmpUsernameText.Text)
                {
                    MessageBox.Show("Username already exists,Try another one");
                    isExist = true;
                }
            }
            rdr.Close();
            //Signing up if username is unique
            if (isExist == false)
            {
                SqlCommand cmd = new SqlCommand("Insertemp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                string name = EmpNameText.Text;
                string username = EmpUsernameText.Text;
                string email = EmpEmailText.Text;
                string password = EmpPassText.Text;
                string confirmPassword = EmpConfirmPassText.Text;
                string phone = EmpPhoneText.Text;
                string dep = EmpDepartmentText.Text;
                string gender = EmpGenderText.Text;
                //confirm that the password is correct
                if (password == confirmPassword)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@userName", username));
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@phone", phone));
                    cmd.Parameters.Add(new SqlParameter("@password", password));
                    cmd.Parameters.Add(new SqlParameter("@gender", gender));
                    cmd.Parameters.Add(new SqlParameter("@department", dep));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Signed up successfully, You can log in now");
                }
                else
                    MessageBox.Show("Password Does not match.");

                
            }
            con.Close();
        }
        //Sign up as a Donor
        private void DonorSignUp_Click(object sender, EventArgs e)
        {
            con.Open();
            //Checking wether the username in our database or not
            string selectString = "select UserName from Donor";
            SqlCommand cmnd = new SqlCommand(selectString, con);

            cmnd.CommandType = CommandType.Text;
            SqlDataReader rdr = cmnd.ExecuteReader();
            bool isExist = false;
            while (rdr.Read())
            {
                string userName = (string)rdr["UserName"];
                userName = userName.Replace(" ", "");

                if (userName == DonorUsernameText.Text)
                {
                    MessageBox.Show("Username already exists,Try another one");
                    isExist = true;
                }
            }
            rdr.Close();
            //Signing up if username is unique
            if (isExist == false)
            {
                SqlCommand cmd = new SqlCommand("SignUp", con);
                string name = DonorNameText.Text;
                string username = DonorUsernameText.Text;
                string email = DonorEmailText.Text;
                string password = DonorPasswordText.Text;
                string confirmPassword = DonorConfirmPassText.Text;
                string address = DonorAddressText.Text;
                string gender = DonorGenderText.Text;
                //Sign up if the password is correct
                if (password == confirmPassword)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@userName", username));
                    cmd.Parameters.Add(new SqlParameter("@name", name));
                    cmd.Parameters.Add(new SqlParameter("@email", email));
                    cmd.Parameters.Add(new SqlParameter("@password", password));
                    cmd.Parameters.Add(new SqlParameter("@address", address));
                    cmd.Parameters.Add(new SqlParameter("@gender", gender));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Signed up successfully, You can log in now");
                }
                else
                    MessageBox.Show("Password Does not match.");
            }
            con.Close();
        }

        private void Information_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Information = new Information();
            Information.Show();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            con.Open();
            string LogInAs = LogInText.Text.ToString();
            

            string log = "select UserName ,Password ," + LogInAs + "_ID from " + LogInAs;
            SqlCommand cmd = new SqlCommand(log, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            bool exist = false;
            while (reader.Read())
            {
                string User = UsernameLogin.Text;
                string Pass = PasswordLogin.Text;
                string username = (string)reader["UserName"];
                username = username.Replace(" ", "");
                string password = (string)reader["Password"];
                password = password.Replace(" ", "");
                //checking that username and password are correct 
                if (User==username)
                {
                    if (Pass == password)
                    {
                        exist = true;
                        id = (int)reader[LogInAs + "_ID"];
                        Log = username;
                    }
                }
            }
            reader.Close();
            if (exist == false)
            {
                MessageBox.Show("Please enter your information again!");
            }
            else
            {
                //Showing the panel according to the user
                this.Hide();
                if (LogInAs == "Donor")
                {
                    var Donor_Account = new Donor_Account();
                    Donor_Account.Show();
                }
                else if (LogInAs == "Employee")
                {
                    var Employee_Account = new Employee_Account();
                    Employee_Account.Show();
                }
                else
                {
                    var Admin_Account = new Admin_Account();
                    Admin_Account.Show();
                }
            }

            con.Close();
        }

    }
}

