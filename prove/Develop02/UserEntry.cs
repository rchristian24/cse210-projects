public class UserEntry
{
    public string _userPrompt;
    public string _userDate;
    public string _userResponse;

    public void DisplayUserEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _userDate = theCurrentTime.ToShortDateString();

        Console.WriteLine($"Date: {_userDate}  {_userPrompt}");
        Console.WriteLine($"{_userResponse}");
        Console.WriteLine();
    }
}
