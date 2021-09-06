using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class Shop : Form
    {
        public int IndexOfBuyerInList { get; set; }
        public List<Product> ProductsInBasket = new List<Product>();
        public Shop()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Загрузка формы с присваиванием данных элементам управления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Shop_Load(object sender, EventArgs e)
        {
            try
            {
                string[] nameOfProducts = new string[Store.ListOfProducts.Count];
                for (int i = 0; i < Store.ListOfProducts.Count; i++)
                {
                    nameOfProducts[i] = Store.ListOfProducts[i].NameOfProduct;
                }
                Products.Items.AddRange(nameOfProducts);
                // Добавление продуктов в список всех продуктов.
                for (int i = 0; i < Store.Orders.Count; i++)
                {
                    if (Store.Orders[i].InfoAboutBuyer.Item2 == IndexOfBuyerInList)
                    {
                        ViewOrders.Items.Add($"Code of order: {Store.Orders[i].NumOfOrder}");
                        // Добавление заказов в список заказов пользователя.
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Проверка на наличие продуктов в корзине.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public (bool, int) ItemsInCart(int num)
        {
            try
            {
                for (int i = 0; i < ProductsInBasket.Count; i++)
                {
                    if (ProductsInBasket[i].VCode == Store.ListOfProducts[num].VCode)
                    {
                        return (false, i);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return (true, -1);
        }
        /// <summary>
        /// Добавление продукта в корзину для последующего оформления заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProductToBasket_Click(object sender, EventArgs e)
        {
            try
            {
                if (Products.SelectedIndex >= 0)
                {
                    if (Quantity.TextLength != 0 && GetQuantityOfProducts().Item1)
                    {
                        if (int.TryParse(Quantity.Text, out int quantityInOrder) && quantityInOrder > 0)
                        {
                            int index = GetQuantityOfProducts().Item2;
                            Basket.Rows.Clear();
                            // Очистка таблицы для вывода содержимого корзины.
                            if (ItemsInCart(index).Item1)
                            // Проверка на наличие товара в корзине для правильного оформления заказа.
                            {
                                ProductsInBasket.Add(new Product(Store.ListOfProducts[index].NameOfProduct, quantityInOrder,
                                    Store.ListOfProducts[index].Price, Store.ListOfProducts[index].VCode,
                                    Store.ListOfProducts[index].Path));
                                // Добавление товаров в корзину.
                            }
                            else
                            {
                                ProductsInBasket[ItemsInCart(index).Item2].Quantity += quantityInOrder;
                            }
                            for (int i = 0; i < ProductsInBasket.Count; i++)
                            {
                                Basket.Rows.Add(ProductsInBasket[i].NameOfProduct, ProductsInBasket[i].Quantity, ProductsInBasket[i].VCode, ProductsInBasket[i].Price);
                                // Отображение товаров в таблице.
                            }
                            Store.ListOfProducts[index].Quantity -= quantityInOrder;
                            // Учет изменения количества товаров.
                            Process();
                            Basket.Visible = true;
                            Quantity.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("The quantity of goods cannot be negative");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter quantity of selected product again");
                    }
                }
                else
                {
                    MessageBox.Show("Choose product!");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Проверка на количество товаров на складе.
        /// </summary>
        /// <returns></returns>
        public (bool, int) GetQuantityOfProducts()
        {
            try
            {
                for (int i = 0; i < Store.ListOfProducts.Count; i++)
                {
                    if (Products.SelectedItem.ToString() == Store.ListOfProducts[i].NameOfProduct)
                    {
                        int.TryParse(Quantity.Text, out int num);
                        if (Store.ListOfProducts[i].Quantity >= num && Store.ListOfProducts[i].Quantity > 0)
                        {
                            return (true, i);
                        }
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
        /// Вывод количества выбранного товара.
        /// </summary>
        public void Process()
        {
            try
            {
                if (Products.SelectedIndex >= 0)
                {
                    Display.Text = Store.ListOfProducts[Products.SelectedIndex].Quantity.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process();
        }
        /// <summary>
        /// Проверка на правильность введенных данных и последующее оформление заказа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkout_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProductsInBasket.Count > 0)
                {
                    Store.Orders.Add(new Order(GetTotalPrice(), DateTime.Now.ToString(), Store.Orders.Count + 1, "",
                        (Store.buyers[IndexOfBuyerInList].Email, IndexOfBuyerInList), ProductsInBasket));
                    // Оформление заказа.
                    Products.Text = "";
                    ViewOrders.Items.Add($"Code of order: {Store.Orders.Count}");
                    ProductsInBasket = new List<Product>();
                    MessageBox.Show("Order is processed ");
                    Basket.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("There are no items in your cart");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Получение общей суммы за заказ.
        /// </summary>
        /// <returns></returns>
        public double GetTotalPrice()
        {
            double price = 0;
            try
            {
                for (int i = 0; i < ProductsInBasket.Count; i++)
                {
                    price += ProductsInBasket[i].Price * ProductsInBasket[i].Quantity;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return price;
        }
        /// <summary>
        /// Вывод заказов в таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ViewOrders.SelectedItem != null)
                {
                    ViewStatus.Text = GetStatus();
                    Basket.Rows.Clear();
                    int index = GetIndexOfOrderInList();
                    for (int i = 0; i < Store.Orders[index].ProductsInOrder.Count; i++)
                    {
                        Basket.Rows.Add(Store.Orders[index].ProductsInOrder[i].NameOfProduct, Store.Orders[index].ProductsInOrder[i].Quantity.ToString(),
                            Store.Orders[index].ProductsInOrder[i].VCode, Store.Orders[index].ProductsInOrder[i].Quantity * Store.Orders[index].ProductsInOrder[i].Price);
                        // Добавление информации о заказе в таблицу.
                    }
                    if (ViewStatus.Text == "Обработан")
                    // Если статус заказа обработан, то пользователю предлагается оплатить заказ.
                    {
                        ChooseStatus.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Select order!");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Получение индекса заказа в списке.
        /// </summary>
        /// <returns></returns>
        public int GetIndexOfOrderInList()
        {
            try
            {
                string code = ViewOrders.Text.Substring(15);
                int.TryParse(code, out int num);
                for (int i = 0; i < Store.Orders.Count; i++)
                {
                    if (num == Store.Orders[i].NumOfOrder)
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
        /// Получение статуса заказа.
        /// </summary>
        /// <returns></returns>
        public string GetStatus()
        {
            try
            {
                string str = ViewOrders.Text.Substring(15);
                int.TryParse(str, out int code);
                for (int i = 0; i < Store.Orders.Count; i++)
                {
                    if (code == Store.Orders[i].NumOfOrder)
                    {
                        return Store.Orders[i].Status;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return "";
        }
        /// <summary>
        /// Оплата заказа, те изменение его статуса.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseStatus_Click(object sender, EventArgs e)
        {
            try
            {
                ChooseStatus.Visible = false;
                if (ViewOrders.SelectedIndex >= 0)
                {
                    if (ViewStatus.Text == "Обработан")
                    {
                        string str = ViewOrders.Text.Substring(15);
                        int.TryParse(str, out int code);
                        // Получение кода заказа.
                        for (int i = 0; i < Store.Orders.Count; i++)
                        {
                            if (code == Store.Orders[i].NumOfOrder)
                            {
                                ViewStatus.Text = "Обработан\\Оплачен";
                                Store.Orders[i].Status = "Обработан\\Оплачен";
                                // Изменение статуса, те произведение оплаты.
                                Store.buyers[Store.Orders[i].InfoAboutBuyer.Item2].Money += Store.Orders[i].Price;
                                // Оплата заказа.
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("The status of your item does not match the status \"Обработан\"");
                    }
                }
                else
                {
                    ChooseStatus.Visible = true;
                    MessageBox.Show("Select order!");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
