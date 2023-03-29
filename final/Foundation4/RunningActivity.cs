public class RunningActivity : ExerciseActivity
{
    private double _distance;

    public RunningActivity(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        double distance = _distance;
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