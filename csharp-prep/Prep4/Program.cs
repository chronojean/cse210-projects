using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = float.Parse(Console.ReadLine());
            if (number != 0) numbers.Add(number);
        }
        Console.WriteLine("The sum is: " + numbers.Sum());
        Console.WriteLine("The average is: " + Math.Round(numbers.Average(), 3));
        Console.WriteLine("The largest number is: " + numbers.Max());
        Console.WriteLine("The smallest positive number is: " + numbers.Where(n => n > 0).Min());
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (float num in numbers) Console.WriteLine(num);
    }
}
