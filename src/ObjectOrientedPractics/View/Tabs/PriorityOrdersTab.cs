using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
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
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder _currentPriorityOrder;

        public PriorityOrdersTab()
        {
            InitializeComponent();
            InitializeComboBoxDeliveryTime();
            InitializeComboBoxStatus();
            ClearOrder();
        }

        private void InitializeComboBoxDeliveryTime()
        {
            comboBoxDeliveryTime.Items.AddRange(new string[]
            {
                "9:00 - 11:00",
                "11:00 - 13:00",
                "13:00 - 15:00",
                "15:00 - 17:00",
                "17:00 - 19:00",
                "19:00 - 21:00"
            });
        }

        private void InitializeComboBoxStatus()
        {
            comboBoxStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
        }

        private void DisplayPriorityOrderDetails(PriorityOrder order)
        {
            textBoxIdOrder.Text = order.Id.ToString();
            textBoxCreated.Text = order.CreationDate.ToString("dd.MM.yyyy HH:mm");
            comboBoxStatus.SelectedItem = order.Status;
            addressControl1.Address = order.Address;
            comboBoxDeliveryTime.SelectedItem = order.DesiredDeliveryTime;
            listBoxOrderItems.Items.Clear();
            listBoxOrderItems.Items.AddRange(order.Items.ToArray());
            labelTotalAmountOrdersTab.Text = order.TotalAmount.ToString("N2");
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            // Генерация случайного товара
            var randomItem = new Item { Name = "Random Item", Cost = new Random().Next(100, 5000) };
            _currentPriorityOrder.Items.Add(randomItem);
            listBoxOrderItems.Items.Add(randomItem);
            labelTotalAmountOrdersTab.Text = _currentPriorityOrder.TotalAmount.ToString("N2");
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (listBoxOrderItems.SelectedItem is Item selectedItem)
            {
                _currentPriorityOrder.Items.Remove(selectedItem);
                listBoxOrderItems.Items.Remove(selectedItem);
                labelTotalAmountOrdersTab.Text = _currentPriorityOrder.TotalAmount.ToString("N2");
            }
        }

        private void buttonClearOrder_Click(object sender, EventArgs e)
        {
            ClearOrder();
        }

        private void ClearOrder()
        {
            _currentPriorityOrder = new PriorityOrder();
            DisplayPriorityOrderDetails(_currentPriorityOrder);
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentPriorityOrder != null && comboBoxStatus.SelectedItem is OrderStatus selectedStatus)
            {
                _currentPriorityOrder.Status = selectedStatus;
            }
        }

        private void comboBoxDeliveryTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentPriorityOrder != null)
            {
                _currentPriorityOrder.DesiredDeliveryTime = comboBoxDeliveryTime.SelectedItem.ToString();
            }
        }
    }
}
