using System;
class ReflectionActivity : Activity
{
    private List<string> _reflectionPrompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    int _counter;
    public ReflectionActivity(string name, string description) : base(name, description)
    {
    }
    public void PauseDisplay()
    {
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine();
        Console.Write("You may begin in:  ");
        CountdownTimer(8);
        Console.WriteLine();
    }
    public void DisplayPrompt()
    {
        ShufflePrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        if (_counter > _questions.Count)
        {
            _counter = 0;
        }
        Console.WriteLine($"---{_reflectionPrompts[_counter]}---");
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue");
        Console.ReadLine();
        _counter++;
    }
    public void ShufflePrompt()
    {
        int lastIndex = _reflectionPrompts.Count() - 1;

        while (lastIndex > 0)
        {
            string tempValue = _reflectionPrompts[lastIndex];
            int randomIndex = new Random().Next(0, lastIndex);
            _reflectionPrompts[lastIndex] = _reflectionPrompts[randomIndex];
            _reflectionPrompts[randomIndex] = tempValue;
            lastIndex--;
        }
    }
    public void Shuffle()
    {
        int lastIndex = _questions.Count() - 1;

        while (lastIndex > 0)
        {
            string tempValue = _questions[lastIndex];
            int randomIndex = new Random().Next(0, lastIndex);
            _questions[lastIndex] = _questions[randomIndex];
            _questions[randomIndex] = tempValue;
            lastIndex--;
        }
    }
    public void RunList()
    {
        Shuffle();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            if (_counter > _questions.Count)
            {
                _counter = 0;
            }
            Console.WriteLine($"{_questions[_counter]}");
            PauseSpinner();
            Console.WriteLine();
            Thread.Sleep(2000);
            _counter++;
            currentTime = DateTime.Now;
        }
    }
}