using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}