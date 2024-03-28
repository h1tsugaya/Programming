using System;

class Movie
{
    string _name;
    int _duration;
    double _rating;
    int _releaseYear;

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

    public int ReleaseYear
    {
        get { return _releaseYear; }
        set
        {
            Validator.AssertValueInRange(value, 1850, DateTime.Now.Year + 1);
            _releaseYear = value;
        }
    }
    public int Duration
    {
        get { return _duration; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _duration = value;
        }
    }
    public Genre Genre { get; set; }

    public double Rating
    {
        get { return _rating; }
        set
        {
            Validator.AssertValueInRange(value, 0, 11);
            _rating = value;
        }
    }

    public Movie()
    {
        Name = "Fight Club";
        Duration = 139;
        ReleaseYear = 1999;
        Genre = Genre.Thriller;
    }

    public Movie(string name, int duration, int releaseyear, Genre genre, double rating)
    {
        Name = name;
        ReleaseYear = releaseyear;
        Duration = duration;
        Genre = genre;
        Rating = rating;
    }
}