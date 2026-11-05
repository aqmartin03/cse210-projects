public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void BreatheIn()
    {
        Console.Write("Breathe In...");
        ShowCountdown(3);
        Console.WriteLine();
    }

    public void BreatheOut()
    {
        Console.Write("Now Breathe Out...");
        ShowCountdown(5);
    }

    public void Run()
    {
        ShowPrologue();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            BreatheIn();
            BreatheOut();
            Console.WriteLine();
            Console.WriteLine();
        }
        CongratsMessage();
        ShowSpinner(5);
        Console.WriteLine();
        ShowEpilogue();
        ShowSpinner(5);
        Console.WriteLine();
    }
}