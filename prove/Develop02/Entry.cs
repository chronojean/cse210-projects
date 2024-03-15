public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public Entry()
    {

    }
    public void Display()
    {
        Console.WriteLine($"Date: {this._date} - Prompt: {this._promptText}\n\t\t{this._entryText}");
    }
}