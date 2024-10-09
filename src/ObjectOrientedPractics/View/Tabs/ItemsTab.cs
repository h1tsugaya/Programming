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

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка, отображающая и управляющая товарами.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            InitializeCategoryComboBox();
        }

        /// <summary>
        /// Инициализирует выпадающий список значениями из перечисления Category.
        /// </summary>
        private void InitializeCategoryComboBox()
        {
            // Добавляем все значения перечисления Category в выпадающий список
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                comboBoxCategory.Items.Add(category);
            }

            // Устанавливаем значение по умолчанию (первое значение списка)
            comboBoxCategory.SelectedIndex = 0;

            // Добавляем обработчик для события изменения выбранного элемента
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
        }

        /// <summary>
        /// Обрабатывает событие изменения категории в выпадающем списке.
        /// Присваивает выбранную категорию текущему выбранному товару.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = itemsListBox.SelectedIndex;
                Item selectedItem = _items[selectedIndex];

                // Присваиваем новую категорию выбранному товару
                selectedItem.Category = (Category)comboBoxCategory.SelectedItem;
            }
        }

        /// <summary>
        /// Обрабатывает событие нажатия кнопки "Add".
        /// Добавляет новый товар в список и обновляет <see cref="ListBox"/>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Item newItem = new Item(
                        textBoxName.Text,
                        textBoxDescription.Text,
                        decimal.Parse(textBoxCost.Text),
                        (Category)comboBoxCategory.SelectedItem
                    );

                    _items.Add(newItem);
                    itemsListBox.Items.Add(newItem.Name);

                    ClearInputFields();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Обрабатывает событие нажатия кнопки "Remove".
        /// Удаляет выбранный товар из списка и <see cref="ListBox"/>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = itemsListBox.SelectedIndex;
                _items.RemoveAt(selectedIndex);
                itemsListBox.Items.RemoveAt(selectedIndex);
                ClearInputFields();
            }
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранного элемента в <see cref="ListBox"/>.
        /// Отображает информацию о выбранном товаре в текстовых полях.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (itemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = itemsListBox.SelectedIndex;
                Item selectedItem = _items[selectedIndex];

                textBoxId.Text = selectedItem.Id.ToString();
                textBoxName.Text = selectedItem.Name;
                textBoxDescription.Text = selectedItem.Info;
                textBoxCost.Text = selectedItem.Cost.ToString();
                comboBoxCategory.SelectedItem = selectedItem.Category;
            }
        }

        /// <summary>
        /// Проверяет корректность введенных данных.
        /// Подсвечивает текстовые поля красным, если данные неверны.
        /// </summary>
        /// <returns>Возвращает <see langword="true"/>, если все данные корректны, иначе <see langword="false"/>.</returns>
        private bool ValidateInput()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                textBoxName.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                textBoxName.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(textBoxDescription.Text))
            {
                textBoxDescription.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                textBoxDescription.BackColor = SystemColors.Window;
            }

            if (!decimal.TryParse(textBoxCost.Text, out decimal cost) || cost < 0 || cost > 100000)
            {
                textBoxCost.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                textBoxCost.BackColor = SystemColors.Window;
            }

            return isValid;
        }

        /// <summary>
        /// Очищает все текстовые поля.
        /// </summary>
        private void ClearInputFields()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            textBoxCost.Text = "";
            comboBoxCategory.SelectedIndex = 0;
        }
    }
}
