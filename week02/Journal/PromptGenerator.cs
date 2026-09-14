using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> prompts;

    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "What is your favorite childhood memory?",
            "Describe a time when you overcame a challenge.",
            "If you could travel anywhere in the world, where would you go and why?",
            "What is a super power you wish you had and why?",
            "Write about a person who has had a significant impact on your life."
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}