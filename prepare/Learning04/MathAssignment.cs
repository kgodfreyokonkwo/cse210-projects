public class MathAssignment : Assignment
{
	private string _textBookSection = "";
    private string _problems = "";
    
    public string GetTextBookSection()
    {
        return _textBookSection;
    }
    public void SetTextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public MathAssignment()
    {

    }

    public string GetHomeWorkList()
    {
        return $"the section is {_textBookSection} and the problem is {_problems}";
    }
}