using ProjectProgramming.Model;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace ProjectProgramming
{
    public partial class MainForm : Form
    {
        bool _isProgrammaticChange = false;
        List<Rectangle> _intersecting = new List<Rectangle>();
        List<Panel> _rectanglePanels;
        List<Rectangle> _rectangles;
        Rectangle _currentRectangle;
        Movie[] _movies = new Movie[5];
        Movie _currentMovie = new Movie();
        Type[] typeModel = new Type[6] { typeof(Color), typeof(EducationForms), typeof(Genre), typeof(SmartphoneManufacturers), typeof(Seasons), typeof(Weekday) };

        public MainForm()
        {
            InitializeComponent();
            // 
            // Initialize ComboBoxSeasons
            // 
            object[] values = Enum.GetValues(typeof(Seasons)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(values);
            Random random = new Random();
            //for (int i = 0; i < 5; i++)
            //{
            //    Rectangle rectangle = new Rectangle(random.Next(6, 51), random.Next(3, 58), Color.Green);
            //    _rectangles[i] = rectangle;
            //    RectanglesListBox.Items.Add(rectangle);
            //}

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

            CustomMethods.TextBoxRectangles = new TextBox[5] { textBoxRectangleId,
                                                                textBoxRectangleWidth,
                                                                textBoxRectangleHeight,
                                                                textBoxRectangleX,
                                                                textBoxRectangleY };

            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
        }

        void textBoxRectangleX_TextChanged(object sender, EventArgs e)
        {
            TextBoxCoordinatesHandler(textBoxRectangleX, "x");
        }
        void textBoxRectangleY_TextChanged(object sender, EventArgs e)
        {
            TextBoxCoordinatesHandler(textBoxRectangleY, "y");
        }
        void textBoxRectangleWidth_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleHandler(textBoxRectangleWidth, "width");
        }
        void textBoxRectangleHeight_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleHandler(textBoxRectangleHeight, "height");
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

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
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
            textBoxLength.Text = rectangle.Height.ToString();
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
                int height = int.Parse(textBoxLength.Text);
                _currentRectangle.Height = height;

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

        private void buttonAddRectanlge_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize(RectanglesPanel, 150, 150);
            _rectangles.Add(rectangle);
            listBoxForRectangles.Items.Add(rectangle);
            Panel panel = InitialPanel(rectangle);
            panel.BackColor = AppColors.Success;
            _rectanglePanels.Add(panel);
            RectanglesPanel.Controls.Add(panel);
            FindCollisions(rectangle);
        }
        private void buttonDeleteRectangle_Click(object sender, EventArgs e)
        {
            if (listBoxForRectangles.SelectedItem == null && listBoxForRectangles.SelectedIndex == -1) return;
            Rectangle rectangle = (Rectangle)listBoxForRectangles.SelectedItem;
            int selectedIndex = listBoxForRectangles.SelectedIndex;
            _rectangles.Remove(rectangle);
            listBoxForRectangles.Items.Remove(rectangle);
            ClearRectangleInfo();
            _rectanglePanels.RemoveAt(selectedIndex);
            RectanglesPanel.Controls.RemoveAt(selectedIndex);
            FindCollisions(rectangle);
        }
        /// <summary>
        /// Resizing a rectangle
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="dimensionType">"width" or "height"</param>
        private void listBoxForRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxForRectangles.SelectedItem == null) return;
            _currentRectangle = (Rectangle)listBoxForRectangles.SelectedItem;
            UpdateRectangleInfo(_currentRectangle, listBoxForRectangles.SelectedIndex);
        }
        void TextBoxSizeRectangleHandler(TextBox textBox, string dimensionType)
        {
            if (_currentRectangle == null || _isProgrammaticChange) return;
            try
            {
                int value = int.Parse(textBox.Text);
                switch (dimensionType)
                {
                    case "width":
                        _currentRectangle.Width = value;
                        break;
                    case "height":
                        _currentRectangle.Height = value;
                        break;
                    default: throw new ArgumentException("Non-existent argument value.");
                }
                ListBoxSelectedRectangleUpdate();

                textBox.BackColor = AppColors.Default;
            }
            catch (Exception)
            {
                textBox.BackColor = AppColors.Invalid;
            }
        }
        /// <summary>
        /// Moving a rectangle
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="coordinateType">"x" or "y"</param>
        void TextBoxCoordinatesHandler(TextBox textBox, string coordinateType)
        {
            if (_currentRectangle == null || _isProgrammaticChange) return;
            try
            {
                int coordinate = int.Parse(textBox.Text);
                switch (coordinateType)
                {
                    case "x":
                        _currentRectangle.Coordinates = new Point2D(coordinate, _currentRectangle.Coordinates.Y);
                        break;
                    case "y":
                        _currentRectangle.Coordinates = new Point2D(_currentRectangle.Coordinates.X, coordinate);
                        break;
                    default: throw new ArgumentException("Non-existent argument value.");
                }
                ListBoxSelectedRectangleUpdate();
                textBox.BackColor = AppColors.Default;
            }
            catch (Exception)
            {
                textBox.BackColor = AppColors.Invalid;
            }
        }
        void ListBoxSelectedRectangleUpdate()
        {
            int indexRectangles = listBoxForRectangles.Items.IndexOf(_currentRectangle);
            listBoxForRectangles.Items.RemoveAt(indexRectangles);
            listBoxForRectangles.Items.Insert(indexRectangles, _currentRectangle);
            listBoxForRectangles.SelectedIndex = indexRectangles;
            Panel panel = InitialPanel(_currentRectangle);
            panel.BackColor = AppColors.Success;
            _rectanglePanels[indexRectangles] = panel;
            RectanglesPanel.Controls.Clear();
            RectanglesPanel.Controls.AddRange(_rectanglePanels.ToArray());
            FindCollisions(_currentRectangle);
        }

        void FindCollisions(Rectangle rectangle)
        {
            // Создаём копию списка, чтобы из-за изменения во время выполнения цикла, не появлялась ошибка
            List<Rectangle> intersecting = new List<Rectangle>(_intersecting);
            // Перебираем ранее пересекающиеся прямоугольники со всеми прямоугольниками,
            foreach (Rectangle e in intersecting)
            {
                if (listBoxForRectangles.Items.IndexOf(e) == -1) continue;
                bool isRemove = true;
                foreach (Rectangle r in _rectangles)
                {
                    if (e != r && CollisionManager.IsCollision(e, r))
                    {
                        isRemove = false;
                        break;
                    }
                }
                if (isRemove)
                {
                    _intersecting.Remove(e);
                    _rectanglePanels[listBoxForRectangles.Items.IndexOf(e)].BackColor = AppColors.Success;
                }
            }
            if (_intersecting.Contains(rectangle)) _intersecting.Remove(rectangle);
            if (!_rectangles.Contains(rectangle)) return;

            bool flag = false;
            foreach (Rectangle r in _rectangles)
            {
                if (rectangle != r && CollisionManager.IsCollision(rectangle, r))
                {
                    if (!_intersecting.Contains(r)) _intersecting.Add(r);
                    _rectanglePanels[listBoxForRectangles.Items.IndexOf(r)].BackColor = AppColors.Danger;
                    flag = true;
                }
            }
            if (flag)
            {
                _intersecting.Add(rectangle);
                _rectanglePanels[listBoxForRectangles.Items.IndexOf(rectangle)].BackColor = AppColors.Danger;
            }
        }
        void UpdateRectangleInfo(Rectangle rectangle, int selectedIndex)
        {
            _isProgrammaticChange = true;
            textBoxRectangleId.Text = rectangle.Id.ToString();
            textBoxRectangleX.Text = rectangle.Coordinates.X.ToString();
            textBoxRectangleY.Text = rectangle.Coordinates.Y.ToString();
            textBoxRectangleWidth.Text = rectangle.Width.ToString();
            textBoxRectangleHeight.Text = rectangle.Height.ToString();
            listBoxForRectangles.SelectedIndex = selectedIndex;
            _isProgrammaticChange = false;
        }
        Panel InitialPanel(Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.Location = new Point((int)rectangle.Coordinates.X, (int)rectangle.Coordinates.Y);
            panel.Width = rectangle.Width;
            panel.Height = rectangle.Height;
            return panel;
        }
        void ClearRectangleInfo()
        {
            foreach (TextBox tb in CustomMethods.TextBoxRectangles)
            {
                tb.Clear();
                tb.BackColor = AppColors.Default;
            }
        }
    }
}