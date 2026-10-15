using System;
using System.Globalization;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;
    private string _name;

    public Activity(DateTime date, int minutes, string name)
    {
        _date = date;
        _minutes = minutes;
        _name = name;
    }

    // Derived classes need the length, but the variable stays private.
    protected int GetMinutes()
    {
        return _minutes;
    }

    // Each type of activity calculates these in its own way.
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Defined once here. It uses the overridden methods above,
    // so the derived classes do not need their own version.
    public string GetSummary()
    {
        string date = _date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture);
        string distance = GetDistance().ToString("0.0", CultureInfo.InvariantCulture);
        string speed = GetSpeed().ToString("0.0", CultureInfo.InvariantCulture);
        string pace = GetPace().ToString("0.0", CultureInfo.InvariantCulture);

        return $"{date} {_name} ({_minutes} min): Distance {distance} miles, Speed {speed} mph, Pace: {pace} min per mile";
    }
}