using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    [Serializable]
    public class Order
    {
        public List<Product> ProductsInOrder { get; set; }
        public double Price { get; set; }
        public (string , int) InfoAboutBuyer { get; set; }
        public string Time { get; set; }
        public int NumOfOrder { get; set; }
        public string Status { get; set; }
        /// <summary>
        /// Создание объекта класса.
        /// </summary>
        /// <param name="price">Цена заказа</param>
        /// <param name="time">Время создания</param>
        /// <param name="num">Номер заказа</param>
        /// <param name="status">Статус</param>
        /// <param name="info">Покупатель</param>
        /// <param name="prd">Продукты заказа.</param>
        public Order(double price,string time,int num,string status,(string,int)info, List<Product> prd)
        {
            Price = price;
            Status = status;
            Time = time;
            NumOfOrder = num;
            ProductsInOrder = prd;
            InfoAboutBuyer = info;
        }
    }
}
