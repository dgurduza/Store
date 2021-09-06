using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    /// <summary>
    /// Форма для получения данных для создаваемого товара.
    /// </summary>
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Проверка введенных данных на соответствие условию .
        /// И последующий переход в основное приложение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (NewName.Text.Length != 0)
                {
                    if (VCode.Text.Length != 0)
                    {
                        if (CheckVC())
                        {
                            if (Price.Text.Length != 0 && double.TryParse(Price.Text, out Store.Price) && Store.Price > 0)
                            {
                                if (NumOfUnits.Text.Length != 0 && int.TryParse(NumOfUnits.Text, out Store.AmountOfProduct) && Store.AmountOfProduct >= 0)
                                {
                                    Store.Product = NewName.Text;
                                    Store.VenCode = VCode.Text;
                                    Store.ListOfProducts.Add(new Product(Store.Product, Store.AmountOfProduct, Store.Price, Store.VenCode, Store.PathOfProduct));
                                    // Присваивание полученных данных и добавление товара в список товаров склада.
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Enter number of units again");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter price of product again");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product with this vendor code already exists");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter code of product again");
                    }
                }
                else
                {
                    MessageBox.Show("Enter name of product again");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Проверка на наличие на складе продукта с таким же артикулом как и введенный только что.
        /// </summary>
        /// <returns></returns>
        public bool CheckVC()
        {
            try
            {
                int count = 0;
                for (int i = 0; i < Store.ListOfProducts.Count; i++)
                {
                    if (VCode.Text == Store.ListOfProducts[i].VCode)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return false;
        }
    }
}
