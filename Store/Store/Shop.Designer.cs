
namespace Store
{
    partial class Shop
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
            this.Basket = new System.Windows.Forms.DataGridView();
            this.NameOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityOnBasket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOfTotalProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.ComboBox();
            this.AddProductToBasket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Checkout = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ViewOrders = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.ViewStatus = new System.Windows.Forms.TextBox();
            this.ChooseStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Basket)).BeginInit();
            this.SuspendLayout();
            // 
            // Basket
            // 
            this.Basket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Basket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfProduct,
            this.QuantityOnBasket,
            this.Code,
            this.PriceOfTotalProducts});
            this.Basket.Location = new System.Drawing.Point(418, 51);
            this.Basket.Name = "Basket";
            this.Basket.RowHeadersWidth = 62;
            this.Basket.RowTemplate.Height = 33;
            this.Basket.Size = new System.Drawing.Size(795, 398);
            this.Basket.TabIndex = 1;
            // 
            // NameOfProduct
            // 
            this.NameOfProduct.HeaderText = "Name";
            this.NameOfProduct.MinimumWidth = 8;
            this.NameOfProduct.Name = "NameOfProduct";
            this.NameOfProduct.ReadOnly = true;
            this.NameOfProduct.Width = 150;
            // 
            // QuantityOnBasket
            // 
            this.QuantityOnBasket.HeaderText = "Quantity";
            this.QuantityOnBasket.MinimumWidth = 8;
            this.QuantityOnBasket.Name = "QuantityOnBasket";
            this.QuantityOnBasket.ReadOnly = true;
            this.QuantityOnBasket.Width = 150;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 8;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 150;
            // 
            // PriceOfTotalProducts
            // 
            this.PriceOfTotalProducts.HeaderText = "Price";
            this.PriceOfTotalProducts.MinimumWidth = 8;
            this.PriceOfTotalProducts.Name = "PriceOfTotalProducts";
            this.PriceOfTotalProducts.ReadOnly = true;
            this.PriceOfTotalProducts.Width = 150;
            // 
            // Products
            // 
            this.Products.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Products.FormattingEnabled = true;
            this.Products.Location = new System.Drawing.Point(86, 51);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(233, 33);
            this.Products.TabIndex = 2;
            this.Products.SelectedIndexChanged += new System.EventHandler(this.Products_SelectedIndexChanged);
            // 
            // AddProductToBasket
            // 
            this.AddProductToBasket.BackColor = System.Drawing.Color.Azure;
            this.AddProductToBasket.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddProductToBasket.Location = new System.Drawing.Point(153, 191);
            this.AddProductToBasket.Name = "AddProductToBasket";
            this.AddProductToBasket.Size = new System.Drawing.Size(108, 34);
            this.AddProductToBasket.TabIndex = 3;
            this.AddProductToBasket.Text = "Add";
            this.AddProductToBasket.UseVisualStyleBackColor = false;
            this.AddProductToBasket.Click += new System.EventHandler(this.AddProductToBasket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(782, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Basket";
            // 
            // Checkout
            // 
            this.Checkout.BackColor = System.Drawing.Color.Azure;
            this.Checkout.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Checkout.Location = new System.Drawing.Point(741, 455);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(182, 34);
            this.Checkout.TabIndex = 5;
            this.Checkout.Text = "Checkout basket";
            this.Checkout.UseVisualStyleBackColor = false;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(132, 154);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(150, 31);
            this.Quantity.TabIndex = 7;
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(179, 117);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(140, 31);
            this.Display.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantity";
            // 
            // ViewOrders
            // 
            this.ViewOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ViewOrders.FormattingEnabled = true;
            this.ViewOrders.Location = new System.Drawing.Point(86, 308);
            this.ViewOrders.Name = "ViewOrders";
            this.ViewOrders.Size = new System.Drawing.Size(246, 33);
            this.ViewOrders.TabIndex = 10;
            this.ViewOrders.SelectedIndexChanged += new System.EventHandler(this.ViewOrders_SelectedIndexChanged);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Status.Location = new System.Drawing.Point(179, 364);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(69, 21);
            this.Status.TabIndex = 11;
            this.Status.Text = "Status";
            // 
            // ViewStatus
            // 
            this.ViewStatus.Location = new System.Drawing.Point(12, 403);
            this.ViewStatus.Name = "ViewStatus";
            this.ViewStatus.ReadOnly = true;
            this.ViewStatus.Size = new System.Drawing.Size(400, 31);
            this.ViewStatus.TabIndex = 12;
            // 
            // ChooseStatus
            // 
            this.ChooseStatus.BackColor = System.Drawing.Color.Azure;
            this.ChooseStatus.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChooseStatus.Location = new System.Drawing.Point(132, 452);
            this.ChooseStatus.Name = "ChooseStatus";
            this.ChooseStatus.Size = new System.Drawing.Size(150, 34);
            this.ChooseStatus.TabIndex = 13;
            this.ChooseStatus.Text = "Pay";
            this.ChooseStatus.UseVisualStyleBackColor = false;
            this.ChooseStatus.Visible = false;
            this.ChooseStatus.Click += new System.EventHandler(this.ChooseStatus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(158, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Products";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(170, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Orders";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1225, 498);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChooseStatus);
            this.Controls.Add(this.ViewStatus);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ViewOrders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddProductToBasket);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.Basket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Basket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Basket;
        private System.Windows.Forms.ComboBox Products;
        private System.Windows.Forms.Button AddProductToBasket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Checkout;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityOnBasket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOfTotalProducts;
        private System.Windows.Forms.ComboBox ViewOrders;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox ViewStatus;
        private System.Windows.Forms.Button ChooseStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}