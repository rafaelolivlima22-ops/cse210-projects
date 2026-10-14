using System;
using System.Collections.Generic;

// EXCEEDING REQUIREMENTS:
// 1. The program keeps a log of how many times each activity was completed
//    in the current session and shows it in the menu.
// 2. Random prompts and questions are never repeated until every one of them
//    has been used at least once (see PickUnique in Activity.cs).
// 3. Input is validated, so the duration must be a number greater than 0.

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> log = new Dictionary<string, int>
        {
            { "Breathing", 0 },
            { "Reflection", 0 },
            { "Listing", 0 }
        };

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            Console.WriteLine($"Session log -> Breathing: {log["Breathing"]} | Reflection: {log["Reflection"]} | Listing: {log["Listing"]}");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
                log["Breathing"]++;
            }
            else if (choice == "2")
            {
                new ReflectionActivity().Run();
                log["Reflection"]++;
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
                log["Listing"]++;
            }
            else if (choice == "4")
            {
                running = false;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}