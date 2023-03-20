public class SimpleGoals : Goals
{
    //Declare and instantiate the goal type attribute
    private string _goalType = "Simple Goal";

    //Define the constructors, also link to the base class. 2 constructors are needed, tne constructor for no action
    //default and the constructor for action.
    public SimpleGoals() : base()
    {

    }
    public SimpleGoals(string goalName, string goalDescription, int goalPoints, string completedDate) 
    : base(goalName, goalDescription, goalPoints, completedDate)
    {

    }

    //Override method for the GetGoalDetails method showing the concept of polymorphism,
    public override string GetGoalDetails()
    {
        return $"{_goalType}-{GetName()}-{GetDescription()}-{base._goalPoints}-{base._isComplete}"; 
    }
    //Override method for the SetGoalParts method.
    public override void SetGoalParts(string[] parts)
    {
        _goalName = parts[1];
        _goalDescription = parts[2];
        _goalPoints = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);
    }
    //Override the RecordGoalEvent method
    public override int RecordGoalEvent()
    {
        base._isComplete = true;
        return base._goalPoints;
    }
    public override void CreateGoal()
    {
        Console.Write("What is the amount of point associated with this goal? ");

        //Convert string response from user to int
        string userPoint = Console.ReadLine();
        int goalPoints = Convert.ToInt32(userPoint); 

        //instantiate the method class
        SimpleGoals simpleGoals = new SimpleGoals(_goalName, _goalDescription, goalPoints, _completedDate);
        simpleGoals.SetGoalPoints(goalPoints);
        GoalsMenu._goalsList.Add(simpleGoals);  
    }

}