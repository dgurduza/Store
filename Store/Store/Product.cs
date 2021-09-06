using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    [Serializable]
    public class Product
    {
        public string NameOfProduct { get; set; }
        public double Price { get; set; }
        public string VCode { get; set; }
        public int Quantity { get; set; }
        public string Path { get; set; }
        /// <summary>
        /// Конструктор для создания объекта класса.
        /// </summary>
        /// <param name="_name">Имя</param>
        /// <param name="_quantity">Объем</param>
        /// <param name="_price">Цена</param>
        /// <param name="_vcode">Артикул</param>
        /// <param name="path">Путь в классификаторе</param>
        public Product(string _name, int _quantity, double _price, string _vcode, string path)
        {
            NameOfProduct = _name;
            Price = _price;
            VCode = _vcode;
            Quantity = _quantity;
            Path = path;
        }
    }
}
