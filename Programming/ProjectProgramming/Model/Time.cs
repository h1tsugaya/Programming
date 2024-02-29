using System;

class Time
{
    int _hours;
    int _minutes;
    int _seconds;


    public int Hours
    {
        get { return _hours; }
        set
        {
            if (value < 0 || value > 24)
            {
                throw new ArgumentException("The Hours cannot be less than 0 and more than 24!");
            }
            _hours = value;
        }
    }
    public int Minutes
    {
        get { return _minutes; }
        set
        {
            if (value < 0 || value > 60)
            {
                throw new ArgumentException("The Minutes cannot be less than zero and more than 60!");
            }
            _minutes = value;
        }
    }

    public int Seconds
    {
        get { return _seconds; }
        set
        {
            if (value < 0 || value > 60)
            {
                throw new ArgumentException("The Seconds cannot be less than zero and more than 60!");
            }
            _seconds = value;
        }
    }

    public Time()
    {
        Hours = 21;
        Minutes = 10;
        Seconds = 41;
    }

    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
}