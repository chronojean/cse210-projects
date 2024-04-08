public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // No additional attributes needed for EternalGoal
    }

    public override void RecordEvent()
    {
        // Logic for recording event for an eternal goal (if needed)
    }

    public override bool IsComplete()
    {
        // Logic to check if the eternal goal is complete
        return false; // Placeholder logic
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}";
    }
}