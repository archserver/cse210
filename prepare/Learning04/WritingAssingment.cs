public class WritingAssignment : Assignment
{
    private string _title;
    
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        SetTitle(title);
    }

    public string GetWritingInfo()
    {
        return "Title: "+ _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }
}