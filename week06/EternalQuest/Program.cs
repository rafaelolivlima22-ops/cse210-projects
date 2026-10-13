using System;

// EXCEEDING REQUIREMENTS:
// 1. Levels: every 1000 points the player levels up and gets a new title
//    (Beginner, Apprentice, Adventurer, Champion, Ninja Unicorn).
// 2. Negative goals: a "bad habit" goal that takes points away when recorded.
// 3. The level, the level-up message and negative goals are all saved/loaded.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}