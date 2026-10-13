using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoalDetails();
            else if (choice == "3") SaveGoals();
            else if (choice == "4") LoadGoals();
            else if (choice == "5") RecordEvent();
            else if (choice == "6") running = false;
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points. Level {GetLevel()}: {GetLevelTitle()}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("  4. Negative Goal (bad habit, loses points)");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = ReadInt();

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = ReadInt();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = ReadInt();
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else if (type == "4")
        {
            _goals.Add(new NegativeGoal(name, description, points));
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int number = ReadInt();

        if (number < 1 || number > _goals.Count)
        {
            Console.WriteLine("That goal does not exist.");
            return;
        }

        int oldLevel = GetLevel();
        int earned = _goals[number - 1].RecordEvent();
        _score += earned;

        if (earned >= 0)
        {
            Console.WriteLine($"Congratulations! You have earned {earned} points!");
        }
        else
        {
            Console.WriteLine($"Oh no! You lost {-earned} points.");
        }

        Console.WriteLine($"You now have {_score} points.");

        if (GetLevel() > oldLevel)
        {
            Console.WriteLine($"*** LEVEL UP! You are now level {GetLevel()}: {GetLevelTitle()} ***");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("That file was not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] halves = lines[i].Split(':', 2);
            string type = halves[0];
            string[] p = halves[1].Split('|');

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(p[0], p[1], int.Parse(p[2]), bool.Parse(p[3])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(p[0], p[1], int.Parse(p[2])));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(p[0], p[1], int.Parse(p[2]), int.Parse(p[4]), int.Parse(p[3]), int.Parse(p[5])));
            }
            else if (type == "NegativeGoal")
            {
                _goals.Add(new NegativeGoal(p[0], p[1], int.Parse(p[2])));
            }
        }

        Console.WriteLine("Goals loaded.");
    }

    private int GetLevel()
    {
        return Math.Max(0, _score) / 1000 + 1;
    }

    private string GetLevelTitle()
    {
        string[] titles = { "Beginner", "Apprentice", "Adventurer", "Champion", "Ninja Unicorn" };
        return titles[Math.Min(GetLevel() - 1, titles.Length - 1)];
    }

    private int ReadInt()
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Please enter a number: ");
        }
        return number;
    }
}