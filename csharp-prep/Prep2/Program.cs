using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string temp = Console.ReadLine();
        int gradePercentage = int.Parse(temp);
        string letter = "A";
        string sign = "";
        bool approved = true;
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
            approved = false;
        }
        else
        {
            letter = "F";
            approved = false;
        }

        if (letter != "F")
        {
            if (gradePercentage % 10 >= 7 && letter != "A")
            {
                sign = "+";
            }
            else if (gradePercentage % 10 < 3)
            {
                sign = "-";
            }
        }
        Console.WriteLine($"Grade: {letter}{sign}");
        if (approved)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.Write("I'm sorry, you didn't pass, study harder for the next time!");
        }
    }
}