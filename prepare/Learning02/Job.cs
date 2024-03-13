public class Job
{
    public string _JobTitle;
    public string _Company;
    public int _startyear;
    public int _endyear;
    public Job(string title, string company, int sYear, int eYear)
    {
        this._JobTitle = title;
        this._Company = company;
        this._startyear = sYear;
        this._endyear = eYear;
    }
    public void display()
    {
        Console.WriteLine($"{this._JobTitle} ({this._Company}) {this._startyear}-{this._endyear}");
    }

}