using System;
using System.Collections.Generic;
using System.Linq;

//receive the words and save a string and convert to list
public class Word 
{
    public string _word { get; set; }


    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }


    public string getRenderedText()
    {
        return "default";
    }

    public string WordStringToWordList()
    {
        List<string> wordList = _word.Split(' ').ToList();

        return $"{wordList}";
    } 


}