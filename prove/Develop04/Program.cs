//Used polymorphism in the showspinner to show a default spinner that last fixed seconds
//and a second showspinner to show the spinner only for Run(), this way the spinner
//will only last during the seconds that user specified, clearing the spinner always before exiting.
using System;

class Program
{
    static void Main(string[] args)
    {
        string[] descriptions = { "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area." };

        string answer = "";
        int readySeconds = 5;
        while (answer != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("\t1. Start Breathing activity");
            Console.WriteLine("\t2. Start Reflecting activity");
            Console.WriteLine("\t3. Start Listing Activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                BreathingActivity letsBreathe = new BreathingActivity("Breathing Activity", descriptions[0]);
                letsBreathe.DisplayStartingMessage();
                letsBreathe.ShowSpinner(readySeconds);
                letsBreathe.Run();
                letsBreathe.DisplayEndingMessage();
            }
            else if (answer == "2")
            {
                ReflectingActivity letsReflect = new ReflectingActivity("Reflecting Activity", descriptions[1]);
                letsReflect.DisplayStartingMessage();
                letsReflect.ShowSpinner(readySeconds);
                letsReflect.Run();
                letsReflect.DisplayEndingMessage();
            }
            else if (answer == "3")
            {
                ListingActivity letsList = new ListingActivity("Listing Activity", descriptions[2]);
                letsList.DisplayStartingMessage();
                letsList.ShowSpinner(readySeconds);
                letsList.Run();
                letsList.DisplayEndingMessage();
            }
            else if (answer == "4")
            {

            }
            else
            {

            }
        }
        Console.Clear();
    }
}