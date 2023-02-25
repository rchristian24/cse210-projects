using System;
class BreathingActivity : Activity
{
    int _in;
    int _out;
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }
    public BreathingActivity(int inBreath, int outBreath, string name, string description) : base(name, description)
    {
        _in = inBreath;
        _out = outBreath;
    }
    public int OxygenIn()
    {
        Console.Write("Amount of seconds for Breathe in: ");
        string oxygenIn = Console.ReadLine();
        _in = int.Parse(oxygenIn);
        Console.WriteLine();
        return _in;
    }
    public int OxygenOut()
    {
        Console.Write("Amount of seconds for Breathe out: ");
        string oxygenOut = Console.ReadLine();
        _out = int.Parse(oxygenOut);
        return _out;
    }
    public void Breathing()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime)
        {
            Console.WriteLine();
            Console.Write($"Breathe in... ");
            CountdownTimer(_in);

            Console.WriteLine();
            Console.Write($"Now breathe out... ");
            CountdownTimer(_out);

            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}