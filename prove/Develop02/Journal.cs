using System;
using System.IO; 


public class Journal
{
    // in this case, the filename is a variable for the class and the user is expected to provide and attribute
    public string _fileName;

    // a List to compile all entries
    public List<Entry> _entries = new List<Entry>();


    //display the journal
    public void DisplayJournal()
    {   
        foreach (Entry input in _entries)
        {
            // reference the DisplayEntry method
            input.DisplayEntry();
            
        }
    }
    
     
    // To save the file
    public void SaveFile()
    {
        //provide a name of the file,
        Console.WriteLine("What would you like to name this file? ");
        _fileName = Console.ReadLine();

        //use the streamWriter feature to save desired components
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            
            //Iterate through the component of the entries and save in given format date:Prompt Question:response
            foreach (Entry input in _entries)
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateDisplay = theCurrentTime.ToLongDateString();
                outputFile.WriteLine($"{input.dateDisplay} : {input._question} : {input._response}");

            }
        }
    }

    public void LoadFile()
    {
        string[] rows = System.IO.File.ReadAllLines(_fileName);

        //Iterate through the all rows in the entry and load all component in given order
        foreach (string row in rows)
        {
            //use the split feature to break long string output into various components
            
            Entry theEntry = new Entry();
            string[] components = row.Split(":");

            theEntry.dateDisplay = components[0];
            theEntry._question = components[1];
            theEntry._response = components[2];

            _entries.Add(theEntry);
        }
    

    }


}