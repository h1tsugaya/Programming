using System;

/// <summary>
/// Представляет фильм.
/// </summary>
class Movie
{
    string _name;
    int _duration;
    double _rating;
    int _releaseYear;

    /// <summary>
    /// Получает или задает название фильма.
    /// </summary>
    public string Name
    {
        get { return _name; }
        set
        {
            if (value.Length == 0)
            {
                throw new ArgumentException("Name is empty!");
            }
            _name = value;
        }
    }

    /// <summary>
    /// Получает или задает год выпуска фильма.
    /// </summary>
    public int ReleaseYear
    {
        get { return _releaseYear; }
        set
        {
            Validator.AssertValueInRange(value, 1850, DateTime.Now.Year + 1);
            _releaseYear = value;
        }
    }

    /// <summary>
    /// Получает или задает длительность фильма в минутах.
    /// </summary>
    public int Duration
    {
        get { return _duration; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _duration = value;
        }
    }

    /// <summary>
    /// Получает или задает жанр фильма.
    /// </summary>
    public Genre Genre { get; set; }

    /// <summary>
    /// Получает или задает рейтинг фильма.
    /// </summary>
    public double Rating
    {
        get { return _rating; }
        set
        {
            Validator.AssertValueInRange(value, 0, 11);
            _rating = value;
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Movie со значениями по умолчанию.
    /// </summary>
    public Movie()
    {
        Name = "Fight Club";
        Duration = 139;
        ReleaseYear = 1999;
        Genre = Genre.Thriller;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Movie с указанными параметрами.
    /// </summary>
    /// <param name="name">Название фильма.</param>
    /// <param name="duration">Длительность фильма в минутах.</param>
    /// <param name="releaseyear">Год выпуска фильма.</param>
    /// <param name="genre">Жанр фильма.</param>
    /// <param name="rating">Рейтинг фильма.</param>
    public Movie(string name, int duration, int releaseyear, Genre genre, double rating)
    {
        Name = name;
        ReleaseYear = releaseyear;
        Duration = duration;
        Genre = genre;
        Rating = rating;
    }
}