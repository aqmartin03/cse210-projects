using System.Diagnostics.Metrics;

public class ListingActivity : Activity
{
    private List<string> _promptList;
    private Random _random = new Random();

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void CreatePromptList()
    {
        _promptList = new List<string>();
        _promptList.Add("Who are people that you appreciate?");
        _promptList.Add("What are personal strengths of yours?");
        _promptList.Add("Who are people that you have helped this week?");
        _promptList.Add("When have you felt the Holy Ghost this month?");
        _promptList.Add("Who are some of your personal heroes?");
    }

    public string GetRandomPrompt()
    {
        return _promptList[_random.Next(_promptList.Count)];
    }

    public void Run()
    {
        int counter = 0;
        CreatePromptList();
        ShowPrologue();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in : ");
        ShowCountdown(5);
        Console.WriteLine();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userResponse = Console.ReadLine();
            // Add 1 to the listCount every time the user types a response.
            counter++;
        }
        Console.WriteLine($"You listed {counter} items!");
        Console.WriteLine();
        CongratsMessage();
        ShowSpinner(5);
        Console.WriteLine();
        ShowEpilogue();
        ShowSpinner(5);
        Console.WriteLine();
    }
}