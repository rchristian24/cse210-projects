using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string gradeAverage = Console.ReadLine();
        int userGrade = int.Parse(gradeAverage);

        string letter = "";

         if(userGrade >= 90)
        {
            letter = "A";
        }

        else if(userGrade >= 80 && userGrade < 90)
        {
            letter = "B";
        }

        else if(userGrade >= 70 && userGrade <80)
        {
            letter = "C";
        }
       
        else if(userGrade >=60 && userGrade <70)
        {
            letter = "D";
        }
        
        else
        {
            letter = "F";
        }

        int remainder = userGrade  % 10;
        
        string sign = ("");

        if (remainder >=7 || userGrade >= 100)
        {
            sign = "+";
        }
        
        else if (remainder <= 3)
        {
            sign = "-";
        }
        
        else
        {
            sign = "";
        }


        if (userGrade >= 70)
        {
        Console.WriteLine($"Your grade is {letter}{sign}. You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Keep trying!");
        }

        

    }
}