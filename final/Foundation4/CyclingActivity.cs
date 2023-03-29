public class CyclingActivity : ExerciseActivity
{
    private double _speed;

    public CyclingActivity(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = _speed * _minutes;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}