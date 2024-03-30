public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string desc) : base(name, desc)
    {
        this._count = 0;
        _prompts = new List<string>{
                                        "Share moments of joy you've experienced recently.",
                                        "List acts of kindness that have brightened your day.",
                                        "Celebrate victories, big or small, from this past month.",
                                        "Think of things or people you're grateful for right now.",
                                        "Recall challenges you've overcome and how you did it.",
                                        "Name what or who makes you feel deeply connected.",
                                        "Describe moments of peace and tranquility you've enjoyed.",
                                        "Think of instances of generosity you've witnessed.",
                                        "Share goals you've achieved and how they made you feel.",
                                        "Consider people whose words or actions have inspired you.",
                                        "Think of moments when you've felt hopeful about the future.",
                                        "Recall memories that bring you joy whenever you think about them."
                                    };


    }
    public void Run()
    {
        List<string> userAnswers = new List<string>();
        int currentSeconds = 0;
        Console.WriteLine("\nList as many responses you can to the follwing prompt:");
        Console.WriteLine($"--- {this.GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        this.ShowCountDown(5, currentSeconds);
        Console.WriteLine();
        DateTime futureTime = DateTime.Now.AddSeconds(this.GetDuration());
        while (DateTime.Now < futureTime)
        {
            Console.Write(">");
            userAnswers.Add(Console.ReadLine());
            this._count++;
        }
        Console.WriteLine($"You listed {this._count} {(this._count != 1 ? "items" : "item")}");

    }
    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }
    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}