public class JournalApp
{
    private Journal _journal = new Journal();
    private string[] _quests = { "Reflect", "Gratitude", "Challenge", "Dream", "Free Write" };

    public void Run()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Quest Menu:");
            Console.WriteLine("1. Start a new quest");
            Console.WriteLine("2. View all entries");
            Console.WriteLine("3. View stats");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string quest = ChooseQuest();
                    Console.Write($"Write your [{quest}] entry: ");
                    string content = Console.ReadLine();
                    _journal.AddEntry(content, quest);
                    Console.WriteLine("Quest complete! XP earned.");
                    break;
                case "2":
                    _journal.DisplayAllEntries();
                    break;
                case "3":
                    _journal.DisplayStats();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Farewell, adventurer!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    private string ChooseQuest()
    {
        Console.WriteLine("Choose your quest:");
        for (int i = 0; i < _quests.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {_quests[i]}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;
        return _quests[Math.Clamp(index, 0, _quests.Length - 1)];
    }
}