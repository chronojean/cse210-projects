public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;
    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = null;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = startVerse;
        this._endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return (this._endVerse.HasValue) ? $"{this._book} {this._chapter}:{this._verse}-{this._endVerse}" : $"{this._book} {this._chapter}:{this._verse}";
    }
}