using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PointsDiscount
    {
        private int _points;

        /// <summary>
        /// Количество накопленных баллов.
        /// </summary>
        public int Points
        {
            get => _points;
            private set => _points = Math.Max(0, value);
        }

        /// <summary>
        /// Строковое свойство, возвращающее название скидки и количество баллов.
        /// </summary>
        public string Info => $"Накопительная – {Points} баллов";

        /// <summary>
        /// Метод для расчета возможной скидки на основе списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки в рублях.</returns>
        public double Calculate(List<Item> items)
        {
            double totalAmount = GetTotalAmount(items);
            double maxDiscount = totalAmount * 0.3;
            return Math.Min(Points, maxDiscount);
        }

        /// <summary>
        /// Метод для применения скидки к списку товаров. Возвращает размер скидки и уменьшает количество баллов.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки в рублях.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Points -= (int)Math.Round(discount, MidpointRounding.AwayFromZero);
            return discount;
        }

        /// <summary>
        /// Метод для обновления количества баллов после каждой покупки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double totalAmount = GetTotalAmount(items);
            int newPoints = (int)Math.Ceiling(totalAmount * 0.1);
            Points += newPoints;
        }

        /// <summary>
        /// Вспомогательный метод для расчета общей стоимости товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Общая стоимость товаров.</returns>
        private double GetTotalAmount(List<Item> items)
        {
            double total = 0.0;
            foreach (var item in items)
            {
                total += item.Cost;
            }
            return total;
        }
    }
}
