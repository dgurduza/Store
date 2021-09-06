using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    [Serializable]
    public class Buyer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string Adress { get; set; }
        public string Password { get; set; }
        public double Money = 0;
        
        public List<Order> Orders = new List<Order>();
        /// <summary>
        /// Создание покупателя.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="lname">Фамилия</param>
        /// <param name="pt">Отчество</param>
        /// <param name="mail">Адрес почты</param>
        /// <param name="adr">Адрес</param>
        /// <param name="pas">Пароль</param>
        /// <param name="num">Номер телефона.</param>
        public Buyer(string name, string lname, string pt,string mail, string adr, string pas, string num)
        {
            Name = name;
            LastName = lname;
            Patronymic = pt;
            Email = mail;
            Adress = adr;
            PhoneNum = num;
            Password = pas;
        
        }
        /// <summary>
        /// Объявление операторов для сравнения покупателей.
        /// </summary>
        /// <param name="buy1"></param>
        /// <param name="buy2"></param>
        /// <returns></returns>
        public static bool operator ==(Buyer buy1, Buyer buy2)
        {
            return buy1.Email==buy2.Email;
        }
        public static bool operator !=(Buyer buy1, Buyer buy2)
        {
            return buy1.Email != buy2.Email;
        }
    }
}
