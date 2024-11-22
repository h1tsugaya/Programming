using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Address : ICloneable, IEquatable<Address>
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        /// <summary>
        /// Событие, которое возникает при изменении любого из свойств.
        /// </summary>
        public event EventHandler<EventArgs> AddressChanged;

        protected virtual void OnAddressChanged(EventArgs e)
        {
            AddressChanged?.Invoke(this, e);
        }

        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

        public bool Equals(Address other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return Index == other.Index &&
                   Country == other.Country &&
                   City == other.City &&
                   Street == other.Street &&
                   Building == other.Building &&
                   Apartment == other.Apartment;
        }

        public override bool Equals(object obj)
        {
            if (obj is Address other)
            {
                return Equals(other);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Index, Country, City, Street, Building, Apartment);
        }

        /// <summary>
        /// Возвращает или задает почтовый индекс (должен быть шестизначным целым числом).
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                if (_index != value)
                {
                    _index = value;
                    OnAddressChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Получает или задает страну или регион (до 50 символов).
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                if (_country != value)
                {
                    _country = value;
                    OnAddressChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Получает или задает город (до 50 символов).
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                if (_city != value)
                {
                    _city = value;
                    OnAddressChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Получает или задает улицу (до 100 символов).
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                if (_street != value)
                {
                    _street = value;
                    OnAddressChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Получает или задает номер здания (до 10 символов).
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                if (_building != value)
                {
                    _building = value;
                    OnAddressChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Получает или задает номер квартиры (до 10 символов).
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                if (_apartment != value)
                {
                    _apartment = value;
                    OnAddressChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="Address"/> класса со значениями по умолчанию.
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="Address"/> класса с указанными значениями.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна или регион.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер квартиры.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Возвращает полный адрес в виде строки.
        /// </summary>
        /// <returns>Строка, представляющая полный адрес.</returns>
        public override string ToString()
        {
            return $"{Index}, {Country}, {City}, {Street}, {Building}, Apt {Apartment}";
        }
    }
}
