using System.Linq;

public class Prompt_Phrase
{
    private string[] _prompts;
    public Prompt_Phrase(params string[] additionalPhrases)
    {
        _prompts = new string[] {
            "What is one new thing I learned today, and how can I apply it in my life?",
            "In what ways did I challenge myself outside of my comfort zone today?",
            "How did I positively impact someone else's life today?",
            "What is one goal I have progressed towards today, no matter how small the progress?",
            "How can I show gratitude for the opportunities and blessings I received today?",
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        // Concatenar frases predefinidas con frases adicionales si se proporcionan
        this._prompts = (additionalPhrases != null) ? _prompts.Concat(additionalPhrases).ToArray() : _prompts;
    }
    public string GetRandomPrompt() => _prompts[new Random().Next(_prompts.Length)];
}
