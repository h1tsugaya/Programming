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
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    // Создаем новый товар на основе введенных данных
                    Item newItem = new Item(
                        textBoxName.Text,
                        textBoxDescription.Text,
                        decimal.Parse(textBoxCost.Text)
                    );

                    // Добавляем товар в список и обновляем ListBox
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

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            {
                if (itemsListBox.SelectedIndex != -1)
                {
                    int selectedIndex = itemsListBox.SelectedIndex;
                    _items.RemoveAt(selectedIndex);
                    itemsListBox.Items.RemoveAt(selectedIndex);
                    ClearInputFields();
                }
            }
        }
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
            }
        }
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
        private void ClearInputFields()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            textBoxCost.Text = "";
        }
    }
}
