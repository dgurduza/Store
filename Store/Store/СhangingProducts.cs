using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class СhangingProducts : Form
    {
        /// <summary>
        /// Загрузка элементов формы.
        /// </summary>
        public СhangingProducts()
        {
            InitializeComponent();
            Box();
        }
        /// <summary>
        /// Метод для добавления товаров в СomboBox. 
        /// </summary>
        private void Box()
        {
            try
            {
                for (int i = 0; i < Store.ListOfProducts.Count; i++)
                {
                    if (Store.ListOfProducts[i].Path == Store.FullPath)
                    {
                        BoxOfProducts.Items.Add(Store.ListOfProducts[i].NameOfProduct);
                        // Добавление в КомбоБокс товаров из раздела.
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Удаление выбранного товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfProducts.SelectedIndex >= 0)
                {
                    for (int i = 0; i < Store.ListOfProducts.Count; i++)
                    {
                        if (Store.ListOfProducts[i].NameOfProduct == BoxOfProducts.Text)
                        {
                            BoxOfProducts.Items.Remove(Store.ListOfProducts[i].NameOfProduct);
                            // Удаление из КомбоБокса.
                            BoxOfProducts.Text = "";
                            Store.ListOfProducts.RemoveAt(i);
                            // Удаление товаров из списка товаров склада.
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Select item");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Сокрытие ненужных элементов и появление элементов для переименования.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rename_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfProducts.SelectedIndex >= 0)
                {
                    Rename.Visible = false;
                    ChangeName.Visible = true;
                    BoxToRename.Visible = true;
                    ChangeAmount.Visible = false;
                    ChangePrice.Visible = false;
                    ChangeVC.Visible = false;
                    Delete.Visible = false;
                    ChangingPrice.Visible = false;
                    ChangingVC.Visible = false;
                    ChangingAmount.Visible = false;
                }
                else
                {
                    MessageBox.Show("Select item");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Проверка товара на артикул.
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            try
            {
                int count = 0;
                for (int i = 0; i < Store.ListOfProducts.Count; i++)
                {
                    if (Store.ListOfProducts[i].VCode == BoxToRename.Text)
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
        /// <summary>
        /// Метод переименования.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeName_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxToRename.TextLength > 0 && BoxOfProducts.SelectedItem != null)
                {
                    for (int i = 0; i < Store.ListOfProducts.Count; i++)
                    {
                        if (Store.ListOfProducts[i].NameOfProduct == BoxOfProducts.SelectedItem.ToString())
                        {
                            BoxOfProducts.Items[BoxOfProducts.SelectedIndex] = BoxToRename.Text;
                            Store.ListOfProducts[i].NameOfProduct = BoxToRename.Text;
                            // Смена названия в комбобокс и списке товаров.
                            BoxToRename.Text = "";
                        }
                    }
                    Rename.Visible = true;
                    ChangeName.Visible = false;
                    BoxToRename.Visible = false;
                    ChangeAmount.Visible = true;
                    ChangePrice.Visible = true;
                    ChangeVC.Visible = true;
                    Delete.Visible = true;
                    ChangingPrice.Visible = false;
                    ChangingVC.Visible = false;
                    ChangingAmount.Visible = false;

                }
                else
                {
                    MessageBox.Show("Enter new name");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Сокрытие ненужных элементов и появление элементов для изменения цены.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangePrice_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfProducts.SelectedIndex >= 0)
                {
                    Rename.Visible = false;
                    ChangeName.Visible = false;
                    BoxToRename.Visible = true;
                    ChangeAmount.Visible = false;
                    ChangePrice.Visible = false;
                    ChangeVC.Visible = false;
                    Delete.Visible = false;
                    ChangingPrice.Visible = true;
                    ChangingVC.Visible = false;
                    ChangingAmount.Visible = false;
                }
                else
                {
                    MessageBox.Show("Select item");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Метод изменения цены выбранного товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangingPrice_Click(object sender, EventArgs e)
        {
            try
            {
                double priceInBox;
                if (BoxToRename.TextLength > 0 && BoxOfProducts.SelectedItem != null)
                {
                    for (int i = 0; i < Store.ListOfProducts.Count; i++)
                    {
                        if (Store.ListOfProducts[i].NameOfProduct == BoxOfProducts.SelectedItem.ToString())
                        {
                            if (double.TryParse(BoxToRename.Text, out priceInBox) && priceInBox > 0)
                            {
                                Store.ListOfProducts[i].Price = priceInBox;
                                // Смена цены.
                            }
                            else
                            {
                                MessageBox.Show("Enter price again");
                            }
                        }
                    }
                    Rename.Visible = true;
                    ChangeName.Visible = false;
                    BoxToRename.Visible = false;
                    ChangeAmount.Visible = true;
                    ChangePrice.Visible = true;
                    ChangeVC.Visible = true;
                    Delete.Visible = true;
                    ChangingPrice.Visible = false;
                    ChangingVC.Visible = false;
                    ChangingAmount.Visible = false;
                    BoxToRename.Text = "";
                }
                else
                {
                    MessageBox.Show("Enter new price");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Метод изменения количества товаров.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangingAmount_Click(object sender, EventArgs e)
        {
            try
            {
                int amountInBox;
                if (BoxToRename.TextLength > 0 && BoxOfProducts.SelectedItem != null)
                {
                    for (int i = 0; i < Store.ListOfProducts.Count; i++)
                    {
                        if (Store.ListOfProducts[i].NameOfProduct == BoxOfProducts.SelectedItem.ToString())
                        {
                            if (int.TryParse(BoxToRename.Text, out amountInBox) && amountInBox >= 0)
                            {
                                Store.ListOfProducts[i].Quantity = amountInBox;
                                // Смена количества товаров.
                            }
                            else
                            {
                                MessageBox.Show("Enter amount again");
                            }
                        }
                    }
                    Rename.Visible = true;
                    ChangeName.Visible = false;
                    BoxToRename.Visible = false;
                    ChangeAmount.Visible = true;
                    ChangePrice.Visible = true;
                    ChangeVC.Visible = true;
                    Delete.Visible = true;
                    ChangingPrice.Visible = false;
                    ChangingVC.Visible = false;
                    ChangingAmount.Visible = false;
                    BoxToRename.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Сокрытие ненужных элементов и появление элементов для изменения количества товаров на складе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeAmount_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfProducts.SelectedIndex >= 0)
                {
                    Rename.Visible = false;
                    ChangeName.Visible = false;
                    BoxToRename.Visible = true;
                    ChangeAmount.Visible = false;
                    ChangePrice.Visible = false;
                    ChangeVC.Visible = false;
                    Delete.Visible = false;
                    ChangingPrice.Visible = false;
                    ChangingVC.Visible = false;
                    ChangingAmount.Visible = true;
                }
                else
                {
                    MessageBox.Show("Select item");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Изменение артикула.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangingVC_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxToRename.TextLength > 0 && BoxOfProducts.SelectedItem != null)
                {
                    for (int i = 0; i < Store.ListOfProducts.Count; i++)
                    {
                        if (Store.ListOfProducts[i].NameOfProduct == BoxOfProducts.SelectedItem.ToString())
                        {
                            if (Check())
                            {
                                Store.ListOfProducts[i].VCode = BoxToRename.Text;
                                // Смена артикула.
                            }
                            else
                            {
                                MessageBox.Show("Product with this vendor code already exists");
                            }
                        }
                    }
                    Rename.Visible = true;
                    ChangeName.Visible = false;
                    BoxToRename.Visible = false;
                    ChangeAmount.Visible = true;
                    ChangePrice.Visible = true;
                    ChangeVC.Visible = true;
                    Delete.Visible = true;
                    ChangingPrice.Visible = false;
                    ChangingVC.Visible = false;
                    ChangingAmount.Visible = false;
                    BoxToRename.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Сокрытие ненужных элементов и появление элементов для изменения артикула товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeVC_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxOfProducts.SelectedIndex >= 0)
                {
                    Rename.Visible = false;
                    ChangeName.Visible = false;
                    BoxToRename.Visible = true;
                    ChangeAmount.Visible = false;
                    ChangePrice.Visible = false;
                    ChangeVC.Visible = false;
                    Delete.Visible = false;
                    ChangingPrice.Visible = false;
                    ChangingVC.Visible = true;
                    ChangeAmount.Visible = false;
                }
                else
                {
                    MessageBox.Show("Select item");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
