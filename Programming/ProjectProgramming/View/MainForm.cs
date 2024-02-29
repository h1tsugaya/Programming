namespace ProjectProgramming
{
    public partial class MainForm : Form
    {
        Rectangle[] _rectangles = new Rectangle[5];
        Rectangle _currentRectangle = new Rectangle();
        Type[] typeModel = new Type[6] { typeof(Color), typeof(EducationForms), typeof(Genre), typeof(SmartphoneManufacturers), typeof(Seasons), typeof(Weekday) };
        public MainForm()
        {
            InitializeComponent();
            object[] values = Enum.GetValues(typeof(Seasons)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(values);
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Rectangle rectangle = new Rectangle(random.Next(6, 51), random.Next(3, 58), Color.Green);
                _rectangles[i] = rectangle;
                RectanglesListBox.Items.Add(rectangle);
            }
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

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                MessageBox.Show("Значение не выбрано!");
            }
            SeasonComboBox.BackColor = System.Drawing.Color.White;
            switch (SeasonComboBox.SelectedItem)
            {
                case Seasons.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Seasons.Autumn:
                    BackgroundColor(ColorTranslator.FromHtml("#e29c45"));
                    break;
                case Seasons.Winter:
                    MessageBox.Show("Бррр! Холодно!");
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

        static private bool TryGetEnumValue<T>(string itemName, out T value) where T : struct // T - пользовательский тип данных
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            Rectangle rectangle = (Rectangle)RectanglesListBox.SelectedItem;
            textBoxLength.Text = rectangle.Length.ToString();
            textBoxWidth.Text = rectangle.Width.ToString();
            textBoxColor.Text = rectangle.Color.ToString();
        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Length = Convert.ToInt32(textBoxLength.Text);
            int index = RectanglesListBox.Items.IndexOf(_currentRectangle);
            RectanglesListBox.Items.RemoveAt(index);
            RectanglesListBox.Items.Insert(index, _currentRectangle);
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Width = Convert.ToInt32(textBoxWidth.Text);
            int index = RectanglesListBox.Items.IndexOf(_currentRectangle);
            RectanglesListBox.Items.RemoveAt(index);
            RectanglesListBox.Items.Insert(index, _currentRectangle);
        }
    }
}