using System;
public class Eternal : Goals
{
    public override void CreateGoal()
    {
        base.CreateGoal();
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
        return false;
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
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points! ");
        _pointTally += _points;
        return _points;
    }
}