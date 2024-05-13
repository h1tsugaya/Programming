using System;

/// <summary>
/// Представляет время.
/// </summary>
class Time
{
    int _hours;
    int _minutes;
    int _seconds;

    /// <summary>
    /// Получает или задает часы.
    /// </summary>
    public int Hours
    {
        get { return _hours; }
        set
        {
            Validator.AssertValueInRange(value, 0, 24);
            _hours = value;
        }
    }

    /// <summary>
    /// Получает или задает минуты.
    /// </summary>
    public int Minutes
    {
        get { return _minutes; }
        set
        {
            Validator.AssertValueInRange(value, 0, 61);
            _minutes = value;
        }
    }

    /// <summary>
    /// Получает или задает секунды.
    /// </summary>
    public int Seconds
    {
        get { return _seconds; }
        set
        {
            Validator.AssertValueInRange(value, 0, 61);
            _seconds = value;
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Time со значениями текущего времени.
    /// </summary>
    public Time()
    {
        Hours = DateTime.Now.Hour;
        Minutes = DateTime.Now.Minute;
        Seconds = DateTime.Now.Second;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Time с указанными параметрами.
    /// </summary>
    /// <param name="hours">Часы.</param>
    /// <param name="minutes">Минуты.</param>
    /// <param name="seconds">Секунды.</param>
    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
}
