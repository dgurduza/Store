
namespace Store
{
    partial class Store
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            Serialize();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Classifier = new System.Windows.Forms.TreeView();
            this.ContextMenuForTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateSection = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameSection = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteSection = new System.Windows.Forms.ToolStripMenuItem();
            this.CsvOutput = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetNewName = new System.Windows.Forms.TextBox();
            this.RenameButton = new System.Windows.Forms.Button();
            this.GetNameForSection = new System.Windows.Forms.Button();
            this.SubSection = new System.Windows.Forms.Button();
            this.CreateProduct = new System.Windows.Forms.Button();
            this.SubSectionName = new System.Windows.Forms.Button();
            this.Changing = new System.Windows.Forms.Button();
            this.CreatorCSV = new System.Windows.Forms.Button();
            this.MakeCSV = new System.Windows.Forms.Button();
            this.OldStore = new System.Windows.Forms.Button();
            this.SaveStore = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.Button();
            this.OpenShop = new System.Windows.Forms.Button();
            this.ContextMenuForTreeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CsvOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // Classifier
            // 
            this.Classifier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Classifier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Classifier.ContextMenuStrip = this.ContextMenuForTreeView;
            this.Classifier.Location = new System.Drawing.Point(12, 12);
            this.Classifier.Name = "Classifier";
            this.Classifier.Size = new System.Drawing.Size(425, 518);
            this.Classifier.TabIndex = 0;
            this.Classifier.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Classifier_NodeMouseDoubleClick);
            // 
            // ContextMenuForTreeView
            // 
            this.ContextMenuForTreeView.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuForTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateSection,
            this.RenameSection,
            this.DeleteSection});
            this.ContextMenuForTreeView.Name = "ContextMenuForTreeView";
            this.ContextMenuForTreeView.Size = new System.Drawing.Size(215, 100);
            // 
            // CreateSection
            // 
            this.CreateSection.Name = "CreateSection";
            this.CreateSection.Size = new System.Drawing.Size(214, 32);
            this.CreateSection.Text = "Создать";
            this.CreateSection.Click += new System.EventHandler(this.ClickToCreate);
            // 
            // RenameSection
            // 
            this.RenameSection.Name = "RenameSection";
            this.RenameSection.Size = new System.Drawing.Size(214, 32);
            this.RenameSection.Text = "Переименовать";
            this.RenameSection.Click += new System.EventHandler(this.ClickToRename);
            // 
            // DeleteSection
            // 
            this.DeleteSection.Name = "DeleteSection";
            this.DeleteSection.Size = new System.Drawing.Size(214, 32);
            this.DeleteSection.Text = "Удалить";
            this.DeleteSection.Click += new System.EventHandler(this.ClickToDelete);
            // 
            // CsvOutput
            // 
            this.CsvOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CsvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CsvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.VendorCode,
            this.ProductPrice,
            this.Amount});
            this.CsvOutput.Location = new System.Drawing.Point(485, 12);
            this.CsvOutput.Name = "CsvOutput";
            this.CsvOutput.RowHeadersWidth = 62;
            this.CsvOutput.RowTemplate.Height = 33;
            this.CsvOutput.Size = new System.Drawing.Size(832, 493);
            this.CsvOutput.TabIndex = 1;
            this.CsvOutput.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 150;
            // 
            // VendorCode
            // 
            this.VendorCode.HeaderText = "Vendore code";
            this.VendorCode.MinimumWidth = 8;
            this.VendorCode.Name = "VendorCode";
            this.VendorCode.Width = 150;
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Price";
            this.ProductPrice.MinimumWidth = 8;
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Width = 150;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Quantity";
            this.Amount.MinimumWidth = 8;
            this.Amount.Name = "Amount";
            this.Amount.Width = 150;
            // 
            // GetNewName
            // 
            this.GetNewName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GetNewName.Location = new System.Drawing.Point(12, 553);
            this.GetNewName.Name = "GetNewName";
            this.GetNewName.Size = new System.Drawing.Size(217, 31);
            this.GetNewName.TabIndex = 2;
            this.GetNewName.Visible = false;
            // 
            // RenameButton
            // 
            this.RenameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RenameButton.Location = new System.Drawing.Point(266, 550);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(171, 34);
            this.RenameButton.TabIndex = 3;
            this.RenameButton.Text = "Enter";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Visible = false;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // GetNameForSection
            // 
            this.GetNameForSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GetNameForSection.Location = new System.Drawing.Point(266, 550);
            this.GetNameForSection.Name = "GetNameForSection";
            this.GetNameForSection.Size = new System.Drawing.Size(171, 34);
            this.GetNameForSection.TabIndex = 4;
            this.GetNameForSection.Text = "Enter";
            this.GetNameForSection.UseVisualStyleBackColor = true;
            this.GetNameForSection.Visible = false;
            this.GetNameForSection.Click += new System.EventHandler(this.Naming);
            // 
            // SubSection
            // 
            this.SubSection.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SubSection.BackColor = System.Drawing.Color.Lavender;
            this.SubSection.Location = new System.Drawing.Point(487, 511);
            this.SubSection.Name = "SubSection";
            this.SubSection.Size = new System.Drawing.Size(162, 34);
            this.SubSection.TabIndex = 5;
            this.SubSection.Text = "Create subsection";
            this.SubSection.UseVisualStyleBackColor = false;
            this.SubSection.Visible = false;
            this.SubSection.Click += new System.EventHandler(this.SubSection_Click);
            // 
            // CreateProduct
            // 
            this.CreateProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateProduct.BackColor = System.Drawing.Color.Lavender;
            this.CreateProduct.Location = new System.Drawing.Point(487, 551);
            this.CreateProduct.Name = "CreateProduct";
            this.CreateProduct.Size = new System.Drawing.Size(162, 34);
            this.CreateProduct.TabIndex = 6;
            this.CreateProduct.Text = "Get new product";
            this.CreateProduct.UseVisualStyleBackColor = false;
            this.CreateProduct.Visible = false;
            this.CreateProduct.Click += new System.EventHandler(this.CreateProduct_Click);
            // 
            // SubSectionName
            // 
            this.SubSectionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubSectionName.Location = new System.Drawing.Point(266, 551);
            this.SubSectionName.Name = "SubSectionName";
            this.SubSectionName.Size = new System.Drawing.Size(171, 34);
            this.SubSectionName.TabIndex = 7;
            this.SubSectionName.Text = "Enter";
            this.SubSectionName.UseVisualStyleBackColor = true;
            this.SubSectionName.Visible = false;
            this.SubSectionName.Click += new System.EventHandler(this.SubSectionName_Click);
            // 
            // Changing
            // 
            this.Changing.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Changing.BackColor = System.Drawing.Color.Lavender;
            this.Changing.Location = new System.Drawing.Point(655, 551);
            this.Changing.Name = "Changing";
            this.Changing.Size = new System.Drawing.Size(165, 34);
            this.Changing.TabIndex = 8;
            this.Changing.Text = "Change produts";
            this.Changing.UseVisualStyleBackColor = false;
            this.Changing.Visible = false;
            this.Changing.Click += new System.EventHandler(this.Changing_Click);
            // 
            // CreatorCSV
            // 
            this.CreatorCSV.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreatorCSV.BackColor = System.Drawing.Color.Lavender;
            this.CreatorCSV.Location = new System.Drawing.Point(826, 551);
            this.CreatorCSV.Name = "CreatorCSV";
            this.CreatorCSV.Size = new System.Drawing.Size(126, 34);
            this.CreatorCSV.TabIndex = 9;
            this.CreatorCSV.Text = "Get CSV";
            this.CreatorCSV.UseVisualStyleBackColor = false;
            this.CreatorCSV.Visible = false;
            this.CreatorCSV.Click += new System.EventHandler(this.CreatorCSV_Click);
            // 
            // MakeCSV
            // 
            this.MakeCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MakeCSV.BackColor = System.Drawing.Color.Lavender;
            this.MakeCSV.Location = new System.Drawing.Point(266, 550);
            this.MakeCSV.Name = "MakeCSV";
            this.MakeCSV.Size = new System.Drawing.Size(171, 34);
            this.MakeCSV.TabIndex = 10;
            this.MakeCSV.Text = "Enter";
            this.MakeCSV.UseVisualStyleBackColor = false;
            this.MakeCSV.Visible = false;
            this.MakeCSV.Click += new System.EventHandler(this.MakeCSV_Click);
            // 
            // OldStore
            // 
            this.OldStore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OldStore.BackColor = System.Drawing.Color.Lavender;
            this.OldStore.Location = new System.Drawing.Point(655, 512);
            this.OldStore.Name = "OldStore";
            this.OldStore.Size = new System.Drawing.Size(165, 34);
            this.OldStore.TabIndex = 11;
            this.OldStore.Text = "Download store";
            this.OldStore.UseVisualStyleBackColor = false;
            this.OldStore.Visible = false;
            this.OldStore.Click += new System.EventHandler(this.OldStore_Click);
            // 
            // SaveStore
            // 
            this.SaveStore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveStore.BackColor = System.Drawing.Color.Lavender;
            this.SaveStore.Location = new System.Drawing.Point(826, 511);
            this.SaveStore.Name = "SaveStore";
            this.SaveStore.Size = new System.Drawing.Size(126, 34);
            this.SaveStore.TabIndex = 12;
            this.SaveStore.Text = "Save store";
            this.SaveStore.UseVisualStyleBackColor = false;
            this.SaveStore.Visible = false;
            this.SaveStore.Click += new System.EventHandler(this.SaveStore_Click);
            // 
            // Information
            // 
            this.Information.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Information.BackColor = System.Drawing.Color.Red;
            this.Information.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Information.Location = new System.Drawing.Point(1142, 512);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(175, 74);
            this.Information.TabIndex = 13;
            this.Information.Text = "Info";
            this.Information.UseVisualStyleBackColor = false;
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // OpenShop
            // 
            this.OpenShop.BackColor = System.Drawing.Color.ForestGreen;
            this.OpenShop.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OpenShop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OpenShop.Location = new System.Drawing.Point(958, 512);
            this.OpenShop.Name = "OpenShop";
            this.OpenShop.Size = new System.Drawing.Size(174, 72);
            this.OpenShop.TabIndex = 14;
            this.OpenShop.Text = "SHOP";
            this.OpenShop.UseVisualStyleBackColor = false;
            this.OpenShop.Visible = false;
            this.OpenShop.Click += new System.EventHandler(this.OpenShop_Click);
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1325, 592);
            this.Controls.Add(this.OpenShop);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.SaveStore);
            this.Controls.Add(this.OldStore);
            this.Controls.Add(this.MakeCSV);
            this.Controls.Add(this.CreatorCSV);
            this.Controls.Add(this.Changing);
            this.Controls.Add(this.SubSectionName);
            this.Controls.Add(this.CreateProduct);
            this.Controls.Add(this.SubSection);
            this.Controls.Add(this.GetNameForSection);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.GetNewName);
            this.Controls.Add(this.CsvOutput);
            this.Controls.Add(this.Classifier);
            this.MinimumSize = new System.Drawing.Size(1347, 648);
            this.Name = "Store";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            this.ContextMenuForTreeView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CsvOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView Classifier;
        private System.Windows.Forms.DataGridView CsvOutput;
        private System.Windows.Forms.ContextMenuStrip ContextMenuForTreeView;
        private System.Windows.Forms.ToolStripMenuItem CreateSection;
        private System.Windows.Forms.ToolStripMenuItem RenameSection;
        private System.Windows.Forms.ToolStripMenuItem DeleteSection;
        private System.Windows.Forms.TextBox GetNewName;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.Button GetNameForSection;
        private System.Windows.Forms.Button SubSection;
        private System.Windows.Forms.Button CreateProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button SubSectionName;
        private System.Windows.Forms.Button Changing;
        private System.Windows.Forms.Button CreatorCSV;
        private System.Windows.Forms.Button MakeCSV;
        private System.Windows.Forms.Button OldStore;
        private System.Windows.Forms.Button SaveStore;
        private System.Windows.Forms.Button Information;
        private System.Windows.Forms.Button OpenShop;
    }
}

