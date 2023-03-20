public class CheckListGoals : Goals
{
    //Declare and instantiate the attributes for goal type, goal repeats, goal repeat completed and bonus points.
    private string _goalType = "Checklist Goal";
    private int _goalRepeatNo;
    private int _goalCompleted = 0;
    private int _bonus;
    
    //Define trhe constructors and link to the base class constructors
    public CheckListGoals() : base()
    {

    }
    public CheckListGoals(string goalName, string goalDescription, int goalPoints, int goalRepeatNo, int bonus, string completedDate) 
    : base(goalName, goalDescription, goalPoints, completedDate)
    {
        _goalRepeatNo = goalRepeatNo;
        _bonus = bonus;
    }

    //Override the DisplayGoalInfo method
    public override string DisplayGoalInfo()
    {
        return $"{base._goalName} ({base._goalDescription}) Reps Completed {_goalCompleted}/{_goalRepeatNo}";
    }
    //Override the GetGoalDetails method
    public override string GetGoalDetails()
    {
        return $"{_goalType}-{base._goalName}-{base._goalDescription}-{base._goalPoints}-{_isComplete}-{_bonus}-{_goalRepeatNo}-{_goalCompleted}";
    }
    //Override the SetGolaParts methods
    public override void SetGoalParts(string[] parts)
    {
        _goalName = parts[1];
        _goalDescription = parts[2];
        _goalPoints = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);
        _bonus = int.Parse(parts[5]);
        _goalRepeatNo = int.Parse(parts[6]);
        _goalCompleted = int.Parse(parts[7]);
    }
    //Override the RecordGoalEvent methods
    public override int RecordGoalEvent()
    {
        int points = 0;
        points += base._goalPoints;
        _goalCompleted += 1;
        if(_goalCompleted >= _goalRepeatNo)
        {
            _isComplete = true;
            points += _bonus;
            
        }
        return points; 
    }
    // Override the create goal method to create only checklist specific goal
    public override void CreateGoal()
    {
        Console.Write("What is the amount of point associated with each repetition of this goal? ");

        //Convert string response from user to int
        string userPoint = Console.ReadLine();
        int goalPoints = Convert.ToInt32(userPoint); 
        
        Console.Write("How many repetitions will it take to complete this goal? ");

        //Convert string response from user to int
        string repeatNo = Console.ReadLine();
        int goalRepeatNo = Convert.ToInt32(repeatNo); 

        Console.Write("What are the bonus points for completing this goal? ");

        //Convert string response from user to int
        string bonusPoint = Console.ReadLine();
        int bonus = Convert.ToInt32(bonusPoint); 

        CheckListGoals checkListGoals = new CheckListGoals(_goalName, _goalDescription, goalPoints, goalRepeatNo, bonus, _completedDate);
        checkListGoals.SetGoalPoints(goalPoints);
        GoalsMenu._goalsList.Add(checkListGoals);
    }

}