public class Assignment
{
    protected string _studentName = "";
    private string _topic = "";

    public string GetName()
    {
        return _studentName;
    }
    public void SetName(string studentName)
    {
        _studentName = studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public Assignment()
    {

    }

    public string GetSummary()
    {
        return $"{_studentName}: Assignment on {_topic}";
    }
	
}