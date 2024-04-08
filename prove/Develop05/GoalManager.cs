public class GoalManager
{
	private List<Goal> _goals;
	private int _score;

	public GoalManager()
	{
		_goals = new List<Goal>();
		_score = 0;
	}

	public int GetScore()
	{
		return _score;
	}
	public void SetScore(int newScore)
	{
		_score = newScore;
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
		for (int i = 0; i < _goals.Count; i++)
		{
			Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
		}
	}



	public void ListGoalDetails()
	{
		// Lists the details of each goal
		if (_goals.Count == 0)
		{
			Console.WriteLine("No goals available.");
		}
		else
		{
			Console.WriteLine("List of Goals:");
			int index = 1;
			foreach (Goal goal in _goals)
			{
				string checkbox = goal.IsComplete() ? "[x]" : "[ ]";
				Console.WriteLine($"{index}. {goal.GetDetailsString()}");
				index++;
			}
		}
	}

	// Dentro de la clase GoalManager
	public void CreateGoal()
	{
		string goalTypeInput = "";
		while (goalTypeInput != "1" && goalTypeInput != "2" && goalTypeInput != "3")
		{
			Console.Clear();
			Console.WriteLine("The types of Goals are:");
			Console.WriteLine("  1. Simple Goal");
			Console.WriteLine("  2. Eternal Goal");
			Console.WriteLine("  3. Checklist Goal");
			Console.Write("Which type of goal would you like to create? ");
			goalTypeInput = Console.ReadLine();
		}
		Console.WriteLine();

		Console.Write("What is the name of your goal? ");
		string buffGoalName = Console.ReadLine();
		Console.Write("What is the description of it? ");
		string buffGoalDescription = Console.ReadLine();
		Console.Write("What is the amount of points associated with this goal? ");
		int buffPoints = int.Parse(Console.ReadLine());

		// Perform action based on user choice
		if (goalTypeInput == "1")
		{
			// Create Simple Goal
			SimpleGoal newGoal = new SimpleGoal(buffGoalName, buffGoalDescription, buffPoints);
			_goals.Add(newGoal);
		}
		else if (goalTypeInput == "2")
		{
			EternalGoal newGoal = new EternalGoal(buffGoalName, buffGoalDescription, buffPoints);
			_goals.Add(newGoal);
		}
		else if (goalTypeInput == "3")
		{
			// Create Checklist Goal
			Console.Write("How many times does this goal need to be accomplished for a bonus? ");
			int buffTimes = int.Parse(Console.ReadLine());
			Console.Write("What is the bonus for accomplishing it that times? ");
			int buffBonusPoints = int.Parse(Console.ReadLine());
			// Code to create a Checklist Goal goes here
			ChecklistGoal newGoal = new ChecklistGoal(buffGoalName, buffGoalDescription, buffPoints, buffTimes, buffBonusPoints);
			_goals.Add(newGoal);
		}
	}


	public void RecordEvent()
	{
		Console.Clear();
		int goalIndex = -1;
		while (goalIndex < 1 || goalIndex > _goals.Count)
		{
			Console.WriteLine("The goals are:");
			ListGoalNames();
			Console.Write("Which goal do you want to accomplish? ");
			goalIndex = int.Parse(Console.ReadLine());
		}

		// Check if the goal index is valid
		if (goalIndex >= 1 && goalIndex <= _goals.Count)
		{
			// Record the event for the selected goal
			Goal selectedGoal = _goals[goalIndex - 1];
			selectedGoal.RecordEvent();

			// Add points based on the type of goal
			int pointsToAdd = selectedGoal.GetPoints();
			_score += pointsToAdd;

			// For ChecklistGoal, add bonus points if applicable
			if (selectedGoal is ChecklistGoal checklistGoal)
			{
				if (checklistGoal.IsComplete())
				{
					pointsToAdd += checklistGoal.GetBonusPoints();
					_score += checklistGoal.GetBonusPoints();
					if (checklistGoal.GetBonusPoints() > 0)
					{
						Console.WriteLine("Bonus points unlocked!");
					}
				}
			}

			Console.WriteLine($"Event recorded successfully for the selected goal. {pointsToAdd} points added.");
		}
		else
		{
			Console.WriteLine("Invalid goal index. Please select a valid goal.");
		}
	}




	public void SaveGoals(string fileName)
	{
		using (StreamWriter writer = new StreamWriter(fileName))
		{
			// Write total score
			writer.WriteLine(GetScore());

			// Write each goal
			foreach (Goal goal in _goals)
			{
				writer.WriteLine(goal.GetStringRepresentation());
			}
		}
	}


	public void LoadGoals(string fileName)
	{
		// Clear existing goals
		_goals.Clear();

		try
		{
			using (StreamReader reader = new StreamReader(fileName))
			{
				// Read total score
				int totalScore = int.Parse(reader.ReadLine());
				SetScore(totalScore);

				// Read each goal
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					string[] parts = line.Split(':');
					string type = parts[0];
					string[] data = parts[1].Split(',');

					if (type == "SimpleGoal")
					{
						string name = data[0];
						string description = data[1];
						int points = int.Parse(data[2]);
						bool isComplete = bool.Parse(data[3]);
						SimpleGoal goal = new SimpleGoal(name, description, points);
						if (isComplete) goal.RecordEvent();
						_goals.Add(goal);
					}
					else if (type == "EternalGoal")
					{
						string name = data[0];
						string description = data[1];
						int points = int.Parse(data[2]);
						EternalGoal goal = new EternalGoal(name, description, points);
						_goals.Add(goal);
					}
					else if (type == "ChecklistGoal")
					{
						string name = data[0];
						string description = data[1];
						int points = int.Parse(data[2]);
						int bonus = int.Parse(data[3]);
						int target = int.Parse(data[4]);
						int amountCompleted = int.Parse(data[5]);
						ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);

						// Registrar el evento para cada tarea completada
						while (amountCompleted > 0)
						{
							goal.RecordEvent();
							amountCompleted--;
						}

						_goals.Add(goal);
					}

				}
			}

			Console.WriteLine("Goals loaded successfully.");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Error loading goals: {ex.Message}");
		}
	}



}