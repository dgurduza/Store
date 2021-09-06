
namespace Store
{
    partial class LoginUsers
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
            this.GetBuyer = new System.Windows.Forms.Button();
            this.GetSeller = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckData = new System.Windows.Forms.Button();
            this.CheckLogin = new System.Windows.Forms.TextBox();
            this.CheckPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckSellerData = new System.Windows.Forms.Button();
            this.InfoAboutShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetBuyer
            // 
            this.GetBuyer.BackColor = System.Drawing.Color.Honeydew;
            this.GetBuyer.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetBuyer.Location = new System.Drawing.Point(209, 77);
            this.GetBuyer.Name = "GetBuyer";
            this.GetBuyer.Size = new System.Drawing.Size(112, 34);
            this.GetBuyer.TabIndex = 0;
            this.GetBuyer.Text = "Buyer";
            this.GetBuyer.UseVisualStyleBackColor = false;
            this.GetBuyer.Click += new System.EventHandler(this.GetBuyer_Click);
            // 
            // GetSeller
            // 
            this.GetSeller.BackColor = System.Drawing.Color.Honeydew;
            this.GetSeller.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GetSeller.Location = new System.Drawing.Point(488, 77);
            this.GetSeller.Name = "GetSeller";
            this.GetSeller.Size = new System.Drawing.Size(112, 34);
            this.GetSeller.TabIndex = 1;
            this.GetSeller.Text = "Seller";
            this.GetSeller.UseVisualStyleBackColor = false;
            this.GetSeller.Click += new System.EventHandler(this.GetSeller_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(338, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Authorization";
            // 
            // CheckData
            // 
            this.CheckData.BackColor = System.Drawing.Color.Lavender;
            this.CheckData.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckData.Location = new System.Drawing.Point(338, 357);
            this.CheckData.Name = "CheckData";
            this.CheckData.Size = new System.Drawing.Size(140, 34);
            this.CheckData.TabIndex = 3;
            this.CheckData.Text = "Enter";
            this.CheckData.UseVisualStyleBackColor = false;
            this.CheckData.Visible = false;
            this.CheckData.Click += new System.EventHandler(this.CheckData_Click);
            // 
            // CheckLogin
            // 
            this.CheckLogin.Location = new System.Drawing.Point(325, 229);
            this.CheckLogin.Name = "CheckLogin";
            this.CheckLogin.Size = new System.Drawing.Size(165, 31);
            this.CheckLogin.TabIndex = 4;
            // 
            // CheckPassword
            // 
            this.CheckPassword.Location = new System.Drawing.Point(325, 293);
            this.CheckPassword.Name = "CheckPassword";
            this.CheckPassword.Size = new System.Drawing.Size(165, 31);
            this.CheckPassword.TabIndex = 5;
            this.CheckPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(216, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "LogIn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(216, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Magneto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(279, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choose who you are:";
            // 
            // CheckSellerData
            // 
            this.CheckSellerData.BackColor = System.Drawing.Color.Lavender;
            this.CheckSellerData.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckSellerData.Location = new System.Drawing.Point(338, 357);
            this.CheckSellerData.Name = "CheckSellerData";
            this.CheckSellerData.Size = new System.Drawing.Size(140, 34);
            this.CheckSellerData.TabIndex = 9;
            this.CheckSellerData.Text = "Enter";
            this.CheckSellerData.UseVisualStyleBackColor = false;
            this.CheckSellerData.Visible = false;
            this.CheckSellerData.Click += new System.EventHandler(this.CheckSellerData_Click);
            // 
            // InfoAboutShop
            // 
            this.InfoAboutShop.BackColor = System.Drawing.Color.Red;
            this.InfoAboutShop.Location = new System.Drawing.Point(732, 407);
            this.InfoAboutShop.Name = "InfoAboutShop";
            this.InfoAboutShop.Size = new System.Drawing.Size(58, 33);
            this.InfoAboutShop.TabIndex = 10;
            this.InfoAboutShop.Text = "Info";
            this.InfoAboutShop.UseVisualStyleBackColor = false;
            this.InfoAboutShop.Click += new System.EventHandler(this.InfoAboutShop_Click);
            // 
            // LoginUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(802, 452);
            this.Controls.Add(this.InfoAboutShop);
            this.Controls.Add(this.CheckSellerData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckPassword);
            this.Controls.Add(this.CheckLogin);
            this.Controls.Add(this.CheckData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetSeller);
            this.Controls.Add(this.GetBuyer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginUsers";
            this.Load += new System.EventHandler(this.LoginUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetBuyer;
        private System.Windows.Forms.Button GetSeller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CheckData;
        private System.Windows.Forms.TextBox CheckLogin;
        private System.Windows.Forms.TextBox CheckPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CheckSellerData;
        private System.Windows.Forms.Button InfoAboutShop;
    }
}