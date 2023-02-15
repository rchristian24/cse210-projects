using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        //base
        Assignment assignment = new Assignment("Sam Jones", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine("");
        //derived
        Math math = new Math("7.13", "8-9", "Juan Rodriguez", "Math");
        Console.WriteLine(math.DisplayHomeworkList());
        Console.WriteLine("");
        Writing writing = new Writing("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(writing.GetWritingInfo());

    }
}