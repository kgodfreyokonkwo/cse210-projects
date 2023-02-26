using System;
using System.Collections.Generic;


//store the scripture references and use the references to create a string such as John3:1-3
public class Reference 
{
    private string _Book = "";
    private string _Chapter = "";
    private string _VerseBeg = "";

    private string _VerseEnd = "";

    public Reference(string book, string chapter, string verseB, string verseE)
    {
        _Book = book;
        _Chapter = chapter;
        _VerseBeg = verseB;
        _VerseEnd = verseE;
    }

    public void DisplayReference()
    {

    }


    public string GetScriptVerse()
	{
        return $"{_Book}{_Chapter}:{_VerseBeg}-{_VerseEnd}: ";

	}


	
}