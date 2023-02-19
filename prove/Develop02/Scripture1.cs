using System;
using System.IO;

public class Scripture1
{
    // questions that would serve as prompts, and eventually stored as a list to prompt responses from user
    public string _verse1 = "1Nephi3:7-And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandment unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them. ";
    public string _verse2 = "1Nephi19:23-And I did read many things unto them which were written in the books of Moses; but that I might more fully persuade them to believe in the Lord their Redeemer I did read unto them that which was written by the prophet Isaiah; for I did liken all scriptures unto us, that it might be for our profit and learning.";
    public string _verse3 = "2Nephi2:25-Adam fell that men might be; and men are, that they might have joy.";
    public string _verse4 = "2Nephi2:27-Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself. ";
    public string _verse5 = "2Nephi9:29-But to be learned is good if they hearken unto the counsels of God. ";
    public string _verse6 = "2Nephi32:3-Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do. ";
    public string _verse7 = "Mosiah2:17-And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God. ";
    public string _verse8 = "Mosiah4:30-But this much I can tell you, that if ye do not watch yourselves, and your thoughts, and your words, and your deeds, and observe the commandments of God, and continue in the faith of what ye have heard concerning the coming of our Lord, even unto the end of your lives, ye must perish. And now, O man, remember, and perish not.";
    public string _verse9 = "Alma32:21-And now as I said concerning faith, faith is not to have a perfect knowledge of things; therefore if ye have ";
    public string _verse10 = "Alma37:35-O, remember, my son, and learn wisdom in thy youth; yea, learn in thy youth to keep the commandments of God.";
 

    // creat a list of questions called _questions
    public List<string> _verse = new List<string>();

    // Select and display a random prompt question
    public string SelectVerse()
    {
        var random = new Random();
        return _verse[random.Next(_verse.Count)];
    }
    
}