class ListingActivity : Activity
{
    private string[] prompts = {
        "List people who have helped you.",
        "List things you're grateful for.",
        "List moments that made you smile."
    };

    protected override void PerformActivity()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine("Start listing. Press Enter after each item:");

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
    }
}