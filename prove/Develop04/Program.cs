using System;


class Program
{
    static void Main(string[] args)
    {
        string input = "";
        while (input != "4")
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1.Start Breathing Activity");
            Console.WriteLine(" 2.Start Reflecting Activity");
            Console.WriteLine(" 3.Start Listing Activity");
            Console.WriteLine(" 4.Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "This activity will help you relax through breathing in and out slowly. Clear your mind and focus on your breathing.");
                activity1.GetGreeting();
                activity1.GetDuration();
                Console.Clear();
                activity1.StartActivity();
                activity1.OxygenIn();
                activity1.OxygenOut();
                activity1.Breathing();
                activity1.GetEndMessage();
                activity1.PauseSpinner();
            }
            else if (input == "2")
            {
                ReflectionActivity activity2 = new ReflectionActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                activity2.GetGreeting();
                activity2.GetDuration();
                Console.Clear();
                activity2.StartActivity();
                activity2.DisplayPrompt();
                activity2.PauseDisplay();
                Console.Clear();
                activity2.RunList();
                activity2.GetEndMessage();
                activity2.PauseSpinner();
            }
            else if (input == "3")
            {
                ListingActivity activity3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                activity3.GetGreeting();
                activity3.GetDuration();
                Console.Clear();
                activity3.StartActivity();
                activity3.ListingRunActvity();
                activity3.ListUserInput();
                activity3.DisplayCounter();
                activity3.GetEndMessage();
                activity3.PauseSpinner();
            }
        }
    }
}