using System;

class Movie
{
    string _name;
    int _duration;
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

    public int ReleaseYear { get; set; }
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
    public Genre Genre { get; set; }

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