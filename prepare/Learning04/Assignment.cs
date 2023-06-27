public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        SetStudentName(name);
        SetTopic(topic);
    }

    public string GetSummary()
    {
        return "Student: " + _studentName + " Topic: " + _topic;
    }

    public void SetStudentName(string name)
    {
        _studentName = name;
    }

    public void SetTopic(string topic)
    {
         _topic = topic;
    }
}