
namespace Store
{
    partial class Information
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
            this.NewName = new System.Windows.Forms.TextBox();
            this.VCode = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.NumOfUnits = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GetInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(12, 232);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(173, 31);
            this.NewName.TabIndex = 0;
            // 
            // VCode
            // 
            this.VCode.Location = new System.Drawing.Point(221, 232);
            this.VCode.Name = "VCode";
            this.VCode.Size = new System.Drawing.Size(179, 31);
            this.VCode.TabIndex = 1;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(437, 232);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(176, 31);
            this.Price.TabIndex = 2;
            // 
            // NumOfUnits
            // 
            this.NumOfUnits.Location = new System.Drawing.Point(650, 232);
            this.NumOfUnits.Name = "NumOfUnits";
            this.NumOfUnits.Size = new System.Drawing.Size(178, 31);
            this.NumOfUnits.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(146, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter information about product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(230, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vendor code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(491, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(686, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // GetInfo
            // 
            this.GetInfo.BackColor = System.Drawing.Color.Maroon;
            this.GetInfo.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GetInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GetInfo.Location = new System.Drawing.Point(356, 338);
            this.GetInfo.Name = "GetInfo";
            this.GetInfo.Size = new System.Drawing.Size(128, 48);
            this.GetInfo.TabIndex = 9;
            this.GetInfo.Text = "Check";
            this.GetInfo.UseVisualStyleBackColor = false;
            this.GetInfo.Click += new System.EventHandler(this.GetInfo_Click);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(840, 446);
            this.Controls.Add(this.GetInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumOfUnits);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.VCode);
            this.Controls.Add(this.NewName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.TextBox VCode;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox NumOfUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GetInfo;
    }
}