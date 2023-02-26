class ScriptureView
{

    private string _ref;

    private string _data;
    private string _range = null;


    public ScriptureView(String reference, String data, String versRange = null)
    {
        this._ref = reference;
        this._range = versRange;
        this._data = data;

    }
    public void ClearScreen()
    {
        Console.Clear();
    }
    public void WriteToScreen(int listRemoved = 0)
    {
        Console.Write(this._ref + " ");
        Console.WriteLine(this._data);
        Console.Write("("+listRemoved+" removed/"+this._data.Split(' ').ToList<string>().Count+" words)");
        Console.WriteLine(" ");
        Console.WriteLine("Press Enter Key to Continue or Type Quit to Finish ");

    }
}