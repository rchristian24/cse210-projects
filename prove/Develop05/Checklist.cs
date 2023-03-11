using System;
public class Checklist : Goals
{
    private int _totalTimes;
    private int _completedTimes = 0;
    private int _bonusPoints;
    private Boolean _checkComplete;

    public int GetTotalTimes()
    {
        return _totalTimes;
    }

    public void SetTotalTimes(int totalTimes)
    {
        _totalTimes = totalTimes;
    }

    public int GetCompletedTimes()
    {
        return _completedTimes;
    }

    public void SetCompletedTimes(int completedTimes)
    {
        _completedTimes = completedTimes;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }

    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _totalTimes = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int GetTally()
    {
        if (_complete == true)
        {
            _pointTally += (_points + _bonusPoints);
        }
        return _pointTally;
    }

    public override string CreateList()
    {
        if (_name == null)
        {
            return null;
        }
        else
        {
            string stringLine = ($"[ ]{_name} ({_description}) ---Currently Completed:{_completedTimes}/{_totalTimes}");
            return stringLine;
        }
    }

    public override bool IsComplete()
    {
        if (_completedTimes == _totalTimes)
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
        _bonusPoints = int.Parse(spiltStrings[3]);
        _completedTimes = int.Parse(spiltStrings[4]);
        _totalTimes = int.Parse(spiltStrings[5]);
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{GetBonusPoints()},{GetCompletedTimes()},{GetTotalTimes()}";
    }

    public override int RecordEvent()
    {
        _completedTimes++;

        if (IsComplete())
        {
            Console.WriteLine($"Congratulations! You have earned {_points + _bonusPoints} points! ");
            ShootingStar();
            _pointTally += _points + _bonusPoints;
            return _points + _bonusPoints;
        }
        Console.WriteLine($"Congratulations! You have earned {_points} points! ");
        _pointTally += _points;
        return _points;
    }

    public void ShootingStar()
    {
        for (int row = 5; row >= 1; --row)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write("****");
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
            Console.WriteLine();
        }
    }
}