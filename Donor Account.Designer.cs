
namespace Donation_System
{
    partial class Donor_Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Donor_Account));
            this.DonationRequest = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.panelDonationRequest = new System.Windows.Forms.Panel();
            this.RecievingTimeText = new System.Windows.Forms.ComboBox();
            this.RecievingTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Month = new System.Windows.Forms.ComboBox();
            this.RecievingDate = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.CategoryText = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.EditInfo = new System.Windows.Forms.Button();
            this.IDText = new System.Windows.Forms.TextBox();
            this.panelEditInfo = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.DonorAddressText = new System.Windows.Forms.TextBox();
            this.DonorConfirmPassText = new System.Windows.Forms.TextBox();
            this.DonorPasswordText = new System.Windows.Forms.TextBox();
            this.DonorEmailText = new System.Windows.Forms.TextBox();
            this.DonorGenderText = new System.Windows.Forms.ComboBox();
            this.DonorGender = new System.Windows.Forms.Label();
            this.DonorUsernameText = new System.Windows.Forms.TextBox();
            this.DonorAddress = new System.Windows.Forms.Label();
            this.DonorConfirmPass = new System.Windows.Forms.Label();
            this.DonorPassword = new System.Windows.Forms.Label();
            this.DonorEmail = new System.Windows.Forms.Label();
            this.DonorUsername = new System.Windows.Forms.Label();
            this.DonorName = new System.Windows.Forms.Label();
            this.DonorNameText = new System.Windows.Forms.TextBox();
            this.DonorDonationsGrid = new System.Windows.Forms.DataGridView();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.RecievingText = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YearText = new System.Windows.Forms.Label();
            this.DayText = new System.Windows.Forms.ComboBox();
            this.MonthText = new System.Windows.Forms.ComboBox();
            this.RecievingDText = new System.Windows.Forms.Label();
            this.DescText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EDITREQUEST = new System.Windows.Forms.Button();
            this.DeleteOrEdit = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.panelDonationRequest.SuspendLayout();
            this.panelEditInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorDonationsGrid)).BeginInit();
            this.EditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DonationRequest
            // 
            this.DonationRequest.BackColor = System.Drawing.Color.DarkSalmon;
            this.DonationRequest.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonationRequest.Location = new System.Drawing.Point(352, 9);
            this.DonationRequest.Name = "DonationRequest";
            this.DonationRequest.Size = new System.Drawing.Size(148, 30);
            this.DonationRequest.TabIndex = 0;
            this.DonationRequest.Text = "Donation Request";
            this.DonationRequest.UseVisualStyleBackColor = false;
            this.DonationRequest.Click += new System.EventHandler(this.DonationRequest_Click);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.DarkSalmon;
            this.LogOut.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(506, 9);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 30);
            this.LogOut.TabIndex = 1;
            this.LogOut.Text = "Logout";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkSalmon;
            this.Delete.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(410, 377);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(88, 27);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete ";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.DarkSalmon;
            this.Edit.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(504, 377);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 27);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.DarkSalmon;
            this.Welcome.Location = new System.Drawing.Point(12, 11);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(90, 22);
            this.Welcome.TabIndex = 4;
            this.Welcome.Text = "Welcome";
            // 
            // panelDonationRequest
            // 
            this.panelDonationRequest.Controls.Add(this.RecievingTimeText);
            this.panelDonationRequest.Controls.Add(this.RecievingTime);
            this.panelDonationRequest.Controls.Add(this.label6);
            this.panelDonationRequest.Controls.Add(this.label5);
            this.panelDonationRequest.Controls.Add(this.Year);
            this.panelDonationRequest.Controls.Add(this.Day);
            this.panelDonationRequest.Controls.Add(this.Month);
            this.panelDonationRequest.Controls.Add(this.RecievingDate);
            this.panelDonationRequest.Controls.Add(this.DescriptionText);
            this.panelDonationRequest.Controls.Add(this.Description);
            this.panelDonationRequest.Controls.Add(this.CategoryText);
            this.panelDonationRequest.Controls.Add(this.Category);
            this.panelDonationRequest.Controls.Add(this.Done);
            this.panelDonationRequest.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDonationRequest.Location = new System.Drawing.Point(13, 69);
            this.panelDonationRequest.Name = "panelDonationRequest";
            this.panelDonationRequest.Size = new System.Drawing.Size(550, 283);
            this.panelDonationRequest.TabIndex = 5;
            // 
            // RecievingTimeText
            // 
            this.RecievingTimeText.FormattingEnabled = true;
            this.RecievingTimeText.Items.AddRange(new object[] {
            "00:09AM",
            "00:10AM",
            "00:11AM",
            "00:12PM",
            "00:01PM",
            "00:02PM",
            "00:03PM",
            "00:04PM",
            "00:05PM",
            "00:06PM",
            "00:07PM"});
            this.RecievingTimeText.Location = new System.Drawing.Point(162, 209);
            this.RecievingTimeText.Name = "RecievingTimeText";
            this.RecievingTimeText.Size = new System.Drawing.Size(60, 25);
            this.RecievingTimeText.TabIndex = 5;
            // 
            // RecievingTime
            // 
            this.RecievingTime.AutoSize = true;
            this.RecievingTime.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecievingTime.Location = new System.Drawing.Point(22, 214);
            this.RecievingTime.Name = "RecievingTime";
            this.RecievingTime.Size = new System.Drawing.Size(134, 17);
            this.RecievingTime.TabIndex = 16;
            this.RecievingTime.Text = "Recieving time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(299, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "/";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.Location = new System.Drawing.Point(322, 177);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(44, 17);
            this.Year.TabIndex = 13;
            this.Year.Text = "2018";
            // 
            // Day
            // 
            this.Day.FormattingEnabled = true;
            this.Day.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Day.Location = new System.Drawing.Point(162, 174);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(43, 25);
            this.Day.TabIndex = 3;
            // 
            // Month
            // 
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.Month.Location = new System.Drawing.Point(233, 174);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(60, 25);
            this.Month.TabIndex = 4;
            // 
            // RecievingDate
            // 
            this.RecievingDate.AutoSize = true;
            this.RecievingDate.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecievingDate.Location = new System.Drawing.Point(22, 177);
            this.RecievingDate.Name = "RecievingDate";
            this.RecievingDate.Size = new System.Drawing.Size(134, 17);
            this.RecievingDate.TabIndex = 9;
            this.RecievingDate.Text = "Recieving date";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(162, 74);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(317, 89);
            this.DescriptionText.TabIndex = 2;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(19, 58);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(107, 17);
            this.Description.TabIndex = 7;
            this.Description.Text = "Description";
            // 
            // CategoryText
            // 
            this.CategoryText.FormattingEnabled = true;
            this.CategoryText.Items.AddRange(new object[] {
            "Money",
            "Clothes ",
            "Food",
            "Books"});
            this.CategoryText.Location = new System.Drawing.Point(162, 18);
            this.CategoryText.Name = "CategoryText";
            this.CategoryText.Size = new System.Drawing.Size(121, 25);
            this.CategoryText.TabIndex = 1;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(19, 21);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(80, 17);
            this.Category.TabIndex = 1;
            this.Category.Text = "Category";
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.DarkSalmon;
            this.Done.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(404, 214);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 25);
            this.Done.TabIndex = 6;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // EditInfo
            // 
            this.EditInfo.BackColor = System.Drawing.Color.DarkSalmon;
            this.EditInfo.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditInfo.Location = new System.Drawing.Point(235, 9);
            this.EditInfo.Name = "EditInfo";
            this.EditInfo.Size = new System.Drawing.Size(111, 30);
            this.EditInfo.TabIndex = 0;
            this.EditInfo.Text = "Edit my info";
            this.EditInfo.UseVisualStyleBackColor = false;
            this.EditInfo.Click += new System.EventHandler(this.EditInfo_Click);
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(329, 379);
            this.IDText.Multiline = true;
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(66, 23);
            this.IDText.TabIndex = 9;
            // 
            // panelEditInfo
            // 
            this.panelEditInfo.Controls.Add(this.EditButton);
            this.panelEditInfo.Controls.Add(this.DonorAddressText);
            this.panelEditInfo.Controls.Add(this.DonorConfirmPassText);
            this.panelEditInfo.Controls.Add(this.DonorPasswordText);
            this.panelEditInfo.Controls.Add(this.DonorEmailText);
            this.panelEditInfo.Controls.Add(this.DonorGenderText);
            this.panelEditInfo.Controls.Add(this.DonorGender);
            this.panelEditInfo.Controls.Add(this.DonorUsernameText);
            this.panelEditInfo.Controls.Add(this.DonorAddress);
            this.panelEditInfo.Controls.Add(this.DonorConfirmPass);
            this.panelEditInfo.Controls.Add(this.DonorPassword);
            this.panelEditInfo.Controls.Add(this.DonorEmail);
            this.panelEditInfo.Controls.Add(this.DonorUsername);
            this.panelEditInfo.Controls.Add(this.DonorName);
            this.panelEditInfo.Controls.Add(this.DonorNameText);
            this.panelEditInfo.Location = new System.Drawing.Point(18, 69);
            this.panelEditInfo.Name = "panelEditInfo";
            this.panelEditInfo.Size = new System.Drawing.Size(552, 280);
            this.panelEditInfo.TabIndex = 10;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.EditButton.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(381, 208);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(84, 29);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DonorAddressText
            // 
            this.DonorAddressText.Location = new System.Drawing.Point(101, 175);
            this.DonorAddressText.Name = "DonorAddressText";
            this.DonorAddressText.Size = new System.Drawing.Size(225, 20);
            this.DonorAddressText.TabIndex = 6;
            // 
            // DonorConfirmPassText
            // 
            this.DonorConfirmPassText.Location = new System.Drawing.Point(365, 143);
            this.DonorConfirmPassText.Name = "DonorConfirmPassText";
            this.DonorConfirmPassText.Size = new System.Drawing.Size(100, 20);
            this.DonorConfirmPassText.TabIndex = 5;
            // 
            // DonorPasswordText
            // 
            this.DonorPasswordText.Location = new System.Drawing.Point(101, 142);
            this.DonorPasswordText.Name = "DonorPasswordText";
            this.DonorPasswordText.Size = new System.Drawing.Size(100, 20);
            this.DonorPasswordText.TabIndex = 4;
            // 
            // DonorEmailText
            // 
            this.DonorEmailText.Location = new System.Drawing.Point(101, 110);
            this.DonorEmailText.Name = "DonorEmailText";
            this.DonorEmailText.Size = new System.Drawing.Size(225, 20);
            this.DonorEmailText.TabIndex = 3;
            // 
            // DonorGenderText
            // 
            this.DonorGenderText.AllowDrop = true;
            this.DonorGenderText.FormattingEnabled = true;
            this.DonorGenderText.Items.AddRange(new object[] {
            "Male ",
            "Female"});
            this.DonorGenderText.Location = new System.Drawing.Point(101, 208);
            this.DonorGenderText.Name = "DonorGenderText";
            this.DonorGenderText.Size = new System.Drawing.Size(121, 21);
            this.DonorGenderText.TabIndex = 7;
            // 
            // DonorGender
            // 
            this.DonorGender.AutoSize = true;
            this.DonorGender.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorGender.Location = new System.Drawing.Point(15, 208);
            this.DonorGender.Name = "DonorGender";
            this.DonorGender.Size = new System.Drawing.Size(62, 17);
            this.DonorGender.TabIndex = 11;
            this.DonorGender.Text = "Gender";
            // 
            // DonorUsernameText
            // 
            this.DonorUsernameText.Location = new System.Drawing.Point(101, 77);
            this.DonorUsernameText.Name = "DonorUsernameText";
            this.DonorUsernameText.Size = new System.Drawing.Size(100, 20);
            this.DonorUsernameText.TabIndex = 2;
            // 
            // DonorAddress
            // 
            this.DonorAddress.AutoSize = true;
            this.DonorAddress.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorAddress.Location = new System.Drawing.Point(15, 175);
            this.DonorAddress.Name = "DonorAddress";
            this.DonorAddress.Size = new System.Drawing.Size(71, 17);
            this.DonorAddress.TabIndex = 8;
            this.DonorAddress.Text = "Address";
            // 
            // DonorConfirmPass
            // 
            this.DonorConfirmPass.AutoSize = true;
            this.DonorConfirmPass.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorConfirmPass.Location = new System.Drawing.Point(207, 143);
            this.DonorConfirmPass.Name = "DonorConfirmPass";
            this.DonorConfirmPass.Size = new System.Drawing.Size(152, 17);
            this.DonorConfirmPass.TabIndex = 7;
            this.DonorConfirmPass.Text = "Confirm Password";
            // 
            // DonorPassword
            // 
            this.DonorPassword.AutoSize = true;
            this.DonorPassword.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorPassword.Location = new System.Drawing.Point(15, 145);
            this.DonorPassword.Name = "DonorPassword";
            this.DonorPassword.Size = new System.Drawing.Size(80, 17);
            this.DonorPassword.TabIndex = 6;
            this.DonorPassword.Text = "Password";
            // 
            // DonorEmail
            // 
            this.DonorEmail.AutoSize = true;
            this.DonorEmail.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorEmail.Location = new System.Drawing.Point(15, 113);
            this.DonorEmail.Name = "DonorEmail";
            this.DonorEmail.Size = new System.Drawing.Size(62, 17);
            this.DonorEmail.TabIndex = 5;
            this.DonorEmail.Text = "E-mail";
            // 
            // DonorUsername
            // 
            this.DonorUsername.AutoSize = true;
            this.DonorUsername.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorUsername.Location = new System.Drawing.Point(15, 77);
            this.DonorUsername.Name = "DonorUsername";
            this.DonorUsername.Size = new System.Drawing.Size(80, 17);
            this.DonorUsername.TabIndex = 4;
            this.DonorUsername.Text = "Username";
            // 
            // DonorName
            // 
            this.DonorName.AutoSize = true;
            this.DonorName.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorName.Location = new System.Drawing.Point(15, 39);
            this.DonorName.Name = "DonorName";
            this.DonorName.Size = new System.Drawing.Size(44, 17);
            this.DonorName.TabIndex = 2;
            this.DonorName.Text = "Name";
            // 
            // DonorNameText
            // 
            this.DonorNameText.Location = new System.Drawing.Point(101, 36);
            this.DonorNameText.Name = "DonorNameText";
            this.DonorNameText.Size = new System.Drawing.Size(100, 20);
            this.DonorNameText.TabIndex = 1;
            // 
            // DonorDonationsGrid
            // 
            this.DonorDonationsGrid.BackgroundColor = System.Drawing.Color.White;
            this.DonorDonationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DonorDonationsGrid.Location = new System.Drawing.Point(13, 51);
            this.DonorDonationsGrid.Name = "DonorDonationsGrid";
            this.DonorDonationsGrid.Size = new System.Drawing.Size(568, 301);
            this.DonorDonationsGrid.TabIndex = 21;
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.RecievingText);
            this.EditPanel.Controls.Add(this.label1);
            this.EditPanel.Controls.Add(this.label2);
            this.EditPanel.Controls.Add(this.label3);
            this.EditPanel.Controls.Add(this.YearText);
            this.EditPanel.Controls.Add(this.DayText);
            this.EditPanel.Controls.Add(this.MonthText);
            this.EditPanel.Controls.Add(this.RecievingDText);
            this.EditPanel.Controls.Add(this.DescText);
            this.EditPanel.Controls.Add(this.label8);
            this.EditPanel.Controls.Add(this.EDITREQUEST);
            this.EditPanel.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditPanel.Location = new System.Drawing.Point(22, 63);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(538, 283);
            this.EditPanel.TabIndex = 19;
            // 
            // RecievingText
            // 
            this.RecievingText.FormattingEnabled = true;
            this.RecievingText.Items.AddRange(new object[] {
            "00:09AM",
            "00:10AM",
            "00:11AM",
            "00:12PM",
            "00:01PM",
            "00:02PM",
            "00:03PM",
            "00:04PM",
            "00:05PM",
            "00:06PM",
            "00:07PM"});
            this.RecievingText.Location = new System.Drawing.Point(159, 195);
            this.RecievingText.Name = "RecievingText";
            this.RecievingText.Size = new System.Drawing.Size(60, 25);
            this.RecievingText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Recieving time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "/";
            // 
            // YearText
            // 
            this.YearText.AutoSize = true;
            this.YearText.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearText.Location = new System.Drawing.Point(314, 157);
            this.YearText.Name = "YearText";
            this.YearText.Size = new System.Drawing.Size(44, 17);
            this.YearText.TabIndex = 13;
            this.YearText.Text = "2018";
            // 
            // DayText
            // 
            this.DayText.FormattingEnabled = true;
            this.DayText.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DayText.Location = new System.Drawing.Point(159, 154);
            this.DayText.Name = "DayText";
            this.DayText.Size = new System.Drawing.Size(43, 25);
            this.DayText.TabIndex = 2;
            // 
            // MonthText
            // 
            this.MonthText.FormattingEnabled = true;
            this.MonthText.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.MonthText.Location = new System.Drawing.Point(225, 154);
            this.MonthText.Name = "MonthText";
            this.MonthText.Size = new System.Drawing.Size(60, 25);
            this.MonthText.TabIndex = 3;
            // 
            // RecievingDText
            // 
            this.RecievingDText.AutoSize = true;
            this.RecievingDText.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecievingDText.Location = new System.Drawing.Point(19, 156);
            this.RecievingDText.Name = "RecievingDText";
            this.RecievingDText.Size = new System.Drawing.Size(134, 17);
            this.RecievingDText.TabIndex = 9;
            this.RecievingDText.Text = "Recieving date";
            // 
            // DescText
            // 
            this.DescText.Location = new System.Drawing.Point(159, 33);
            this.DescText.Multiline = true;
            this.DescText.Name = "DescText";
            this.DescText.Size = new System.Drawing.Size(317, 89);
            this.DescText.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Description";
            // 
            // EDITREQUEST
            // 
            this.EDITREQUEST.BackColor = System.Drawing.Color.DarkSalmon;
            this.EDITREQUEST.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDITREQUEST.Location = new System.Drawing.Point(401, 233);
            this.EDITREQUEST.Name = "EDITREQUEST";
            this.EDITREQUEST.Size = new System.Drawing.Size(75, 31);
            this.EDITREQUEST.TabIndex = 5;
            this.EDITREQUEST.Text = "Done";
            this.EDITREQUEST.UseVisualStyleBackColor = false;
            this.EDITREQUEST.Click += new System.EventHandler(this.EDITREQUEST_Click);
            // 
            // DeleteOrEdit
            // 
            this.DeleteOrEdit.AutoSize = true;
            this.DeleteOrEdit.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrEdit.Location = new System.Drawing.Point(221, 379);
            this.DeleteOrEdit.Name = "DeleteOrEdit";
            this.DeleteOrEdit.Size = new System.Drawing.Size(108, 20);
            this.DeleteOrEdit.TabIndex = 20;
            this.DeleteOrEdit.Text = "Enter ID:";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.DarkSalmon;
            this.Home.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(13, 374);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(86, 32);
            this.Home.TabIndex = 22;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Donor_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(599, 418);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.DonorDonationsGrid);
            this.Controls.Add(this.DeleteOrEdit);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.panelEditInfo);
            this.Controls.Add(this.panelDonationRequest);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.EditInfo);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.DonationRequest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Donor_Account";
            this.Text = "Donor_Account";
            this.panelDonationRequest.ResumeLayout(false);
            this.panelDonationRequest.PerformLayout();
            this.panelEditInfo.ResumeLayout(false);
            this.panelEditInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorDonationsGrid)).EndInit();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DonationRequest;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Panel panelDonationRequest;
        private System.Windows.Forms.ComboBox CategoryText;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button EditInfo;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label RecievingDate;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label RecievingTime;
        private System.Windows.Forms.ComboBox RecievingTimeText;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Panel panelEditInfo;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox DonorAddressText;
        private System.Windows.Forms.TextBox DonorConfirmPassText;
        private System.Windows.Forms.TextBox DonorPasswordText;
        private System.Windows.Forms.TextBox DonorEmailText;
        private System.Windows.Forms.ComboBox DonorGenderText;
        private System.Windows.Forms.Label DonorGender;
        private System.Windows.Forms.TextBox DonorUsernameText;
        private System.Windows.Forms.Label DonorAddress;
        private System.Windows.Forms.Label DonorConfirmPass;
        private System.Windows.Forms.Label DonorPassword;
        private System.Windows.Forms.Label DonorEmail;
        private System.Windows.Forms.Label DonorUsername;
        private System.Windows.Forms.Label DonorName;
        private System.Windows.Forms.TextBox DonorNameText;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.ComboBox RecievingText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label YearText;
        private System.Windows.Forms.ComboBox DayText;
        private System.Windows.Forms.ComboBox MonthText;
        private System.Windows.Forms.Label RecievingDText;
        private System.Windows.Forms.TextBox DescText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EDITREQUEST;
        private System.Windows.Forms.Label DeleteOrEdit;
        private System.Windows.Forms.DataGridView DonorDonationsGrid;
        private System.Windows.Forms.Button Home;
    }
}