using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string again = "yes";
        while (again == "yes")
        {
        Random randomGenerator = new Random ();
        int rand = randomGenerator.Next(1,101);

        int number;
        int tries = 0;
        
            do
            {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();
            
            tries = tries + 1;
            number = int.Parse(input);
                    
                if (number < rand)
                {
                    Console.WriteLine("higher");
                }
                else if (number > rand)
                {
                    Console.WriteLine("lower");
                }
            }while ( number != rand);    
                if (number == rand)
                {
                    Console.Write($"You guessed it! You guessed {tries} times. Do you want to play again? yes/no  ");
                    again = Console.ReadLine();
                }
        }
    }
    
        
    
}