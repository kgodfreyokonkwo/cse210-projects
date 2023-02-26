using System;
using System.Collections.Generic;
using System.Linq;

class Program
    {

    static void Main(string[] args)
        {
            //get input from the user, 
            //user will input the scripture of choice and the references
            //the book, chapter, and verse, and type in the scripture to be memorized
            // Request for user's name

            Console.Write("what is your first name? ");
            string first = Console.ReadLine();

            //provide customized response to user, asking for option selection
            Console.WriteLine();
            Console.WriteLine($" Hi {first}, You are welcome to your scripture learning App ");           Console.Write("Please type the scripture Book? ");
            string refBook = Console.ReadLine();
            
            Console.Write("Please type the scripture Chapter? ");
            string refChapter = Console.ReadLine();

            Console.Write("Please type the scripture verse? ");
            string refVerseB = Console.ReadLine();
            
            Console.Write("Please type the scripture verse? ");
            string refVerseE = Console.ReadLine();

            Console.Write("Please type the scripture to be memorized? ");
            string ScripText = Console.ReadLine();

            Reference reference = new Reference(refBook, refChapter, refVerseB, refVerseE);
            Console.Write(reference.GetScriptVerse());
            string ScriptRef = Console.ReadLine(); 


            //convert scripture text to  dictionary with a string list
            Dictionary<string, string> scripture = new Dictionary<string, string>
            {
               { "text", ScripText}
            };

            //convert string text to words without special character for easy manipulation
            List<string> wordslist = scripture["text"].Split(' ').ToList();
            int totalWords = wordslist.Count;


            
            Console.Clear();
            Console.Write(reference.GetScriptVerse());
            Console.WriteLine("{0}", scripture["text"]);
            Console.WriteLine("\nPress Enter or type quit:");

            //as long as the user remains in use of the app,
            while (true)
            {
                string input = Console.ReadLine();
                //if the user is not quiting yet
                if (input == "quit")
                {
                    break;
                }

                //If the words have not been exhausted
                if (wordslist.Count == 0)
                {
                    Console.WriteLine("\nThe memorizing exercise is completed!");
                    break;
                }
                
                //hide the words, until the total number of words is not exhausted
                Console.Clear();
                int hiddenWords = totalWords - wordslist.Count;
                int toHide = Math.Min(wordslist.Count, 1);
                for (int i = 0; i < toHide; i++)
                {
                    int index = new Random().Next(wordslist.Count);
                    wordslist[index] = "_";
                }

                
                Console.WriteLine("{0}", ScripText);
                Console.WriteLine("{0} ({1}/{2} words memorized)", string.Join(" ", wordslist), hiddenWords, totalWords);
                Console.WriteLine("\nPress Enter or type quit:"); 
            }
            
        }
            
    }

