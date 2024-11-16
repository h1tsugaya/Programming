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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class AddDiscountForm : Form
    {
        public AddDiscountForm()
        {
            InitializeComponent();
        }

        public Category SelectedCategory => (Category)comboBoxDiscountCategory.SelectedItem;

        private void AddDiscountForm_Load(object sender, EventArgs e)
        {
            comboBoxDiscountCategory.DataSource = Enum.GetValues(typeof(Category));
            comboBoxDiscountCategory.SelectedIndex = 0;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (comboBoxDiscountCategory.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите категорию скидки.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
