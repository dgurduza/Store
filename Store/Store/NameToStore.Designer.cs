
namespace Store
{
    partial class NameToStore
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
            this.StoreName = new System.Windows.Forms.TextBox();
            this.GetNameToStore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ControlBox = false;
            this.SuspendLayout();
            // 
            // StoreName
            // 
            this.StoreName.Location = new System.Drawing.Point(96, 159);
            this.StoreName.Name = "StoreName";
            this.StoreName.Size = new System.Drawing.Size(150, 31);
            this.StoreName.TabIndex = 0;
            // 
            // GetNameToStore
            // 
            this.GetNameToStore.BackColor = System.Drawing.Color.FloralWhite;
            this.GetNameToStore.Location = new System.Drawing.Point(118, 196);
            this.GetNameToStore.Name = "GetNameToStore";
            this.GetNameToStore.Size = new System.Drawing.Size(112, 34);
            this.GetNameToStore.TabIndex = 1;
            this.GetNameToStore.Text = "Enter";
            this.GetNameToStore.UseVisualStyleBackColor = false;
            this.GetNameToStore.Click += new System.EventHandler(this.GetNameToStore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name To Store";
            // 
            // NameToStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(355, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetNameToStore);
            this.Controls.Add(this.StoreName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NameToStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NameToStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StoreName;
        private System.Windows.Forms.Button GetNameToStore;
        private System.Windows.Forms.Label label1;
    }
}