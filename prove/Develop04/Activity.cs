using System;
using System.Threading;
class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected List<string> _userList = new List<string>();

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void GetGreeting()
    {
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}\n\n{_description}");
        Console.WriteLine();
    }
    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like your session to last? ");

        _duration = int.Parse(Console.ReadLine());
        return _duration;
    }
    public void StartActivity()
    {
        Console.WriteLine("Get Ready ...");
        PauseSpinner();
        Console.WriteLine();
    }
    public void PauseSpinner()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
    }
    public void CountdownTimer(int seconds)
    {
        while (seconds > 0)
        {
            seconds = seconds - 1;
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void GetEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }
}