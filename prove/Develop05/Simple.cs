using System;
public class Simple : Goals
{
    public Simple()
    {
    }

    public override void CreateGoal()
    {
        Simple simple = new Simple();
        base.CreateGoal();
        simple.SetName(_name);
        simple.SetDescription(_description);
        simple.SetPoints(_points);
    }

    public override int GetTally()
    {
        base.GetTally();
        return _pointTally;
    }

    public override string CreateList()
    {
        return base.CreateList();
    }

    public override bool IsComplete()
    {
        if (_complete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void Save(string file)
    {
        base.Save(file);
    }

    public override void Load()
    {
        base.Load();
    }

    public override void CreateSplitString(string unParsedString)
    {
        string[] spiltStrings = unParsedString.Split(",");
        _name = spiltStrings[0];
        _description = spiltStrings[1];
        _points = int.Parse(spiltStrings[2]);
        _complete = bool.Parse(spiltStrings[3]);
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetName()},{GetDescription()},{GetPoints()},{IsComplete()}";
    }

    public override int RecordEvent()
    {
        _complete = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points! ");
        return _points;
    }
}
