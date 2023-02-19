using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop03
{
    public class Reference
    {
        private string Book;

        private int Chapter;

        private int Verse;

        //private int verseEnd;


        public Reference(string book, int chapter, int verse)
        {
            this.Book = book;
            this.Chapter = chapter;
            this.Verse = verse;    
              
        }
        public void display()
        {
            
        }
    }
}