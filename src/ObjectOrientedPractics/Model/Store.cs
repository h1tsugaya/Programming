using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий магазин.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров в магазине.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Список покупателей магазина.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="Store"/> класса.
        /// Поля _items и _customers инициализируются пустыми списками.
        /// </summary>
        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customer>();
        }

        /// <summary>
        /// Получает или задает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// Получает или задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set => _customers = value;
        }
    }
}
