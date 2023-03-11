using System;
using System.IO;
public abstract class Goals
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _pointTally;
    protected Boolean _complete;

    public Goals()
    {
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public bool GetComplete()
    {
        return _complete;
    }

    public void SetComplete(bool complete)
    {
        _complete = complete;
    }

    public int GetPointTally()
    {
        return _pointTally;
    }

    public void SetPointTally(int pointTally)
    {
        _pointTally = pointTally;
    }

    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual int GetTally()
    {
        if (_complete == true)
        {
            _pointTally += _points;
        }
        return _pointTally;
    }

    public virtual string CreateList()
    {
        if (_name == null)
        {
            return null;
        }
        else
        {
            string listString = ($"{CheckMark()} {_name} ({_description})");
            return listString;
        }
    }

    public abstract Boolean IsComplete();

    public virtual string CheckMark()
    {
        if (_complete == true)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

    public virtual void Save(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(GetStringRepresentation());
        }
    }

    public virtual void Load()
    {
        string goalDetails = "";
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string goalName = parts[0];
            goalDetails = parts[1];
        }
    }

    public abstract void CreateSplitString(string unParsedString);

    public abstract string GetStringRepresentation();

    public virtual int RecordEvent()
    {
        if (_complete == true)
        {
            return _points;
        }
        else
        {
            return 0;
        }
    }
}
