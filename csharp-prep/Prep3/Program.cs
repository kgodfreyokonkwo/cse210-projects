using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //Console.Write("Choose a magic number from 1 to 101 ");
        //int magicNumber = int.Parse(Console.ReadLine());

        // to generate random number from 1 to 101
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);

        //to define two variables- the guess from the user and the number of loop
        //count
        int guess = -1;
        int count = 0;

        //to introduce a loop requesting for input, and generating an output
        while (guess != magicNumber && count < 100)
        {
            Console.Write("Chose a random integer from 1 to 101 ");
            guess = int.Parse(Console.ReadLine());

            count = count + 1;
            
            if (magicNumber > guess)
            {
                Console.WriteLine("go Higher");
            }
             else if (magicNumber < guess)
            {
                Console.WriteLine("go Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it right, you guessed {count} times ");
            }

            }
        }     
    }
}