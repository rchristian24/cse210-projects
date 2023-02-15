using System;
public class Writing : Assignment
{
    private string _title;
    public Writing()
    {
        _title ="";
    }
    public Writing(string title, string name, string topic) : base(name, topic)
    {
        _title = title;
    }
    public string GetWritingInfo()
    {
        return $"{GetSummary()}\n{_title} by {_name}";
    }
}