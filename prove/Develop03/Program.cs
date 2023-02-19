using System;
using System.Collections.Generic;


    class Program
    {
    
    static void Main(string[] args)
        {
            // Request for user's name
            Console.Write("what is your first name? ");
            string first = Console.ReadLine();

            //provide customized response to user, asking for option selection
            Console.WriteLine();
            Console.WriteLine($" Hi {first}, You are welcome to your scripture learning App ");

            //prompt the user to type in the scripture verse text to memorize
            Console.Write("Please type the scripture you would like to memorize? ");
            string word = Console.ReadLine();

            //prompt the user to type in the book, chapter and verse reference of the scripture provided
            Console.Write("Please type the scripture Book? ");
            string scriptBook = Console.ReadLine();
            
            Console.Write("Please type the scripture Chapter? ");
            string scriptChapt = Console.ReadLine();

            Console.Write("Please type the scripture verse? ");
            string scriptVerse = Console.ReadLine();

            
            //reference the Reference class and save as a new instance
            Reference reference = new Reference(scriptBook, scriptChapt, scriptVerse);

            //call method in scripture class to retrieve scripture as plain text
            string plainScripture = (Word.getRenderedText(word));
            
            //Display complete scriptural text and reference
            Console.WriteLine($"{reference.Book}{reference.Chapter}:{reference.Verse}");
            Console.WriteLine(plainScripture);
            Console.WriteLine("\nPress Enter or type quit:");
            Console.ReadLine();

   
            //convert scripture text to  dictionary with a string list
            Dictionary<string, string> scripture = new Dictionary<string, string>
            {
               { "text", plainScripture}
            };

            //convert string text to words without special character for easy manipulation
            List<string> wordslist = scripture["text"].Split(' ').ToList();
            int totalWords = wordslist.Count;


            Console.Write($"{reference.Book}{reference.Chapter}:{reference.Verse}:");
            Console.Clear();
            Console.WriteLine("{0}", scripture["text"]);
            Console.WriteLine("\nPress Enter or type quit:");

            //inteate through the words while the use is not quiting
            //select words at random and hide, until all the words have been hidden
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }


                if (wordslist.Count == 0)
                {
                    Console.WriteLine("\nThe memorizing exercise is completed!");
                    break;
                }

                Console.Clear();
                int hiddenWords = totalWords - wordslist.Count;
                int toHide = Math.Min(wordslist.Count, 3);
                for (int i = 0; i < toHide; i++)
                {
                    int index = new Random().Next(wordslist.Count);
                    wordslist[index] = "_";
                }

                Console.WriteLine($"{reference.Book}{reference.Chapter}:{reference.Verse}:");
                Console.WriteLine("{0} ({1}/{2} words memorized)", string.Join(" ", wordslist), hiddenWords, totalWords);
                Console.WriteLine("\nHit Enter or type quit:");
            }
        }
    }

