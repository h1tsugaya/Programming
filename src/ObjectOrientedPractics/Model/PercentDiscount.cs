using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий процентную скидку на определенную категорию товаров.
    /// </summary>
    public class PercentDiscount : IDiscount
    {
        private int _discountPercent;
        private double _totalSpent;

        /// <summary>
        /// Словарь, хранящий проценты скидок для каждой категории товаров.
        /// </summary>
        public static Dictionary<Category, int> DiscountPercentsByCategory { get; } = new()
        {
            { Category.Electronics, 5 },
            { Category.Clothing, 7 },
            { Category.HomeAppliances, 6 },
            { Category.Food, 10 },
            { Category.Cosmetics, 8 },
            { Category.SportsEquipment, 7 },
            { Category.Furniture, 5 }
        };

        /// <summary>
        /// Получает категорию товаров, на которую предоставляется скидка.
        /// </summary>
        public Category Category { get; }

        /// <summary>
        /// Получает текущий процент скидки.
        /// </summary>
        public int DiscountPercent
        {
            get => _discountPercent;
            private set => _discountPercent = Math.Clamp(value, 1, 10);
        }

        /// <summary>
        /// Возвращает информацию о скидке в формате "Процентная «{Категория}» - {Процент}%".
        /// </summary>
        public string Info => $"Процентная «{Category}» - {DiscountPercent}%";

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PercentDiscount"/> с заданной категорией товаров.
        /// </summary>
        /// <param name="category">Категория товаров.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
            DiscountPercent = DiscountPercentsByCategory.ContainsKey(category)
                ? DiscountPercentsByCategory[category]
                : 1; // Если категория не найдена, установить минимальную скидку 1%
            _totalSpent = 0.0;
        }

        /// <summary>
        /// Рассчитывает возможную скидку на товары указанной категории.
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
        /// Применяет процентную скидку к товарам указанной категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки в рублях.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            return discount;
        }

        /// <summary>
        /// Обновляет процент скидки на основе общей суммы покупок товаров указанной категории.
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

            while (_totalSpent >= 1000 && DiscountPercent < 10)
            {
                DiscountPercent++;
                _totalSpent -= 1000;
            }
        }
    }
}
