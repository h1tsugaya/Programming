using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        /// <summary>
        /// Получает или задает адрес.
        /// </summary>
        public Address Address
        {
            get
            {
                // Собираем адрес из полей ввода
                _address.Index = int.Parse(textBoxIndex.Text);
                _address.Country = textBoxCountry.Text;
                _address.City = textBoxCity.Text;
                _address.Street = textBoxStreet.Text;
                _address.Building = textBoxBuilding.Text;
                _address.Apartment = textBoxApartment.Text;

                return _address;
            }
            set
            {
                _address = value;
                // Заполняем текстовые поля данными адреса
                textBoxIndex.Text = _address.Index.ToString();
                textBoxCountry.Text = _address.Country;
                textBoxCity.Text = _address.City;
                textBoxStreet.Text = _address.Street;
                textBoxBuilding.Text = _address.Building;
                textBoxApartment.Text = _address.Apartment;
            }
        }

        public AddressControl()
        {
            InitializeComponent();
            _address = new Address(); // Инициализация пустым адресом.
            DisplayAddress();
        }

        /// <summary>
        /// Проверяет корректность данных, введенных в текстовые поля.
        /// Подсвечивает поля красным цветом в случае ошибок.
        /// </summary>
        /// <returns>Возвращает <see langword="true"/>, если все поля введены корректно, иначе <see langword="false"/>.</returns>
        public bool ValidateInput()
        {
            bool isValid = true;

            // Проверка индекса
            if (!int.TryParse(textBoxIndex.Text, out int index) || textBoxIndex.Text.Length != 6)
            {
                textBoxIndex.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                textBoxIndex.BackColor = SystemColors.Window;
            }

            // Проверка страны
            if (string.IsNullOrWhiteSpace(textBoxCountry.Text) || textBoxCountry.Text.Length > 50)
            {
                textBoxCountry.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                textBoxCountry.BackColor = SystemColors.Window;
            }

            // Проверка города
            if (string.IsNullOrWhiteSpace(textBoxCity.Text) || textBoxCity.Text.Length > 50)
            {
                textBoxCity.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                textBoxCity.BackColor = SystemColors.Window;
            }

            // Проверка улицы
            if (string.IsNullOrWhiteSpace(textBoxStreet.Text) || textBoxStreet.Text.Length > 100)
            {
                textBoxStreet.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                textBoxStreet.BackColor = SystemColors.Window;
            }

            // Проверка здания
            if (string.IsNullOrWhiteSpace(textBoxBuilding.Text) || textBoxBuilding.Text.Length > 10)
            {
                textBoxBuilding.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                textBoxBuilding.BackColor = SystemColors.Window;
            }


            // Проверка квартиры
            if (string.IsNullOrWhiteSpace(textBoxApartment.Text) || textBoxApartment.Text.Length > 10)
            {
                textBoxApartment.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                textBoxApartment.BackColor = SystemColors.Window;
            }

            return isValid;
        }

        private void DisplayAddress()
        {
            // Отображаем данные адреса в элементах управления (например, текстовых полях).
            textBoxIndex.Text = _address.Index.ToString();
            textBoxCountry.Text = _address.Country;
            textBoxCity.Text = _address.City;
            textBoxStreet.Text = _address.Street;
            textBoxBuilding.Text = _address.Building;
            textBoxApartment.Text = _address.Apartment;
        }

        private void ValidateAndUpdateAddress()
        {
            try
            {
                // Присваиваем значения полям адреса, вызывая валидацию.
                _address.Index = int.Parse(textBoxIndex.Text);
                _address.Country = textBoxCountry.Text;
                _address.City = textBoxCity.Text;
                _address.Street = textBoxStreet.Text;
                _address.Building = textBoxBuilding.Text;
                _address.Apartment = textBoxApartment.Text;

                // Если валидация прошла успешно, очищаем цвета.
                ClearErrorIndicators();
            }
            catch (ArgumentException ex)
            {
                // Если произошла ошибка валидации, показываем ошибку.
                ShowErrorIndicators(ex.Message);
            }
        }

        private void ShowErrorIndicators(string errorMessage)
        {
            // Подсвечиваем поля красным и показываем всплывающее сообщение об ошибке.
            textBoxIndex.BackColor = Color.Red;
            textBoxCountry.BackColor = Color.Red;
            textBoxCity.BackColor = Color.Red;
            textBoxStreet.BackColor = Color.Red;
            textBoxBuilding.BackColor = Color.Red;
            textBoxApartment.BackColor = Color.Red;

            // Выводим всплывающее сообщение
            toolTip.SetToolTip(textBoxIndex, errorMessage);
        }

        private void ClearErrorIndicators()
        {
            // Очищаем подсветку полей.
            textBoxIndex.BackColor = Color.White;
            textBoxCountry.BackColor = Color.White;
            textBoxCity.BackColor = Color.White;
            textBoxStreet.BackColor = Color.White;
            textBoxBuilding.BackColor = Color.White;
            textBoxApartment.BackColor = Color.White;

            // Очищаем подсказки об ошибках
            toolTip.SetToolTip(textBoxIndex, string.Empty);
        }

        /// <summary>
        /// Очищает все текстовые поля.
        /// </summary>
        public void ClearFields()
        {
            textBoxIndex.Text = "";
            textBoxCountry.Text = "";
            textBoxCity.Text = "";
            textBoxStreet.Text = "";
            textBoxBuilding.Text = "";
            textBoxApartment.Text = "";
        }

        private void textBoxIndex_Leave(object sender, EventArgs e)
        {
            ValidateAndUpdateAddress();
        }

        private void textBoxCountry_Leave(object sender, EventArgs e)
        {
            ValidateAndUpdateAddress();
        }

        private void textBoxCity_Leave(object sender, EventArgs e)
        {
            ValidateAndUpdateAddress();
        }

        private void textBoxStreet_Leave(object sender, EventArgs e)
        {
            ValidateAndUpdateAddress();
        }

        private void textBoxBuilding_Leave(object sender, EventArgs e)
        {
            ValidateAndUpdateAddress();
        }

        private void textBoxApartment_Leave(object sender, EventArgs e)
        {
            ValidateAndUpdateAddress();
        }
    }
}
