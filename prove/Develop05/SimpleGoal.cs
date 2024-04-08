public class SimpleGoal : Goal
{
    private bool _isComplete;
    public override string GetName()
    {
        return _shortName;
    }

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        // Logic to mark the simple goal as complete
        _isComplete = true;
    }
    public override int GetPoints()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[x]" : "[ ]";
        return $"{checkbox} {_shortName} ({_description})";
    }


    public override string GetStringRepresentation()
    {
        string isComplete = _isComplete ? "True" : "False";
        return $"SimpleGoal:{_shortName},{_description},{_points},{isComplete}";
    }

}
