using System;

class Movie
{
    string _name;
    int _duration;
    int _releaseYear;
    string _genre;
    double _rating;

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
    public int Duration
    {
        get { return _duration; }
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Duration cannot be less then 1 minutes!");
            }
            _duration = value;
        }
    }

    public int ReleaseYear
    {
        get { return _releaseYear; }
        set
        {
            if (value < 1895)
            {
                throw new ArgumentException("Films were not released until 1895!");
            }
            _duration = value;
        }
    }
    public string Genre
    {
        get { return _genre; }
        set { _genre = value; }
    }

    public double Rating
    {
        get { return _rating; }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("The rating cannot be less than zero and more than 10!");
            }
            _rating = value;
        }
    }

    public Movie()
    {
        Name = "Fight Club";
        Duration = 139;
        ReleaseYear = 1999;
        Genre = "thriller";
    }

    public Movie(string name, int duration, int releaseyear, string genre, double rating)
    {
        Name = name;
        Duration = duration;
        ReleaseYear = releaseyear;
        Genre = genre;
        Rating = rating;
    }
}