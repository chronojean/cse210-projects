using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment maths = new MathAssignment("7.3", "8-19", "Jean Andrade", "Fractions");
        WritingAssignment writing = new WritingAssignment("The Causes of World War II by Mary Waters", "Michel Andrade", "European History");

        Console.Clear();
        Console.WriteLine($"{maths.GetSummary()}\n{maths.GetHomeworkList()}");
        Console.WriteLine();
        Console.WriteLine($"{writing.GetSummary()}\n{writing.GetWritingInformation()}");
        Console.Write("\nPress Enter to exit.\t");
        Console.ReadLine();
        Console.Clear();
    }
}