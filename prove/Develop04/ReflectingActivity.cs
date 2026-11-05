public class ReflectingActivity : Activity
{
    private List<string> _promptList;
    private List<string> _questionList;
    private Random _random = new Random();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void CreatePromptList()
    {
        _promptList = new List<string>();
        _promptList.Add("Think of a time when you stood up for someone else.");
        _promptList.Add("Think of a time when you did something really difficult.");
        _promptList.Add("Think of a time when you helped someone in need.");
        _promptList.Add("Think of a time when you did something truly selfless.");
        _promptList.Add("Think of a time when you have seen the hand of the Lord in your life.");
    }

    public void CreateQuestionList()
    {
        _questionList = new List<string>();
        _questionList.Add("Why was this experience meaningful to you?");
        _questionList.Add("Have you ever done anything like this before?");
        _questionList.Add("How did you get started?");
        _questionList.Add("How did you feel when it was complete?");
        _questionList.Add("What made this time different than other times when you were not as successful?");
        _questionList.Add("What is your favorite thing about this experience?");
        _questionList.Add("What could you learn from this experience that applies to other situations?");
        _questionList.Add("What did you learn about yourself through this experience?");
        _questionList.Add("How can you keep this experience in mind in the future?");
    }

    public string GetRandomPrompt()
    {
        return _promptList[_random.Next(_promptList.Count)];
    }

    public string GetRandomQuestion()
    {
        return _questionList[_random.Next(_questionList.Count)];
    }

    public void Run()
    {
        ShowPrologue();
        CreatePromptList();
        CreateQuestionList();

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine("Consider the Following Prompt:\n");
        
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(10);
            Console.WriteLine();
        }
        Console.WriteLine();
        CongratsMessage();
        ShowSpinner(5);
        Console.WriteLine();
        ShowEpilogue();
        ShowSpinner(5);
        Console.WriteLine();
    }
}