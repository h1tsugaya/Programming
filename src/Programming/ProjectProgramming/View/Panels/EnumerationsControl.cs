using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectProgramming.View.Panels
{
    public partial class EnumerationsControl : UserControl
    {
        Type[] typeModel = new Type[6] { typeof(Color), typeof(EducationForms), typeof(Genre), typeof(SmartphoneManufacturers), typeof(Seasons), typeof(Weekday) };

        public EnumerationsControl()
        {
            InitializeComponent();
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(typeModel[selectedIndex]).Cast<object>().ToArray();
            TextBoxValue.Text = "";
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedIndex == -1) return;
            TextBoxValue.Text = ValuesListBox.SelectedIndex.ToString();
        }
    }
}
