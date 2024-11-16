using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PercentDiscount
    {
        private int _discountPercent;
        private double _totalSpent;

        /// <summary>
        /// Категория товаров, на которую предоставляется скидка.
        /// </summary>
        public Category Category { get; }

        /// <summary>
        /// Текущий процент скидки (от 1% до 10%).
        /// </summary>
        public int DiscountPercent
        {
            get => _discountPercent;
            private set => _discountPercent = Math.Clamp(value, 1, 10);
        }

        /// <summary>
        /// Строковое свойство, возвращающее название скидки и текущий процент.
        /// </summary>
        public string Info => $"Процентная «{Category}» - {DiscountPercent}%";

        /// <summary>
        /// Конструктор, принимающий категорию товаров.
        /// </summary>
        /// <param name="category">Категория товаров.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
            DiscountPercent = 1;
            _totalSpent = 0.0;
        }

        /// <summary>
        /// Метод для расчета возможной скидки на основе списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки в рублях.</returns>
        public double Calculate(List<Item> items)
        {
            double discountAmount = 0.0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    discountAmount += item.Cost * (DiscountPercent / 100.0);
                }
            }
            return discountAmount;
        }

        /// <summary>
        /// Метод для применения скидки к списку товаров. Возвращает размер скидки и уменьшает сумму покупок.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки в рублях.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            return discount;
        }

        /// <summary>
        /// Метод для обновления суммы покупок и увеличения процента скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double categoryTotal = 0.0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    categoryTotal += item.Cost;
                }
            }

            _totalSpent += categoryTotal;

            // Увеличиваем процент скидки на 1% за каждую 1000 рублей потраченных на товары данной категории.
            while (_totalSpent >= 1000 && DiscountPercent < 10)
            {
                DiscountPercent++;
                _totalSpent -= 1000;
            }
        }
    }
}
