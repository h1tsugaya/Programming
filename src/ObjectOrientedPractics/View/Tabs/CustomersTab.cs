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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    Customer newCustomer = new Customer(
                        textBoxFullName.Text,
                        textBoxAddress.Text
                        );

                    _customers.Add(newCustomer);
                    CustomersListBox.Items.Add(newCustomer.Fullname);

                    ClearInputFields();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRemove2_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;
                _customers.RemoveAt(selectedIndex);
                CustomersListBox.Items.RemoveAt(selectedIndex);
                ClearInputFields();
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;
                Customer selectedCustomer = _customers[selectedIndex];

                textBoxId2.Text = selectedCustomer.Id.ToString();
                textBoxFullName.Text = selectedCustomer.Fullname;
                textBoxAddress.Text = selectedCustomer.Address;
            }
        }

        private bool ValidateInput()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
            {
                textBoxFullName.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                textBoxFullName.BackColor = SystemColors.Window;
            }

            if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
            {
                textBoxAddress.BackColor = Color.Red;
                isValid = false;
            }
            else
            {
                textBoxAddress.BackColor = SystemColors.Window;
            }

            return isValid;
        }
        private void ClearInputFields()
        {
            textBoxId2.Text = "";
            textBoxFullName.Text = "";
            textBoxAddress.Text = "";
        }
    }
}
