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
    public partial class GetStore : Form
    {
        public string[] MasOfPath;
        public string PathOfDirectory;
        /// <summary>
        /// Создание элементов формы и получение данных в ComdoBox.
        /// </summary>
        public GetStore()
        {
            InitializeComponent();
            GetDirectoriesToBox();
        }
        /// <summary>
        /// Получение списка файлов в которых храниться информация про склады.
        /// </summary>
        public void GetDirectoriesToBox()
        {
            try
            {
                MasOfPath = Directory.GetDirectories(@"..\..\..\Stores");
                // Получение путей папок.
                for (int i = 0; i < MasOfPath.Length; i++)
                {
                    MasOfPath[i] = MasOfPath[i].Substring(16);
                    // Получение названий.
                }
                ComboMenu.Items.AddRange(MasOfPath);
                // Добавление в комбобокс.
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Выбор файлов(склада) и последующий переход в основное приложение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetInfoInDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (ComboMenu.SelectedItem != null)
                {
                    PathOfDirectory = $@"..\..\..\Stores\{ComboMenu.SelectedItem.ToString()}";
                    // Получение пути склада.
                    Close();
                }
                else
                {
                    MessageBox.Show("Select directory");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
