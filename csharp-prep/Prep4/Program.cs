using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers , type 0 when finished");
        int number = 0;
        int userNumber = -1;
        while (userNumber !=0)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            userNumber = int.Parse(input);
            
            if (userNumber != 0 )
            {
                numbers.Add(userNumber);
            }
        }
        foreach (int num in numbers)
        {
            number += num;
        }
        Console.WriteLine($"The total in {number}");
        double average = (double) number / numbers.Count;
        Console.WriteLine ($"The average is: {average}");
        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");
    }
}