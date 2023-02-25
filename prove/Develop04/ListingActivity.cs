using System;
using System.Collections.Generic;
class ListingActivity : Activity
{
    Random random = new Random();
    private List<string> _listPrompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    private string _listInput;
    public ListingActivity(string name, string description) : base(name, description)
    {
    }
    public void DisplayCounter()
    {
        Console.WriteLine($"You listed {_userList.Count()} items!");
    }
    public void ListingRunActvity()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        int i = random.Next(_listPrompts.Count);
        Console.WriteLine($"---{_listPrompts[i]}---");
        Console.Write($"You may begin in: ");
        CountdownTimer(5);
        Console.WriteLine();
    }
    public void ListUserInput()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            _listInput = Console.ReadLine();
            _userList.Add(_listInput);
            currentTime = DateTime.Now;
        }
    }
}




