using System;

public class PromptGenerator
{
    public List<string> _prompts;

    private Random _random;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Write about an act of service you either witnessed or performed today:",
            "If you had one thing you could do over today, what would it be?",
            "What was the best part of your day?",
            "Write about something you learned today:",
            "Who was the most interesting person you interacted with today?",
            "Write about something that happened for which you are grateful today:",
            "Who would you write a letter to that is no longer with us and what would you say?",
            "What was something you did recently that makes you feel joy?",
            "What did you give thanks for in your morning prayer?",
            "Write about a tender mercy you noticed today:",
            "Write about an experience where you felt the spirit with you today:",
            "What is one intereting thing you learn in your scripture personal study today?",
            "Write about something you noticed that reminded you of the Savior today:"
        };
        _random = new Random();
    }

    public string GenerateRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}

