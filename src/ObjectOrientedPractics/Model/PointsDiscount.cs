using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий скидку накопительных баллов.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {

        public int CompareTo(PointsDiscount other)
        {
            if (other == null) return 1;
            return Points.CompareTo(other.Points);
        }

        /// <summary>
        /// Получает текущее количество накопленных баллов.
        /// </summary>
        public int Points { get; private set; }

        /// <summary>
        /// Возвращает информацию о скидке в формате "Накопительная – {Баллы} баллов".
        /// </summary>
        public string Info => $"Накопительная – {Points} баллов";

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PointsDiscount"/> с заданным количеством баллов.
        /// </summary>
        /// <param name="initialPoints">Начальное количество баллов.</param>
        public PointsDiscount(int initialPoints = 0)
        {
            Points = Math.Max(initialPoints, 0);
        }

        /// <summary>
        /// Рассчитывает возможную скидку на основе текущих накопленных баллов.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки в рублях.</returns>
        public double Calculate(List<Item> items)
        {
            double totalAmount = 0;
            foreach (var item in items)
            {
                totalAmount += item.Cost;
            }

            double maxDiscount = totalAmount * 0.3;
            return Math.Min(Points, maxDiscount);
        }

        /// <summary>
        /// Применяет скидку и списывает накопленные баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки в рублях.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            Points -= (int)discount;
            return discount;
        }

        /// <summary>
        /// Обновляет количество накопленных баллов на основе стоимости товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double totalAmount = 0;
            foreach (var item in items)
            {
                totalAmount += item.Cost;
            }

            int earnedPoints = (int)Math.Ceiling(totalAmount * 0.1);
            Points += earnedPoints;
        }
    }
}
