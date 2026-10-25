using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        
        scriptures.Add(
            new Scripture(
                new Reference("Alma", 7, 11),
                "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people."
            ));

        scriptures.Add(
            new Scripture(
                new Reference("John", 3, 16, 17),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved."
            ));

        scriptures.Add(
            new Scripture(
                new Reference("Mosiah", 2, 41),
                "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it."
            ));

        Random random = new Random();
        Scripture selected = scriptures[random.Next(scriptures.Count)];

        while (!selected.IsEntirelyHidden())
        {
            //  Put the scripture reference + verse here
            Console.Clear();
            Console.WriteLine(selected.GetDisplayText() + "\n");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                break;
            }
            selected.HideRandomWords(3);
        }
    }
}