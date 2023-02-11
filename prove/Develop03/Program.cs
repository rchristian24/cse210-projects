using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        Reference reference = new Reference("Proverbs", "3", "5", "-6");
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        string input = " ";

        scripture.FullScripture();
        while (input != "quit" && !scripture.IsVerseHidden())
        {
            Console.WriteLine("Please press enter to continue memorization, type 't' to test your knowledge or type 'quit' to end program: ");
            Console.Write(">");
            input = Console.ReadLine();
            Console.Clear();
            if (input == "t")
            {
                scripture.Test();
            }
            else
            {
                scripture.HideRandomWord();
                scripture.TextDisplay();
            }
        }
    }
}