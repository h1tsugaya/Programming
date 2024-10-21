using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий заказ.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly DateTime _creationDate;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Статус заказа.
        /// </summary>
        private OrderStatus _status;

        /// <summary>
        /// Создает новый экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        public Order(Address address, List<Item> items)
        {
            _id = IdGenerator.GetNextId();
            _creationDate = DateTime.Now;
            _address = address;
            _items = items ?? new List<Item>();
            _status = OrderStatus.New;
        }

        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        public DateTime CreationDate => _creationDate;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value ?? new Address(); }
        }

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value ?? new List<Item>(); }
        }

        /// <summary>
        /// Общая стоимость всех товаров в заказе.
        /// </summary>
        public double TotalAmount
        {
            get
            {
                double sum = 0;
                Items.ForEach(x => { sum += x.Cost; });
                return Math.Round(sum, 2);
            }
        }
        /// <summary>
        /// Статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
