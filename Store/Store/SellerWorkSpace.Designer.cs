
namespace Store
{
    partial class SellerWorkSpace
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
            this.BuyersOfShop = new System.Windows.Forms.ComboBox();
            this.ViewTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridViewOrders = new System.Windows.Forms.DataGridView();
            this.OrderOfBuyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOfOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewTotalOrders = new System.Windows.Forms.Button();
            this.AllOrders = new System.Windows.Forms.ComboBox();
            this.StatusOfOrder = new System.Windows.Forms.Label();
            this.StatusOfSelectedOrder = new System.Windows.Forms.TextBox();
            this.NewStatus = new System.Windows.Forms.Button();
            this.ChooseStatusBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // BuyersOfShop
            // 
            this.BuyersOfShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuyersOfShop.FormattingEnabled = true;
            this.BuyersOfShop.Location = new System.Drawing.Point(73, 44);
            this.BuyersOfShop.Name = "BuyersOfShop";
            this.BuyersOfShop.Size = new System.Drawing.Size(253, 33);
            this.BuyersOfShop.TabIndex = 0;
            this.BuyersOfShop.SelectedIndexChanged += new System.EventHandler(this.BuyersOfShop_SelectedIndexChanged);
            // 
            // ViewTotalPrice
            // 
            this.ViewTotalPrice.Location = new System.Drawing.Point(73, 118);
            this.ViewTotalPrice.Name = "ViewTotalPrice";
            this.ViewTotalPrice.ReadOnly = true;
            this.ViewTotalPrice.Size = new System.Drawing.Size(253, 31);
            this.ViewTotalPrice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "The amount paid for all orders";
            // 
            // GridViewOrders
            // 
            this.GridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderOfBuyer,
            this.Date,
            this.PriceOfOrder,
            this.Owner,
            this.CurrentStatus});
            this.GridViewOrders.Location = new System.Drawing.Point(397, 12);
            this.GridViewOrders.Name = "GridViewOrders";
            this.GridViewOrders.RowHeadersWidth = 62;
            this.GridViewOrders.RowTemplate.Height = 33;
            this.GridViewOrders.Size = new System.Drawing.Size(794, 450);
            this.GridViewOrders.TabIndex = 3;
            // 
            // OrderOfBuyer
            // 
            this.OrderOfBuyer.HeaderText = "Order";
            this.OrderOfBuyer.MinimumWidth = 8;
            this.OrderOfBuyer.Name = "OrderOfBuyer";
            this.OrderOfBuyer.ReadOnly = true;
            this.OrderOfBuyer.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date of issue";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // PriceOfOrder
            // 
            this.PriceOfOrder.HeaderText = "Price";
            this.PriceOfOrder.MinimumWidth = 8;
            this.PriceOfOrder.Name = "PriceOfOrder";
            this.PriceOfOrder.ReadOnly = true;
            this.PriceOfOrder.Width = 150;
            // 
            // Owner
            // 
            this.Owner.HeaderText = "Owner";
            this.Owner.MinimumWidth = 8;
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            this.Owner.Width = 150;
            // 
            // CurrentStatus
            // 
            this.CurrentStatus.HeaderText = "Current status";
            this.CurrentStatus.MinimumWidth = 8;
            this.CurrentStatus.Name = "CurrentStatus";
            this.CurrentStatus.ReadOnly = true;
            this.CurrentStatus.Width = 150;
            // 
            // ViewTotalOrders
            // 
            this.ViewTotalOrders.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ViewTotalOrders.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewTotalOrders.Location = new System.Drawing.Point(73, 424);
            this.ViewTotalOrders.Name = "ViewTotalOrders";
            this.ViewTotalOrders.Size = new System.Drawing.Size(253, 34);
            this.ViewTotalOrders.TabIndex = 4;
            this.ViewTotalOrders.Text = "Show all active orders";
            this.ViewTotalOrders.UseVisualStyleBackColor = false;
            this.ViewTotalOrders.Click += new System.EventHandler(this.ViewTotalOrders_Click);
            // 
            // AllOrders
            // 
            this.AllOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AllOrders.FormattingEnabled = true;
            this.AllOrders.Location = new System.Drawing.Point(73, 207);
            this.AllOrders.Name = "AllOrders";
            this.AllOrders.Size = new System.Drawing.Size(253, 33);
            this.AllOrders.TabIndex = 5;
            this.AllOrders.SelectedIndexChanged += new System.EventHandler(this.AllOrders_SelectedIndexChanged);
            // 
            // StatusOfOrder
            // 
            this.StatusOfOrder.AutoSize = true;
            this.StatusOfOrder.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusOfOrder.Location = new System.Drawing.Point(174, 253);
            this.StatusOfOrder.Name = "StatusOfOrder";
            this.StatusOfOrder.Size = new System.Drawing.Size(60, 21);
            this.StatusOfOrder.TabIndex = 6;
            this.StatusOfOrder.Text = "Status";
            // 
            // StatusOfSelectedOrder
            // 
            this.StatusOfSelectedOrder.Location = new System.Drawing.Point(12, 281);
            this.StatusOfSelectedOrder.Name = "StatusOfSelectedOrder";
            this.StatusOfSelectedOrder.ReadOnly = true;
            this.StatusOfSelectedOrder.Size = new System.Drawing.Size(379, 31);
            this.StatusOfSelectedOrder.TabIndex = 7;
            // 
            // NewStatus
            // 
            this.NewStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NewStatus.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewStatus.Location = new System.Drawing.Point(148, 355);
            this.NewStatus.Name = "NewStatus";
            this.NewStatus.Size = new System.Drawing.Size(112, 34);
            this.NewStatus.TabIndex = 8;
            this.NewStatus.Text = "Choose";
            this.NewStatus.UseVisualStyleBackColor = false;
            this.NewStatus.Click += new System.EventHandler(this.NewStatus_Click);
            // 
            // ChooseStatusBox
            // 
            this.ChooseStatusBox.Location = new System.Drawing.Point(127, 318);
            this.ChooseStatusBox.Name = "ChooseStatusBox";
            this.ChooseStatusBox.Size = new System.Drawing.Size(150, 31);
            this.ChooseStatusBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(159, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "All orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(170, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Buyers";
            // 
            // SellerWorkSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1203, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChooseStatusBox);
            this.Controls.Add(this.NewStatus);
            this.Controls.Add(this.StatusOfSelectedOrder);
            this.Controls.Add(this.StatusOfOrder);
            this.Controls.Add(this.AllOrders);
            this.Controls.Add(this.ViewTotalOrders);
            this.Controls.Add(this.GridViewOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewTotalPrice);
            this.Controls.Add(this.BuyersOfShop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellerWorkSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerWorkSpace";
            this.Load += new System.EventHandler(this.SellerWorkSpace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BuyersOfShop;
        private System.Windows.Forms.TextBox ViewTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridViewOrders;
        private System.Windows.Forms.Button ViewTotalOrders;
        private System.Windows.Forms.ComboBox AllOrders;
        private System.Windows.Forms.Label StatusOfOrder;
        private System.Windows.Forms.TextBox StatusOfSelectedOrder;
        private System.Windows.Forms.Button NewStatus;
        private System.Windows.Forms.TextBox ChooseStatusBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderOfBuyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOfOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentStatus;
    }
}