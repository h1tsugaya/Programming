
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий покупателя.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор покупателя (только для чтения).
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя (ФИО).
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Создает новый экземпляр класса Customer.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя (до 200 символов).</param>
        /// <param name="address">Адрес доставки покупателя (до 500 символов).</param>
        public Customer(string fullname, Address address)
        {
            _id = IdGenerator.GetNextId();
            Fullname = fullname;
            Address = address;
        }

        /// <summary>
        /// Уникальный идентификатор покупателя.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Полное имя покупателя (ФИО).
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если длина имени превышает 200 символов.</exception>
        public string Fullname
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Адрес доставки покупателя.
        /// </summary>
        /// <exception cref="ArgumentException">Выбрасывается, если длина адреса превышает 500 символов.</exception>
        public Address Address
        {
            get => _address;
            set => _address = value ?? new Address(); // Если передан null, инициализируем пустым адресом.
        }
    }
}
