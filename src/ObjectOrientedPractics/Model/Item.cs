using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий товар.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
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

        public event EventHandler<EventArgs> NameChanged;
        public event EventHandler<EventArgs> InfoChanged;
        public event EventHandler<EventArgs> CostChanged;

        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        public bool Equals(Item other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (obj is Item other)
            {
                return Equals(other);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public int CompareTo(Item other)
        {
            if (other == null) return 1;
            return Cost.CompareTo(other.Cost);
        }

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

        public Item()
        {
            _id = IdGenerator.GetNextId();
            Name = Id.ToString();
            Info = "";
            Cost = 0;
            Category = Category.Electronics;
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
                if (_name != value)
                {
                    _name = value;
                    OnNameChanged(EventArgs.Empty);
                }
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
                if (_info != value)
                {
                    _info = value;
                    OnInfoChanged(EventArgs.Empty);
                }
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
                if (_cost != value)
                {
                    _cost = value;
                    OnCostChanged(EventArgs.Empty);
                }
            }
        }

        protected virtual void OnNameChanged(EventArgs e)
        {
            NameChanged?.Invoke(this, e);
        }

        protected virtual void OnInfoChanged(EventArgs e)
        {
            InfoChanged?.Invoke(this, e);
        }

        protected virtual void OnCostChanged(EventArgs e)
        {
            CostChanged?.Invoke(this, e);
        }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
