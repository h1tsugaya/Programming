using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
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

        public string CustomerName { get; set; }

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private readonly string _creationDate;

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
        /// Уникальный идентификатор заказа.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        public DateTime CreationDate { get; }

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        public List<Item> Items { get; set; }

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
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Создает новый экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="deliveryAddress">Адрес доставки.</param>
        /// <param name="items">Список товаров.</param>
        public Order()
        {
            CustomerName = "Steve";
            Status = OrderStatus.New;
            CreationDate = DateTime.Now;
            Address = new Address();
            Items = [];
            _id = IdGenerator.GetNextId();
        }

        public Order(string customerName, OrderStatus status, DateTime creationDate, List<Item> items) 
        {
            CustomerName = customerName;
            Status = status;
            CreationDate = creationDate;
            Items = new List<Item>(items);
            Address = new Address();
            Id = IdGenerator.GetNextId();
        }

    }
}
