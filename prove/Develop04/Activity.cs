public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _spinnerDuration;

    public Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
        Console.Clear();
        Console.WriteLine($"Welcome to the {this._name}");
        Console.WriteLine($"\n{this._description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        this._duration = int.Parse(Console.ReadLine());
        this._spinnerDuration = 7;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        this.ShowSpinner(this._spinnerDuration);
        Console.WriteLine($"\nYou have completed another {this._duration} seconds of the {this._name}.");
        this.ShowSpinner(this._spinnerDuration);
    }
    public void ShowSpinner(int seconds)
    {
        char[] spinnerChars = { '|', '/', '-', '\\' };

        for (int i = 0; i < seconds; i++)
        {
            foreach (char spinnerChar in spinnerChars)
            {
                Console.Write(spinnerChar);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }
    public void ShowSpinner(int seconds, int curSeconds)
    {
        int currentSeconds = curSeconds;
        char[] spinnerChars = { '|', '/', '-', '\\' };

        for (int i = 0; i < seconds; i++)
        {
            if (currentSeconds >= _duration)
            {
                break;
            }

            foreach (char spinnerChar in spinnerChars)
            {
                Console.Write(spinnerChar);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }

            currentSeconds++;
        }
    }

    public void ShowCountDown(int seconds, int curSeconds)
    {
        int currentSeconds = curSeconds;
        for (int i = seconds; i > 0; i--)
        {
            if (currentSeconds >= this._duration)
            {
                break;
            }
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            currentSeconds++;
        }
        Console.Write(" ");
    }
    public int GetDuration() { return this._duration; }
}