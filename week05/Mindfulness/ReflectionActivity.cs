class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time you overcame a challenge.",
        "Recall a moment of kindness you experienced.",
        "Remember a time you felt truly at peace."
    };

    private string[] questions = {
        "Why was this experience meaningful?",
        "What did you learn from it?",
        "How did it change your perspective?"
    };

    protected override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner(3);

        int timePerQuestion = duration / questions.Length;
        foreach (string question in questions)
        {
            Console.WriteLine(question);
            ShowSpinner(timePerQuestion);
        }
    }
}