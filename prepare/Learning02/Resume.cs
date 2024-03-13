
public class Resume
{
    public string _Name;
    public List<Job> _jobs;
    public Resume(string name)
    {
        this._Name = name;
        this._jobs = new List<Job>();
    }
    public void display()
    {
        Console.WriteLine("Name: " + _Name);
        Console.WriteLine("Jobs:");
        foreach (var j in this._jobs)
            j.display();
    }
}