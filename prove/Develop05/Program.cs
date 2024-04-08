using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Clear();
		// Create an instance of GoalManager
		GoalManager goalManager = new GoalManager();

		// Menu loop
		bool continueMenuLoop = true;
		while (continueMenuLoop)
		{
			Console.WriteLine($"Your current score is: {goalManager.GetScore()} points");
			// Display menu options
			Console.WriteLine("Menu Options:");
			Console.WriteLine("  1. Create New Goal");
			Console.WriteLine("  2. List Goals");
			Console.WriteLine("  3. Save Goals");
			Console.WriteLine("  4. Load Goals");
			Console.WriteLine("  5. Record Event");
			Console.WriteLine("  6. Quit");
			Console.Write("Select a choice from the menu: ");

			// Get user input
			string input = Console.ReadLine();
			Console.WriteLine();

			Console.Clear();

			// Perform action based on user choice
			if (input == "1")
			{
				// If user chooses to create a new goal
				if (input == "1")
				{
					// If user chooses to create a new goal
					goalManager.CreateGoal();
				}


			}
			else if (input == "2")
			{
				// List Goals including the checkbox and other details
				goalManager.ListGoalDetails();
			}
			else if (input == "3")
			{
				// Save Goals
				Console.Write("What is the filename for the goal file? ");
				goalManager.SaveGoals(Console.ReadLine());
			}
			else if (input == "4")
			{
				// Load Goals
				Console.Write("What is the filename for the goal file? ");
				goalManager.LoadGoals(Console.ReadLine());
			}
			else if (input == "5")
			{
				// Record Event
				goalManager.RecordEvent();
			}
			else if (input == "6")
			{
				// Quit
				continueMenuLoop = false;
			}
			else
			{
				// Invalid input
				Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
			}

			Console.WriteLine();
		}

		Console.WriteLine("Goodbye!");
	}
}
