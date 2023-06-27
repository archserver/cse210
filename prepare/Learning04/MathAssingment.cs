public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problem;

    public MathAssignment(string studentName, string topic, string textbookSection, string problem) : base (studentName, topic)
    {
        Settextbook(textbookSection);
        SetProblem(problem);
    }

    public string GetHomeworkList()
    {
        return "Section: "+ _textbookSection + " Problems: " +_problem;
    }

    public void Settextbook(string tbs)
    {
        _textbookSection = tbs;
    }

    public void SetProblem(string prob)
    {
        _problem = prob;
    }
}