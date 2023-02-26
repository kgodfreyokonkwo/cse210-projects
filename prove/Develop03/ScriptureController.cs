class ScriptureController
{

    private Dictionary<string, string> scriptureData;

    private Scripture scripture;

    private List<string> listRemovedItems = new List<string>();

    private List<string> listRemovedItemX = new List<string>();

    private List<string> indexCount = new List<string> { };

    private List<string> indexCounter = new List<string> { };

    private string wordLister;

    private List<string> wordListControl;


    public void promptUser(Scripture scripture, string range = null)
    {
        Console.Clear();
        scriptureData = new Dictionary<string, string>();
        scriptureData.Add(scripture.getRefKey(), scripture.getRefValue());
        ScriptureView scriptureView = new ScriptureView(scripture.getRefKey(), scripture.getRefValue(), range);
        scriptureView.ClearScreen();
        scriptureView.WriteToScreen();

        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
        {

            hideRandomText(scriptureData, scripture.getRefKey());


        }
        else if (Console.ReadLine() == "quit")
        {

            Environment.Exit(0);

        }
        else
        {

            this.promptUser(scripture, range);
        }

    }
    public void hideRandomText(Dictionary<string, string> scriptureData, string keyText, string keyValue = null)
    {

        if (keyValue != null)
        {
            scripture = new Scripture(keyText, keyValue);
            scriptureData.Remove(keyText);

            scriptureData.Add(scripture.getRefKey(), scripture.getRefValue());

        }
        else
        {
            this.wordListControl = scriptureData[keyText].Split(' ').ToList();
        }

        //Split Dictionary to list
        List<string> wordLists = scriptureData[keyText].Split(' ').ToList();

        int listIndex = this.findItemIndex(wordLists);


        indexCounter.Add(listIndex.ToString());

        string blanker = "";

        for (int j = 0; j < wordLists[listIndex].Length; j++)
        {
            blanker += "_";
        }

        this.listRemovedItemX.Add(wordLists[listIndex]);


        if (wordLists[listIndex] == blanker)
        {


        }
        else
        {
            wordLists[listIndex] = blanker;
            wordListControl[listIndex] = "";

            this.listRemovedItems.Add(wordLists[listIndex]);

            wordLister = string.Join(" ", wordLists.ToArray());

            ScriptureView scriptureView = new ScriptureView(keyText, wordLister);
            scriptureView.ClearScreen();
            scriptureView.WriteToScreen(listRemovedItems.Count);

            if(listRemovedItems.Count == wordLists.Count){
                Environment.Exit(0);
            }
           
        }





        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
        {

            hideRandomText(scriptureData, keyText, wordLister);

        }
        else if (Console.ReadLine() == "quit")
        {

            Environment.Exit(0);

        }
        else
        {

            this.promptUser(scripture, wordLister);
        }

    }

    public int findItemIndex(List<string> words)
    {

        Random random = new Random();

        int totalWords = words.Count;
        // Console.Write(totalWords + " ");
        int listIndex = random.Next(totalWords);
        if (indexCounter.Contains(listIndex.ToString()))
        {
            return findItemIndex(words);
            
        }

        return listIndex;

    }
}
