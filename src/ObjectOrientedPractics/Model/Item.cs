using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий товар.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Уникальный идентификатор товара (только для чтения).
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Создает новый экземпляр класса Item.
        /// </summary>
        /// <param name="name">Название товара (до 200 символов).</param>
        /// <param name="info">Описание товара (до 1000 символов).</param>
        /// <param name="cost">Стоимость товара (от 0 до 100000).</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Уникальный идентификатор товара.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Название товара.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если длина названия превышает 200 символов.</exception>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Описание товара.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если длина описания превышает 1000 символов.</exception>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если стоимость выходит за пределы от 0 до 100000.</exception>
        public double Cost
        {
            get => _cost;
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentException("Стоимость товара должна быть в диапазоне от 0 до 100000.");
                }
                _cost = value;
            }
        }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category { get; set; }
    }
}
