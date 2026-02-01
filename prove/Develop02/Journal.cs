using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length < 3)
            {
                continue;
            }

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            Entry entry = new Entry(date, prompt, text);
            _entries.Add(entry);
        }
    }

    public void Search(string keyword)
{
    foreach (Entry entry in _entries)
    {
        if (entry._entryText.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
            entry._promptText.Contains(keyword, StringComparison.OrdinalIgnoreCase))
        {
            entry.Display();
        }
    }
}

}
