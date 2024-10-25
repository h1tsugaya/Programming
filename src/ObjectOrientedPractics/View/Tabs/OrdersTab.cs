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
    public partial class OrdersTab : UserControl
    {
        public List<Customer> Customers { get; set; }
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Обновляет данные списка заказов и таблицы.
        /// </summary>
        public void UpdateOrders()
        {
            _orders.Clear();

            foreach (var customer in Customers)
            {
                _orders.AddRange(customer.Orders);
            }

            /*UpdateDataGridView();*/
        }

        /*/// <summary>
        /// Обновляет данные в таблице DataGridView на основе списка заказов.
        /// </summary>
        private void UpdateDataGridView()
        {
            dataGridViewOrders.Rows.Clear();

            foreach (var order in _orders)
            {
                int rowIndex = dataGridViewOrders.Rows.Add();
                var row = dataGridViewOrders.Rows[rowIndex];

                row.Cells["Id"].Value = order.Id;
                row.Cells["Created"].Value = order.Created;
                row.Cells["CustomerName"].Value = $"{order.Customer.FirstName} {order.Customer.LastName}";
                row.Cells["DeliveryAddress"].Value = $"{order.Address}";
                row.Cells["TotalAmount"].Value = order.TotalAmount;
                row.Cells["Status"].Value = order.Status.ToString();
            }
        }*/
        public OrdersTab()
        {
            InitializeComponent();
        }
    }
}
