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
    public partial class MoviesControl : UserControl
    {
        Movie[] _movies = new Movie[5];
        Movie _currentMovie = new Movie();
        public MoviesControl()
        {
            InitializeComponent();
            Random random = new Random();
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
        static private bool TryGetEnumValue<T>(string itemName, out T value) where T : struct // T - пользовательский тип данных
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
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
    }
}
