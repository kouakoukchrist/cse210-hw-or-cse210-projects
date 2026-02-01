using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What made you smile today?",
        "What was the hardest part of your day?",
        "What are you grateful for today?",
        "What did you learn today?",
        "Who did you help today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
