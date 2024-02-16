namespace ProjectProgramming
{
    public partial class MainForm : Form
    {
        Type[] typeModel = new Type[6] { typeof(Color), typeof(EducationForms), typeof(Genre), typeof(SmartphoneManufacturers), typeof(Seasons), typeof(Weekday) };
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

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

        private void EnumGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ParsingGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string selectedItemName = WeekdayTextBox.Text;
            if (int.TryParse(selectedItemName, out _))
            {
                MessageBox.Show("Введено неправильное значение!");
            }
            else if (TryGetEnumValue<Weekday>(selectedItemName, out Weekday value))
            {
                ResultLabel.Text = $"Это день недели ({value} = {(int)value + 1})";
            }
            else
            {
                ResultLabel.Text = $"Нет такого дня недели";
            }
        }
        static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }
    }
}