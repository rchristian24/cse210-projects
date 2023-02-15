using System;
public class Math : Assignment
{
    private string _textbookSection;
    private string  _problems;

    public Math()
    {
        _textbookSection = "";
        _problems = "";
    }
    public Math(string textbookSection, string problems, string name, string title): base(name, title)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string DisplayHomeworkList()
    {
        return $"{GetSummary()}\nTextbook Section:{_textbookSection} Problems:{_problems}";
    }
}