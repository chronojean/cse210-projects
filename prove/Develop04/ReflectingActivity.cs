public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string desc) : base(name, desc)
    {
        _prompts = new List<string>(){
                                        "Think of a time when you did something really difficult",
                                        "Recall a challenging situation you faced in the past",
                                        "Reflect on a moment when you overcame a major obstacle",
                                        "Consider a time when you pushed yourself out of your comfort zone",
                                        "Remember a difficult task you successfully completed",
                                        "Contemplate an experience that required perseverance",
                                        "Imagine a scenario where you achieved something despite the odds"
                                    };

        _questions = new List<string>(){
                                            "How did you feel when it was completed?",
                                            "What is your favorite thing about this experience?",
                                            "What lessons did you learn from overcoming this challenge?",
                                            "In what ways did this experience shape your character?",
                                            "How did you motivate yourself to keep going?",
                                            "What strengths did you discover about yourself during this time?",
                                            "Did you face any setbacks along the way? How did you handle them?",
                                            "Who supported you during this difficult time?",
                                            "What advice would you give to someone facing a similar challenge?",
                                            "Did you have any doubts about your ability to succeed? How did you overcome them?",
                                            "What strategies did you use to tackle the difficulties you encountered?",
                                            "Did you experience any moments of self-doubt? How did you overcome them?",
                                            "How did you celebrate your achievement?",
                                            "What role did perseverance play in your success?",
                                            "Did you have a support system to help you through this challenge?",
                                            "How did this experience change your perspective on difficult situations?",
                                            "What kept you motivated when things got tough?",
                                            "How did you measure your progress along the way?",
                                            "What advice would you give to your past self when facing this challenge?",
                                            "What did you learn about yourself during this experience?",
                                            "How did you stay focused on your goal?",
                                            "What obstacles did you encounter and how did you overcome them?",
                                            "What was the most challenging part of this experience?",
                                            "How did you stay positive during difficult moments?",
                                            "What did you do differently when faced with obstacles?",
                                            "Did you seek help from others? How did they assist you?",
                                            "What did you discover about your strengths and weaknesses?",
                                            "How did you manage your time effectively?",
                                            "What role did perseverance play in your journey?",
                                            "What advice would you give to someone facing a similar challenge?",
                                            "How did this experience change your approach to challenges?",
                                            "What resources did you utilize to help you overcome this challenge?",
                                            "What kept you motivated when things got tough?",
                                            "What did you learn from your mistakes during this experience?",
                                            "How did this experience contribute to your personal growth?",
                                            "What steps did you take to overcome feelings of frustration?",
                                            "How did you maintain a positive attitude throughout this experience?",
                                            "What strategies did you use to overcome obstacles?",
                                            "How did this experience strengthen your resilience?",
                                            "What role did determination play in your success?",
                                            "How did you stay committed to your goal?",
                                            "What did you do differently when faced with similar challenges in the future?",
                                            "How did this experience shape your future actions?",
                                            "What skills did you develop as a result of this experience?",
                                            "How did you adapt to changes along the way?",
                                            "What did you discover about your abilities during this experience?",
                                            "How did you handle moments of uncertainty?",
                                            "What did you learn about your own limitations?",
                                            "How did you prioritize tasks during this experience?",
                                            "What advice would you give to someone about to embark on a similar journey?"
                                        };

    }
    public void Run()
    {
        int currentSeconds = 0;
        int questionSeconds = 9;
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n\t--- {this.GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        this.ShowCountDown(5, 0);
        Console.Clear();
        while (currentSeconds < this.GetDuration())
        {
            Console.Write($">{this.GetRandomQuestion()} ");
            this.ShowSpinner(questionSeconds, currentSeconds);
            Console.WriteLine();
            currentSeconds += questionSeconds;
        }
    }
    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }
    public string GetRandomQuestion()
    {
        return _questions[new Random().Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions() { }
}