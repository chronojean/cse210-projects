public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string tbs, string problems, string name, string topic) : base(name, topic)
    {
        this._textbookSection = tbs;
        this._problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Sections {this._textbookSection} Problems {this._problems}";
    }
}