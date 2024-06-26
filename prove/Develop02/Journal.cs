using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class Journal
    {
        public List<Entry> Entries;
        public List<string> Prompts;

        public Journal()
        {
            Entries = new List<Entry>();
            Prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };
        }

        public void WriteEntry()
        {
            Random rand = new Random();
            int promptIndex = rand.Next(Prompts.Count);
            string prompt = Prompts[promptIndex];

            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            DateTime date = DateTime.Now;

            Entry newEntry = new Entry(date, prompt, response);
            Entries.Add(newEntry);
        }

        public void DisplayEntries()
        {
            foreach (var entry in Entries)
            {
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                Console.WriteLine();
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in Entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            Entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string response = parts[2];

                    Entry entry = new Entry(date, prompt, response);
                    Entries.Add(entry);
                }
            }
        }
    }
}
