using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        // ���� ��� �������� ������� Store.
        private Store _store;

        public MainForm()
        {
            InitializeComponent();
            // ������������� Store.
            _store = new Store();

            // ����������� ������ ������� � ����������� ��������.
            itemsTab.Items = _store.Items;
            customersTab.Customers = _store.Customers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
