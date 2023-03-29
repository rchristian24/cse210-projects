public abstract class ExerciseActivity
{
    private string _date;
    protected double _minutes;

    public ExerciseActivity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();

    public virtual double GetSpeed()
    {
        double speed = (GetDistance() / _minutes) * 60;
        return speed;
    }

    public virtual double GetPace()
    {
        double pace = _minutes / GetDistance();
        return pace;
    }

    public void DisplaySummary()
    {
        Console.WriteLine($"{_date} {GetType()} ({_minutes} minutes) - Distance: {Math.Round(GetDistance(), 2)} miles, Speed: {Math.Round(GetSpeed(), 2)} mph, Pace: {Math.Round(GetPace(), 2)} min per mile");
    }
}