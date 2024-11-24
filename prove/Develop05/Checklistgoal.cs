public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int CurrentCount { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) 
        : base(name, points)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusPoints = bonusPoints;
    }

    public override void RecordProgress()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            Console.WriteLine($"Progress recorded for '{Name}'. {Points} points earned.");
            if (CurrentCount == TargetCount)
            {
                IsComplete = true;
                Console.WriteLine($"Goal '{Name}' completed! Bonus {BonusPoints} points awarded.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already complete.");
        }
    }

    public override string GetStatus()
    {
        return $"[ {(IsComplete ? "X" : " ")} ] {Name} (Completed {CurrentCount}/{TargetCount})";
    }

    public override string Serialize()
    {
        return $"Checklist|{Name}|{Points}|{TargetCount}|{BonusPoints}|{CurrentCount}";
    }
}
