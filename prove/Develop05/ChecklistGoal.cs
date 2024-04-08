public class ChecklistGoal : Goal
{
	private int _amountCompleted;
	private int _target;
	private int _bonus;
	public override string GetName()
	{
		return _shortName;
	}

	public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
	{
		_amountCompleted = 0;
		_target = target;
		_bonus = bonus;
	}
	public override int GetPoints()
	{
		return _points;
	}
	public int GetBonusPoints()
	{
		return _amountCompleted == _target ? _bonus : 0;
	}

	public override void RecordEvent()
	{
		// Logic to record event for a checklist goal
		_amountCompleted++;
	}

	public override bool IsComplete()
	{
		// Logic to check if the checklist goal is complete
		return _amountCompleted >= _target;
	}

	public override string GetDetailsString()
	{
		string checkbox = IsComplete() ? "[x]" : "[ ]";
		return $"{checkbox} {_shortName} ({_description}) --- Currently Completed: {_amountCompleted}/{_target}";
	}


	public override string GetStringRepresentation()
	{
		return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
	}

}