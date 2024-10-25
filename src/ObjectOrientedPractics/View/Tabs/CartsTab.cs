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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Поле для хранения текущего выбранного покупателя.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Список доступных товаров.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Обновляет данные вкладки, включая список товаров и покупателей.
        /// </summary>
        public void RefreshData()
        {
            if (Items != null)
            {
                listBoxCartItems.Items.Clear();
                listBoxCartItems.Items.AddRange(Items.ToArray());

            }
            if (Customers != null)
            {
                comboBoxCustomer.Items.Clear();
                comboBoxCustomer.Items.AddRange(Customers.ToArray());

            }
        }

        /// <summary>
        /// Очищает корзину текущего покупателя.
        /// </summary>
        private void ClearCart()
        {
            if (_currentCustomer != null)
            {
                _currentCustomer.Cart.Items.Clear();
                listBoxCart.Items.Clear();
            }
        }

        /// <summary>
        /// Обновляет отображение общей суммы товаров в корзине.
        /// </summary>

        private void UpdateAmount()
        {
            if (_currentCustomer == null)
            {
                labelAmountCount.Text = "0";
                return;
            }
            labelAmountCount.Text = _currentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки добавления товара в корзину.
        /// Добавляет выбранный товар из списка в корзину текущего покупателя.
        /// </summary>
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            if (listBoxCartItems.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.Add((Item)listBoxCartItems.SelectedItem);
                listBoxCart.Items.Add(listBoxCartItems.SelectedItem);
                listBoxCartItems.SelectedIndex = -1;
                UpdateAmount();
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки удаления товара из корзины.
        /// Удаляет выбранный товар из корзины текущего покупателя.
        /// </summary>
        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxCart.SelectedIndex != -1)
            {
                _currentCustomer.Cart.Items.RemoveAt(listBoxCart.SelectedIndex);
                listBoxCart.Items.RemoveAt(listBoxCart.SelectedIndex);
                UpdateAmount();
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки очистки корзины.
        /// Очищает корзину и обновляет сумму.
        /// </summary>
        private void buttonClearCart_Click(Object sender, EventArgs e)
        {
            ClearCart();
            UpdateAmount();
        }

        /// <summary>
        /// Обработчик события нажатия кнопки создания заказа.
        /// Создает новый заказ на основе товаров в корзине текущего покупателя и очищает корзину.
        /// </summary>
        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            if (listBoxCart.Items.Count != 0)
            {
                string year = DateTime.Now.Year.ToString();
                string month = DateTime.Now.Month.ToString();
                string day = DateTime.Now.Day.ToString();
                string hour = DateTime.Now.Hour.ToString();
                string minute = DateTime.Now.Minute.ToString();
                string Date = day + "." + month + "." + year + ". " + hour + ":" + minute;
                List<Item> items = _currentCustomer.Cart.Items;
                Order newOrder = new Order(OrderStatus.New, Date, items);
                _currentCustomer.Orders.Add(newOrder);
                items.Clear();
                ClearCart();
                UpdateAmount();
            }
        }

        /// <summary>
        /// Обработчик события изменения выбранного покупателя в выпадающем списке.
        /// Обновляет текущего покупателя и отображает его корзину.
        /// </summary>
        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCustomer.SelectedIndex != -1)
            {
                _currentCustomer = (Customer)comboBoxCustomer.SelectedItem;
                UpdateCartItemsListBox();
                UpdateAmount();
            }
            else
            {
                _currentCustomer = null;
                listBoxCart.Items.Clear();
                UpdateAmount();
            }
        }

        /// <summary>
        /// Обновляет отображение товаров в корзине текущего покупателя в списке ListBox.
        /// </summary>
        private void UpdateCartItemsListBox()
        {
            listBoxCart.Items.Clear();
            if (_currentCustomer != null)
            {
                listBoxCart.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
            }
        }

    }
}
