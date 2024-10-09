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

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="CustomersTab"/>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
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
                    Customer newCustomer = new Customer(
                        textBoxFullName.Text,
                        newAddress
                        );

                    _customers.Add(newCustomer);
                    CustomersListBox.Items.Add(newCustomer.Fullname);

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
                Customer selectedCustomer = _customers[selectedIndex];

                textBoxId2.Text = selectedCustomer.Id.ToString();
                textBoxFullName.Text = selectedCustomer.Fullname;
                addressControl1.Address = selectedCustomer.Address;
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
        /// Очищает текстовые поля, связанные с клиентом.
        /// </summary>
        private void ClearInputFields()
        {
            textBoxId2.Text = "";
            textBoxFullName.Text = "";
            addressControl1.ClearFields();
        }
    }
}
