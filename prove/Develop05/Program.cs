using System;
class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        string goalType = "";
        List<Goals> goals = new List<Goals>();

        Simple simple = new Simple();

        Eternal eternal = new Eternal();

        Checklist checklist = new Checklist();

        while (userInput != "6")
        {
            Console.WriteLine();
            int points = 0;
            foreach (Goals goal in goals)
            {
                points += goal.GetTally();
            }
            Console.WriteLine($"You now have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1.Create New Goal");
            Console.WriteLine("  2.List Goals");
            Console.WriteLine("  3.Save Goals");
            Console.WriteLine("  4.Load Goals");
            Console.WriteLine("  5.Record Event");
            Console.WriteLine("  6.Quit");
            Console.Write("Select a numbered choice from the menu: ");
            userInput = Console.ReadLine();
            Console.WriteLine();

            if (userInput == "1")
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("  1.Simple Goal");
                Console.WriteLine("  2.Eternal Goal");
                Console.WriteLine("  3.Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                goalType = Console.ReadLine();

                if (goalType == "1")
                {
                    simple.CreateGoal();
                    goals.Add(simple);
                }
                if (goalType == "2")
                {
                    eternal.CreateGoal();
                    goals.Add(eternal);
                }
                if (goalType == "3")
                {
                    checklist.CreateGoal();
                    goals.Add(checklist);
                }
            }

            if (userInput == "2" || userInput == "5")
            {
                int index = 1;
                Console.WriteLine("The goals are:");
                foreach (Goals g in goals)
                {
                    string goalList = g.CreateList();
                    Console.WriteLine($"{index}.{goalList}");
                    index++;
                }
            }

            if (userInput == "3")
            {
                Console.WriteLine("What name would you like to save this file under?");
                Console.Write(">");
                string file = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(file))
                {
                    foreach (Goals goal in goals)
                    {
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }
                }
            }

            if (userInput == "4")
            {
                Console.WriteLine("What file would you like to load?");
                Console.Write(">");
                string file = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(file);

                foreach (string line in lines)
                {
                    string goalDetails = "";
                    string[] parts = line.Split(":");
                    string goalName = parts[0];
                    goalDetails = parts[1];
                    if (goalName == "SimpleGoal")
                    {
                        Simple simple1 = new Simple();
                        simple1.CreateSplitString(goalDetails);
                        goals.Add(simple1);
                    }
                    if (goalName == "EternalGoal")
                    {
                        Eternal eternal1 = new Eternal();
                        eternal1.CreateSplitString(goalDetails);
                        goals.Add(eternal1);
                    }
                    if (goalName == "ChecklistGoal")
                    {
                        Checklist checklist1 = new Checklist();
                        checklist1.CreateSplitString(goalDetails);
                        goals.Add(checklist1);
                    }
                }
            }

            if (userInput == "5")
            {
                Console.Write("Which goal did you accomplish? ");
                int accomplish = int.Parse(Console.ReadLine());
                goals[accomplish - 1].RecordEvent();
            }
        }
    }
}