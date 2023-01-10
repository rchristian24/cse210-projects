using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int>numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int newNumber = -1;
       

        while (newNumber != 0)
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();
            newNumber = int.Parse(userNumber);
           

            numbers.Add(newNumber);
        }
        float total = 0;
        
        foreach(int number in numbers)
        {
            
            total += number;

        }
        Console.WriteLine($"The sum is {total}");
        float average = total / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }  
        Console.WriteLine($"The max number is {max}"); 

        int min = numbers[0];
        foreach (int number in numbers)
        {
            if(number > 0 && number < min )
            {
                min = number;
            }
        }
        Console.WriteLine($"The smallest positive number is {min}");

       var result = numbers.OrderBy(number => number);
       Console.WriteLine("Sorted List: ");
       foreach(int value in result)
       {
        Console.Write(value + " ");
       }
       
        
        }
    }
