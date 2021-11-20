namespace Donation_System
{
    partial class Employee_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Account));
            this.Welcome = new System.Windows.Forms.Label();
            this.AllDonations = new System.Windows.Forms.Label();
            this.ShowDonations = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.ComboBox();
            this.LogOut = new System.Windows.Forms.Button();
            this.ByCategory = new System.Windows.Forms.DataGridView();
            this.AllDonationsGrid = new System.Windows.Forms.DataGridView();
            this.Show = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ByCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllDonationsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.LightPink;
            this.Welcome.Location = new System.Drawing.Point(17, 17);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(150, 38);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome";
            // 
            // AllDonations
            // 
            this.AllDonations.AutoSize = true;
            this.AllDonations.Font = new System.Drawing.Font("Kristen ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllDonations.Location = new System.Drawing.Point(19, 88);
            this.AllDonations.Name = "AllDonations";
            this.AllDonations.Size = new System.Drawing.Size(136, 27);
            this.AllDonations.TabIndex = 1;
            this.AllDonations.Text = "All donations";
            // 
            // ShowDonations
            // 
            this.ShowDonations.AutoSize = true;
            this.ShowDonations.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDonations.Location = new System.Drawing.Point(258, 91);
            this.ShowDonations.Name = "ShowDonations";
            this.ShowDonations.Size = new System.Drawing.Size(176, 23);
            this.ShowDonations.TabIndex = 2;
            this.ShowDonations.Text = "Show donations for: ";
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "Money",
            "Food",
            "Clothes"});
            this.Category.Location = new System.Drawing.Point(440, 91);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(121, 21);
            this.Category.TabIndex = 1;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.LightPink;
            this.LogOut.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(567, 17);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 28);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "Logout";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // ByCategory
            // 
            this.ByCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ByCategory.Location = new System.Drawing.Point(24, 136);
            this.ByCategory.Name = "ByCategory";
            this.ByCategory.Size = new System.Drawing.Size(618, 181);
            this.ByCategory.TabIndex = 6;
            // 
            // AllDonationsGrid
            // 
            this.AllDonationsGrid.BackgroundColor = System.Drawing.Color.White;
            this.AllDonationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllDonationsGrid.Location = new System.Drawing.Point(24, 136);
            this.AllDonationsGrid.Name = "AllDonationsGrid";
            this.AllDonationsGrid.Size = new System.Drawing.Size(618, 181);
            this.AllDonationsGrid.TabIndex = 7;
            // 
            // Show
            // 
            this.Show.BackColor = System.Drawing.Color.LightPink;
            this.Show.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show.Location = new System.Drawing.Point(567, 88);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 30);
            this.Show.TabIndex = 2;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = false;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.LightPink;
            this.Home.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(486, 17);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 28);
            this.Home.TabIndex = 8;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Employee_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(665, 337);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.AllDonationsGrid);
            this.Controls.Add(this.ByCategory);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.ShowDonations);
            this.Controls.Add(this.AllDonations);
            this.Controls.Add(this.Welcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee_Account";
            this.Text = "Employee_Account";
            ((System.ComponentModel.ISupportInitialize)(this.ByCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllDonationsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label AllDonations;
        private System.Windows.Forms.Label ShowDonations;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.DataGridView ByCategory;
        private System.Windows.Forms.DataGridView AllDonationsGrid;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Home;
    }
}