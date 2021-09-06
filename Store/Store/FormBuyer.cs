using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class FormBuyer : Form
    {
        public FormBuyer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Получение и проверка введенных данных для создания покупателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoAboutBuyer_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameBox.TextLength != 0)
                {
                    if (PatronBox.TextLength != 0)
                    {
                        if (LastNameBox.TextLength != 0)
                        {
                            if (AdressBox.TextLength != 0)
                            {
                                if (MailBox.TextLength != 0 && Check())
                                {
                                    if (PasswordBox.TextLength != 0)
                                    {
                                        if (PNumBox.TextLength != 0)
                                        {
                                            Store.buyers.Add(new Buyer(NameBox.Text, PatronBox.Text, LastNameBox.Text, MailBox.Text, AdressBox.Text, PasswordBox.Text, PNumBox.Text));
                                            Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter number again");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Enter password again");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter e-mail again");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter adress again");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter last name again");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter patronymic again");
                    }
                }
                else
                {
                    MessageBox.Show("Enter name again");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Проверка на наличие введенного адреса почты в списке логинов.
        /// </summary>
        /// <returns></returns>
        public bool Check()
        {
            try
            {
                int count = 0;
                for (int i = 0; i < Store.buyers.Count; i++)
                {
                    if (Store.buyers[i].Email == MailBox.Text)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    if (MailBox.Text != LoginUsers.LoginOfSeller)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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
