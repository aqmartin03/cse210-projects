public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    private int _activitiesDoneAmount;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void ShowCountdown(int s)
    {
        for (int i = s; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowPrologue()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write($"How long, in seconds, would you like for your session? ");
        string secondsString = Console.ReadLine();
        _duration = int.Parse(secondsString);
    }

    public void ShowSpinner(int s)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(s);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string spinning = spinner[i];
            Console.Write(spinning);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowEpilogue()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
    }

    public void CongratsMessage()
    {
        Console.WriteLine("Well done!!");
    }

    public void CountActivitiesDone(int activityCount)
    {
        _activitiesDoneAmount = activityCount;
        _activitiesDoneAmount++;
        if (_activitiesDoneAmount == 1)
        {
            Console.WriteLine($"You have accomplished {_activitiesDoneAmount} activity in this session.");
        }
        else
        {
            Console.WriteLine($"You have accomplished {_activitiesDoneAmount} activities in this session.");
        }
        
    }
}