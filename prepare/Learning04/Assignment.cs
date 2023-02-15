using System;
public class Assignment
{
    protected string _name;
    private string _topic;
    public Assignment()
    {
        _name = "";
        _topic = "";
    }
    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }
    
    public string GetSummary()
    {
        return $"Name:{_name} Topic:{_topic}";
    }
}
