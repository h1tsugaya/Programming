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
using System.Windows.Forms.VisualStyles;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Список всех заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Текущий выбранный заказ.
        /// </summary>
        private Order _currentOrder;

        private PriorityOrder _selectedPriorityOrder;

        public OrdersTab()
        {
            InitializeComponent();
            InitializeDataGridView();
            InitializeComboBoxStatus();
            InitializeComboBoxDeliveryTime();
        }

        private void InitializeComboBoxDeliveryTime()
        {
            comboBoxDeliveryTime.Items.Clear();
            comboBoxDeliveryTime.Items.AddRange(Enum.GetValues(typeof(DeliveryTime)).Cast<object>().ToArray());
        }

        /// <summary>
        /// Инициализирует настройки DataGridView для отображения заказов.
        /// </summary>
        private void InitializeDataGridView()
        {
            dataGridViewOrders.Columns.Clear();

            dataGridViewOrders.AutoGenerateColumns = false;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.MultiSelect = false;
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToResizeRows = false;
            dataGridViewOrders.AllowUserToOrderColumns = false;
            dataGridViewOrders.AllowUserToResizeColumns = false;

            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                ReadOnly = true
            });
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CreationDate",
                HeaderText = "Created",
                ReadOnly = true
            });
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CustomerName",
                HeaderText = "Customer",
                ReadOnly = true
            });
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DeliveryAddress",
                HeaderText = "Delivery Address",
                ReadOnly = true
            });
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "Total Amount",
                ReadOnly = true
            });
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Total",
                HeaderText = "Total",
                ReadOnly = true
            });
            dataGridViewOrders.Columns.Add(new DataGridViewComboBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                DataSource = Enum.GetValues(typeof(OrderStatus))
            });
        }

        /// <summary>
        /// Инициализирует настройки ComboBox для изменения статуса заказа.
        /// </summary>
        private void InitializeComboBoxStatus()
        {
            comboBoxStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
        }

        /// <summary>
        /// Обработчик изменения статуса заказа.
        /// </summary>
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder != null && comboBoxStatus.SelectedItem is OrderStatus selectedStatus)
            {
                _currentOrder.Status = selectedStatus;
                dataGridViewOrders.Refresh();
            }
        }

        private void comboBoxDeliveryTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedPriorityOrder != null && comboBoxDeliveryTime.SelectedItem is DeliveryTime selectedTime)
            {
                _selectedPriorityOrder.DesiredDeliveryTime = selectedTime;
            }
        }

        /// <summary>
        /// Обновляет список заказов и отображает их в таблице.
        /// </summary>
        public void UpdateOrders()
        {
            if (Customers == null)
            {
                _orders = new List<Order>();
                dataGridViewOrders.DataSource = null;
                return;
            }

            _orders = new List<Order>();

            foreach (var customer in Customers)
            {
                foreach (var order in customer.Orders)
                {
                    order.Customer = customer;
                    order.CustomerName = customer.Fullname;
                    _orders.Add(order);
                }
            }

            dataGridViewOrders.DataSource = null;
            dataGridViewOrders.DataSource = _orders;
        }

        /// <summary>
        /// Обработчик выбора строки в DataGridView.
        /// </summary>
        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewOrders.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < _orders.Count)
                {
                    _currentOrder = _orders[selectedIndex];

                    if (_currentOrder is PriorityOrder priorityOrder)
                    {
                        _selectedPriorityOrder = priorityOrder;
                        panelPriorityOrder.Visible = true;
                        comboBoxDeliveryTime.SelectedItem = priorityOrder.DesiredDeliveryTime;
                    }
                    else
                    {
                        _selectedPriorityOrder = null;
                        panelPriorityOrder.Visible = false;
                    }

                    DisplayOrderDetails(_currentOrder);
                }
            }
        }

        /// <summary>
        /// Отображает детали выбранного заказа на панели справа.
        /// </summary>
        /// <param name="order">Выбранный заказ.</param>
        private void DisplayOrderDetails(Order order)
        {
            textBoxIdOrder.Text = order.Id.ToString();
            textBoxCreated.Text = order.CreationDate.ToString("dd.MM.yyyy HH:mm");
            comboBoxStatus.SelectedItem = order.Status;
            addressControlOrdersTab.Address = order.Address;
            listBoxOrderItems.Items.Clear();
            listBoxOrderItems.Items.AddRange(order.Items.ToArray());
            labelTotalAmountOrdersTab.Text = order.TotalAmount.ToString("N2");
            labelTotalOrdersTab.Text = order.Total.ToString("N2");

            if (order is PriorityOrder priorityOrder)
            {
                comboBoxDeliveryTime.SelectedItem = priorityOrder.DesiredDeliveryTime;
                panelPriorityOrder.Visible = true;
            }
            else
            {
                panelPriorityOrder.Visible = false;
            }
        }

        public void RefreshData()
        {
            UpdateOrders();
        }

    }
}
