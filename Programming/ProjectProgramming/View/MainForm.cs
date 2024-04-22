using System.Windows.Forms;

namespace ProjectProgramming
{
    public partial class MainForm : Form
    {
        Rectangle[] _rectangles = new Rectangle[5];
        Rectangle _currentRectangle;
        Movie[] _movies = new Movie[5];
        Movie _currentMovie = new Movie();
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

            string[] moviesListBoxItems = new string[5];
            string[] movieTitles = new string[5] { "Fight Club", "American Psycho", "Kill Bill", "Pulp Fiction", "Drive" };
            for (int i = 0; i < 5; i++)
            {
                int durationMinutes = random.Next(20, 280);
                int releaseYear = random.Next(1950, DateTime.Now.Year + 1);
                double rating = Math.Round(random.NextDouble() * 10, 1);
                Movie movie = new Movie(movieTitles[i], durationMinutes, releaseYear, Genre.Action, rating);
                _movies[i] = movie;
                moviesListBoxItems[i] = ($"Movie {i + 1}");
            }
            listBoxMovies.Items.AddRange(moviesListBoxItems);
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

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int MaxWidth = rectangles[0].Width;
            int MaxWidthIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rectangles[i].Width > MaxWidth)
                {
                    MaxWidth = rectangles[i].Width;
                    MaxWidthIndex = i;
                }
            }
            return MaxWidthIndex;
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
            middleXTextBox.Text = rectangle.Center.X.ToString();
            middleYTextBox.Text = rectangle.Center.Y.ToString();
            idTextBox.Text = rectangle.Id.ToString();
        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {

            int index = RectanglesListBox.Items.IndexOf(_currentRectangle);
            RectanglesListBox.Items.RemoveAt(index);
            RectanglesListBox.Items.Insert(index, _currentRectangle);
            try
            {
                textBoxLength.BackColor = System.Drawing.Color.White;
                int length = int.Parse(textBoxLength.Text);
                _currentRectangle.Length = length;

            }
            catch (Exception)
            {
                textBoxLength.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {

            int index = RectanglesListBox.Items.IndexOf(_currentRectangle);
            RectanglesListBox.Items.RemoveAt(index);
            RectanglesListBox.Items.Insert(index, _currentRectangle);
            try
            {
                textBoxWidth.BackColor = System.Drawing.Color.White;
                int width = int.Parse(textBoxWidth.Text);
                _currentRectangle.Width = width;
            }
            catch (Exception)
            {
                textBoxWidth.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            int RectangleMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = RectangleMaxWidthIndex;
        }

        private void listBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMovies.SelectedIndex == -1) return;
            _currentMovie = _movies[listBoxMovies.SelectedIndex];
            textBoxName.Text = _currentMovie.Name.ToString();
            textBoxDuration.Text = _currentMovie.Duration.ToString();
            textBoxYearRelease.Text = _currentMovie.ReleaseYear.ToString();
            textBoxGenre.Text = _currentMovie.Genre.ToString();
            textBoxRating.Text = _currentMovie.Rating.ToString();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxName.BackColor = System.Drawing.Color.White;
                string Name = textBoxName.Text;
                _currentMovie.Name = Name;
            }
            catch (Exception)
            {
                textBoxName.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxDuration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxDuration.BackColor = System.Drawing.Color.White;
                int Duration = int.Parse(textBoxDuration.Text);
                _currentMovie.Duration = Duration;
            }
            catch (Exception)
            {
                textBoxDuration.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxYearRelease_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxYearRelease.BackColor = System.Drawing.Color.White;
                int Release = int.Parse(textBoxYearRelease.Text);
                _currentMovie.ReleaseYear = Release;
            }
            catch (Exception)
            {
                textBoxYearRelease.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxGenre_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            string genre = textBoxGenre.Text;
            if (TryGetEnumValue<Genre>(genre, out Genre value))
            {
                _currentMovie.Genre = value;
                textBoxGenre.BackColor = System.Drawing.Color.White;
            }
            else
            {
                textBoxGenre.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxRating_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxRating.BackColor = System.Drawing.Color.White;
                double Rating = double.Parse(textBoxRating.Text);
                _currentMovie.Rating = Rating;
            }
            catch (Exception)
            {
                textBoxRating.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void buttonMovies_Click(object sender, EventArgs e)
        {
            double MovieMaxRateIndex = FindMovieMaxRate(_movies);
            listBoxMovies.SelectedIndex = (int)MovieMaxRateIndex;
        }
        private int FindMovieMaxRate(Movie[] _movies)
        {
            double MaxRate = _movies[0].Rating;
            int MaxRateIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (_movies[i].Rating > MaxRate)
                {
                    MaxRate = _movies[i].Rating;
                    MaxRateIndex = i;
                }
            }
            return MaxRateIndex;
        }
        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}