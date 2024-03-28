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
            Validator.AssertValueInRange(value, 0, 24);
            _hours = value;
        }
    }
    public int Minutes
    {
        get { return _minutes; }
        set
        {
            Validator.AssertValueInRange(value, 0, 61);
            _minutes = value;
        }
    }
    public int Seconds
    {
        get { return _seconds; }
        set
        {
            Validator.AssertValueInRange(value, 0, 61);
            _seconds = value;
        }
    }

    public Time()
    {
        Hours = DateTime.Now.Hour;
        Minutes = DateTime.Now.Minute;
        Seconds = DateTime.Now.Second;
    }

    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
}
