using System;

class Program
{
    static void Main(string[] args)
    {   
        int activityCount = 0;
        int choice = 0;
        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            choice = int.Parse(userInput);

            if (choice == 1)
            // If the user chooses the breathing activity
            {
                BreathingActivity breathe = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                // Ask the user for the duration of seconds the exercise should be.
                breathe.Run();
                breathe.CountActivitiesDone(activityCount);
                activityCount++;
                breathe.ShowSpinner(5);
            }
            if (choice == 2)
            // If the user chooses the reflecting activity
            {
                ReflectingActivity reflect = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflect.Run();
                reflect.CountActivitiesDone(activityCount);
                activityCount++;
                reflect.ShowSpinner(5);
            }
            if (choice == 3)
            // If the user chooses the listing activity
            {
                ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listing.Run();
                listing.CountActivitiesDone(activityCount);
                activityCount++;
                listing.ShowSpinner(5);
            }
        }
    }
}