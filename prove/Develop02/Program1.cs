using System;
using System.Collections.Generic;


    class Program1
    {
        static void Main(string[] args)
        {
            // Request for user's name
            Console.Write("what is your first name? ");
            string first = Console.ReadLine();

            //provide customized response to user, asking for option selection
            Console.WriteLine();
            Console.WriteLine($" Hi {first}, You are welcome to your scripture learning App ");
            Console.Write("Would you like to continue or quit? Y to continue, N to quit: ");
            String start = Console.ReadLine();

            public List<string> _verse = new List<string>();

            // reference the promptGenerator class which returns a random question/prompt for the user
            Scripture userVerse = new Scripture();
            userVerse._verse.Add(userVerse._verse1);
            userVerse._verse.Add(userVerse._verse2);
            userVerse._verse.Add(userVerse._verse3);
            userVerse._verse.Add(userVerse._verse4);
            userVerse._verse.Add(userVerse._verse5);
            userVerse._verse.Add(userVerse._verse6);
            userVerse._verse.Add(userVerse._verse7);
            userVerse._verse.Add(userVerse._verse8);
            userVerse._verse.Add(userVerse._verse9);
            userVerse._verse.Add(userVerse._verse10);

                
            if (start == "Y")

            {
                //get a recent entry
                Reference currentReference = new Reference();
                currentReference._verse = userVerse.SelectVerse();
                Console.WriteLine(currentReference._verse);



            }
                {

                }
            Dictionary<string, string> scripture = new Dictionary<string, string>
            {
                { "reference", "John 3:16" },
                { "text", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life." }
            };

            List<string> words = scripture["text"].Split(' ').ToList();
            int totalWords = words.Count;

            Console.Clear();
            Console.WriteLine("{0}: {1}", scripture["reference"], scripture["text"]);
            Console.WriteLine("\nPress Enter or type quit:");

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "quit")
                {
                    break;
                }

                if (words.Count == 0)
                {
                    Console.WriteLine("\nYou have memorized the scripture!");
                    break;
                }

                Console.Clear();
                int hiddenWords = totalWords - words.Count;
                int toHide = Math.Min(words.Count, 3);
                for (int i = 0; i < toHide; i++)
                {
                    int index = new Random().Next(words.Count);
                    words[index] = "_";
                }

                Console.WriteLine("{0}: ", scripture["reference"]);
                Console.WriteLine("{0} ({1}/{2} words memorized)", string.Join(" ", words), hiddenWords, totalWords);
                Console.WriteLine("\nPress Enter or type quit:");
            }
        }
    }

