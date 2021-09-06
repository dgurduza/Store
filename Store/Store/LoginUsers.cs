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
    public partial class LoginUsers : Form
    {
        public static string LoginOfSeller = "seller@hse.ru";
        public string PasswordOfSeller = "hse";
        public LoginUsers()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Регистрация покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetBuyer_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show(
                   "Вы уже зарегистрированны в системе?",
                   "Сообщение",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);
                // Получение данных от пользователя об наличии аккаунта в магазине.
                if (result == DialogResult.Yes)
                {
                    CheckLogin.Text = "";
                    CheckPassword.Text = "";
                    CheckData.Visible = true;
                    CheckSellerData.Visible = false;
                }
                else
                {
                    FormBuyer fb = new FormBuyer();
                    fb.ShowDialog();
                    // Создание формы для регистрации пользователя.
                    CheckData.Visible = true;
                    CheckSellerData.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Регистрация продавца.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetSeller_Click(object sender, EventArgs e)
        {
            CheckSellerData.Visible = true;
            CheckData.Visible = false;
            CheckLogin.Text = "";
            CheckPassword.Text = "";
        }
        /// <summary>
        /// Проверка введенных пользователем данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckData_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckLogin.TextLength != 0)
                {
                    if (CheckPassword.TextLength != 0)
                    {
                        if (CheckEnteredData().Item1)
                        {
                            Shop myShop = new Shop();
                            myShop.IndexOfBuyerInList = CheckEnteredData().Item2;
                            CheckLogin.Text = "";
                            CheckPassword.Text = "";
                            myShop.ShowDialog();
                            CheckData.Visible = false;
                        }
                        else
                        {
                            CheckPassword.Text = "";
                            MessageBox.Show("Email or password entered incorrectly!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter your password!");
                    }
                }
                else
                {
                    MessageBox.Show("Enter your e-mail!");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Проверка на наличие аккаунта в магазине.
        /// </summary>
        /// <returns></returns>
        public (bool, int) CheckEnteredData()
        {
            try
            {
                for (int i = 0; i < Store.buyers.Count; i++)
                {
                    if (CheckLogin.Text == Store.buyers[i].Email && CheckPassword.Text == Store.buyers[i].Password)
                    {
                        return (true, i);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return (false, -1);
        }
        /// <summary>
        /// Проверка данных и последующее открытие рабочего пространства продавца.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckSellerData_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckLogin.TextLength != 0)
                {
                    if (CheckPassword.TextLength != 0)
                    {
                        if (CheckLogin.Text == LoginOfSeller && CheckPassword.Text == PasswordOfSeller)
                        {
                            SellerWorkSpace workSpace = new SellerWorkSpace();
                            CheckLogin.Text = "";
                            CheckPassword.Text = "";
                            // Очистка полей для ввода данных.
                            workSpace.ShowDialog();
                            // Открытие рабочего пространства продавца.
                            CheckSellerData.Visible = false;
                        }
                        else
                        {
                            CheckPassword.Text = "";
                            MessageBox.Show("Email or password entered incorrectly!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter your password!");
                    }
                }
                else
                {
                    MessageBox.Show("Enter your e-mail!");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Получение правил.
        /// </summary>
        public void ViewInfo()
        {
            try
            {
                string letter = File.ReadAllText(@"..\..\..\ShopRules.txt");
                MessageBox.Show(letter);
                // Для оптимизации вывод правил из файла.
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Вывод информации об работе с магазином.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoAboutShop_Click(object sender, EventArgs e)
        {
            ViewInfo();
        }
        /// <summary>
        /// При загрузке формы вывод правил работы с магазином.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginUsers_Load(object sender, EventArgs e)
        {
            ViewInfo();
        }
    }
}
