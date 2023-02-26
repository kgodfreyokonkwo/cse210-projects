using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Scripture scripture = new Scripture("John 3:16", "For God so Love The World That He gave his Only Begotten Son That Who So believeth In Him Will Have Everlasting Life.");

        ScriptureController scriptureController = new ScriptureController();

        scriptureController.promptUser(scripture,null);

    }
    
}