using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View;
using ObjectOrientedPractics.View.Tabs;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        // Поле для хранения объекта Store.
        private Store _store;

        public MainForm()
        {
            InitializeComponent();
            // Инициализация Store.
            _store = new Store();

            // Присваиваем списки товаров и покупателей вкладкам.
            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Customers;

            cartsTab.Items = _store.Items;
            cartsTab.Customers = _store.Customers;

            ordersTab.Customers = _store.Customers;
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
    }
}
