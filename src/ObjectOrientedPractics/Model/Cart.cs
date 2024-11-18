using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий корзину покупателя.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        List<Item> _items = [];

        public Customer Customer { get; set; }

        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Рассчитывает и возвращает общую сумму всех товаров в корзине.
        /// </summary>
        /// <returns>Суммарная стоимость товаров в корзине.</returns>
        public double Amount
        {
            get
            {
                double totalSum = Items?.Sum(item => item.Cost) ?? 0.0;

                double totalDiscount = Customer?.Discounts?.Sum(discount => discount.Calculate(Items)) ?? 0.0;

                return Math.Round(totalSum - totalDiscount, 2);
            }
        }
    }
}
