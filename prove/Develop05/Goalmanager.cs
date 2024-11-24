using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Progress");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1": CreateGoal(); break;
                case "2": RecordProgress(); break;
                case "3": ShowGoals(); break;
                case "4": ShowScore(); break;
                case "5": SaveGoals(); break;
                case "6": LoadGoals(); break;
                case "7": return;
                default: Console.WriteLine("Invalid choice. Try again."); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Select goal type: 1. Simple 2. Eternal 3. Checklist");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private void RecordProgress()
    {
        ShowGoals();
        Console.Write("Select a goal to record progress (1-N): ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordProgress();
            _score += _goals[index].Points;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    private void ShowGoals()
    {
        Console.WriteLine("Your Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    private void ShowScore()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.Serialize());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                _goals.Add(Goal.Deserialize(lines[i]));
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}
