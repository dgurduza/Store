
namespace Store
{
    partial class GetStore
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
            this.GetInfoInDirectory = new System.Windows.Forms.Button();
            this.ComboMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetInfoInDirectory
            // 
            this.GetInfoInDirectory.BackColor = System.Drawing.Color.Snow;
            this.GetInfoInDirectory.Location = new System.Drawing.Point(125, 219);
            this.GetInfoInDirectory.Name = "GetInfoInDirectory";
            this.GetInfoInDirectory.Size = new System.Drawing.Size(112, 34);
            this.GetInfoInDirectory.TabIndex = 0;
            this.GetInfoInDirectory.Text = "Enter";
            this.GetInfoInDirectory.UseVisualStyleBackColor = false;
            this.GetInfoInDirectory.Click += new System.EventHandler(this.GetInfoInDirectory_Click);
            // 
            // ComboMenu
            // 
            this.ComboMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMenu.FormattingEnabled = true;
            this.ComboMenu.Location = new System.Drawing.Point(96, 111);
            this.ComboMenu.Name = "ComboMenu";
            this.ComboMenu.Size = new System.Drawing.Size(176, 33);
            this.ComboMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directories";
            // 
            // GetStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(370, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboMenu);
            this.Controls.Add(this.GetInfoInDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetOldStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetInfoInDirectory;
        private System.Windows.Forms.ComboBox ComboMenu;
        private System.Windows.Forms.Label label1;
    }
}