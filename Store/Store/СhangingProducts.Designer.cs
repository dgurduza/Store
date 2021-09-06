
namespace Store
{
    partial class СhangingProducts
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
            this.BoxOfProducts = new System.Windows.Forms.ComboBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Rename = new System.Windows.Forms.Button();
            this.BoxToRename = new System.Windows.Forms.TextBox();
            this.ChangeName = new System.Windows.Forms.Button();
            this.ChangePrice = new System.Windows.Forms.Button();
            this.ChangeVC = new System.Windows.Forms.Button();
            this.ChangeAmount = new System.Windows.Forms.Button();
            this.ChangingAmount = new System.Windows.Forms.Button();
            this.ChangingVC = new System.Windows.Forms.Button();
            this.ChangingPrice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BoxOfProducts
            // 
            this.BoxOfProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxOfProducts.FormattingEnabled = true;
            this.BoxOfProducts.Location = new System.Drawing.Point(312, 105);
            this.BoxOfProducts.Name = "BoxOfProducts";
            this.BoxOfProducts.Size = new System.Drawing.Size(187, 33);
            this.BoxOfProducts.TabIndex = 0;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.Info;
            this.Delete.Location = new System.Drawing.Point(312, 352);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(188, 34);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Rename
            // 
            this.Rename.BackColor = System.Drawing.SystemColors.Info;
            this.Rename.Location = new System.Drawing.Point(12, 404);
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(188, 34);
            this.Rename.TabIndex = 2;
            this.Rename.Text = "Rename";
            this.Rename.UseVisualStyleBackColor = false;
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // BoxToRename
            // 
            this.BoxToRename.Location = new System.Drawing.Point(312, 206);
            this.BoxToRename.Name = "BoxToRename";
            this.BoxToRename.Size = new System.Drawing.Size(187, 31);
            this.BoxToRename.TabIndex = 3;
            this.BoxToRename.Visible = false;
            // 
            // ChangeName
            // 
            this.ChangeName.Location = new System.Drawing.Point(352, 261);
            this.ChangeName.Name = "ChangeName";
            this.ChangeName.Size = new System.Drawing.Size(112, 34);
            this.ChangeName.TabIndex = 4;
            this.ChangeName.Text = "Enter";
            this.ChangeName.UseVisualStyleBackColor = true;
            this.ChangeName.Visible = false;
            this.ChangeName.Click += new System.EventHandler(this.ChangeName_Click);
            // 
            // ChangePrice
            // 
            this.ChangePrice.BackColor = System.Drawing.SystemColors.Info;
            this.ChangePrice.Location = new System.Drawing.Point(212, 404);
            this.ChangePrice.Name = "ChangePrice";
            this.ChangePrice.Size = new System.Drawing.Size(188, 34);
            this.ChangePrice.TabIndex = 5;
            this.ChangePrice.Text = "Change Price";
            this.ChangePrice.UseVisualStyleBackColor = false;
            this.ChangePrice.Click += new System.EventHandler(this.ChangePrice_Click);
            // 
            // ChangeVC
            // 
            this.ChangeVC.BackColor = System.Drawing.SystemColors.Info;
            this.ChangeVC.Location = new System.Drawing.Point(406, 404);
            this.ChangeVC.Name = "ChangeVC";
            this.ChangeVC.Size = new System.Drawing.Size(188, 34);
            this.ChangeVC.TabIndex = 6;
            this.ChangeVC.Text = "Change Vendor code";
            this.ChangeVC.UseVisualStyleBackColor = false;
            this.ChangeVC.Click += new System.EventHandler(this.ChangeVC_Click);
            // 
            // ChangeAmount
            // 
            this.ChangeAmount.BackColor = System.Drawing.SystemColors.Info;
            this.ChangeAmount.Location = new System.Drawing.Point(600, 404);
            this.ChangeAmount.Name = "ChangeAmount";
            this.ChangeAmount.Size = new System.Drawing.Size(188, 34);
            this.ChangeAmount.TabIndex = 7;
            this.ChangeAmount.Text = "Change amount";
            this.ChangeAmount.UseVisualStyleBackColor = false;
            this.ChangeAmount.Click += new System.EventHandler(this.ChangeAmount_Click);
            // 
            // ChangingAmount
            // 
            this.ChangingAmount.Location = new System.Drawing.Point(352, 261);
            this.ChangingAmount.Name = "ChangingAmount";
            this.ChangingAmount.Size = new System.Drawing.Size(112, 34);
            this.ChangingAmount.TabIndex = 8;
            this.ChangingAmount.Text = "Enter";
            this.ChangingAmount.UseVisualStyleBackColor = true;
            this.ChangingAmount.Visible = false;
            this.ChangingAmount.Click += new System.EventHandler(this.ChangingAmount_Click);
            // 
            // ChangingVC
            // 
            this.ChangingVC.Location = new System.Drawing.Point(352, 261);
            this.ChangingVC.Name = "ChangingVC";
            this.ChangingVC.Size = new System.Drawing.Size(112, 34);
            this.ChangingVC.TabIndex = 9;
            this.ChangingVC.Text = "Enter";
            this.ChangingVC.UseVisualStyleBackColor = true;
            this.ChangingVC.Visible = false;
            this.ChangingVC.Click += new System.EventHandler(this.ChangingVC_Click);
            // 
            // ChangingPrice
            // 
            this.ChangingPrice.BackColor = System.Drawing.SystemColors.Info;
            this.ChangingPrice.Location = new System.Drawing.Point(352, 261);
            this.ChangingPrice.Name = "ChangingPrice";
            this.ChangingPrice.Size = new System.Drawing.Size(112, 34);
            this.ChangingPrice.TabIndex = 10;
            this.ChangingPrice.Text = "Enter";
            this.ChangingPrice.UseVisualStyleBackColor = false;
            this.ChangingPrice.Visible = false;
            this.ChangingPrice.Click += new System.EventHandler(this.ChangingPrice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(266, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 48);
            this.label1.TabIndex = 11;
            this.label1.Text = "Changing products";
            // 
            // СhangingProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangingPrice);
            this.Controls.Add(this.ChangingVC);
            this.Controls.Add(this.ChangingAmount);
            this.Controls.Add(this.ChangeAmount);
            this.Controls.Add(this.ChangeVC);
            this.Controls.Add(this.ChangePrice);
            this.Controls.Add(this.ChangeName);
            this.Controls.Add(this.BoxToRename);
            this.Controls.Add(this.Rename);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.BoxOfProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "СhangingProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СhangingProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BoxOfProducts;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Rename;
        private System.Windows.Forms.TextBox BoxToRename;
        private System.Windows.Forms.Button ChangeName;
        private System.Windows.Forms.Button ChangePrice;
        private System.Windows.Forms.Button ChangeVC;
        private System.Windows.Forms.Button ChangeAmount;
        private System.Windows.Forms.Button ChangingAmount;
        private System.Windows.Forms.Button ChangingVC;
        private System.Windows.Forms.Button ChangingPrice;
        private System.Windows.Forms.Label label1;
    }
}