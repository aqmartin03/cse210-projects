using System;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int read = 0;
        while (read != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string user = Console.ReadLine();
            read = int.Parse(user);

            if (read == 1)
            {
                Entry entry1 = new Entry();
                Console.Write("How are you feeling today (Scale of 1 to 10? ");
                string mood = Console.ReadLine();
                int userMood = int.Parse(mood);
                string getPrompt = entry1.GetRandomPrompt();
                Console.WriteLine(getPrompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                entry1._date = dateText;
                entry1._prompt = getPrompt;
                entry1._response = response;
                entry1._mood = userMood;
                journal._entries.Add(entry1);
            }
            else if (read == 2)
            {
                journal.Display();
            }
            else if (read == 3)
            {
                Console.WriteLine("What is the filename?");
                string response = Console.ReadLine();
                journal.Load(response);
            }
            else if (read == 4)
            {
                Console.WriteLine("What is the filename?");
                string response = Console.ReadLine();
                journal.Save(response);
            }
        }
        
    }
}