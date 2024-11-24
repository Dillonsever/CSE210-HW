using System;

public abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }
    public bool IsComplete { get; protected set; }

    protected Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsComplete = false;
    }

    public abstract void RecordProgress();
    public abstract string GetStatus();
    public abstract string Serialize();

    public static Goal Deserialize(string data)
    {
        string[] parts = data.Split('|');
        string type = parts[0];

        switch (type)
        {
            case "Simple":
                return new SimpleGoal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
            case "Eternal":
                return new EternalGoal(parts[1], int.Parse(parts[2]));
            case "Checklist":
                return new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
            default:
                throw new Exception("Unknown goal type.");
        }
    }
}
