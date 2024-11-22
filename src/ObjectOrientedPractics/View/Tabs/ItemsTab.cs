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
using ObjectOrientedPractics.Services;

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
        private List<Item> _items = new();
        private List<Item> _displayedItems = new();
        private Comparison<Item> _currentSortMethod;

        /// <summary>
        /// Событие, которое зажигается при изменении списка товаров.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            InitializeCategoryComboBox();
            InitializeComboBoxOrderItems();
            textBoxFindItems.TextChanged += TextBoxFindItems_TextChanged;
            _currentSortMethod = SortByName;
            ApplyFiltersAndSort();
        }

        /// <summary>
        /// Открытое свойство для получения или установки списка товаров.
        /// При установке обновляет элемент управления <see cref="ListBox"/>.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value ?? new List<Item>();
                ApplyFiltersAndSort();
                OnItemsChanged();
            }
        }

        /// <summary>
        /// Инициализирует выпадающий список для выбора способа упорядочивания.
        /// </summary>
        private void InitializeComboBoxOrderItems()
        {
            comboBoxOrderItems.Items.Add("По имени");
            comboBoxOrderItems.Items.Add("По возрастанию стоимости");
            comboBoxOrderItems.Items.Add("По убыванию стоимости");

            comboBoxOrderItems.SelectedIndex = 0; // Устанавливаем "По имени" по умолчанию
            comboBoxOrderItems.SelectedIndexChanged += ComboBoxOrderItems_SelectedIndexChanged;
        }

        /// <summary>
        /// Применяет фильтрацию и сортировку к товарам.
        /// </summary>
        private void ApplyFiltersAndSort()
        {
            string searchText = textBoxFindItems.Text.Trim();

            // Фильтрация
            if (string.IsNullOrEmpty(searchText))
            {
                _displayedItems = new List<Item>(_items);
            }
            else
            {
                _displayedItems = DataTools.Filter(_items,
                    item => item.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase));
            }

            // Сортировка
            _displayedItems.Sort(_currentSortMethod);
            UpdateItemsListBox();
        }

        /// <summary>
        /// Обновляет элемент управления <see cref="ListBox"/> для отображения товаров.
        /// </summary>
        private void UpdateItemsListBox()
        {
            int previousIndex = itemsListBox.SelectedIndex;
            itemsListBox.Items.Clear();
            foreach (var item in _displayedItems)
            {
                itemsListBox.Items.Add(item.Name);
            }

            if (previousIndex >= 0 && previousIndex < _displayedItems.Count)
            {
                itemsListBox.SelectedIndex = previousIndex;
            }
        }

        /// <summary>
        /// Сортировка по имени.
        /// </summary>
        private int SortByName(Item a, Item b) => string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// Сортировка по возрастанию стоимости.
        /// </summary>
        private int SortByCostAscending(Item a, Item b) => a.Cost.CompareTo(b.Cost);

        /// <summary>
        /// Сортировка по убыванию стоимости.
        /// </summary>
        private int SortByCostDescending(Item a, Item b) => b.Cost.CompareTo(a.Cost);

        /// <summary>
        /// Обрабатывает изменение способа упорядочивания в выпадающем списке.
        /// </summary>
        private void ComboBoxOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxOrderItems.SelectedIndex)
            {
                case 0:
                    _currentSortMethod = SortByName;
                    break;
                case 1:
                    _currentSortMethod = SortByCostAscending;
                    break;
                case 2:
                    _currentSortMethod = SortByCostDescending;
                    break;
            }

            ApplyFiltersAndSort();
        }

        /// <summary>
        /// Обрабатывает изменение текста в поисковой строке.
        /// </summary>
        private void TextBoxFindItems_TextChanged(object sender, EventArgs e)
        {
            ApplyFiltersAndSort();
        }

        /// <summary>
        /// Инициализирует выпадающий список значениями из перечисления Category.
        /// </summary>
        private void InitializeCategoryComboBox()
        {
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                comboBoxCategory.Items.Add(category);
            }

            comboBoxCategory.SelectedIndex = 0;

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

                selectedItem.Category = (Category)comboBoxCategory.SelectedItem;
                OnItemsChanged();
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
                        double.Parse(textBoxCost.Text),
                        (Category)comboBoxCategory.SelectedItem
                    );

                    _items.Add(newItem);
                    ApplyFiltersAndSort();
                    ClearInputFields();
                    OnItemsChanged();
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
                Item selectedItem = _displayedItems[itemsListBox.SelectedIndex];
                _items.Remove(selectedItem);
                ApplyFiltersAndSort();
                ClearInputFields();
                OnItemsChanged();
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
                Item selectedItem = _displayedItems[itemsListBox.SelectedIndex];
                int realIndex = _items.IndexOf(selectedItem);

                ShowItemDetails(realIndex);
            }
        }

        /// <summary>
        /// Отображает информацию о товаре на правой панели.
        /// </summary>
        private void ShowItemDetails(int index)
        {
            if (index >= 0 && index < _items.Count)
            {
                var item = _items[index];
                textBoxId.Text = item.Id.ToString();
                textBoxName.Text = item.Name;
                textBoxDescription.Text = item.Info;
                textBoxCost.Text = item.Cost.ToString();
                comboBoxCategory.SelectedItem = item.Category;
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

            if (!double.TryParse(textBoxCost.Text, out double cost) || cost < 0 || cost > 100000)
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

        /// <summary>
        /// Вызывает событие ItemsChanged.
        /// </summary>
        private void OnItemsChanged()
        {
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
