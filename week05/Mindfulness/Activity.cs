using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
    }

    public void DisplayStartingMessage()
    {
    }

    public void DisplayEndingMessage()
    {
    }

    public void ShowSpinner(int seconds)
    {
    }

    public void ShowCountDown(int seconds)
    {
    }

    public int GetDuration()
    {
        return _duration;
    }
}