using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Prompt_Phrase prompts = new Prompt_Phrase();
        Entry buff = new Entry();
        int answer = 0;
        Console.WriteLine("Welcome to your journal!");
        while (answer != 5)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please select an option: ");
            answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                buff._date = DateTime.Now.ToString("yyyy-MM-dd");
                buff._promptText = prompts.GetRandomPrompt();
                Console.WriteLine(buff._promptText);
                buff._entryText = Console.ReadLine();
                myJournal.AddEntry(buff);
            }
            else if (answer == 2)
            {
                myJournal.DisplayAll();
            }
            else if (answer == 3)
            {
                Console.Write("Please Type the filename to load its data: ");
                myJournal.LoadFromFile(Console.ReadLine());
            }
            else if (answer == 4)
            {
                Console.Write("Please enter a file name to save this data: ");
                myJournal.SaveToFile(Console.ReadLine());
            }

        }
    }
}