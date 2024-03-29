public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string title, string name, string topic) : base(name, topic)
    {
        this._title = title;
    }
    public string GetWritingInformation()
    {
        return _title;
    }
}