using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetName("Kingsley");
        assignment1.SetTopic("Principle of inheritance in c# programing");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment();
        math1.SetName("Godfrey");
        math1.SetTopic("Binary numbers");
        math1.SetTextBookSection("38A");
        math1.SetProblems("Use Binary number to add and multiply");

        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeWorkList());

        WritingAssignment write1 = new WritingAssignment();
        write1.SetName("Okonkwo");
        write1.SetTopic("Expression");
        write1.SetTitle("Proof writing");
        
        Console.WriteLine(write1.GetSummary());
        Console.WriteLine(write1.GetWritingInformation());


    }
}