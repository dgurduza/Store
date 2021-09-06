using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Store
{
    public partial class NameToStore : Form
    {
        public NameToStore()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Полечение названия склада.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetNameToStore_Click(object sender, EventArgs e)
        {
            if (StoreName.Text.Length > 0)
            {
                if (CheckDirectories())
                {
                    Store.NameOfStore = StoreName.Text;
                    Close();
                }
                else
                {
                    MessageBox.Show("A store with the same name already exists");
                }
            }
            else
            {
                MessageBox.Show("Enter name to store");
            }
        }
        /// <summary>
        /// Проверка на наличие склада с введенным именем.
        /// </summary>
        /// <returns></returns>
        public bool CheckDirectories()
        {
            try
            {
                string[] mas = Directory.GetDirectories(@"..\..\..\Stores");
                // Получение путей папок из заданной директории.
                for (int i = 0; i < mas.Length; i++)
                {
                    string str = mas[i].Substring(16);
                    // Получение названий.
                    if (str == StoreName.Text)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return false;
        }
    }
}
