using System;
using System.IO;
using System.Collections.Generic;

namespace Develop03
{
    public class Program
    {
        static void Main(string[] args)
        {
            var scripture = new Scripture("3Nephi 3:2", "For the Lord is my only hope, I am alone and I need thee");
            Console.WriteLine($"The Scripture {scripture.reference} says; {scripture.text}" );

        }
    }
}