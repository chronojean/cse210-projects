using System;
using System.IO;
public class Journal
{
    private List<Entry> _entries;
    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        Entry buff = new Entry();
        buff._date = newEntry._date;
        buff._promptText = newEntry._promptText;
        buff._entryText = newEntry._entryText;
        this._entries.Add(buff);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in this._entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}\n\t\t\t  {entry._entryText}");
        }
    }
    public void SaveToFile(string filename)
    {
        foreach (Entry entry in this._entries)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"{entry._date};{entry._promptText};{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        List<Entry> buff_entries = new List<Entry>();
        foreach (string line in lines)
        {
            if (!String.IsNullOrEmpty(line))
            {
                string[] splitLine = line.Split(";");
                Entry buff_entry = new Entry();
                buff_entry._date = splitLine[0];
                buff_entry._promptText = splitLine[1];
                buff_entry._entryText = splitLine[2];
                buff_entries.Add(buff_entry);
            }
        }
        this._entries = buff_entries;
    }
}