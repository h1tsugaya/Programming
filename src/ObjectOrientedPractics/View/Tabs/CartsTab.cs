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
                string customerName = _currentCustomer.Fullname;
                DateTime creationDate = DateTime.Now;
                List<Item> items = new List<Item>(_currentCustomer.Cart.Items);
                Order newOrder;

                if (_currentCustomer.IsPriority)
                {
                    // Создаем приоритетный заказ
                    DateTime desiredDeliveryDate = DateTime.Now.AddDays(1);
                    DeliveryTime desiredDeliveryTime = DeliveryTime.Range9To11;
                    newOrder = new PriorityOrder(customerName, OrderStatus.New, creationDate, items, desiredDeliveryDate, desiredDeliveryTime)
                    {
                        Address = _currentCustomer.Address
                    };
                }
                else
                {
                    newOrder = new Order(customerName, OrderStatus.New, creationDate, items)
                    {
                        Address = _currentCustomer.Address
                    };
                }

                // Применяем выбранные скидки
                for (int i = 0; i < checkedListBoxDiscount.Items.Count; i++)
                {
                    if (checkedListBoxDiscount.GetItemChecked(i))
                    {
                        var discount = _currentCustomer.Discounts[i];
                        discount.Apply(_currentCustomer.Cart.Items);
                    }
                }

                // Обновляем все скидки
                foreach (var discount in _currentCustomer.Discounts)
                {
                    discount.Update(_currentCustomer.Cart.Items);
                }

                _currentCustomer.Orders.Add(newOrder);
                items.Clear();
                ClearCart();
                UpdateAmount();
                UpdateDiscountsListBox();
                CalculateDiscounts();
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
                UpdateDiscountsListBox();
                CalculateDiscounts();
            }
            else
            {
                _currentCustomer = null;
                listBoxCart.Items.Clear();
                checkedListBoxDiscount.Items.Clear();
                UpdateAmount();
                UpdateDiscountAmount(0);
                UpdateTotalAmount();
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

        private void UpdateDiscountsListBox()
        {
            checkedListBoxDiscount.Items.Clear();

            if (_currentCustomer == null || _currentCustomer.Discounts == null) return;

            foreach (var discount in _currentCustomer.Discounts)
            {
                checkedListBoxDiscount.Items.Add(discount.Info, true);
            }
        }

        private void CalculateDiscounts()
        {
            if (_currentCustomer == null) return;

            double discountAmount = 0.0;

            for (int i = 0; i < checkedListBoxDiscount.Items.Count; i++)
            {
                if (checkedListBoxDiscount.GetItemChecked(i))
                {
                    var discount = _currentCustomer.Discounts[i];
                    discountAmount += discount.Calculate(_currentCustomer.Cart.Items);
                }
            }

            UpdateDiscountAmount(discountAmount);
            UpdateTotalAmount();
        }

        private void checkedListBoxDiscount_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Используем метод BeginInvoke, чтобы дождаться изменения состояния галочки
            this.BeginInvoke((MethodInvoker)(() =>
            {
                CalculateDiscounts();
            }));
        }

        private void UpdateDiscountAmount(double amount)
        {
            labelDiscountAmountCount.Text = amount.ToString("F2");
        }

        private void UpdateTotalAmount()
        {
            if (_currentCustomer == null) return;

            double totalAmount = _currentCustomer.Cart.Amount - double.Parse(labelDiscountAmountCount.Text);
            labelTotalCount.Text = totalAmount.ToString("F2");
        }

    }
}
