
namespace EternalQuest
{
    class GoalManager
    {
        private readonly List<Goal> _goals = new();
        private int _score = 0;

        public void Start()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"You have {_score} points. (Level {GetLevel()})\n");
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");

                var choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1": CreateGoal(); break;
                    case "2": ListGoalDetails(); break;
                    case "3": SaveGoals(); break;
                    case "4": LoadGoals(); break;
                    case "5": RecordEvent(); break;
                    case "6": return;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
        }

        private int GetLevel()
        {
            return (_score / 1000) + 1;
        }

        private void CreateGoal()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string type = Console.ReadLine() ?? string.Empty;

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Write("What is a short description of it? ");
            string desc = Console.ReadLine() ?? string.Empty;
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine() ?? "0");

            switch (type)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, desc, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, desc, points));
                    break;
                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine() ?? "1");
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine() ?? "0");
                    _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Unknown goal type.");
                    break;
            }
        }

        private void ListGoalDetails()
        {
            Console.WriteLine("Your goals:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
            }
        }

        private void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals to record.");
                return;
            }

            ListGoalDetails();
            Console.Write("Which goal did you accomplish? ");
            int idx = int.Parse(Console.ReadLine() ?? "0") - 1;
            if (idx < 0 || idx >= _goals.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            int earned = _goals[idx].RecordEvent();
            _score += earned;
            Console.WriteLine($"Congratulations! You have earned {earned} points!");
            Console.WriteLine($"You now have {_score} points. (Level {GetLevel()})");
        }

        private void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string file = Console.ReadLine() ?? "goals.txt";

            using var sw = new StreamWriter(file);
            sw.WriteLine(_score);
            foreach (var g in _goals)
            {
                sw.WriteLine(g.Serialize());
            }

            Console.WriteLine($"Saved to '{file}'.");
        }

        private void LoadGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string file = Console.ReadLine() ?? "goals.txt";
            if (!File.Exists(file))
            {
                Console.WriteLine("File not found.");
                return;
            }

            _goals.Clear();
            using var sr = new StreamReader(file);
            _score = int.Parse(sr.ReadLine() ?? "0");

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split('|');
                string type = parts[0];
                switch (type)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(
                            parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(
                            parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(
                            parts[1], parts[2], int.Parse(parts[3]),
                            int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[4])));
                        break;
                    default:
                        Console.WriteLine($"Unknown type in file: {type}");
                        break;
                }
            }

            Console.WriteLine($"Loaded {_goals.Count} goals and score = {_score}. (Level {GetLevel()})");
        }
    }
}
