using System;

class Song
{
    private string _title;
    private string _artist;
    private int _duration;
    private int _release;


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

    public Song()
    {
        Title = "Тп на аме";
        Artist = "Серега Пират";
        Duration = 155;
        Release = 2021;
    }

    public Song(string title, string artist, int duration, int release)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
        Release = release;
    }
}