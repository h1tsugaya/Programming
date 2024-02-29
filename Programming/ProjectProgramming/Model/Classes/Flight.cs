using System;

class Flight
{
    string _departurePoint;
    string _destination;
    int _flightTimeMinutes;

    public string DeparturePoint
    {
        get { return _departurePoint; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _departurePoint = value;
        }
    }
    public string Destination
    {
        get { return _destination; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _destination = value;
        }
    }
    public int FlightTimeMinutes
    {
        get { return _flightTimeMinutes; }
        set
        {
            if (value < 1) throw new ArgumentException();
            _flightTimeMinutes = value;
        }
    }

    public Flight()
    {
        DeparturePoint = "Tomsk";
        Destination = "Krasnoyars";
        FlightTimeMinutes = 95;
    }

    public Flight(string departurePoint, string destination, int flightTimeMinutes)
    {
        DeparturePoint = departurePoint;
        Destination = destination;
        FlightTimeMinutes = flightTimeMinutes;
    }
}