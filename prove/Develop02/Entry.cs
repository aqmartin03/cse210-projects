using System.IO;

public class Entry
{
    // Attributes
    public string _date;
    public string _prompt;
    public string _response;
    public int _mood;
    private List<string> _promptList = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    // Behaviors
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_promptList.Count);

        return _promptList[index];
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine($"Today's mood: {_mood}");
        Console.WriteLine();
    }
}