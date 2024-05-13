using System;

/// <summary>
/// Представляет песню.
/// </summary>
class Song
{
    private string _title;
    private string _artist;
    private int _duration;
    private int _release;

    /// <summary>
    /// Получает или задает название песни.
    /// </summary>
    public string Title
    {
        get { return _title; }
        set
        {
            if (value.Length < 0)
            {
                throw new ArgumentException("Title is empty!");
            }
            _title = value;
        }
    }

    /// <summary>
    /// Получает или задает имя исполнителя.
    /// </summary>
    public string Artist
    {
        get { return _artist; }
        set
        {
            if (value.Length < 0)
            {
                throw new ArgumentException("Name of artist is empty!");
            }
            _artist = value;
        }
    }

    /// <summary>
    /// Получает или задает продолжительность песни в минутах.
    /// </summary>
    public int Duration
    {
        get { return _duration; }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("The duration cannot be less than 1 minute!");
            }
            _duration = value;
        }
    }

    /// <summary>
    /// Получает или задает год выпуска песни.
    /// </summary>
    public int Release
    {
        get { return _release; }
        set
        {
            if (value < 1996)
            {
                throw new ArgumentException("There were no players before 1996!");
            }
            _release = value;
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Song со значениями по умолчанию.
    /// </summary>
    public Song()
    {
        Title = "Тп на аме";
        Artist = "Серега Пират";
        Duration = 155;
        Release = 2021;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Song с указанными параметрами.
    /// </summary>
    /// <param name="title">Название песни.</param>
    /// <param name="artist">Исполнитель.</param>
    /// <param name="duration">Продолжительность песни в минутах.</param>
    /// <param name="release">Год выпуска песни.</param>
    public Song(string title, string artist, int duration, int release)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
        Release = release;
    }
}