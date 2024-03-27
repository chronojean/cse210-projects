public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        this._words = new List<Word>();
        string[] verse = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in verse)
        {
            Word buff = new Word(word);
            this._words.Add(buff);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        int times = numberToHide;
        while (times > 0 && !IsCompletelyHidden())
        {
            int randomWord = rnd.Next(0, this._words.Count);
            if (!this._words[randomWord].IsHidden())
            {
                this._words[randomWord].Hide();
                times--;
            }
        }
    }
    public string GetDisplayText()
    {
        string verse = "";
        foreach (Word word in this._words)
        {
            verse = verse + " " + word.GetDisplayText();
        }
        return this._reference.GetDisplayText() + " \"" + verse.TrimStart() + "\"";
    }
    public bool IsCompletelyHidden()
    {

        foreach (Word word in this._words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;

    }
}
