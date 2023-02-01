public class Entry
{
    public string _prompt;
    public string _date;
    public string _response;
    
    public void DisplayEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        Console.WriteLine($"Date: {_date}  {_prompt}");
        Console.WriteLine($"{_response}");
    }
}
