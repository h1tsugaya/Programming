using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View;
using ObjectOrientedPractics.View.Tabs;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store;

        public MainForm()
        {
            InitializeComponent();
            _store = new Store();

            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Customers;

            cartsTab.Items = _store.Items;
            cartsTab.Customers = _store.Customers;

            ordersTab.Customers = _store.Customers;
            itemsTab.ItemsChanged += ItemsTab_ItemsChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControlMainForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMainForm.SelectedIndex == 2) 
            {
                cartsTab.RefreshData();
            }

            if (tabControlMainForm.SelectedIndex == 3)
            {
                ordersTab.RefreshData();
            }
        }

        /// <summary>
        /// Обработчик события ItemsChanged вкладки ItemsTab.
        /// </summary>
        private void ItemsTab_ItemsChanged(object sender, EventArgs e)
        {
            customersTab.RefreshData();
            cartsTab.RefreshData();
            ordersTab.RefreshData();
        }
    }
}
