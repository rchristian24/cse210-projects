using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Journal Prompt! ");
        Journal journal = new Journal();
        string input;
        do
        {
            Console.WriteLine("");
            Console.WriteLine("Please Select One of the Following Choices: ");
            Console.WriteLine("");
            Console.WriteLine("1. Write from a pre-programmed prompt");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine(" ");
            Console.WriteLine("5. Write from self-written prompt");
            Console.WriteLine("6. Display self-written prompt");
            Console.WriteLine("7. Load from self-written prompt");
            Console.WriteLine("8. Save self-written prompt and response");
            Console.WriteLine(" ");
            Console.WriteLine("9. Display Both");
            Console.WriteLine("10. Quit");
            Console.Write("Type in the corresponding number: ");
            Console.Write(">");
            input = Console.ReadLine();
            if (input == "1")
            {
                journal.Shuffle();
                journal.GeneratePrompt();
            }
            else if (input == "2")
            {    
               journal.Display();
            }
            else if (input == "3")
            {
                journal.Load();   
            }
            else if (input == "4")
            {
                journal.Save();
            }
            else if (input == "5")
            {
                journal.UserPrompt();
            }
            else if (input == "6")
            {
                journal.UserDisplay();
            }
            else if (input == "7")
            {
                journal.UserLoad();   
            }
            else if (input == "8")
            {
                journal.UserEntrySave();
            }
            else if (input == "9")
            {
                journal.DisplayAll();
            }
        } while (input != "10");
    }
}
