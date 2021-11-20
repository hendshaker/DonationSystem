namespace Donation_System
{
    partial class Admin_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Account));
            this.AllDonors = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.DeleteText = new System.Windows.Forms.TextBox();
            this.DeleteID = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.Button();
            this.donor_info = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.donor_info)).BeginInit();
            this.SuspendLayout();
            // 
            // AllDonors
            // 
            this.AllDonors.AutoSize = true;
            this.AllDonors.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllDonors.ForeColor = System.Drawing.Color.RosyBrown;
            this.AllDonors.Location = new System.Drawing.Point(15, 123);
            this.AllDonors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllDonors.Name = "AllDonors";
            this.AllDonors.Size = new System.Drawing.Size(101, 23);
            this.AllDonors.TabIndex = 2;
            this.AllDonors.Text = "All donors";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.IndianRed;
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(543, 65);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 32);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteText
            // 
            this.DeleteText.Location = new System.Drawing.Point(111, 69);
            this.DeleteText.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteText.Name = "DeleteText";
            this.DeleteText.Size = new System.Drawing.Size(148, 25);
            this.DeleteText.TabIndex = 0;
            // 
            // DeleteID
            // 
            this.DeleteID.AutoSize = true;
            this.DeleteID.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteID.ForeColor = System.Drawing.Color.RosyBrown;
            this.DeleteID.Location = new System.Drawing.Point(15, 71);
            this.DeleteID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeleteID.Name = "DeleteID";
            this.DeleteID.Size = new System.Drawing.Size(94, 23);
            this.DeleteID.TabIndex = 1;
            this.DeleteID.Text = "Enter ID:";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.IndianRed;
            this.Welcome.Location = new System.Drawing.Point(13, 18);
            this.Welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(138, 35);
            this.Welcome.TabIndex = 5;
            this.Welcome.Text = "Welcome";
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.IndianRed;
            this.LogOut.ForeColor = System.Drawing.Color.Black;
            this.LogOut.Location = new System.Drawing.Point(543, 25);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(112, 32);
            this.LogOut.TabIndex = 6;
            this.LogOut.Text = "Logout";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // donor_info
            // 
            this.donor_info.BackgroundColor = System.Drawing.Color.White;
            this.donor_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.donor_info.Location = new System.Drawing.Point(19, 161);
            this.donor_info.Name = "donor_info";
            this.donor_info.RowTemplate.Height = 24;
            this.donor_info.Size = new System.Drawing.Size(636, 240);
            this.donor_info.TabIndex = 7;
            // 
            // Admin_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(688, 415);
            this.Controls.Add(this.donor_info);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AllDonors);
            this.Controls.Add(this.DeleteID);
            this.Controls.Add(this.DeleteText);
            this.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin_Account";
            this.Text = "Admin_Account";
            ((System.ComponentModel.ISupportInitialize)(this.donor_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AllDonors;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox DeleteText;
        private System.Windows.Forms.Label DeleteID;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.DataGridView donor_info;
    }
}