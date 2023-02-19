using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace Develop03
{
    public class Scripture
    {
        //public Reference reference = new Reference();
        public string FileName;
        
        //private List<Word> text = new List<Word>();
        
         public Scripture()
         {
 
         }
         
         public void getScripture(string fileName)
         {
           var data = File.ReadAllText("memoryVerse", Encoding.UTF8);

         }
         public void hideWords(string reference, string verse)
         {
            
         }
    }
}