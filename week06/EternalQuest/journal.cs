public class Journal
{
    private List<JournalEntry> _entries = new List<JournalEntry>();
    private int _totalXP = 0;
    private int _streak = 0;
    private DateTime? _lastEntryDate = null;

    public void AddEntry(string content, string questType)
    {
        var entry = new JournalEntry(content, questType);
        _entries.Add(entry);
        _totalXP += entry.GetXP();
        UpdateStreak();
    }

    private void UpdateStreak()
    {
        var today = DateTime.Today;
        if (_lastEntryDate == null || _lastEntryDate.Value.AddDays(1) == today)
        {
            _streak++;
        }
        else if (_lastEntryDate != today)
        {
            _streak = 1;
        }
        _lastEntryDate = today;
    }

    public void DisplayStats()
    {
        Console.WriteLine($"Total XP: {_totalXP}");
        Console.WriteLine($"Current Streak: {_streak} days");
    }

    public void DisplayAllEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.GetFullEntry());
            Console.WriteLine(new string('-', 40));
        }
    }
}