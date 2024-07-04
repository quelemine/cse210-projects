using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding");

        while (true)
        {
            scripture.Display();

            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. The program will now exit.");
                break;
            }

            scripture.HideRandomWords();
        }
    }
}