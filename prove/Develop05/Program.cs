class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalScore = 0;

    static void Main(string[] args)
    {
        LoadGoals();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Total Score: {totalScore}");
            Console.WriteLine();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Save & Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ListGoals();
                    break;
                case "4":
                    SaveGoals();
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Option: ");
        string option = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (option)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid option. Goal not created.");
                break;
        }
    }

    static void RecordEvent()
    {
        ListGoals();
        Console.Write("Enter goal number to record event: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent();
            totalScore += goals[goalIndex].GetPoints();
            if (goals[goalIndex] is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                totalScore += checklistGoal.GetPoints();
            }
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void ListGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].DisplayStatus()} {goals[i].GetName()} ({goals[i].GetDescription()}) - {goals[i].GetPoints()} points");
        }
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(totalScore);
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.SaveGoal());
            }
        }
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                totalScore = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split('|');
                    Goal goal;
                    switch (data[0])
                    {
                        case "Simple":
                            goal = new SimpleGoal("", "", 0);
                            break;
                        case "Eternal":
                            goal = new EternalGoal("", "", 0);
                            break;
                        case "Checklist":
                            goal = new ChecklistGoal("", "", 0, 0, 0);
                            break;
                        default:
                            continue;
                    }
                    goal.LoadGoal(data);
                    goals.Add(goal);
                }
            }
        }
    }
}
