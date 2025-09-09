public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "What are you grateful for today?",
        "Describe a challenging moment you faced recently.",
        "What is a goal you want to achieve this week?",
        "Reflect on a recent success you had.",
        "What is something new you learned today?"
    };

    private Random rand = new Random();

    public string GetRandomPrompt()
    {
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }


}