public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string desc) : base(name, desc)
    {

    }
    public void Run()
    {
        int currentSeconds = 0;
        int breathIn = 4;
        int breathOut = 6;
        while (currentSeconds < this.GetDuration())
        {
            Console.Write("\nBreath in...");
            ShowCountDown(breathIn, currentSeconds);
            currentSeconds += breathIn;
            Console.Write("\nNow Breath out...");
            ShowCountDown(breathOut, currentSeconds);
            currentSeconds += breathOut;
            Console.WriteLine();
        }
    }
}