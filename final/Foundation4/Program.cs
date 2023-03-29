using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");
        List<ExerciseActivity> exercises = new List<ExerciseActivity>();

        RunningActivity running = new RunningActivity("21 March 2023", 30, 5);
        exercises.Add(running);

        CyclingActivity cycling = new CyclingActivity("08 Aug 2023", 45, 15);
        exercises.Add(cycling);

        SwimmingActivity swimming = new SwimmingActivity("18 July 2023", 20, 30);
        exercises.Add(swimming);

        foreach (ExerciseActivity exercise in exercises)
        {
            exercise.DisplaySummary();
        }
    }
}