public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points, bool isComplete = false) 
        : base(name, points)
    {
        IsComplete = isComplete;
    }

    public override void RecordProgress()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already complete.");
        }
    }

    public override string GetStatus()
    {
        return $"[ {(IsComplete ? "X" : " ")} ] {Name}";
    }

    public override string Serialize()
    {
        return $"Simple|{Name}|{Points}|{IsComplete}";
    }
}
