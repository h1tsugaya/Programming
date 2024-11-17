using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка для управления списком клиентов.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список клиентов.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();
        private Customer _selectedCustomer;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Открытое свойство для получения или установки списка покупателей.
        /// При установке обновляет элемент управления <see cref="ListBox"/>.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value ?? new List<Customer>();
                UpdateCustomersListBox();
            }
        }

        /// <summary>
        /// Обновляет элемент управления <see cref="ListBox"/> для отображения покупателей.
        /// </summary>
        private void UpdateCustomersListBox()
        {
            CustomersListBox.Items.Clear();
            foreach (var customer in _customers)
            {
                string displayText = customer.IsPriority ? $"{customer.Fullname} (Priority)" : customer.Fullname;
                CustomersListBox.Items.Add(displayText);
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Add".
        /// Добавляет нового клиента в список и обновляет <see cref="ListBox"/>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Address newAddress = addressControl1.Address;
                    Customer newCustomer = new Customer(textBoxFullName.Text, newAddress);
                    newCustomer.IsPriority = checkBoxIsPriority.Checked;
                    _customers.Add(newCustomer);
                    UpdateCustomersListBox();
                    ClearInputFields();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Remove".
        /// Удаляет выбранного клиента из списка и <see cref="ListBox"/>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void buttonRemove2_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;
                _customers.RemoveAt(selectedIndex);
                CustomersListBox.Items.RemoveAt(selectedIndex);
                ClearInputFields();
            }
        }



        /// <summary>
        /// Обрабатывает изменение выбранного клиента в <see cref="ListBox"/>.
        /// Загружает информацию о выбранном клиенте в текстовые поля.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;
                _selectedCustomer = _customers[selectedIndex];

                textBoxId2.Text = _selectedCustomer.Id.ToString();
                textBoxFullName.Text = _selectedCustomer.Fullname;
                addressControl1.Address = _selectedCustomer.Address;
                checkBoxIsPriority.Checked = _selectedCustomer.IsPriority;
                UpdateDiscountsList();
            }
        }

        private void checkBoxIsPriority_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedCustomer != null)
            {
                _selectedCustomer.IsPriority = checkBoxIsPriority.Checked;
                UpdateCustomersListBox();
            }
        }

        /// <summary>
        /// Проверяет корректность введенных данных.
        /// Подсвечивает поля красным цветом, если данные некорректны.
        /// </summary>
        /// <returns>Возвращает <see langword="true"/>, если все данные корректны, иначе <see langword="false"/>.</returns>
        private bool ValidateInput()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                textBoxFullName.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                textBoxFullName.BackColor = SystemColors.Window;
            }

            if (!addressControl1.ValidateInput())
            {
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Обновляет отображение списка скидок для выбранного клиента.
        /// </summary>
        private void UpdateDiscountsList()
        {
            listBoxDiscounts.Items.Clear();

            if (_selectedCustomer?.Discounts != null)
            {
                foreach (var discount in _selectedCustomer.Discounts)
                {
                    listBoxDiscounts.Items.Add(discount.Info);
                }
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Add Discount".
        /// </summary>
        private void buttonAddDiscount_Click(object sender, EventArgs e)
        {
            using (var addDiscountForm = new AddDiscountForm())
            {
                if (addDiscountForm.ShowDialog() == DialogResult.OK)
                {
                    var selectedCategory = addDiscountForm.SelectedCategory;
                    var newDiscount = new PercentDiscount(selectedCategory);
                    int selectedIndex = CustomersListBox.SelectedIndex;
                    if (selectedIndex != -1)
                    {
                        var selectedCustomer = _customers[selectedIndex];
                        selectedCustomer.Discounts.Add(newDiscount);
                        MessageBox.Show($"Скидка на категорию {selectedCategory} добавлена!",
                                        "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Remove Discount".
        /// </summary>
        private void buttonRemoveDiscount_Click(object sender, EventArgs e)
        {
            int selectedCustomerIndex = CustomersListBox.SelectedIndex;
            int selectedDiscountIndex = listBoxDiscounts.SelectedIndex;

            if (selectedCustomerIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedDiscountIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите скидку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedCustomer = _customers[selectedCustomerIndex];
            var selectedDiscount = selectedCustomer.Discounts[selectedDiscountIndex];

            if (selectedDiscount is PointsDiscount)
            {
                MessageBox.Show("Невозможно удалить накопительную скидку, так как она обязательна для каждого клиента.",
                                "Удаление невозможно", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedCustomer.Discounts.RemoveAt(selectedDiscountIndex);
            listBoxDiscounts.Items.RemoveAt(selectedDiscountIndex);

            MessageBox.Show("Скидка успешно удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// Очищает текстовые поля, связанные с клиентом.
        /// </summary>
        private void ClearInputFields()
        {
            textBoxId2.Text = "";
            textBoxFullName.Text = "";
            addressControl1.ClearFields();
            checkBoxIsPriority.Checked = false;
        }
    }
}
