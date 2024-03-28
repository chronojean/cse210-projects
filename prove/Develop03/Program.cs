//Propt the user for custom Scripture, not Program provided.
//Added a while to repeat as many scriptures as desired
//added a try/catch inside previous while to prevent wrong reference input from crashing the program. exit the while on correct input using break;
//use of a random to choose how many words to hide, and another random to hide choose what words to hide.
//Nice robotic finished message.
using System;

class Program
{
    static void Main(string[] args)
    {
        string repeat = "Y";
        while (repeat.ToUpper() == "Y")
        {
            Reference reference;
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memorizer Helper.");
            while (true)
            {
                try
                {
                    Console.Write("Please type the reference: (ex: 1Nefi 3:7 or 1Nefi 3:7-10): ");
                    string stringReference = Console.ReadLine();
                    string[] parts = stringReference.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);
                    reference = (parts.Length == 4) ? new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3])) : new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                    break;
                }
                catch (System.Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Reference format must be as shown in the ex.");
                    continue;
                }
            }
            Console.Write("Please type the scripture: (ex: And it came to...): ");
            string text = Console.ReadLine();


            Scripture escritura = new Scripture(reference, text);

            Random rnd = new Random();
            string answer = "";
            while (answer != "quit")
            {
                Console.Clear();

                Console.WriteLine(escritura.GetDisplayText());

                Console.Write("\nPress enter to continue or type \"quit\" to finish: ");
                answer = Console.ReadLine().ToLower();
                if (escritura.IsCompletelyHidden()) { break; }
                escritura.HideRandomWords(rnd.Next(1, 4));
            }
            Console.WriteLine("Scripture Finished.");
            Console.Write("\nDo you want to try a new Scripture? Y/N: ");
            repeat = Console.ReadLine().Trim().Substring(0, 1).ToUpper();
        }


        Console.WriteLine("Program Finished");
    }
}