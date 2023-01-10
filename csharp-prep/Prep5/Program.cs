using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptsUserName();
        int number = PromptsUserNumber();
        int squared = SquareNumber(number);
      
        DisplayResult(name, squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptsUserName()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptsUserNumber()
    {
        Console.WriteLine("Enter your favorite number: ");  
        int number = int.Parse(Console.ReadLine()); 
        return number; 
    }
    static int SquareNumber(int number)
    {
        int square = number * number;        
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine ($"{name}, the square of your number is {square}");
        
    }
}