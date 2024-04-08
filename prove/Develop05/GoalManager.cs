public class GoalManager
{
	private List<Goal> _goals;
	private int _score;

	public GoalManager()
	{
		_goals = new List<Goal>();
		_score = 0;
	}

	public void Start()
	{
		// Main function for the GoalManager class
	}

	public void DisplayPlayerInfo()
	{
		// Displays the player's current score
	}

	public void ListGoalNames()
	{
		// Lists the names of each of the goals
	}

	public void ListGoalDetails()
	{
		// Lists the details of each goal
	}

	// Dentro de la clase GoalManager
	public void CreateGoal()
	{
		Console.WriteLine("The types of Goals are:");
		Console.WriteLine("  1. Simple Goal");
		Console.WriteLine("  2. Eternal Goal");
		Console.WriteLine("  3. Checklist Goal");
		Console.Write("Which type of goal would you like to create? ");
		string goalTypeInput = Console.ReadLine();
		Console.WriteLine();

		Console.Write("What is the name of your goal? ");
		string buffGoalName = Console.ReadLine();
		Console.Write("What is the description of it? ");
		string buffGoalDescription = Console.ReadLine();
		Console.Write("What is the amount of points associated with this goal? ");
		int buffPoints = Int32.Parse(Console.ReadLine());

		// Perform action based on user choice
		if (goalTypeInput == "1")
		{
			// Create Simple Goal
			Goal newGoal = new SimpleGoal(buffGoalName, buffGoalDescription, buffPoints);
			_goals.Add(newGoal);
		}
		else if (goalTypeInput == "2")
		{
			// Create Eternal Goal
			// Code to create an Eternal Goal goes here
		}
		else if (goalTypeInput == "3")
		{
			// Create Checklist Goal
			// Code to create a Checklist Goal goes here
		}
		else
		{
			// Invalid input
			Console.WriteLine("Invalid choice. Please enter a number from 1 to 3.");
		}
	}


	public void RecordEvent()
	{
		// Asks the user which goal they have done and records the event
	}

	public void SaveGoals()
	{
		// Saves the list of goals to a file
	}

	public void LoadGoals()
	{
		// Loads the list of goals from a file
	}
}