public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) 
        : base(name, points) { }

    public override void RecordProgress()
    {
        Console.WriteLine($"Goal '{Name}' recorded! You earned {Points} points.");
    }

    public override string GetStatus()
    {
        return $"[ ] {Name} (Eternal)";
    }

    public override string Serialize()
    {
        return $"Eternal|{Name}|{Points}";
    }
}
