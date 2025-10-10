public class JournalEntry
{
    private string _date;
    private string _content;
    private string _questType;
    private int _xpEarned;

    public JournalEntry(string content, string questType)
    {
        _date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        _content = content;
        _questType = questType;
        _xpEarned = CalculateXP(content);
    }

    private int CalculateXP(string content)
    {
        return Math.Min(100, content.Length / 5); // 1 XP per 5 chars, capped at 100
    }

    public int GetXP() => _xpEarned;

    public string GetSummary()
    {
        return $"{_date} [{_questType}] - {_content.Substring(0, Math.Min(30, _content.Length))}...";
    }

    public string GetFullEntry()
    {
        return $"{_date} [{_questType}]\nXP: {_xpEarned}\n{_content}";
    }
}