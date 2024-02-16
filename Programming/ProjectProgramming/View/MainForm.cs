namespace ProjectProgramming
{
    public partial class MainForm : Form
    {
        Type[] typeModel = new Type[6] { typeof(Color), typeof(EducationForms), typeof(Genre), typeof(SmartphoneManufacturers), typeof(Seasons), typeof(Weekday) };
        public MainForm()
        {
            InitializeComponent();
            object[] values = Enum.GetValues(typeof(Seasons)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(values);
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

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string selectedItemName = WeekdayTextBox.Text;
            if (int.TryParse(selectedItemName, out _))
            {
                MessageBox.Show("������� ������������ ��������!");
            }
            else if (TryGetEnumValue<Weekday>(selectedItemName, out Weekday value))
            {
                ResultLabel.Text = $"��� ���� ������ ({value} = {(int)value + 1})";
            }
            else
            {
                ResultLabel.Text = $"��� ������ ��� ������";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                MessageBox.Show("�������� �� �������!");
            }
            SeasonComboBox.BackColor = System.Drawing.Color.White;
            switch (SeasonComboBox.SelectedItem)
            {
                case Seasons.Summer:
                    MessageBox.Show("���! ������!");
                    break;
                case Seasons.Autumn:
                    BackgroundColor(ColorTranslator.FromHtml("#e29c45"));
                    break;
                case Seasons.Winter:
                    MessageBox.Show("����! �������!");
                    break;
                case Seasons.Spring:
                    BackgroundColor(ColorTranslator.FromHtml("#559c45"));
                    break;
            }
        }
        private void BackgroundColor(System.Drawing.Color color)
        {
            TabControl.BackColor = color;
            TabPageEnums.BackColor = color;
            this.BackColor = color;
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