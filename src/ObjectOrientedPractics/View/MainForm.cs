using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View;

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
