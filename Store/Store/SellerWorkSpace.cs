using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class SellerWorkSpace : Form
    {
        public SellerWorkSpace()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Загрузка данных в элементы управления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellerWorkSpace_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Store.buyers.Count; i++)
                {
                    BuyersOfShop.Items.Add(Store.buyers[i].Email);
                    // Добавление покупателей.
                }
                for (int i = 0; i < Store.Orders.Count; i++)
                {
                    AllOrders.Items.Add(Store.Orders[i].NumOfOrder);
                    // Добавление всех заказов.
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// При изменении выбранного пользователя вывод заказов в таблицу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuyersOfShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (BuyersOfShop.SelectedItem != null)
                {
                    ViewTotalPrice.Text = Store.buyers[GetIndex()].Money.ToString();
                    GridViewOrders.Rows.Clear();
                    // Очистка таблицы.
                    for (int i = 0; i < Store.Orders.Count; i++)
                    {
                        if (Store.Orders[i].InfoAboutBuyer.Item1 == Store.buyers[GetIndex()].Email)
                        {
                            GridViewOrders.Rows.Add(Store.Orders[i].NumOfOrder.ToString(), Store.Orders[i].Time, Store.Orders[i].Price,
                                Store.Orders[i].InfoAboutBuyer.Item1, Status(Store.Orders[i]));
                            // Добавление всех заказов в таблицу. 
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
        // Получение статуса заказа.
        public string Status(Order order)
        {
            if (order.Status.Length == 9)
            {
                return "Обработан";
            }
            else if (order.Status.Length == 17)
            {
                return "Оплачен";
            }
            else if (order.Status.Length == 26)
            {
                return "Отгружен";
            }
            else if (order.Status.Length == 0)
            {
                return "Нет статуса";
            }
            else
            {
                return "Исполнен";
            }
        }
        /// <summary>
        /// Получение индекса покупателя в списке.
        /// </summary>
        /// <returns></returns>
        public int GetIndex()
        {
            try
            {
                for (int i = 0; i < Store.buyers.Count; i++)
                {
                    if (BuyersOfShop.SelectedItem.ToString() == Store.buyers[i].Email)
                    {
                        return i;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return -1;
        }
        /// <summary>
        /// При изменении выбранного заказа вывод его статуса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (AllOrders.SelectedItem != null)
                {
                    StatusOfSelectedOrder.Text = Store.Orders[GetIndexToOrder()].Status;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Получение индекса заказа.
        /// </summary>
        /// <returns></returns>
        public int GetIndexToOrder()
        {
            try
            {
                for (int i = 0; i < Store.Orders.Count; i++)
                {
                    if (AllOrders.SelectedItem.ToString() == Store.Orders[i].NumOfOrder.ToString())
                    {
                        return i;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return -1;
        }
        /// <summary>
        /// Изменение статуса заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChooseStatusBox.TextLength > 0)
                {
                    if (StatusOfSelectedOrder.Text == "")
                    {
                        if (ChooseStatusBox.Text == "Обработан")
                        {
                            Store.Orders[GetIndexToOrder()].Status = "Обработан";
                            StatusOfSelectedOrder.Text = Store.Orders[GetIndexToOrder()].Status;
                            // Изменение статуса в списке товаров.
                            ChooseStatusBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Enter status\"Обработан\"");
                        }
                    }
                    else if (StatusOfSelectedOrder.Text == "Обработан\\Оплачен")
                    {
                        if (ChooseStatusBox.Text == "Отгружен")
                        {
                            Store.Orders[GetIndexToOrder()].Status = "Обработан\\Оплачен\\Отгружен";
                            StatusOfSelectedOrder.Text = Store.Orders[GetIndexToOrder()].Status;
                            ChooseStatusBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Enter status\"Отгружен\"");
                        }
                    }
                    else if (StatusOfSelectedOrder.Text == "Обработан\\Оплачен\\Отгружен")
                    {
                        if (ChooseStatusBox.Text == "Исполнен")
                        {
                            Store.Orders[GetIndexToOrder()].Status = "Обработан\\Оплачен\\Отгружен\\Исполнен";
                            StatusOfSelectedOrder.Text = Store.Orders[GetIndexToOrder()].Status;
                            ChooseStatusBox.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Enter status\"Исполнен\"");
                        }
                    }
                    else if (StatusOfSelectedOrder.Text == "Обработан")
                    {
                        MessageBox.Show("The user did not pay for the order. Adding a new status is not possible");
                    }
                    else
                    {
                        MessageBox.Show("The order went through all the stages. Change of status is not possible");
                    }
                }
                else
                {
                    MessageBox.Show("Enter new status");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Вывод всех активных товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewTotalOrders_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewOrders.Rows.Clear();
                for (int i = 0; i < Store.Orders.Count; i++)
                {
                    if (Store.Orders[i].Status.Length <= 26)
                    {
                        GridViewOrders.Rows.Add(Store.Orders[i].NumOfOrder.ToString(), Store.Orders[i].Time, Store.Orders[i].Price,
                            Store.Orders[i].InfoAboutBuyer.Item1, Status(Store.Orders[i]));
                        // Добавление товаров в таблицу.
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
