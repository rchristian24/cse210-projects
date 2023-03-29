public class SwimmingActivity : ExerciseActivity
{
    private double _numberOfLaps;

    public SwimmingActivity(string date, double minutes, double numberOfLaps) : base(date, minutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        double distance = _numberOfLaps * 50 / 1000 * .62;
        return distance;
    }

    public override double GetSpeed()
    {
        return base.GetSpeed();
    }

    public override double GetPace()
    {
        return base.GetPace();
    }
}