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

        private double _discountAmount;

        public string CustomerName { get; set; }

        /// <summary>
        /// Покупатель, оформивший заказ.
        /// </summary>
        public Customer Customer { get; set; }

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

        public string DeliveryAddress => $"{Address.Index}, {Address.Country}, {Address.City}, {Address.Street}, {Address.Building}, {Address.Apartment}";

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Итоговая стоимость заказа с учетом скидки.
        /// </summary>
        public double Total
        {
            get
            {
                double totalSum = Items?.Sum(item => item.Cost) ?? 0.0;

                double totalDiscount = Customer?.Discounts?.Sum(discount => discount.Calculate(Items)) ?? 0.0;

                return Math.Round(totalSum - totalDiscount, 2);
            }
        }

        /// <summary>
        /// Общая стоимость всех товаров в заказе без учета скидки.
        /// </summary>
        public double TotalAmount
        {
            get
            {
                double sum = 0;
                Items.ForEach(item => sum += item.Cost);
                return Math.Round(sum, 2);
            }
        }

        /// <summary>
        /// Сумма примененной скидки.
        /// </summary>
        public double DiscountAmount
        {
            get => _discountAmount;
            set => _discountAmount = Math.Max(value, 0);
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
