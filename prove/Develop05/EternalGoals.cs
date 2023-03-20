public class EternalGoals : Goals
{
    //Declare and instantiate the goal type attribute
    private string _goalType = "Eternal Goal";

    //reference the base class constructors
    public EternalGoals() : base()
    {

    }
    public EternalGoals(string goalName, string goalDescription, int goalPoints, string completedDate) 
    : base(goalName, goalDescription, goalPoints, completedDate)
    {

    }

    //Override the GetGoalDetails method for this claass
    public override string GetGoalDetails()
    {
        return $"{_goalType}-{base._goalName}-{base._goalDescription}-{base._goalPoints}-";
    }
    //Override the SetGoalParts method for this class
    public override void SetGoalParts(string[] parts)
    {
        _goalName = parts[1];
        _goalDescription = parts[2];
        _goalPoints = int.Parse(parts[3]);

    }
    //Override the RecordGoalEvent method for this class
    public override int RecordGoalEvent()
    {
        return base._goalPoints;
    }
    //Override the createGoal method to create only eternal goals
    public override void CreateGoal()
    {
        Console.Write("What is the amount of point associated with each occurence of this goal? ");

        //Convert string response from user to int
        string userPoint = Console.ReadLine();
        int goalPoints = Convert.ToInt32(userPoint); 

        EternalGoals eternalGoals = new EternalGoals(_goalName, _goalDescription, goalPoints, _completedDate); 
        eternalGoals.SetGoalPoints(goalPoints);
        GoalsMenu._goalsList.Add(eternalGoals);
    }
    
}