public class GoalsMenu 
{
    public static int currentScore = 0;

    //A list to hold all the goals created to make modification and use easy
    public static List<Goals> _goalsList = new List<Goals>();

    //a method to list goals. This method will be the same for all goal categories
    public static void ListGoals()
    {
        Console.WriteLine("The goals are:");
        int goalNo = 0;

        //loop through the goal list and assess if the goal is complete, then check completion box and display goals with 
        //checked box, serial number and goal information
        foreach(Goals goal in _goalsList) 
        {
            string isComplete = " ";
            string finishDate = "";
            if(goal.IsComplete())
            {
                isComplete = "x";
                finishDate = goal.dateCompleted();
            }
            goalNo += 1;
            Console.WriteLine($"{goalNo}. [{isComplete}] {goal.DisplayGoalInfo()}.{finishDate}");
        }
    } 

    //a method to save goals. this is also the same for all goal categories
    public static void SaveGoals() 
    {
        Console.WriteLine("What file name would you like to save it to? "); 
        string fileName = Console.ReadLine();

        using(StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(currentScore);

            foreach(Goals goal in _goalsList)
            {
                outputFile.WriteLine($"{goal.GetGoalDetails()}");
            }            
        }
    }
    // A method to load goals from the goal file. this is also the same for all goal categories.
    public static void LoadGoals() 
    {
       Console.WriteLine("What file name for the goal file? "); 
        string fileName = Console.ReadLine();

        _goalsList.Clear();

        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        foreach(string line in lines)
        {
            string[] parts = line.Split("-");

            if(parts[0] == "Simple Goal")
            {
                SimpleGoals simpleGoals = new SimpleGoals();
                simpleGoals.SetGoalParts(parts);
                _goalsList.Add(simpleGoals);
            }
            else if(parts[0] == "Eternal Goal")
            {
                EternalGoals eternalGoals = new EternalGoals();
                eternalGoals.SetGoalParts(parts);
                _goalsList.Add(eternalGoals);
            }
            else if(parts[0] == "Checklist Goal")
            {
                CheckListGoals checklistGoals = new CheckListGoals();
                checklistGoals.SetGoalParts(parts);
                _goalsList.Add(checklistGoals);
            }
            else
            {
                currentScore = int.Parse(parts[0]);
            }
        }
    }

    // A method to record events. this method is the same for all goal categories
    public static void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");

        //Convert string response from user to int
        string userResponse = Console.ReadLine();
        int goalNo = Convert.ToInt32(userResponse); 
    

        //Search out which goal has beem completed from the goal list
        if(_goalsList[goalNo-1].IsComplete())
        {
            Console.WriteLine("\nThat goal is already complete. Make a new goal.");
        }
        else
        {
            int newPoints = _goalsList[goalNo-1].RecordGoalEvent();
            Console.WriteLine($"Congratulations! You just earned {newPoints}.");
            currentScore += newPoints;
        }

        //the end
    }  
	
}