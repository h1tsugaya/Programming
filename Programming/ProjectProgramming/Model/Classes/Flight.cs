using System;

/// <summary>
/// Представляет полет.
/// </summary>
class Flight
{
    string _departurePoint;
    string _destination;
    int _flightTimeMinutes;

    /// <summary>
    /// Получает или задает пункт отправления.
    /// </summary>
    public string DeparturePoint
    {
        get { return _departurePoint; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _departurePoint = value;
        }
    }

    /// <summary>
    /// Получает или задает пункт назначения.
    /// </summary>
    public string Destination
    {
        get { return _destination; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _destination = value;
        }
    }

    /// <summary>
    /// Получает или задает время полета в минутах.
    /// </summary>
    public int FlightTimeMinutes
    {
        get { return _flightTimeMinutes; }
        set
        {
            if (value < 1) throw new ArgumentException();
            _flightTimeMinutes = value;
        }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Flight со значениями по умолчанию.
    /// </summary>
    public Flight()
    {
        DeparturePoint = "Tomsk";
        Destination = "Krasnoyarsk";
        FlightTimeMinutes = 95;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса Flight с указанными параметрами.
    /// </summary>
    /// <param name="departurePoint">Пункт отправления.</param>
    /// <param name="destination">Пункт назначения.</param>
    /// <param name="flightTimeMinutes">Время полета в минутах.</param>
    public Flight(string departurePoint, string destination, int flightTimeMinutes)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTimeMinutes = flightTimeMinutes;
    }
}