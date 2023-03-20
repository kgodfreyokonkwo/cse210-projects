using System.Collections.Generic;

public abstract class Goals
{
    //Declare common attributes
    protected string _goalName = "";
    protected string _goalDescription = "";
    protected int _goalPoints = 0;
    protected bool _isComplete = false; 
    protected string _completedDate = "";


    //Define constructors, for attributes yet to be accorded values
    public Goals() 
    {
        _goalName = "";
        _goalDescription = "";
        _completedDate = "";
    }
    public Goals(string goalName, string goalDescription, int goalPoints, string completedDate)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _completedDate = completedDate;


    }

    // Define getters for goal name
    public string GetName()
    {
        return _goalName;
    }
    // Define setters for goal name
    public void SetName(string goalName)
    {
        _goalName = goalName;
    }
    //Define getters for goal description
    public string GetDescription()
    {
        return _goalDescription;
    }

    // Define setters for goal description 
    public void SetDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    //Define getter for goal points
    public decimal GetGoalPonts()
    {
        return _goalPoints;
    }

    //Define setter for goal point
    public void SetGoalPoints(int points)
    {
        _goalPoints = points;
    }

   
    //Define an abstract method to create goals (here polymorphism is demonstrated). 
    public abstract void CreateGoal();

    //Define an abstract method for the disentegration of the goal details into parts
    public abstract void SetGoalParts(string[] parts);

    //Define an abstract method to hold and display when called, the goal details
    public abstract string GetGoalDetails(); 

    //Define a method to record event based on type of the goal   
    public abstract int RecordGoalEvent();
    public string dateCompleted()
    {
        DateTime currentDate = DateTime.Now;
        string dateCompleted = currentDate.ToString("dd/MM/yyyy");
        return $"Completed on {dateCompleted}";
    }
    public virtual string DisplayGoalInfo()
    {
        return $"{_goalName} ({_goalDescription})";
    }

    //A boolen method to hold a yes/no response for goal completion
    public bool IsComplete()
    {
        return _isComplete;
    }

}