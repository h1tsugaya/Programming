using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    static class DataTools
    {
        /// <summary>
        /// Фильтрует список элементов на основе заданного условия.
        /// </summary>
        /// <param name="items">Список элементов для фильтрации.</param>
        /// <param name="compare">Функция сравнения, возвращающая true для включаемых элементов.</param>
        /// <returns>Отфильтрованный список элементов.</returns>
        public static List<Item> Filter(List<Item> items, Func<Item, bool> predicate)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            var filteredItems = new List<Item>();
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    filteredItems.Add(item);
                }
            }
            return filteredItems;
        }

        /// <summary>
        /// Сортирует список элементов на основе заданного условия.
        /// </summary>
        /// <param name="items">Список элементов для сортировки.</param>
        /// <param name="compare">Функция сравнения для сортировки.</param>
        /// <returns>Отсортированный список элементов.</returns>
        public static List<Item> Sort(List<Item> items, Comparison<Item> comparison)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            if (comparison == null) throw new ArgumentNullException(nameof(comparison));

            var sortedItems = new List<Item>(items);
            sortedItems.Sort(comparison);
            return sortedItems;
        }
    }
}
