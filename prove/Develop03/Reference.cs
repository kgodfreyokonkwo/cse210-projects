using System;
using System.Collections.Generic;



//Class to manage the reference of the scripture, 
// including the book, chapter and verse reference
public class Reference
{
    public string Book { get; set; }

    public string Chapter { get; set; }

    public string Verse { get; set; }

    public Reference(string book, string chapter, string verse)
    {
        this.Book = book;
        this.Chapter = chapter;
        this.Verse = verse;

    }

    public void display()
    {

    }
}
